using OopProject.Classes;
using System.Security.Cryptography.X509Certificates;

namespace OOpProjectTest
{
    public class ExamSystemTests
    {
        [Fact]
        public void Answer_ToString_ShouldReturnCorrectFormat()
        {
            Answers answer = new Answers { AnswerId = 1, AnswerText = "C#" };
            string result = answer.ToString();
            Assert.Equal("(1) C#", result);
        }

        [Fact]
        public void Question_ToString_ShouldReturnCorrectData()
        {
            Question question = new Question
            {
                Header = "Q1",
                Body = "What's C#?",
                Mark = 10
            };

            string result = question.ToString();
            Assert.Equal("Header: Q1, Body: What's C#?, Mark: 10" , result);
        }

        [Fact]
        public void Question_CompareTo_ShouldCompareByMark()
        {
            Question q1 = new Question { Mark = 10 };
            Question q2 = new Question { Mark = 5 };
            int result = q1.CompareTo(q2);
            Assert.True(result > 0);
        }

        [Fact]
        public void Question_Clone_ShouldCreateSeparateObject()
        {
            Question original = new Question
            {
                Header = "Q1",
                Body = "What's C#?",
                Mark = 10
            };
            Question clone = (Question)original.Clone();
            clone.Mark = 20;

            Assert.Equal(10, original.Mark);
            Assert.Equal(20, clone.Mark);
            Assert.NotEqual(original, clone);
        }

        [Fact]
        public void Question_ShouldContainAnswers()
        {
            Answers answer1 = new Answers
            {
                AnswerId = 1,
                AnswerText = "Frame Work"
            };
            Answers answer2 = new Answers
            {
                AnswerId = 2,
                AnswerText = "C#"
            };
            Question question = new Question
            {
                Body = "What's C#?",
                AnswerList = new Answers[] { answer1, answer2 },
                RightAnswer = answer2,
            };
            Assert.Equal(2, question.AnswerList.Length);
            Assert.Equal("C#", question.RightAnswer.AnswerText);
        }
        [Fact]
        public void FinalExam_ShouldHaveCorrectNumberOfQuestions()
        {
            Question q1 = new Question
            {
                Body = "What's C#?",
                Mark = 10
            };
            Question q2 = new Question
            {
                Body = "What's .NET?",
                Mark = 5
            };
            FinalExam exam = new FinalExam
            {
                Time = 60,
                NumberOfQuestions = 2,
                Questions = new Question[]
                {
                    q1,
                    q2
                }
            };
            Assert.Equal(60, exam.Time);
            Assert.Equal(2, exam.NumberOfQuestions);
            Assert.Equal(2,exam.Questions.Length);
        }

        [Fact]
        public void PracticalExam_ShouldHaveCorrectNumberOfQuestions()
        {
            Question q1 = new Question
            {
                Body = "What's C#?"
            };
            PracticalExam exam = new PracticalExam
            {
                Time = 30,
                NumberOfQuestions = 1,
                Questions = new Question[]
                {
                    q1
                }
            };
            Assert.Equal(30, exam.Time);
            Assert.Equal(1, exam.NumberOfQuestions);
            Assert.Single(exam.Questions);
        }
    }
}
