using System;
using System.Collections.Generic;
using System.Text;

namespace OopProject.Classes
{
    public class McqQuestion:Question
    {
        public McqQuestion() { }
        public McqQuestion(string header , string body , int mark):base(header , body , mark) { }
    }
}
