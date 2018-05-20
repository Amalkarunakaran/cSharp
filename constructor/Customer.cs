using System.Collections.Generic;
namespace ConstructorNS
{
    public class Customer//another class
    {
        public int Id;
        public string Name;//field
        public List<Order> Orders;
        //constructor is a method within a class with the same name of class
        //constructor do not have a return type or void
        // constructor of class Customer must same name as Customer
        //If we not created a default constructor.It will automatically created.And will set type values to their defaults.(int=0,bool=false,string="")
        //if we create one constructor..then system will not create a default one.
        public Customer()//Parameter less/ Default constructor
        {
            Orders = new List<Order>();//orders field always initialised to an emty list
            //if a class have list of objects,then make sure that the list initialised..
        }
         //:this() used for calling Current constructor ie,parameterless..
         //After calling and initialised..the Custome() and List of orders rest will execute..
         //:this() not have ";".
         //not good practice ...willmake controll flow little bit complex..
         //Also using default constructor is good..
        public Customer(int id) //overload constructor second time with signature change - add parameter id
          : this()
        {
            //Orders = new List<Order>(); copy pasting everywhere is not good way
            this.Id = id;//this denotes current object
        }
        public Customer(int id, string name)//overload constructor third time with int and string.
           : this(id)
        {
            //Orders = new List<Order>();//copy pating everywhere is not good way...
            this.Id=id;
            this.Name=name;
        }
       
    }
}
