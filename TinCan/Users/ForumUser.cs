using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinCan.Users
{   

    public interface ForumUser
    {        
        string Username { get; set; }
        void SetFullName(string firstName, string lastName);
        string GetFullName();
        DateTime GetDateCreated();
    }
    
}
