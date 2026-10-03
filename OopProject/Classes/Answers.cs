using System;
using System.Collections.Generic;
using System.Text;

namespace OopProject.Classes
{
    /// <summary>
    /// Represents an answer for an exam question
    /// </summary>
    public class Answers
    {
        /// <summary>
        /// Gets or sets the unique identifier of the answer
        /// </summary>
        public int AnswerId { get; set; }
        /// <summary>
        /// gets or sets the text of the answer
        /// </summary>
        public string AnswerText { get; set; }

        /// <summary>
        /// returns a string represntation of the answe
        /// </summary>
        public override string ToString()
        {
            return $"({AnswerId}) {AnswerText}";
        }
    }
}
