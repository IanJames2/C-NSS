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

static void Main()
{
    AllQuestions questions = AllQuestions();
    foreach(string question in questions)
    {
        Console.WriteLine(question);
    }
    /*
    AllPositiveAnswers positiveAnswers = AllPositiveAnswers();
    foreach(string positiveAnswer in positiveAnswers)
    {
    Console.WriteLine(positiveAnswer);
    }

    AllNegativeAnswers negativeAnswers = AllNegativeAnswers();
    foreach(string negativeAnswer in negativeAnswers)
    {
        Console.WriteLine(negativeAnswer);
    }
    */
}

public class AllQuestions : IEnumerable
{
    private string[] questions = {"Are you enthusiastic?", "Do you love C# yet?", "Do you want to know a secret?"};

    public IEnumerator GetEnumerator()
    {
        for (int Index = 0; Index < questions.Length; Index++)
        {
            yield return questions[Index];
        }
    }
}
/*
public class AllPositiveAnswers : IEnumerable
{
    private string[] positiveAnswers = {"Yay!", "Good job sucking up to your instructor!", "ME TOO!!!! I love secrets...tell me one!"};

    public IEnumerator GetEnumerator()
    {
        for (int Index = 0; Index < positiveAnswers.Length; Index++)
        {
            yield return answers[Index];
        }
    }
}

public class AllQuestions : IEnumerable
{
    private string[] negativeAnswers = {"You should try it!", "You will...oh, yes, you will...", "Oh, no...secrets are the best, I love to share them!"};

    public IEnumerator GetEnumerator()
    {
        for (int Index = 0; Index < negativeAnswers.Length; Index++)
        {
            yield return questions[Index];
        }
    }
}
*/

