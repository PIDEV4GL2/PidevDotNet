using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
 

namespace PidevDotNet.ViewModel
{
    public class EvaluationModel
    {

        //public DateTime DateEval { get; set; }
       public int id { get; set; }
       // public int Id { get; set; }
        public double moyenneNote { get; set; }
        public string name { get; set; }
        public string typeEval { get; set; }
        public DateTime dateEval { get; set; }
        public int noteA { get; set; }
        public int noteB { get; set; }


       // public string critere { get; set; }
       // public string notation { get; set; }
        // public  user users{ get; set; }
    }

   
}