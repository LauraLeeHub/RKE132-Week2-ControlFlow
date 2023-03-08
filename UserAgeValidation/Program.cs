// See https://aka.ms/new-console-template for more information

//rakendus kusib kasutajal sisestada tema vanus
//kui kasutaja vanus on vaiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to instagram"

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Enter your age");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

if(userAge >= 13) 
{
    Console.WriteLine("Welcome to instagram!");
}
else //if (userAge <13)
{
    Console.WriteLine("You are too young to use instagram.");
}
