using ClassLibrary1;

namespace Session_11
{
  public  class Program
    {
        Customer cust1 = new Customer();    
        Pet pet1 = new Pet();
        PetFood food1 = new PetFood();
        Employee employee1 = new Employee();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
        }
    }
}