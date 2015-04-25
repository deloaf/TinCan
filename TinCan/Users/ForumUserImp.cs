using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinCan.Users {

    public class ForumUserImp : ForumUser {
        User internalUser;

        public ForumUserImp() {
            internalUser = new User();
            internalUser.DateTimeCreated = DateTime.Now;
        }

        public string Username {
            get;
            set;
        }

        void ForumUser.SetFullName(string firstName, string lastName) {
            internalUser.FirstName = firstName;
            internalUser.LastName = lastName;
        }

        string ForumUser.GetFullName() {
            return internalUser.FirstName + " " + internalUser.LastName;
        }

        DateTime ForumUser.GetDateCreated() {
            return internalUser.DateTimeCreated.Date;
        }
    }

}
