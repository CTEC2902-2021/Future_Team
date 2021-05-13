using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballClub.Models
{
	public class Player
	{
        //This code is used to create the tables in the database
        public virtual int PlayerId { get; set; }
        public virtual string TeamName { get; set; }
        public virtual int TeamId { get; set; }
        public virtual string Player1 { get; set; }
        public virtual string Player2 { get; set; }
        public virtual string Player3 { get; set; }
        public virtual string Player4 { get; set; }
        public virtual string Player5 { get; set; }
        public virtual string Player6 { get; set; }
        public virtual string Player7 { get; set; }
        public virtual string Player8 { get; set; }
        public virtual string Player9 { get; set; }
        public virtual string Player10 { get; set; }
        public virtual string Player11 { get; set; }
    }
}