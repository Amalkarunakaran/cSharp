/* program to demonstrate class
OUTPUT : Hello Balu, my name is Amal
mobin
Hello Georgy, my name is Gokul */

using System;
namespace Classes
{
    public class Person //a new class with accessibility modifier person
    {
        public string Name;// field
        public void Introduce(string to)//method
        {
            System.Console.WriteLine("Hello {0}, my name is {1}",to,Name);

        }
        public Person Parse1(string str)//pars is an instance method of class person
        {
            var person = new Person();
            person.Name = str;
            return person;

        }
        //static member member 
        public static Person Parse2(string str)//by creating static method.so we can access Parse2 outside without creating object.
        {
            var person = new Person();
            person.Name=str;
            return person;
        }
    }
    class MainClass//main class
    {
        static void Main(string[] args)
        {
            var person = new Person();//create an instance(object - person) of class "Person"
            // can also writen as Person person = new Person(); 
            person.Name="Amal";//accessing Name field from class Person 
            person.Introduce("Balu");//accessing method of class introduce

            var p1 = person.Parse1("mobin");//calling parse1 from class Person with obect person and assign to var p1.
            System.Console.WriteLine(p1.Name);//console Name field in object p1.

            var p2 = Person.Parse2("Gokul");
            //call Parse2 method from Person class directly becouse its a stsic member method.so no need of object creation.
            p2.Introduce("Georgy");
            //can also call introduce with p2.it have a person object in Parse2 static method
        }
        
    }
    
}
