using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestData.Models
{
    public class DbInitializer: DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext db)
        {

            Answer answer = new Answer { IsCorrect = true, IdQuestion = 1 , Text = "Answer1", Id = 1 };
            Answer answer1 = new Answer { IsCorrect = true, IdQuestion = 1, Text = "Answer1", Id = 2 };
            Answer answer2 = new Answer { IsCorrect = true, IdQuestion = 1 , Text = "Answer1", Id = 3 };
            Answer answer3 = new Answer { IsCorrect = true, IdQuestion = 1 , Text = "Answer1", Id = 4 };
            Answer answer4 = new Answer { IsCorrect = true, IdQuestion = 1 , Text = "Answer1", Id = 5 };
            Answer answer5 = new Answer { IsCorrect = true, IdQuestion = 1 , Text = "Answer1", Id = 6 };
            Answer answer6 = new Answer { IsCorrect = true, IdQuestion = 1, Text = "Answer1", Id = 7 };
            List<Answer> lAns = new List<Answer>() {answer,answer1,answer2,answer3,answer4,answer5,answer6 };
            db.Answer.AddRange(lAns);

            Test test = new Test { Id = 1 , Caption = "Test1" };
            Test test1 = new Test { Id = 1, Caption = "Test2" };
            db.Test.Add(test);
            db.Test.Add(test1);


            Question question = new Question { Text = "A?", Answer =new List<Answer>() { answer,answer1,answer2,answer3} , Id = 1 , Test = test, TestId = test.Id };
            Question question1 = new Question { Text = "B?", Answer = new List<Answer>() { answer4, answer5, answer6 }, Id = 1 , Test = test, TestId = test.Id };

            db.Question.Add(question);
            db.Question.Add(question1);


         



            db.SaveChanges();

          
        }
    }
}