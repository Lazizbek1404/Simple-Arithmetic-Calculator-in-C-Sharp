//Greeting and Input User Name
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

//Input two numbers
Console.WriteLine($"Hello, {name}\nEnter two numbers with one space");
string[] input = Console.ReadLine().Split();

//Create two variables with input numbers
int firstNumber = Convert.ToInt32(input[0]);
int secondNumber = Convert.ToInt32(input[1]);

//Output simple arithmetic operations
Console.WriteLine($"Addition: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
Console.WriteLine($"Subtraction: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
Console.WriteLine($"Multiplication: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
Console.WriteLine($"Division (without remainder): {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
Console.WriteLine($"Division (with remainder): {firstNumber} / {secondNumber} = {firstNumber / secondNumber} (remainder: {firstNumber % secondNumber})");

