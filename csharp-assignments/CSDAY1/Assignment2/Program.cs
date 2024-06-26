// 2. GroceryList program  

List<String> listItem = new List<String>();

while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    String input = Console.ReadLine().Trim();

    if (input.StartsWith("+ "))
    {
        String addList = input.Substring(1);
        listItem.Add(addList);
    }
    else if (input.StartsWith("-"))
    {
        String removeList = input.Substring(1);
        listItem.Remove(removeList);
    }
    else if (input == "--")
    {
        listItem.Clear();

    }
    else { Console.WriteLine("invalid input"); }

    Console.WriteLine("List Items: ");

    foreach (string str in listItem)
    {
        Console.WriteLine(str);
    }

}




//3rd Prime numbers in given range

int[] FindPrimesInRange(int startNum, int endNum)
{
    List <int> primes = new List <int>();

    for (int i = startNum; i<=endNum; i++)
    {
        if (isPrime(i))
        {
            primes.Add(i);
        }
    }
    return primes.ToArray();
}

bool isPrime(int num)
{ if (num <= 1)
        return false;
for (int i=2; i<= num/2; i++)
        if(num%i == 0)
            return false;

    return true;
}

int[] arr = FindPrimesInRange(2, 50);
foreach (int i in arr)
{
    Console.WriteLine(i);
}




// 4. Roate array 

Console.WriteLine("Enter array of integers:");
string[] input = Console.ReadLine().Split();
int[] array = new int[input.Length];
for (int i = 0; i < input.Length; i++)
{
    array[i] = int.Parse(input[i]);
}
Console.WriteLine("Enter number of rotations:");
int k = int.Parse(Console.ReadLine());

// Sum 
int[] sum = new int[array.Length];

// Performing rotations 
for (int r = 1; r <= k; r++)
{
    int[] rotatedArray = RotateRight(array, r);

    for (int i = 0; i < array.Length; i++)
    {
        sum[i] += rotatedArray[i];
    }

    Console.WriteLine(r+ "Times Rotated :"+ rotatedArray);
}

Console.WriteLine($"Sum array: " + sum);

//rotating right 
int[] RotateRight(int[] array, int r)
{
    int n = array.Length;
    int[] rotated = new int[n];

    for (int i = 0; i < n; i++)
    {
        rotated[(i + r) % n] = array[i];
    }

    return rotated;
}


//5 Longest sequence of eual elemts in arry of integers 

Console.WriteLine("Enter the array of integers (space separated):");
string[] input = Console.ReadLine().Split(' ');
int[] array = Array.ConvertAll(input, int.Parse);

int currentLength = 1;
int maxLength = 1;
int startIndex = 0;
int bestStartIndex = 0;

// Find the longest sequence of equal elements
for (int i = 1; i < array.Length; i++)
{
    if (array[i] == array[i - 1])
    {
        currentLength++;
    }
    else
    {
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            bestStartIndex = startIndex;
        }
        // Reset for new sequence
        startIndex = i;
        currentLength = 1;
    }
}

// Check the last sequence
if (currentLength > maxLength)
{
    maxLength = currentLength;
    bestStartIndex = startIndex;
}

Console.Write("Longest sequence of equal elements: ");
for (int i = bestStartIndex; i < bestStartIndex + maxLength; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();


//7. Most Frequent number in given sequence 

using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Enter the array of integers (space separated):");
string[] input = Console.ReadLine().Split(' ');
int[] array = Array.ConvertAll(input, int.Parse);

int mostFrequent = array[0];
int maxCount = 1;

for (int i = 0; i < array.Length; i++)
{
    int currentCount = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] == array[i])
        {
            currentCount++;
        }
    }

    if (currentCount > maxCount)
    {
        maxCount = currentCount;
        mostFrequent = array[i];
    }
}

Console.WriteLine("Most frequent number in the array is " + mostFrequent);



// Strings
//1. Read string and points back 

string str = Console.ReadLine();

for (int i = str.Length - 1; i >= 0; i--)
{
    Console.Write(str[i]);
}
Console.WriteLine();


//2. Reverses words in given sequence 

string str = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/";
string result = String.Join(" ", str.Split('.', ' ').Reverse());
Console.WriteLine(result);



//3. Extracts given text from all palindromes 

using System.Text.RegularExpressions;
string str = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";

// Using regex pattern to match words
string pattern = @"\b\p{L}+\b";
MatchCollection matches = Regex.Matches(str, pattern);


HashSet<string> palindromes = new HashSet<string>();

foreach (Match match in matches)
{
   string word = match.Value;
   if (IsPalindrome(word))
   {
      palindromes.Add(word);
   }
}

// Printing sorted list of palindromes
Console.WriteLine(string.Join(", ", palindromes.OrderBy(p => p, StringComparer.OrdinalIgnoreCase).ThenBy(p => p, StringComparer.Ordinal)));

// palindrome function definition
bool IsPalindrome(string word)
{
   int length = word.Length;
   for (int i = 0; i < length / 2; i++)
   {
      if (word[i] != word[length - i - 1])
      {
         return false;
      }
   }
   return true;
}


// 4. Parse URL in the format 

var uri = new Uri("ftp://www.example.com/employee");

Console.WriteLine($"[protocol] = \"{uri.Scheme }\"");
Console.WriteLine($"[server] = \"{uri.Host}\"");
Console.WriteLine($"[resource] = \"{uri.AbsolutePath.TrimStart('/')}\"");

