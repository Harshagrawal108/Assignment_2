using System;

Que1Ass2:
Ans: -
using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }


    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }


    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Age: " + Age);
        Console.WriteLine("Employee Salary: $" + Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {

        Employee employee1 = new Employee("Harshit Sengar", 22, 50000000.00);


        Console.WriteLine("Employee Details:");
        employee1.DisplayDetails();
    }
}

Que2Ass2:
Ans: -
using System;

public static class Logger
{
    public static void LogMessage(string message)
    {
        Console.WriteLine($"{DateTime.Now}: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger.LogMessage("This is a log message.");
        Logger.LogMessage("Another log message.");

    }
}
Que3Ass2:
Ans: -
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excption
{
    internal class Ass5Que1
    {
        static void Main(string[] args)
        {
            try
            {
                int dividend = 10;
                int divisor = 0;

                int result = dividend / divisor;

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program completed.");
            }
        }
    }
}

Que4Ass2:
Ans: -
using System;

public class MyClass
{
    private int myField;

    public void SetMyField(int value)
    {
        myField = value;
    }

    public int GetMyField()
    {
        return myField;
    }
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        myObject.SetMyField(560);

        int value = myObject.GetMyField();
        Console.WriteLine($"The value of myField is: {value}");
    }
}

Que5Ass2:
Ans: -
using System;

public partial class Person
{
    public void PrintFullName()
    {
        if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
        else
        {
            Console.WriteLine("Full Name: (Not specified)");
        }
    }
}

public partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "Harshit";
        person.LastName = "Sengar";

        person.PrintFullName();
    }
}

Que6Ass2:
Ans: -
using System;

public partial class Employee
{
    public decimal CalculateSalary()
    {
        return BaseSalary;
    }

    public decimal CalculateSalaryWithBonus(decimal bonusPercentage)
    {
        if (bonusPercentage < 0 || bonusPercentage > 100)
        {
            throw new ArgumentException("Invalid bonus percentage. It must be between 0 and 100.");
        }

        decimal bonusAmount = (bonusPercentage / 100) * BaseSalary;
        return BaseSalary + bonusAmount;
    }

    public decimal CalculateSalaryWithOvertime(decimal hourlyRate, int hoursWorked)
    {
        if (hourlyRate < 0 || hoursWorked < 0)
        {
            throw new ArgumentException("Hourly rate and hours worked must be non-negative.");
        }

        return BaseSalary + (hourlyRate * hoursWorked);
    }
}


Que7Ass2:
Ans: -
using System;

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
    }
}

Que8Ass2:
Ans: -
using System;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();
}

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} is barking!");
    }

    public override void MakeSound()
    {
        Bark();
    }
}

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }

    public void Meow()
    {
        Console.WriteLine($"{Name} is meowing!");
    }

    public override void MakeSound()
    {
        Meow();
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Harsh", 3);
        Cat cat = new Cat("Ketty", 2);

        dog.Bark();
        cat.Meow();

        Animal animal1 = dog;
        Animal animal2 = cat;

        animal1.MakeSound();
        animal2.MakeSound();
    }
}

Que9Ass2:
Ans: -
using System;

public class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

public sealed class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}
class Program
{
    static void Main()
    {
        Car car = new Car();
        car.StartEngine();
        car.Drive();
        car.StopEngine();
    }
}

Que10Ass2:
Ans: -
using System;

public class BankAccount
{
    public string AccountNumber { get; private set; }
    public decimal Balance { get; protected set; }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }
}

public sealed class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, decimal initialBalance)
        : base(accountNumber, initialBalance)
    {
    }

    public void AddInterest(decimal rate)
    {
        if (rate > 0)
        {
            decimal interest = Balance * rate / 100;
            Balance += interest;
            Console.WriteLine($"Added interest of {interest:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid interest rate.");
        }
    }

    public override void Withdraw(decimal amount)
    {
        decimal minimumBalance = 100;

        if (amount > 0 && Balance - amount >= minimumBalance)
        {
            base.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance to maintain the minimum balance.");
        }
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount savingsAccount = new SavingsAccount("SA12345", 1000);

        savingsAccount.Deposit(290);
        savingsAccount.Withdraw(290);

        savingsAccount.AddInterest(5);

        savingsAccount.Withdraw(560);

        Console.WriteLine($"Final balance in the savings account: {savingsAccount.Balance:C}");
    }
}
