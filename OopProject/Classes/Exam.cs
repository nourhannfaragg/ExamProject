using System;
using System.Collections.Generic;
using System.Text;

namespace OopProject.Classes
{
    /// <summary>
    /// Represents the base class for different types of exams.
    /// </summary>
    public class Exam:ICloneable,IComparable
    {
        /// <summary>
        /// Gets or sets the duration of the exam in minutes.
        /// </summary>
        public int Time {  get; set; }
        /// <summary>
        /// Gets or sets the number of questions in the exam.
        /// </summary>
        public int NumberOfQuestions { get; set; }
        /// <summary>
        /// Gets or sets the questions included in the exam.
        /// </summary>
        public Question[] Questions { get; set; }

        public Exam() { }
        public Exam(int Time) : this(Time, 0) { }

        public Exam(int time,int numberOfQ)
        {
            Time = time;
            NumberOfQuestions = numberOfQ;
        }
        /// <summary>
        /// Displays the exam.
        /// </summary>
        public virtual void ShowExam() { }

        /// <summary>
        /// creates a copy of the current exam.
        /// </summary>
        /// <returns> a cloned copy of the current exam</returns>
        public object Clone()
        {
            return this.MemberwiseClone(); //create copy object From CurrentObect
        }
        /// <summary>
        /// compares two exams based on their time
        /// </summary>
        /// <param name="obj">The exam to compare with</param>
        /// <returns></returns>
        public int CompareTo(object? obj)
        {
            Exam other = (Exam)obj;
            return Time.CompareTo(other.Time);
        }
        /// <summary>
        /// Returns a string representation of the Exam.
        /// </summary>
        public override string ToString()
        {
            return $"Time: {Time},Number Of Questions: {NumberOfQuestions}";
        }
    }
}
