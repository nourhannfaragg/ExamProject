using OopProject.Classes;

namespace OopProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Answers a1 = new Answers { AnswerId = 1, AnswerText = "Java Script" };
            Answers a2 = new Answers { AnswerId = 2, AnswerText = "C#" };
            Answers a3 = new Answers { AnswerId = 3, AnswerText = ".Net" };
            Answers a4 = new Answers { AnswerId = 4, AnswerText = "Type Script" };

            Question question1 = new Question { Header = "Q1", Body = "What's C#?", Mark = 10 , AnswerList=new Answers[] {a1,a2,a3,a4} , RightAnswer =a2 };
            Question question2 = new Question
            {
                Header = "Q2",
                Body = "What's .Net?",
                Mark = 5,
                AnswerList = new Answers[]
            {
                new Answers {AnswerId=1 ,AnswerText ="Frame Work"},
                new Answers {AnswerId=2 ,AnswerText ="Data Base"},
                new Answers {AnswerId=3 ,AnswerText ="Os"} },
                RightAnswer = new Answers
                {
                    AnswerId = 1,
                    AnswerText = "Frame Work"
                }
            };
                
            Question question3 = new Question
            {
                Header = "Q3",
                Body = "What's Type Script?",
                Mark = 20,
                AnswerList = new Answers[]
            {
                new Answers{AnswerId=1 , AnswerText = "Java Script With Types"},
                new Answers{AnswerId=2 , AnswerText = " Java Script"}
            },
                RightAnswer = new Answers
                {
                    AnswerId = 1,
                    AnswerText = "Java Script With Types"
                }
            };

            Question q4 = (Question)question2.Clone();
            q4.Mark = 25;
            Console.WriteLine($"Original Question: {question2}");

            Console.WriteLine($"Cloned Question: {q4}");

            Question[] questions = { question1, question2, question3 };
            Array.Sort(questions);
            Console.Write("===== Sorted Question =====");
            foreach (Question question in questions)
            {
                Console.WriteLine($"- {question}");
            }


            FinalExam exam01 = new FinalExam()
            {
                Time = 60,
                NumberOfQuestions = 2,
                Questions = new Question[]
                {
                     question1,question2
                }
            };

            PracticalExam practicalExam = new PracticalExam
            {
                Time = 60,
                NumberOfQuestions = 2,
                Questions = new Question[]
                {
                    question1,question2
                }
            };

            Subject subject = new Subject { SubjectId = 1, SubjectName = "C#" };
            subject.CreateExam(exam01);

            exam01.ShowExam();

            practicalExam.ShowExam();
        }
    }
}
