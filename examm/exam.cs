using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static examm.Exam;
using static examm.Question
    ;

namespace examm
{
        public abstract class Exam : ICloneable, IComparable<Exam>
        {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public int QuestionCount { get; set; } // To track the number of questions added

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
            QuestionCount = 0;
        }

        public void AddQuestion(Question question)
        {
            if (QuestionCount < Questions.Length)
            {
                Questions[QuestionCount] = question;
                QuestionCount++;
            }
            else
            {
                Console.WriteLine("Cannot add more questions. Maximum limit reached.");
            }
        }

        public abstract void ShowExam();

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Exam other)
        {
            return Time.CompareTo(other.Time);
        }

        public override string ToString()
        {
            return $"Exam Time: {Time} minutes, Number of Questions: {NumberOfQuestions}";
        }
    }

    
  
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        //public override void ShowExam()
        //{
        //    int totalMarks = 0;
        //    int earnedMarks = 0;

        //    foreach (var question in Questions)
        //    {
        //        if (question != null)
        //        {
        //            question.DisplayQuestion();
        //            Console.Write("Please Enter The Answer Id: ");
        //            int userAnswerId = int.Parse(Console.ReadLine());

        //            if (userAnswerId == question.AnswerList[0].AnswerId)
        //            {
        //                earnedMarks += question.Mark;
        //            }

        //            totalMarks += question.Mark;
        //        }
        //    }

        //    Console.WriteLine($"Your Grade is {earnedMarks} from {totalMarks}");
        //}
        public override void ShowExam()
        {
            int totalMarks = 0;
            int earnedMarks = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Questions.Length; i++)
            {
                var question = Questions[i];
                if (question != null)
                {
                    Console.WriteLine($"# Question {i + 1} : {question.Body}");
                    question.DisplayQuestion();

                    Console.Write("Your Answer => ");
                    int userAnswerId = int.Parse(Console.ReadLine());

                    string userAnswerText = question.AnswerList[userAnswerId - 1].AnswerText;
                    string rightAnswerText = question.AnswerList[0].AnswerText;

                    Console.WriteLine($"Your Answer => {userAnswerText}");
                    Console.WriteLine($"Right Answer => {rightAnswerText}");

                    if (userAnswerId == question.AnswerList[0].AnswerId)
                    {
                        earnedMarks += question.Mark;
                    }

                    totalMarks += question.Mark;
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"Your Grade is {earnedMarks} from {totalMarks}");
            Console.WriteLine($"Time = {stopwatch.Elapsed}");
            Console.WriteLine("Thank You");
        }
    }


    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            int totalMarks = 0;
            int earnedMarks = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Questions.Length; i++)
            {
                var question = Questions[i];
                if (question != null)
                {
                    Console.WriteLine($"# Question {i + 1} : {question.Body}");
                    question.DisplayQuestion();

                    Console.Write("Your Answer => ");
                    int userAnswerId = int.Parse(Console.ReadLine());

                    string userAnswerText = question.AnswerList[userAnswerId - 1].AnswerText;
                    string rightAnswerText = question.AnswerList[0].AnswerText;

                    Console.WriteLine($"Your Answer => {userAnswerText}");
                    Console.WriteLine($"Right Answer => {rightAnswerText}");

                    if (userAnswerId == question.AnswerList[0].AnswerId)
                    {
                        earnedMarks += question.Mark;
                    }

                    totalMarks += question.Mark;
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"Your Grade is {earnedMarks} from {totalMarks}");
            Console.WriteLine($"Time = {stopwatch.Elapsed}");
            Console.WriteLine("Thank You");
        }
    }
}
