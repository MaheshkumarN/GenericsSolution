using static System.Console;

using GenericsLibrary;
using System.Reflection;
using System.Runtime.CompilerServices;
using GenericsClientConApp;


#region Default Code
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#endregion


#region SwapTool
//int num1 = 10, num2 = 20;
//SwapTool swapTool = new SwapTool();
//WriteLine($"Before Swap Num1: {num1} and Num2: {num2}");
//swapTool.Swap(num1, num2);
//WriteLine($"After Swap Num1: {num1} and Num2: {num2}");


//WriteLine($"Ref Before Swap Num1: {num1} and Num2: {num2}");
//swapTool.Swap(num1, num2);
//WriteLine($"Ref After Swap Num1: {num1} and Num2: {num2}");

//string firstName = "Peter", lastName = "Parker";
//WriteLine($"Ref Before Swap FirstName: {firstName} and LastName: {lastName}");
//swapTool.Swap(ref firstName, ref lastName);
//WriteLine($"Ref After Swap FirstName: {firstName} and LastName: {lastName}");

//Printer.PrintHeader($"Ref Before Swap FirstName: {firstName} and LastName: {lastName}");
//swapTool.Swap(ref firstName, ref lastName);
//WriteLine($"FirstName: {firstName} and LastName: {lastName}");
//Printer.PrintFooter();


//Printer.Print($"FirstName: {firstName} and LastName: {lastName}", "Before Swap");
//swapTool.Swap(ref firstName, ref lastName);
//Printer.Print($"FirstName: {firstName} and LastName: {lastName}", "After Swap"); 
#endregion

#region With GenArray<int>
//GenArray<int> genArray = new GenArray<int>();
//genArray.Add(10);
//genArray.Add(2);

//Printer.Print($"{genArray[1]}", "genArray[1]");
////Printer.Print($"{genArray[2]}", "genArray[2]");
//genArray.Add(7);
//genArray.Add(9);

//Printer.PrintHeader("Loop through the Array");
//for (int i = 0; i < genArray.Length; i++)
//{
//  WriteLine($"genArray[{i}] = {genArray[i]}");
//}
//Printer.PrintFooter();

//genArray.Sort();
//Printer.PrintHeader("After Sort");
//for (int i = 0; i < genArray.Length; i++)
//{
//  WriteLine($"genArray[{i}] = {genArray[i]}");
//}
//Printer.PrintFooter();

#endregion


#region GenArray<string>
//GenArray<string> genArray = new GenArray<string>();
//genArray.Add("Tintin");
//genArray.Add("Mickey");

//Printer.Print($"{genArray[1]}", "genArray[1]");
////Printer.Print($"{genArray[2]}", "genArray[2]");
//genArray.Add("Jerry");
//genArray.Add("Phantom");

//Printer.PrintHeader("Loop through the Array");
//for (int i = 0; i < genArray.Length; i++)
//{
//	WriteLine($"genArray[{i}] = {genArray[i]}");
//}
//Printer.PrintFooter();

//genArray.Sort();
//Printer.PrintHeader("After Sort");
//for (int i = 0; i < genArray.Length; i++)
//{
//  WriteLine($"genArray[{i}] = {genArray[i]}");
//}
//Printer.PrintFooter();
#endregion

#region GenArray<Person>
GenArray<Person> genArray = new GenArray<Person>();
genArray.Add(new Person(10, "Tintin"));
genArray.Add(new Person(7, "Mickey"));

Printer.Print($"{genArray[1]}", "genArray[1]");
//Printer.Print($"{genArray[2]}", "genArray[2]");
genArray.Add(new Person(3, "Jerry"));
genArray.Add(new Person(8, "Phantom"));

Printer.PrintHeader("Loop through the Array");
for (int i = 0; i < genArray.Length; i++)
{
  WriteLine($"genArray[{i}] = {genArray[i]}");
}
Printer.PrintFooter();

genArray.Sort();
Printer.PrintHeader("After Sort");
for (int i = 0; i < genArray.Length; i++)
{
  WriteLine($"genArray[{i}] = {genArray[i]}");
}
Printer.PrintFooter();


#endregion


