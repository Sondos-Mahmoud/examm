using System;
using System.Collections.Generic;
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

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                if (question != null)
                {
                    question.DisplayQuestion();
                }
            }
        }
    }

    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                if (question != null)
                {
                    question.DisplayQuestion();
                    Console.WriteLine($"Right Answer: {question.AnswerList[0].AnswerText}");
                }
            }
        }
    }
}
