// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//input a string
Console.WriteLine("Enter a first name");
string fname = Console.ReadLine();
Console.WriteLine(fname);

//input an integer
Console.WriteLine("Enter an integer");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);

//input a floating point number
Console.WriteLine("Enter a decimal number");
double num2 = Convert.ToDouble(Console.ReadLine());

//input a line of strings
Console.WriteLine("Write a text line");
var names = Console.ReadLine().Split();
foreach (var name in names){
    Console.WriteLine(name);
}


Console.WriteLine("Enter a set of numbers in a line");
var nums = Console.ReadLine().Split();
var numbers = new List<int>();
foreach(var numstr in nums)
{
    int number;
    Int32.TryParse(numstr,out number);
    numbers.Add(number);
}

