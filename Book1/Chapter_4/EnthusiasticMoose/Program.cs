using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


// Let the moose speak!




void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}


MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("How are you today?");


List<Question> questions = new List<Question>
{
    new Question
    {
        Text = "Are you enthusiastic?",
        PositiveAnswer = "Yay!",
        NegativeAnswer = "You should try it!"
    },
    new Question
    {
        Text = "Do you love C# yet?",
        PositiveAnswer = "Good job sucking up to your instructor!",
        NegativeAnswer = "You will...oh, yes, you will..."
    },
    new Question
    {
        Text = "Do you want to know a secret?",
        PositiveAnswer = "ME TOO!!!! I love secrets...tell me one!",
        NegativeAnswer = "Oh, no...secrets are the best, I love to share them!"
    }
};

var listOfQuestions = questions.Where(q => q.Text.Contains("?"));

foreach (Question question in questions)
{
    Console.WriteLine(question.Text);
}

var listOfPositiveAnswers = questions.Where(pa => pa.Text.Contains("!"));
foreach (Question PositiveAnswer in questions)
{
    Console.WriteLine(PositiveAnswer.PositiveAnswer);
}

var listOfNegativeAnswers = questions.Where(na => na.Text.Contains("s"));
foreach (Question NegativeAnswer in questions)
{
    Console.WriteLine(NegativeAnswer.NegativeAnswer);
}


public class Question
{
    public string Text { get; set; }
    public string PositiveAnswer { get; set; }
    public string NegativeAnswer { get; set; }

}