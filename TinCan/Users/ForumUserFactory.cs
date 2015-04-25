using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinCan.Users {
    public class ForumUserFactory {
        public ForumUser CreateForumUser(string username){
            ForumUserImp newUser =  new ForumUserImp();
            newUser.Username = username;
            return newUser;
        }
    }
}
