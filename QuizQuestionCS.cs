using System;
using Xamarin.Forms;

namespace PersonalityQuiz
{

    public class QuizCS : CarouselPage
    {
        public QuizCS()
        {
            Thickness padding;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                case Device.Android:
                    padding = new Thickness(0, 40, 0, 0);
                    break;
                default:
                    padding = new Thickness();
                    break;
            }

            ItemTemplate = new DataTemplate(() => {
                var questionLabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    HorizontalOptions = LayoutOptions.Center
                };
                questionLabel.SetBinding(Button.TextProperty, "Question");

                var answer1 = new Button
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                answer1.SetBinding(Button.TextProperty, "answer1");

                var answer2 = new Button
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                answer2.SetBinding(Button.TextProperty, "answer2");
                var answer3 = new Button
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                answer3.SetBinding(Button.TextProperty, "answer3");

                var answer4 = new Button
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                answer4.SetBinding(Button.TextProperty, "answer4");


                return new ContentPage
                {
                    Padding = padding,
                    Content = new StackLayout
                    {
                        Children = {
                    questionLabel,
                    answer1,
                    answer2,
                    answer3,
                    answer4
                }
                    }
                };
            });
            QuizDataModel quizDataModel = new QuizDataModel();
            ItemsSource = quizDataModel.QuizQuestions;
        }
    }
}

