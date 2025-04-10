﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BmdbNetWeb.Models {
    [Table("User")]
    public partial class User {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal CollectionValue { get; set; }
        public Boolean Admin { get; set; } = false;

    }
}
