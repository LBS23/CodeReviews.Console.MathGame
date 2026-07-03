
using System.Runtime.CompilerServices;

Random r = new Random();
List<string> operations = new List<string>();
int points = 0;
string? userAnswer;
string? mathQuestion;
int computerAnswer;
bool isTrue = true;
int totalOp;
do
{
    int number1 = r.Next(0, 101);
    int number2 = r.Next(0, 101);
    Console.WriteLine($"Welcome to the math game! Current points: {points}");
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Get an addition question.");
    Console.WriteLine("2. Get a subtraction question.");
    Console.WriteLine("3. Get a division question.");
    Console.WriteLine("4. Get a multiplication question.");
    Console.WriteLine("5. Show past answers.");
    Console.WriteLine("6. Exit the game.");
    string? userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            {
                Console.Write($"{number1} + {number2} = ");
                computerAnswer = number1 + number2;
                userAnswer = Console.ReadLine();
                mathQuestion = number1.ToString() + " + " + number2.ToString() + " = " + userAnswer;
                operations.Add(mathQuestion);
                if (int.Parse(userAnswer) == computerAnswer)
                {
                    Console.WriteLine("Correct Answer! Good Job!");
                    points++;
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Answer, Try another time!");
                    Console.ReadLine();
                    continue;
                }
            }
        case "2":
            {
                Console.Write($"{number1} - {number2} = ");
                computerAnswer = number1 - number2;
                userAnswer = Console.ReadLine();
                mathQuestion = number1.ToString() + " - " + number2.ToString() + " = " + userAnswer;
                operations.Add(mathQuestion);
                if (int.Parse(userAnswer) == computerAnswer)
                {
                    Console.WriteLine("Correct Answer! Good Job!");
                    points++;
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Answer, Try another time!");
                    Console.ReadLine();
                    continue;
                }
            }
        case "3":
            {
                while (number2 == 0 || (number1 % number2) != 0)
                {
                    number2 = r.Next(0, 101);
                }
                Console.Write($"{number1} / {number2} = ");
                computerAnswer = number1 / number2;
                userAnswer = Console.ReadLine();
                mathQuestion = number1.ToString() + " / " + number2.ToString() + " = " + userAnswer;
                operations.Add(mathQuestion);
                if (int.Parse(userAnswer) == computerAnswer)
                {
                    Console.WriteLine("Correct Answer! Good Job!");
                    points++;
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Answer, Try another time!");
                    Console.ReadLine();
                    continue;
                }
            }
        case "4":
            {
                Console.Write($"{number1} * {number2} = ");
                userAnswer = Console.ReadLine();
                computerAnswer = number1 * number2;
                mathQuestion = number1.ToString() + " * " + number2.ToString() + " = " + userAnswer;
                operations.Add(mathQuestion);
                if (int.Parse(userAnswer) == computerAnswer)
                {
                    Console.WriteLine("Correct Answer, Good Job!");
                    Console.ReadLine();
                    points++;
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect answer, try another time!");
                    Console.ReadLine();
                    continue;
                }
            }
        case "5":
            {
                totalOp = operations.Count;
                if (totalOp == 0)
                {
                    Console.WriteLine("You have no registered attempts.");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("This have been your past questions and answers: ");
                    for (int i = 0; i < totalOp; i++)
                    {
                        Console.WriteLine($"{operations[i]}");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    continue;
                }
            }
        case "6":
            {
                Console.WriteLine("Thank you so much for playing.");
                isTrue = false;
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                continue;
            }
        default:
            {
                Console.WriteLine("Invalid Input, please try again following the directions.");
                Console.ReadLine();
                continue;
            }
    }
} while (isTrue);