using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasySnowdown.Models

{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        public string FirstName {get;set;}

        [Required]
        public string LastName {get;set;}

        [Required]
        public string Username {get;set;}

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string Password {get;set;}
        
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConPass {get;set;}
        public User(){}

    }
}