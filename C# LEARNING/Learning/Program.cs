// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Globalization;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Datatypes in C#
            /*string name = "Brown";
            char grade = 'D';
            int age = 20;
            double, float, decimal
            double gpa = 4.82;
            bool isMale = true;

            string xterName = "Deji";
            int xterAge;
            xterAge = 65;
            Console.WriteLine("There was a man named " +xterName);
            Console.WriteLine("He was " +xterAge + " yrs old");

            xterName = "Ayo";
            Console.WriteLine("He really liked the name " +xterName);
            Console.WriteLine("But didn't like being " +xterAge);


            //Working with strings in C#
            string name = "Adeniyi Oluwafemi";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper() );
            Console.WriteLine(name.ToLower() );
            Console.WriteLine(name.Contains("Oluwafemi"));
            Console.WriteLine(name.IndexOf("Oluwafemi"));
            Console.WriteLine(name[3]);
            Console.WriteLine(name.IndexOf('g'));
            Console.WriteLine(name.IndexOf('e'));
            Console.WriteLine(name.Substring(8));
            Console.WriteLine(name.Substring(8, 4)); 


            //Working with numbers in C#
            Console.WriteLine(12345);
            Console.WriteLine(-6.889);
            Console.WriteLine(10 + 20);
            Console.WriteLine(20 / 15);
            Console.WriteLine(25 % 10);
            Console.WriteLine(25 / 2 + 15 - 6 * 3);
            Console.WriteLine(7.5 + 4.2);
            Console.WriteLine(7 + 3.6);
            
            int num = 20;
            Console.WriteLine(num);
            Console.WriteLine(num++);
            Console.WriteLine(num--);
            Console.WriteLine(Math.Abs(20));
            Console.WriteLine(Math.Pow(6, 5));
            Console.WriteLine(Math.Sqrt(7));
            Console.WriteLine(Math.Max(5, 15));
            Console.WriteLine(Math.Min(65, 67));
            Console.WriteLine(Math.Round(50.66)); 


            //Getting User Input in C#
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Hello " + name + " you are " + age + " yrs old"); 


            //Building a Calculator in C#
            int num = Convert.ToInt32("54");
            Console.WriteLine( num + 7);
            Console.Write("Enter first num: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second num: ");
            double num2 =  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2); 


            //Building a MadLibs in C#
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a pluralNoun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity); 


            //Arrays in C#
           int[] list1 = {2, 4, 6, 7, 8, 1}; 
           list1[3] = 50;
           Console.WriteLine(list1[3]);

           string[] interns = new string[4];
           interns[0] = "Micheal";
           interns[1] = "Peter";
           interns[2] = "Cyril";
           interns[3] = "Precious";
           Console.WriteLine(interns[3]); 


            //Methods in C#
           Hi("Femi", 21);
           Hi("Tobi", 30);
           Hi("Stella", 19);
           Hi("Tolu", 31);

           Console.ReadLine();
           
        static void Hi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " yrs old");
            Console.WriteLine("You are welcome to BlazeFx");
        }
        
            int cubedNumber = cube(6);
            Console.WriteLine(cubedNumber);
            //Console.WriteLine(cube(6));

            Console.ReadLine(); 

            Console.WriteLine(cube(7));
            
        //Return Statements in C#
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        

        //If Statements in C#
        bool isMale = false;
        bool isTall = false;

        if (isMale && isTall)
        {
            Console.WriteLine("You are a male and you are tall");
        }
        else if(isMale || !isTall)
        {
            Console.WriteLine("You are a male but not tall");
        }
        else if(!isMale && isTall)
        {
            Console.WriteLine("You are not a male but you are tall");
        }
        else
        {
            Console.WriteLine("You are either not a male, not tall or both");
        }  

        Console.WriteLine(GetMax(51, 70, 6));

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else 
            {
                result = num3;
            }
              
            return result;
        } 


        //Building a Better Caculator
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator: ");
        string op = Console.ReadLine();

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        

        if (op == "+")
        {
            Console.WriteLine(num1 + num2);
        }
        else if (op == "-")
        {
            Console.WriteLine(num1 - num2);
        }
        else if (op == "/")
        {
            Console.WriteLine(num1 / num2);
        }
        else if (op == "*")
        {
            Console.WriteLine(num1 * num2);
        }
        else if (op == "%")
        {
            Console.WriteLine(num1 % num2);
        }
        else
        {
            Console.WriteLine("Invalid Operator");
        } 

        Console.WriteLine(GetDay(5));
        

        //Switch Statements in C#
        static string GetDay(int DayNum)
        {
            string DayName;
            switch (DayNum)
            {
                case 0:
                DayName = "Sunday";
                break;
                case 1:
                DayName = "Monday";
                break;
                case 2:
                DayName = "Tuesday";
                break;
                case 3:
                DayName = "Wednesday";
                break;
                case 4: 
                DayName = "Thursday";
                break;
                case 5: 
                DayName = "Friday";
                break;
                case 6:
                DayName = "Saturday";
                break;
                default:
                DayName = "Invalid Entry";
                break;
            }
            return DayName;
        } 


        //While Loops In C#
        int index = 0;
        while (index <= 9)
        {
            Console.WriteLine(index);
            index++;
        } 


        //Do-while Loops in C#
        int index = 7;
        do
        {
            Console.WriteLine(index);
            index++;
        } while (index <= 3);   


        //Building a Guessing Game
        string SecretWord = "Forex";
        string guess = "";

        while (guess != SecretWord)
        {
            Console.Write("Enter your guess: ");
            guess = Console.ReadLine();
        }
        Console.Write("You Win"); 


        // Guessing game using while loop
        string SecretWord = "Forex";
        string guess = "";
        int GuessCount = 0;
        int GuessLimit = 3;
        bool OutOfGuesses = false;

        while (guess != SecretWord && !OutOfGuesses)
        {
            if (GuessCount < GuessLimit)
            {
                Console.Write("Enter your guess: ");
                guess = Console.ReadLine();
                GuessCount++;
            }
            else 
            {
                OutOfGuesses = true;
            }     
        }
        if (OutOfGuesses)
        {
            Console.WriteLine("You Lose!");
        }
        else
        {
            Console.WriteLine("You Win!");
        }

        //Guessing game using Do-while loop
        do
        {
            if (GuessCount < GuessLimit)
            {
                Console.Write("Enter your guess: ");
                guess = Console.ReadLine();
                GuessCount++;
            }
            else 
            {
                OutOfGuesses = true;
            }
            
        } 
        while (guess != SecretWord && !OutOfGuesses);
        if  (OutOfGuesses)
            {
                Console.WriteLine("You Lose");
            }
            else 
            {
                Console.WriteLine("You Win");
            }   

            For-loops in C#
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            int [] Wealth = {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
            for (int i = 0; i < Wealth.Length ; i++)
            {
                Console.WriteLine(Wealth[i]);
            }   


            //Building an Exponent Method
            Console.WriteLine(GetPow(3, 2));

            static int GetPow(int BaseNum, int PowNum)
            {
                int result = 1;
                for (int i = 0; i < PowNum; i++)
                {
                    result = result * BaseNum;
                }
                return result;
            }   

            //2D Arrays in C# 
            int [,] NumGrid = 
            {
                {1, 2},
                {3, 4},
                {5, 6},
                {7, 8}
            };
            Console.WriteLine(NumGrid[1, 0]);   


            //Exception Handling in C# 
            try
            {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);   
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }   

            //Classes & Objects 
            Book book1 = new Book("Femi");                      //used from class Book.cs
            book1.title = "How To Become a Successful Forex Trader";
            book1.author = "Adeniyi Oluwafemi";
            book1.pages = 200;

            Book book2 = new Book("Stella");                       //used from class Book.cs
            book2.title = "How To Become a Profitable Forex Trader";
            book2.author = "BlazeFx";
            book2.pages = 350;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.pages); 
            Console.WriteLine(book1.author);
            Console.WriteLine(book2.title);

            Book book1 = new Book("How To Become a Successful Forex Tradex", "Femi", 200);
            Book book2 = new Book("How To Become a Profitable Forex Trader", "BlazeFx", 350);

            book2.title = "Forex Trading";

            Console.WriteLine(book2.title);  */   

            //Object Methods
            Student student1 = new Student("Femi", "Computer Science", 4.82);          //used from class Student.cs
            Student student2 = new Student("Covenant", "Mass Comm", 4.00);             //used from class Student.cs
            
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());      
/*
            //Getters and Setters
            Movie movie1 = new Movie("A Tribe Called Judah", "Jennifer", "Goat");       //used from class Movies.cs
            Movie movie2 = new Movie("Prophetess", "Yetunde", "Dog");                   //used from class Movies.cs

            Console.WriteLine(movie1.Rating);
            Console.WriteLine(movie2.Rating);
            Console.WriteLine(movie1.title);
            Console.WriteLine(movie2.title);
            Console.WriteLine(movie1.director);
            Console.WriteLine(movie2.director); 

            //Static Class Attributes
            Song Yah = new Song("Yah", "Dunsin", 6000);                             //used from class Song.cs
            Console.WriteLine(Song.SongCount);
            Song CallingMyName = new Song("Calling My Name", "Ebuka", 3600);        //used from class Song.cs
            Console.WriteLine(Song.SongCount);
            Song DarlingJesus = new Song("Darling Jesus", "Neeja", 240);            //used from class Song.cs

            Console.WriteLine(Yah.title);
            Console.WriteLine(CallingMyName.duration);
            Console.WriteLine(Yah.getsongCount());  

            //Static Method and Classes - static method is a method that pertains to a class and doesn't need an object to be crated before it can be used
            Console.WriteLine(Math.Sqrt(10000));                    //Math and Sqrt are static methods
            UsefulTools.SayHi("Femi");                              //used from class UsefulTools.cs 
            UsefulTools.Welcome("Deji", 20);                      //used from class UsefulTools.cs 

            //Inheritance 
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeSalad();

            ItalianChef Italianchef = new ItalianChef();
            Italianchef.MakeSpag();

            Chef cook = new Chef();
            cook.ChefsSpecialDish();

            ItalianChef chefs = new ItalianChef();
            chefs.ChefsSpecialDish();       */
            
        }   
    }     
}
