namespace FuelStation.Web.Shared {
    public class UserSession {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public int ExpiresIn { get; set; }
        public string? Token { get; set; }
        public DateTime ExpiryTimeStamp { get; set; }




    }
}
