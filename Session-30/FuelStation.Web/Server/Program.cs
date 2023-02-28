using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Server;
using FuelStation.Web.Server.Authentication;
using FuelStation.Web.Shared.Validator;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IEntityRepo<Customer>, CustomerRepo>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();

builder.Services.AddScoped<IEntityRepo<Employee>, EmployeeRepo>();

builder.Services.AddScoped<IEntityRepo<Item>, ItemRepo>();
builder.Services.AddScoped<IItemRepo, ItemRepo>();

builder.Services.AddScoped<IEntityRepo<TransactionLine>, TransactionLineRepo>();

builder.Services.AddScoped<IEntityRepo<Transaction>, TransactionRepo>();
builder.Services.AddScoped<ITransactionRepo, TransactionRepo>();
builder.Services.AddScoped<IValidator, Validator>();



// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

/***************authentication******************/
builder.Services.AddAuthentication(auth => {
    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(auth => {
    auth.RequireHttpsMetadata = false;
    auth.SaveToken = true;
    auth.TokenValidationParameters = new TokenValidationParameters {//maybe another using?
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(JwtAuthenticationManager.JWT_SECURITY_KEY)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});
builder.Services.AddSingleton<UserAccountService>();

/***************End authentication**************/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseWebAssemblyDebugging();
} else {
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

/***************authentication******************/
app.UseAuthentication();
app.UseAuthorization();
/***************End authentication**************/


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
