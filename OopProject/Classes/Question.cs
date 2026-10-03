using System;
using System.Collections.Generic;
using System.Text;

namespace OopProject.Classes
{
    /// <summary>
    /// represents a base quetion in the examination system
    /// </summary>
    public  class Question:IComparable ,ICloneable
    {
        /// <summary>
        /// Gets or sets the question header.
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// Gets or sets the question body.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// Gets or sets the question mark.
        /// </summary>
        public int Mark {  get; set; }
        /// <summary>
        /// Gets or sets the available answers.
        /// </summary>
        public Answers[] AnswerList { get; set; }
        /// <summary>
        /// Gets or sets the correct answers.
        /// </summary>
        public Answers RightAnswer { get; set; }
        public Question() { }
        public Question(string header , string body,int mark) : this()
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        /// <summary>
        /// Returns a string representation of the question.
        /// </summary>
        public override string ToString()
        {
            return $"Header: {Header}, Body: {Body}, Mark: {Mark}";
        }
        /// <summary>
        /// Compares two questions based on their marks.
        /// </summary>
        /// <param name="obj">The question to compare with</param>
        /// <returns>A value indicating the relative order of the question</returns>
        public int CompareTo(object? obj)
        {
            Question other = (Question)obj;
            return Mark.CompareTo(other.Mark);
        }
        /// <summary>
        /// Creates a copy of the current question.
        /// </summary>
        /// <returns>A cloned copy of the question.</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
