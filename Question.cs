using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGameMillioner
{
    public class Question
    {
        public Question(string text, string[] answers, int correctAnswer)
        {
            Text = text;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public string Text { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswer { get; set; }
    }
    
}
