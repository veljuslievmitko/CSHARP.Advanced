using System.Threading.Tasks;

//Create a folder called Exercise
//● Create a txt file in it called calculations
//● Create a method that calculates 2 numbers and returns a string
//in the format: num1 + num2 = result(Ex: 2 + 3 = 5)
//● Ask the user to enter 2 numbers, call the calculate method and
//give the result
//● After the result is written in the console it should also be written
//in the calculations.txt file with a time stamp next to it
//● Call the console 3 times and write 3 results in the txt file




string folderPath = @"..\..\..\Exercise";
string filePath = folderPath + @"\Calculations.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}
if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

string CalculateTwoNumbers(int num1, int num2)
{
    return $"{num1} + {num2} = {num1 + num2}";
}

while (true)
{
    Console.WriteLine("Please enter two numbers");
    Console.WriteLine("Please enter first number");

    bool isParsed1 = int.TryParse(Console.ReadLine(), out int number1);
    Console.WriteLine("Please enter second number");

    bool isParsed2 = int.TryParse(Console.ReadLine(), out int number2);

    if (isParsed1 == false || isParsed2 == false)
    {
        Console.WriteLine("you entered wrong input ");
        continue;
    }

    Console.WriteLine(CalculateTwoNumbers(number1, number2));

    using(StreamWriter sw = new StreamWriter(filePath, true))
    {
        sw.WriteLine(CalculateTwoNumbers(number1, number2));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The calculation was written in the file");
        Console.ResetColor();
    }
}