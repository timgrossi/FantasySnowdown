using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasySnowdown.Models

{
    public class Team
    {
        [Key]
        public int TeamId {get;set;}

        public int UserId {get;set;}

        public List<Player> Players {get;set;}

        public string TeamName {get;set;}

        
    }
}