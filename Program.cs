
Random r = new Random();
List<string> operations = new List<string>();
int points = 0;
string? userAnswer;
string? mathQuestion;
string computerAnswer;
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
    if (userInput.Trim() == "" || userInput == null || userInput.Trim().Length != 1) 
    {
        Console.WriteLine("Incorrect input, please enter a number between 1 and 6 to access our options.");
        continue;
    }
    else
    {
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
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Answer, Try another time!");
                        continue;
                    }
                }
                break;
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
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Answer, Try another time!");
                        continue;
                    }
                }
                break;
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
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Answer, Try another time!");
                        continue;
                    }
                }
                break;
            case "4":
                {

                }
        }
    }
} while (true);