

// Hacker sign program 
using System;
Console.WriteLine("Enter fav color? ");
string color = Console.ReadLine();
Console.WriteLine("Enter astrology sign? ");
string sign= Console.ReadLine();
Console.WriteLine("Stree address number");
string address = Console.ReadLine();

Console.WriteLine(color + sign + address);


// 1. Understanding types program 
Console.WriteLine("The size of sbyte " + sizeof(sbyte) + " with max value  " + sbyte.MaxValue + " and with min value " + sbyte.MinValue);
Console.WriteLine("The size of byte " + sizeof(byte) + " with max value  " + byte.MaxValue + " and with min value " + byte.MinValue);
Console.WriteLine("The size of short " + sizeof(short) + " with max value  " + short.MaxValue + " and with min value " + short.MinValue);
Console.WriteLine("The size of ushort " + sizeof(ushort) + " with max value  " + ushort.MaxValue + " and with min value " + ushort.MinValue);
Console.WriteLine("The size of int " + sizeof(int) + " with max value  " + int.MaxValue + " and with min value " + int.MinValue);
Console.WriteLine("The size of uint " + sizeof(uint) + " with max value  " + uint.MaxValue + " and with min value " + uint.MinValue);
Console.WriteLine("The size of long " + sizeof(long) + " with max value  " + long.MaxValue + " and with min value " + long.MinValue);
Console.WriteLine("The size of ulong " + sizeof(ulong) + " with max value  " + ulong.MaxValue + " and with min value " + ulong.MinValue);
Console.WriteLine("The size of float " + sizeof(float) + " with max value  " + float.MaxValue + " and with min value " + float.MinValue);
Console.WriteLine("The size of double " + sizeof(double) + " with max value  " + double.MaxValue + " and with min value " + double.MinValue);
Console.WriteLine("The size of decimal " + sizeof(decimal) + " with max value  " + decimal.MaxValue + " and with min value " + decimal.MinValue);



// 2. Program Integer to centuries to years, days, hourse, mins, seconds, milli, micro, nano 

using System.Numerics;

Console.WriteLine("Enter an Integer");
int n = Convert.ToInt32(Console.ReadLine());

int years = n * 100;
int Days =  (int)(years * 365.2425);
long hours = (long)Days * 24;
long minutes = hours * 60L;
long seconds = minutes * 60L;
long milliseconds = seconds * 1000L;
ulong microseconds = (ulong)milliseconds * 1000;
ulong nanoseconds = microseconds * 1000;

Console.WriteLine( n + " Centuries = " + years + " YEARS = " + Days + " Days = "+ hours + " Hours = "+ minutes + " Minutes = " + seconds + " Seconds = " + milliseconds + " Milliseconds = "+ microseconds + " Microseconds = "+ nanoseconds + " Nanoseconds");



/*
double a = -100.00D;
Console.WriteLine(a/0);
*/

//for (; true;) ;


//Loops and Operators 

// 1. FIZZBUZZ

for ( int i = 1; i<=100; i++)
{
    
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else { Console.WriteLine(i); };

}

/*


int max = 500;
for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}
*/


// guess random number 
Console.WriteLine("Guess the random number ( 1-3 ) ? ");

int correctNumber = new Random().Next(3) + 1;
while (true) 
{
    int guessedNumber = int.Parse(Console.ReadLine());
    if ( guessedNumber< 1 || guessedNumber > 3){
        Console.WriteLine("Number out of bonds");
    }

    if (correctNumber == guessedNumber)
    {
        Console.WriteLine("You guessed the correct number");
        break;
    }
    else if (correctNumber > guessedNumber)
    {
        Console.WriteLine("your guessnumber is lower to the correct number");
        
    }
    else if (correctNumber < guessedNumber)
    {
        Console.WriteLine("your guessnumber is higher than correcnt number");
        
    }
   
};




// 2. Print-a-Pyramid 

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5 - i; j++)
    {
        Console.Write(" ");
    }
    for (int h = 0; h < i + 1; h++)
    {
        Console.Write("* ");
    }
    Console.WriteLine(); 

}


//3. 
// SAME as Above Guess random Number 


//4. Numbner of days from birthday

DateTime bDate = new DateTime(2000, 01, 01);

DateTime currentDate = DateTime.Today;
int daysOld = (currentDate - bDate).Days;

Console.WriteLine($"The person is "+daysOld +" days old.");

int daysforNextAnniversary = 10000 - (daysOld % 10000);
DateTime nextAnniversary = currentDate.AddDays(daysforNextAnniversary);

Console.WriteLine($"The next 10,000-day anniversary is on: {nextAnniversary}");


//5. Greeting time of the day 

DateTime Time = DateTime.Now;
int Hour = Time.Hour;


if (Hour >= 5 && Hour < 12)
{
    Console.WriteLine("Good Morning");
}
if (Hour >= 12 && Hour < 17)
{
    Console.WriteLine("Good Afternoon");
}
if (Hour >= 17 && Hour < 20)
{
    Console.WriteLine("Good Evening");
}
if ((Hour >= 20 && Hour <= 23) || (Hour >= 0 && Hour < 5))
{
    Console.WriteLine("Good Night");
}



//6. Couting upto 24 

for (int i = 1; i <= 4; i++)
{
    for (int j = 0; j <= 24; j += i)
    {
        
        Console.Write(i);
        if (i + i > 24)
        {
            break;
        }
        Console.Write(",");
    }
    Console.WriteLine();
}
