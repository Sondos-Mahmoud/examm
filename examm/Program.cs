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

            subject.Exam.ShowExam();
        }
    }
    }

