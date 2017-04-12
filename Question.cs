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

        public Question (string request , string reponse,int typeQuestion)
        {
            this.request = request;
            this.reponse = reponse;
            this.typeQuestion = typeQuestion;
        }
       

        

         
    }
}
