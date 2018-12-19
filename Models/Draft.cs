using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasySnowdown.Models

{
    public class Draft
    {
        [Key]
        public int DraftId{get;set;}
        public int UserId {get;set;}
        public int TeamId {get;set;}

        public List<User> Users {get;set;}

        



        
    }
}