﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSserver.Models {
    public class User {

        public int Id { get; set; }

        [StringLength(30)]
        [Required]
        public string UserName { get; set; }

        [StringLength(30)]
        [Required]
        public string Password { get; set; }

        [StringLength(30)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Required]
        public string LastName { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        public bool IsReviewer { get; set; } = false;

        [Required]
        public bool IsAdmin { get; set; } = false;

        public User() {}

    }
}
