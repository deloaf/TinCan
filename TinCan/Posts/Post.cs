﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinCan.Posts {

    public class Post {
        public Guid Id;
        public Users.ForumUser Creator;
        public string Message;
        public DateTime DateCreated;     
    }

}
