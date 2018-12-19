using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasySnowdown.Models

{
    public class Player
    {
        [Key]
        public int PlayerId {get;set;}
        public int Steals {get;set;}

        public int Blocks {get;set;}
        public int Points {get;set;}

        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int TeamId {get;set;}
        
    }
}