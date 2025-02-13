﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest
{
    public class Reservation
    {
        public User MadeBy { get; set; }
        public bool CanBeCancelledBy(User user)
        {
            if (user == null) throw new ArgumentNullException();

            return user == MadeBy || user.IsAdmin;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
