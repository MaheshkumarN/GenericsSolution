using static System.Console;

using GenericsLibrary;
using System.Reflection;
using System.Runtime.CompilerServices;
using GenericsClientConApp;


#region Default Code
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#endregion


int num1 = 10, num2 = 20;
SwapTool swapTool = new SwapTool();
WriteLine($"Before Swap Num1: {num1} and Num2: {num2}");
swapTool.Swap(num1, num2);
WriteLine($"After Swap Num1: {num1} and Num2: {num2}");


WriteLine($"Ref Before Swap Num1: {num1} and Num2: {num2}");
swapTool.Swap(num1, num2);
WriteLine($"Ref After Swap Num1: {num1} and Num2: {num2}");

string firstName = "Peter", lastName = "Parker";
//WriteLine($"Ref Before Swap FirstName: {firstName} and LastName: {lastName}");
//swapTool.Swap(ref firstName, ref lastName);
//WriteLine($"Ref After Swap FirstName: {firstName} and LastName: {lastName}");

//Printer.PrintHeader($"Ref Before Swap FirstName: {firstName} and LastName: {lastName}");
//swapTool.Swap(ref firstName, ref lastName);
//WriteLine($"FirstName: {firstName} and LastName: {lastName}");
//Printer.PrintFooter();


