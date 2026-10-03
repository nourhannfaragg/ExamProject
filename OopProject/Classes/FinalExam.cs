using System;
using System.Collections.Generic;
using System.Text;

namespace OopProject.Classes
{
    /// <summary>
    /// Represents a final examination.
    /// </summary>
    public class FinalExam:Exam
    {
        /// <summary>
        /// Displays the final exam questions, answers, correct answers, and grades.
        /// </summary>
        public override void ShowExam()
        {
           
            Console.WriteLine("\n===== Final Exam =====");
            for(int i = 0;i<Questions.Length;i++)
            {
                Question question = Questions[i];
                Console.WriteLine($"Question {i+1}");
                Console.WriteLine(question.Body);

                Console.WriteLine("Answers: ");
                foreach(Answers ans in question.AnswerList)
                {
                    Console.WriteLine(ans);
                }

                Console.WriteLine($"Correct Answer: {question.RightAnswer.AnswerText}");
                Console.WriteLine($"Grade: {question.Mark}");

                Console.WriteLine();
            }
        }
    }
}
