using System;
namespace PersonalityQuiz
{
    public class QuizQuestion
    {
        public String Question { get; set; }
        public String Response1 { get; set; }
        public String Response2 { get; set; }
        public String Response3 { get; set; }
        public String Response4 { get; set; }


        public QuizQuestion(string question, string response1, string response2, string response3, string response4)
        {
            Question = question;
            Response1 = response1;
            Response2 = response2;
            Response3 = response3;
            Response4 = response4;
        }
    }
}
