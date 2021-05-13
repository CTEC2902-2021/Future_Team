using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballClub.Models
{
    public class Team
    {
        //Prodives the table database with a foreign key
        public virtual int TeamId { get; set; }
    }
}