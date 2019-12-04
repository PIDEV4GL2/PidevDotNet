using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PidevDotNet.Models
{
    public class Evaluation
    {
        public int Id { get; set; }
        public DateTime DateEval { get; set; }
        public double MoyenneNote { get; set; }
        public string name { get; set; }
        public string typeEval { get; set; }
   
        public int noteA { get; set; }
        public int noteB { get; set; }
        public string critere { get; set; }
        public string notation { get; set; }
        


    }

   
}