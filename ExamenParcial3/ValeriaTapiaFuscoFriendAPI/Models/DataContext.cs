﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ValeriaTapiaFuscoFriendAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ValeriaTapiaFuscoFriendAPI.Models.Friend> Friends { get; set; }
    }
}