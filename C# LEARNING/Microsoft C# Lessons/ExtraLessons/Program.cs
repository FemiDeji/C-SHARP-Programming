// See https://aka.ms/new-console-template for more information
/*
//Trimming a text in C#
string Name1 = "    Adeniyi     ";
string Name2 = "    Oluwafemi   ";

Name1 = Name1.TrimStart();
Name2 = Name2.TrimEnd();
Console.WriteLine($"My Surname is {Name1} and my lastname is {Name2}");
Console.WriteLine($"My Surname is {Name1.Trim()} and my lastname is {Name2.Trim()}");


//Replacing a text in C#
string Name3 = "Hello";
string Name4 = "I am a successful Forex Trader";
Name4 = Name4.Replace("Forex", "Fx");
Name3 = "Hi, Welcome to BlazeFx";
Console.WriteLine(Name3);
Console.WriteLine(Name4.Replace("Hello", "Hi, Welcome to BlazeFx"));
Console.WriteLine(Name4.Replace("successful", "profitable"));
Console.WriteLine(Name4);


//Manipulating Strings in C#
string Name5 = "Forex";
Console.WriteLine(Name5.Contains("o"));
Console.WriteLine(Name5.ToUpper());
Console.WriteLine(Name5.Length);

//Numbers
long a = 7600000000;
long b = 5400000000;
long c = a / b;
Console.WriteLine($"C= {c}");

double d = 34.1;
double e = 21.2;
double f = d * e;
Console.WriteLine($"F= {f}");

decimal g = 54.2M;
decimal h = 44.3M;
decimal i = g - h;
Console.WriteLine($"I= {i}");

float j = 23.3F;
float k = 33.4F;
float l = k + j;
Console.WriteLine($"L= {l}");

//Branching, Ifs and Conditional Logic
int a = 2;
int b = 7;
int c = 2;

//bool myTest = c > 10;

if((a + b + c > 15) || (a == b))
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

//Branching, While Loops and Do-while loops
int counter = 0;
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);

int counter = 0;
do
{
    counter++;
    Console.WriteLine(counter);
}
while (counter < 5);

for (int i = 0; i < 5; i++)
{
    if (i == 3)
    {
        Console.WriteLine(i);
    }
    else
    {
        Console.WriteLine("Invalid");
    }
    
}

//Nested for-loop
for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}


//List <T>, Collections  of data, Arrays and Indexing
var names = new List<string> {"Rabbii", "Femi"};
var names = new string [] {"Deji", "Ayo"};

names.Add("John");
names.Add("Stella");
names.Add("Iredia");
names = [..names, "Femi"];

foreach(var name in names[2..4])
foreach(var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine(names[1]);
Console.WriteLine(names[3]);
Console.WriteLine(names[names.Count-1]);

//Sorting and Searching Lists
var names = new List<string> {"Ruth", "Eben", "Dami", "Tobi", "Tolu"};
names.Sort();

var integers = new List<int> {1, 2, 20, 25, 76, 0, 4, 6, 7, 8, 9,};
Console.WriteLine($"0 is at index {integers.IndexOf(0)}");
Console.WriteLine($"7 is at index {integers.IndexOf(7)}");
integers.Sort();
Console.WriteLine($"0 is at index {integers.IndexOf(0)}");
Console.WriteLine($"7 is at index {integers.IndexOf(7)}");

foreach (var number in integers)
{
    Console.WriteLine(number);
}

//LINQ - Language Integrated Query
int [] scores = [65, 76, 34, 88, 90, 21];
Console.WriteLine(scores[0]);

//Specifying the data source
List<int> scores = [65, 76, 34, 88, 90, 21, 100, 98, 91];
scores.Sort();          //sorting the list before executing the other instructions

for (int i = 0; i<scores.Count; i++)
{
    if (scores[i] >80)
    {
        Console.WriteLine("You passed");
    }
    else
    {
        Console.WriteLine("You failed");
    }
}

//Defining the Query
IEnumerable<string> scoreQuery =    //query variable
from score in scores
where score > 80
orderby score descending
select $"The score is {score}";

//Executing the Query
foreach (string s in scoreQuery)
{
    Console.WriteLine(s);
}

//alternative method to define the Query
var scoreQuery =  scores.Where(s => s > 80).
            OrderByDescending(s => s);

List<int> myScores = scoreQuery.ToList();
foreach (var score in myScores)
{
    Console.WriteLine(score);
}

//OOP- Object Oriented Programming
namespace myTest
{
    public class TestRun
    {
        public static void Main()
        {
            Console.WriteLine("Hi");
        }
    }
}       

var p1 = new Person("Femi", "Adeniyi", new DateOnly(2003, 08, 16));
var p2 = new Person("Bamidele", "Omidiora", new DateOnly(2005, 05, 18));
var p3 = new Person("Deji", "Adeniyi", new DateOnly(2005,01,19));

p1.Pets.Add(new Eagle("Fred"));
p1.Pets.Add(new Eagle("Cisco"));

p2.Pets.Add(new Lion("Freddy"));

p3.Pets.Add(new Cat("Dusty"));

List<Person> people = [p1, p2, p3];

foreach (var person in people)
{
    Console.WriteLine($"{person}");
    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"   {pet}");
    }
}

Console.WriteLine(people.Count);

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get; } = firstname;

    public string Last { get; } = lastname;

    public DateOnly Birthday { get; } = birthday;

    public List<Pet> Pets { get; } = new();

    public override string ToString()
    {
        return $"Human {Last} {First}";
    }
}

public abstract class Pet(string firstname)
{
    public string First { get; } = firstname;

    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"{First}, a {GetType().Name} and I {MakeNoise()}";
    }
}

public class Eagle(string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "Soar";
}

public class Lion(string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "Roar";
}

public class Cat(string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "Meow";
}       */


var names = new List<string> { "Ay", "Jeff", "Don"}; 
var pets = new List<string> { "Eagle", "Cat", "Lion"};

// Display all elements in the names list
//Console.WriteLine("Names: ");
foreach (var name in names)
{
    Console.WriteLine($"Human: {name}");
    foreach(var pet in pets)
    {
        Console.WriteLine($"I am a pet: {pet}");
    }
}

// Display all elements in the pets list
//Console.WriteLine("\nPets: ");
// foreach(var pet in pets)
// {
//     Console.WriteLine($"I am a pet: {pet}");
// }

 // LINQ query to order names in descending order and format the output
IEnumerable<string> namesQuery = 
from name in names
orderby name descending
select $"My name is {name}";

// Display the result of the LINQ query
// Console.WriteLine("\nNames in descending order: ");
// foreach(var formattedName in namesQuery)
// {
//     Console.WriteLine(formattedName);
// }

// // Combine both lists and display all elements using LINQ
// var allElements = names.Concat(pets);

// Console.WriteLine("\nAll Elements: ");
// foreach (var element in allElements)
// {
//     Console.WriteLine(element);
// }