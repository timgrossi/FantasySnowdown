using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasySnowdown.Models

{
    public class JoinDraft
    {
        [Key]
        public int JoinDraftId {get;set;}

        public int DraftId {get;set;}

        public int UserId {get;set;}

        public Draft Drafts {get;set;}
        public User Users{get;set;}
    }
}