using System;
using System.Collections.Generic;
using System.Text;

namespace OopProject.Classes
{
    /// <summary>
    /// Represents a subject that contains an exam.
    /// </summary>
    internal class Subject
    {
        /// <summary>
        /// Gets or sets the subject identifier.
        /// </summary>
        public int SubjectId { get; set; }
        /// <summary>
        /// Gets or sets the subject name.
        /// </summary>
        public string SubjectName { get; set; }
        /// <summary>
        /// Gets or sets the exam associated with the subject.
        /// </summary>
        public Exam Exam { get; set; }

        /// <summary>
        /// creates and assigns an exam to the subject
        /// </summary>
        /// <param name="exam"> the exam to assign to the subject</param>
        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }
    }
}
