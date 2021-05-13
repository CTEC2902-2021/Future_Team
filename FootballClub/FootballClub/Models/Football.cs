using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballClub.Models
{
    public class Football
    {
        //This code is used to create the tables in the database
        public virtual int FootballId { get; set; }
        public virtual string Team { get; set; }
        public virtual int TeamId { get; set; }
        public virtual int Played { get; set; }
        public virtual int Won { get; set; }
        public virtual int Draw { get; set; }
        public virtual int Lost { get; set; }
        public virtual int For { get; set; }
        public virtual int Against { get; set; }
        public virtual int GD { get; set; }
        public virtual int Points { get; set; }
    }
}