
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Server {
    public class UserAccountService {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;


        private List<UserAccount> _userAccountList;

        public UserAccountService() {

            _userAccountList = new List<UserAccount>
            {
                new UserAccount { UserName = "admin", Password = "admin", Role = "Administrator", },
                new UserAccount { UserName = "user", Password = "user", Role = "User" }
            };

        }

        public UserAccount? GetUserAccountByUserName(string userName) {
            return _userAccountList.FirstOrDefault(x => x.UserName == userName);
        }

    }
}
