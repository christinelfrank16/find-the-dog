using System;
using Game;
class Program
{
  static void Main()
  {
   Console.WriteLine("Which level you wanna play? Easy or Medium");
   string InputLevel = Console.ReadLine();
   Console.WriteLine("What's your name?");
   string name = Console.ReadLine();
   TextAdventure newGame = new TextAdventure(name, InputLevel, "");
   newGame.StartGame();
   newGame.DifficultylevelEasy();
  }
}