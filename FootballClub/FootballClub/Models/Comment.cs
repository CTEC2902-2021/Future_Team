using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballClub.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string content { get; set; }
        public int parent { get; set; }
    }
}