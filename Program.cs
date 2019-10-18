using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced
{
    public abstract class Person 
    {
        private string name;    
        private int age;       // tính đóng gói 
        protected int salary;        
        public Person(string name,int age,int salary) // public cho các class con có thể truy cập 
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
       public abstract void sayHello();
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }          
    }
    public class Daddy : Person // inheritance
    {
        public int getSalary()
        {
            return salary;
        }

        public int getSalary(int bonus) // Overloading ( tính đa hình)
        {
            return salary + bonus;
        }
        
        public int getSalary(int bonus, int overtime)
        {
            return salary + bonus + overtime * 2;
        }

        public Daddy(string name, int age,int salary): base (name,age,salary)
        {
           
        }
        public override void sayHello() // override của tính đa hình
        {
            Console.WriteLine("Hello, I'm {0} and I'm {1} year old,My salary is {2}", getName(), getAge(),getSalary());
        }

    }
    public class Children : Person
    {
        public Children(string name,int age,int salary) : base(name, age,salary)
        {

        }
        public override void sayHello()
        {
            Console.WriteLine("Hi, I am {0} and I'm {1} year old ", getName(), getAge());
        }
       
    }
    public class Family // tạo class Family để quản lý nhìu person 
    {
        private List<Person> persons = new List<Person>();

        public void Add (Person person) // phương thức add để thêm các person vào class family
        {
            persons.Add(person);
        }
        public void showPerson() //  dùng để gọi phương thức sayHello // Minh họa tính đa hình
        {
            foreach( var person in persons) // cái này ko hiểu thì hỏi gooogle
            {
                person.sayHello();
            }
        }
    }
         
    class Program
    {
        static void Main(string[] args)
        {
            Daddy daddy = new Daddy("John",40,2000);
           
            Children children = new Children("Tom", 18,0);
            Family family = new Family();
            family.Add(daddy);
            family.Add(children);
            family.showPerson();
            //Console.WriteLine(daddy.salary);
            Console.ReadKey();




           
        }
    }
}
