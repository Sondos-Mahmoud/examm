using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static examm.Exam;

namespace examm
{
    internal class Subject
    {
       
            public int SubjectId { get; set; }
            public string SubjectName { get; set; }
            public Exam Exam { get; set; }

            public Subject(int subjectId, string subjectName)
            {
                SubjectId = subjectId;
                SubjectName = subjectName;
            }

            public void CreateExam(int examType, int time, int numberOfQuestions)
            {
                if (examType == 1)
                {
                    Exam = new PracticalExam(time, numberOfQuestions);
                }
                else if (examType == 2)
                {
                    Exam = new FinalExam(time, numberOfQuestions);
                }
            }
        }
    }

