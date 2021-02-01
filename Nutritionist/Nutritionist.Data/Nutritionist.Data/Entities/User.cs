﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Nutritionist.Data.Nutritionist.Data.Entities
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Nutritionists = new HashSet<Nutritionist>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public bool DidDelete { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Nutritionist> Nutritionists { get; set; }
    }
}
