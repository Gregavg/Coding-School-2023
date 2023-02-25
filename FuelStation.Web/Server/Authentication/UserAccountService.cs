
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
                new UserAccount { UserName = "manager", Password = "manager", Role = "Manager", },
                new UserAccount { UserName = "cashier", Password = "cashier", Role = "Cashier" },
                new UserAccount { UserName = "staff", Password = "staff", Role = "Staff" }
            };

        }

        public UserAccount? GetUserAccountByUserName(string userName) {
            return _userAccountList.FirstOrDefault(x => x.UserName == userName);
        }

    }
}
