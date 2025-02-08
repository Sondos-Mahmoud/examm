namespace examm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Type Of Exam (1 For Practical | 2 For Final)");
            int examType = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the time For Exam From (30 min to 180 min)");
            int time = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Number Of questions");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            Subject subject = new Subject(1, "C# Programming");
            subject.CreateExam(examType, time, numberOfQuestions);

            for (int i = 0; i < numberOfQuestions; i++)
            {
                if (examType == 2) // Final Exam
                {
                    Console.WriteLine("Please Enter the Question Type (1 for True/False | 2 for MCQ)");
                    int questionType = int.Parse(Console.ReadLine());

                    if (questionType == 1) // True/False Question
                    {
                        Console.WriteLine("# True | False Question");
                        Console.WriteLine("Please Enter Question Body");
                        string body = Console.ReadLine();

                        Console.WriteLine("Please Enter Question Mark");
                        int mark = int.Parse(Console.ReadLine());

                        TrueFalseQuestion tfQuestion = new TrueFalseQuestion($"Q{i + 1}", body, mark);

                        Console.WriteLine("Please Enter the right Answer id (1 for True | 2 for False)");
                        int rightAnswerId = int.Parse(Console.ReadLine());

                        tfQuestion.AddAnswer(new Answer(1, "True"));
                        tfQuestion.AddAnswer(new Answer(2, "False"));

                        subject.Exam.AddQuestion(tfQuestion);
                    }
                    else if (questionType == 2) // MCQ Question
                    {
                        Console.WriteLine("# MCQ Question");
                        Console.WriteLine("Please Enter Question Body");
                        string body = Console.ReadLine();

                        Console.WriteLine("Please Enter Question Mark");
                        int mark = int.Parse(Console.ReadLine());

                        MCQQuestion mcqQuestion = new MCQQuestion($"Q{i + 1}", body, mark, 3);

                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine($"Please Enter Choice Number {j + 1}");
                            string choice = Console.ReadLine();
                            mcqQuestion.AddAnswer(new Answer(j + 1, choice));
                        }

                        Console.WriteLine("Please Enter the right Answer id");
                        int rightAnswerId = int.Parse(Console.ReadLine());

                        subject.Exam.AddQuestion(mcqQuestion);
                    }
                }
                else if (examType == 1) 
                {
                    Console.WriteLine("# MCQ Question");
                    Console.WriteLine("Please Enter Question Body");
                    string body = Console.ReadLine();

                    Console.WriteLine("Please Enter Question Mark");
                    int mark = int.Parse(Console.ReadLine());

                    MCQQuestion mcqQuestion = new MCQQuestion($"Q{i + 1}", body, mark, 3);

                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Please Enter Choice Number {j + 1}");
                        string choice = Console.ReadLine();
                        mcqQuestion.AddAnswer(new Answer(j + 1, choice));
                    }

                    Console.WriteLine("Please Enter the right Answer id");
                    int rightAnswerId = int.Parse(Console.ReadLine());

                    subject.Exam.AddQuestion(mcqQuestion);
                }
            }

            Console.WriteLine("Do You Want To Start Exam (Y|N)");
            string startExam = Console.ReadLine();

            if (startExam.ToUpper() == "Y")
            {
                Console.Clear();
                subject.Exam.ShowExam();
            }
            else
            {
                Console.WriteLine("Exam not started. Exiting...");
            }
        }
    }
}

