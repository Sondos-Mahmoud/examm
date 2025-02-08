using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examm
{
  
        public class Answer
        {
            public int AnswerId { get; set; }
            public string AnswerText { get; set; }

            public Answer(int answerId, string answerText)
            {
                AnswerId = answerId;
                AnswerText = answerText;
            }
        }
        public abstract class Question
        {
            public string Header { get; set; }
            public string Body { get; set; }
            public int Mark { get; set; }
            public Answer[] AnswerList { get; set; }
            public int AnswerCount { get; set; } // To track the number of answers added

            public Question(string header, string body, int mark, int maxAnswers)
            {
                Header = header;
                Body = body;
                Mark = mark;
                AnswerList = new Answer[maxAnswers];
                AnswerCount = 0;
            }

            public void AddAnswer(Answer answer)
            {
                if (AnswerCount < AnswerList.Length)
                {
                    AnswerList[AnswerCount] = answer;
                    AnswerCount++;
                }
                else
                {
                    Console.WriteLine("Cannot add more answers. Maximum limit reached.");
                }
            }

            public abstract void DisplayQuestion();
        }
        public class TrueFalseQuestion : Question
        {
            public TrueFalseQuestion(string header, string body, int mark) : base(header, body, mark, 2) { }

            public override void DisplayQuestion()
            {
                Console.WriteLine($"{Header}: {Body} (True/False)");
            }
        }

        public class MCQQuestion : Question
        {
            public MCQQuestion(string header, string body, int mark, int maxChoices) : base(header, body, mark, maxChoices) { }

            public override void DisplayQuestion()
            {
                Console.WriteLine($"{Header}: {Body}");
                for (int i = 0; i < AnswerCount; i++)
                {
                    Console.WriteLine($"{i + 1}. {AnswerList[i].AnswerText}");
                }
            }
        }




    }

