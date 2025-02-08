# Examination System

A simple C# program to create and take exams. Supports **Final Exam** and **Practical Exam** with **True/False** and **MCQ** questions.

---

## Features

- **Two Exam Types**:
  - **Final Exam**: True/False and MCQ questions.
  - **Practical Exam**: MCQ questions only.
- **Automatic Grading**: Evaluates answers and calculates grades.
- **Timer**: Tracks time taken to complete the exam.


### Using the System

1. **Start the Program**:
   - Choose the exam type (1 for Practical, 2 for Final).

2. **Enter Exam Details**:
   - Enter exam time (30–180 minutes) and number of questions.

3. **Add Questions**:
   - For **Final Exam**:
     - Choose question type (1 for True/False, 2 for MCQ).
     - Enter question body, mark, and correct answer.
   - For **Practical Exam**:
     - Only MCQ questions are allowed.
     - Enter question body, mark, choices, and correct answer.

4. **Start the Exam**:
   - Confirm to start the exam (Y/N).
   - Answer the questions by selecting the answer ID.

5. **View Results**:
   - After the exam, the program will show:
     - Your answers.
     - Correct answers.
     - Your grade.
     - Time taken.

---

## Example Output

```
Please Enter The Type Of Exam (1 For Practical | 2 For Final)
2
Please Enter the time For Exam From (30 min to 180 min)
60
Please Enter the Number Of questions
2

# Question 1 : What is the extension of a C# language file?
1-.c
2-.cpp
3-.cs
Your Answer => 3
Your Answer => .cs
Right Answer => .cs

# Question 2 : Pascal case is used when naming a class?
1-True
2-False
Your Answer => 1
Your Answer => True
Right Answer => True

Your Grade is 6 from 6
Time = 00:00:28.8669075
Thank You
```

---

## Project Structure

- **Question.cs**: Base class for questions.
- **TrueFalseQuestion.cs**: True/False questions.
- **MCQQuestion.cs**: Multiple Choice Questions.
- **Answer.cs**: Represents answers.
- **Exam.cs**: Base class for exams.
- **FinalExam.cs**: Final Exam implementation.
- **PracticalExam.cs**: Practical Exam implementation.
- **Subject.cs**: Represents a subject and its exam.
- **Program.cs**: Main program.


---

Enjoy using the Examination System! 🚀

--- 

