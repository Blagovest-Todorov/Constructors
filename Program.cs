using System;

namespace _05.Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Consotructors are special type of methods that is called when an object is created, 
            //have the same name as of class that  hold them, 
            //constructors dont return a value, 
            // in a Class may have several construstors with different  set of parameters.
            //they return they create a new object of a given class.

            Car car = new Car(2013); //new Car()  is constructor
            Console.WriteLine(car.Year);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Color);
            string str = new string('n', 10); //constructor make s an obect 10 time n/ nnnnnnnnnn/
            Console.WriteLine(str);
            string str2 = new string('*' , 5);
            Console.WriteLine(str2);
            DateTime dt = new DateTime(2020, 11, 28);
            Console.WriteLine(dt);


        }
        class Car 
        {
            public int Year { get ; set ; } //this is a property ! 
            public  string Color{ get; set; }
            public string Model { get; set; }

            //constructor is always public ! ot mostly public 
            public Car()  //constructor takes the name of the calls , constructor does not have a type 
            {
                Year = 2010; //constructor gives some first intial value of the variables//initializes
                Color = "Black"; //constructor gives starting values of the fileds //initializes firstly the fileds
                Model = "Trabant";
            }
            public Car(int year ) 
            {
                Year = year;
                Color = "black";
                Model = "trabant";
            }
            //the constructor is called, invoked by the word "new"
            //the constructor withou parameters is called default constructor, parameterless constructor! 

        }
    }
}
