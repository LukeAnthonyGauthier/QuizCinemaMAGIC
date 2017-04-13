using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPresentationOral
{
    public class Question
    {
        public string request;
        public string reponse;
        public int typeQuestion;
        public string[] tableauchoix = new string[5];

        public Question (string request , string reponse,int typeQuestion,string choix1 = "", string choix2 = "", string choix3 = "", string choix4 = "", string choix5 = "")
        {
            this.request = request;
            this.reponse = reponse;
            this.typeQuestion = typeQuestion;
        }
       

        

         
    }
}
