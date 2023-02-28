//using Blazored.SessionStorage;
//using FuelStation.Web.Shared;
//using FuelStation.Win.Extensions;
//using Microsoft.AspNetCore.Components.Authorization;
//using Microsoft.AspNetCore.Http;
//using System.Net.Http;
//using System.Security.Claims;
//using System.Text.Json;

//namespace FuelStation.Win.Authentication {
//    public class CustomAuthenticationStateProvider : AuthenticationStateProvider {

//        private readonly HttpClient _httpClient;
//        private readonly IHttpContextAccessor _httpContextAccessor;
//        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

//        public CustomAuthenticationStateProvider(IHttpContextAccessor httpContextAccessor, HttpClient httpClient) {
//            _httpContextAccessor = httpContextAccessor;
//            _httpClient = httpClient;
//        }

//        public override async Task<AuthenticationState> GetAuthenticationStateAsync() {
//            try {
//                var userSessionJson = _httpContextAccessor.HttpContext.Session.GetString("UserSession");
//                if (userSessionJson == null)
//                    return await Task.FromResult(new AuthenticationState(_anonymous));
//                var userSession = JsonSerializer.Deserialize<UserSession>(userSessionJson);
//                var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
//                {
//                    new Claim(ClaimTypes.Name, userSession.UserName),
//                    new Claim(ClaimTypes.Role, userSession.Role)
//                }, "JwtAuth"));

//                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
//            }
//            catch {
//                return await Task.FromResult(new AuthenticationState(_anonymous));
//            }
//        }

//        public async Task UpdateAuthenticationState(UserSession? userSession) {
//            ClaimsPrincipal claimsPrincipal;

//            if (userSession != null) {
//                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
//                {
//                    new Claim(ClaimTypes.Name, userSession.UserName),
//                    new Claim(ClaimTypes.Role, userSession.Role)
//                }));
//                userSession.ExpiryTimeStamp = DateTime.Now.AddSeconds(userSession.ExpiresIn);
//                var userSessionJson = JsonSerializer.Serialize(userSession);
//                _httpContextAccessor.HttpContext.Session.SetString("UserSession", userSessionJson);
//            } else {
//                claimsPrincipal = _anonymous;
//                _httpContextAccessor.HttpContext.Session.Remove("UserSession");
//            }

//            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
//        }


//        public async Task<string> GetToken() {
//            var result = string.Empty;

//            try {
//                var userSessionJson = _httpContextAccessor.HttpContext.Session.GetString("UserSession");
//                if (userSessionJson == null)
//                    return result;

//                var userSession = JsonSerializer.Deserialize<UserSession>(userSessionJson);
//                if (userSession == null || userSession.ExpiryTimeStamp < DateTime.Now)
//                    return result;

//                return userSession.Token;
//            }
//            catch {
//                return result;
//            }
//        }
//    }
//}
