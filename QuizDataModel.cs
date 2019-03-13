using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PersonalityQuiz
{
    public class QuizDataModel : IEnumerable
    {
        public List<QuizQuestion> QuizQuestions { get; set; }

        public QuizDataModel()
        {
            this.QuizQuestions.Add(new QuizQuestion("Whats your favorite flavor of Ice Cream?", "Chocolate", "Vanilla", "Strawberry", "Butter Pecan"));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.QuizQuestions.GetEnumerator();
        }
    }
}
