using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Xml.Linq;
using System;
using SEDc.Homework3.Domain.Models;
using Newtonsoft.Json;
using SEDc.Homework3;

//Create a Dog class with :
//● Name, Age, Color
//● Let the user input these parameters from a console application
//● Create a new Dog object from the inputs and write it as a json in
//a new file on the file system
//● Create a method that reads and prints in the console all the dogs
//from the txt file

string folderPath = @"..\..\..\DogFolder";
string filePath = folderPath + @"\text.json";

if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

if(!File.Exists(filePath)) File.Create(filePath).Close();
List<Dog> dogs = new List<Dog>();

TextHelper.Writer(filePath, dogs);



while (true)
{
    Console.WriteLine("Please enter the parameters of the dog ");
    Console.WriteLine("Please enter Name of the dog ");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter the color of the dog ");
    string color = Console.ReadLine();
    Console.WriteLine("Please enter the Age of the dog ");

    bool ifParsed = int.TryParse(Console.ReadLine(), out int age);
    if (ifParsed == false)
    {
        Console.WriteLine("You entered wrong caracters, please try again");
    continue;

    }


   Dog dogFromInput = new Dog(name, age, color);

    dogs = TextHelper.Reader(filePath);

    dogs.Add(dogFromInput);

    TextHelper.Writer(filePath, dogs);

    dogs = TextHelper.Reader(filePath);

    foreach (Dog dog in dogs)
    {
        dog.Info();
    }





   

  

  


        


 

   
















}