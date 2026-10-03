using System;
using System.Collections.Generic;
using System.Text;

namespace OopProject.Classes
{
    /// <summary>
    /// Represents a practical examination.
    /// </summary>
    public class PracticalExam:Exam
    {
        /// <summary>
        /// Displays the practical exam questions, answers, and correct answers.
        /// </summary>
        public override void ShowExam()
        {
            Console.WriteLine("\n===== Practical Exam =====");
            for(int i = 0; i<Questions.Length ;i++)
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

                Console.WriteLine();
            }
        }
    }
}
