// See https://aka.ms/new-console-template for more information
// Sample Input

using InterfaceimplementationcheckProject;

var verification = new Verification();

var result = verification.CheckIfConstructorExists("Void .ctor()");
Console.WriteLine(result); // Output: True

result = verification.CheckIfMethodExists("InterfaceMethod");
Console.WriteLine(result); // Output: True

result = verification.CheckIfInterfaceImplemented("InterfaceA");
Console.WriteLine(result); // Output: True
