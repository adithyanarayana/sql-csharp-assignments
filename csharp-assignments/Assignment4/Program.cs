// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using Assignment4.Repository;
using Assignment4.DataModel;

//Console.WriteLine("Hello, World!");


// 1. 

MyStack<int> s = new MyStack<int>();

s.Push(1);
s.Push(2);
s.Push(3);
s.Push(4);

Console.WriteLine("Count: " + s.Count()); 

Console.WriteLine("Pop: " + s.Pop()); 
Console.WriteLine("Pop: " + s.Pop()); 
Console.WriteLine("Count: " + s.Count());  
Console.WriteLine();


// 2. 

MyList<int> myList = new MyList<int>();

myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Add(4);
myList.Add(5);  

Console.WriteLine("List Contains 2: " + myList.Contains(2));                 

Console.WriteLine("Element at index 1: " + myList.Find(1));                    

myList.InsertAt(6, 3);
Console.WriteLine("Element at index 3 " + myList.Find(6));     

myList.DeleteAt(1);
Console.WriteLine("Element at index 1 after deletion: " + myList.Find(1));      

myList.Remove(1);

Console.WriteLine("After removal:");

Console.WriteLine(myList.Find(1));



Console.WriteLine("Contains 2: " + myList.Find(2));

// Clear the list
myList.Clear();
Console.WriteLine("Count after clear: " + myList.Contains(2));
Console.WriteLine();




//3. 
var personRepo = new GenericRepository<Person>();

var person1 = new Person { Id = 1, Name = "Fex", Salary = 65000 };
var person2 = new Person { Id = 2, Name = "Lex", Salary = 60000 };
var person3 = new Person { Id = 3, Name = "Nex", Salary = 55000 };
var person4 = new Person { Id = 4, Name = "Bex", Salary = 50000 };

personRepo.Add(person1);
personRepo.Add(person2);
personRepo.Add(person3);
personRepo.Add(person4);
personRepo.Save();

var Persons = personRepo.GetAll();

foreach (var person in Persons)
{
    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Salary: {person.Salary}");
}
Console.WriteLine();
var personById = personRepo.GetById(1);
Console.WriteLine($"For ID 1 -- Name: {personById.Name}, Salary: {personById.Salary}");

personRepo.Remove(person1);
personRepo.Save();
Console.WriteLine();

Persons = personRepo.GetAll();
Console.WriteLine("after removing person1:");
foreach (var person in Persons)
{
    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Salary: {person.Salary}");
}