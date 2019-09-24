using System;
using System.Collections.Generic;

namespace Game {
class TextAdventure
{
  private string _name;
  private string _level;
  private string _items;
  private string _location;

 public TextAdventure(string name, string level, string items) {
  _name = name;
  _level = level;
  _items = items; 
  
  }
 public string Getlevel ()
 {
     return _level;
 }

 public void StartGame(){
     Console.WriteLine("Where are you? [city sidewalk, the mall, a bank]");
     string location = Console.ReadLine().ToLower();
     if(location.Contains("walk")){
         _location = "sidewalk";
     } else if (location.Contains("mall")){
         _location = "mall";
     } else if (location.Contains("bank")){
         _location = "bank";
     } else {
         _location = "unknown";
     }
 }
 public void DifficultylevelEasy() {
  if(_location == "sidewalk"){
     GenerateDogScenario(0);
     NextLocation(0);
     LostTheDog(0);
  }
 }
 public void Difficultylevelhard() {

 }


private void GenerateDogScenario(int pair){
    Dictionary<string,string[]> sidewalkScenarios = new Dictionary<string, string[]>();
    sidewalkScenarios.Add("You find yourself walking down a busy sidewalk, and hear a dog barking. What do you do?", new string[]{"Find the dog", "Keep walking"});
    sidewalkScenarios.Add("You step on a newspaper and pick it up. You see there is a large reward out for a missing dog... Perhaps the one you heard?? What do you do?", new string[]{"Go look for the dog", "Toss the newspaper and keep going"});
    
    int count = 0;
    foreach( KeyValuePair<string,string[]> scenario in sidewalkScenarios){
        if(count == pair){
            string[] options = scenario.Value;
            Console.WriteLine(scenario.Key + " ["+string.Join(",",options) + "]");
            string response = Console.ReadLine().ToLower();
            if(options[1].ToLower().Contains(response) && count < sidewalkScenarios.Count-1){
                GenerateDogScenario(count+1);
            } else {
                break;
            }
        }
        else {
            count++;
        }
    }
    
}
private void NextLocation(int pair){
    Dictionary<string,string[]> nextLocationScenarios = new Dictionary<string, string[]>();
    nextLocationScenarios.Add("You found a dog? At least you think it's a dog. What do you do?", new string[]{"Confirm with someone it is a dog", "Whatever it is looks really dirty; take it home and clean it up."});
    nextLocationScenarios.Add("You cleaned it up at home: it is a dog! But while you grabbed a snack the dog went somewhere else. What do you do?", new string[]{"Find it again", "Leave it and finish your snack"});
    nextLocationScenarios.Add("You find the dog digging in your yard. What do you do?", new string[]{"The dog obviously has excess energy; take him on a walk", "Get really angry at the dog"});
    nextLocationScenarios.Add("On the walk with the dog, someone comes up and claims it's their dog. What do you do?", new string[]{"Give the dog to them","Argue and try to keep the dog"});

    int count = 0;
    foreach( KeyValuePair<string,string[]> scenario in nextLocationScenarios){
        if(count == pair){
            string[] options = scenario.Value;
            Console.WriteLine(scenario.Key + " ["+string.Join(",",options) + "]");
            string response = Console.ReadLine().ToLower();
            if(options[1].ToLower().Contains(response)){
                GenerateDogScenario(count+1);
            } else {
                break;
            }
        }
        else {
            count++;
        }
    }
}

private void LostTheDog(int pair){
    Dictionary<string,string[]> lostDogScenarios = new Dictionary<string, string[]>();
    lostDogScenarios.Add("The dog made you think of Rover, your childhood dog. You miss him so you go to the mall. What do you do from there?", new string[]{"Go buy something really extravagent, the bill will keep Rover off your mind", "Buy some dog food to give to a shelter"});
    lostDogScenarios.Add("You walk by a restaurant and think you see someone you know. What do you do?", new string[]{"Go in and say hi!", "Keep going, it was probably someone else."});
    lostDogScenarios.Add("You are planning to go to the dog shelter but are standing in front of the bank. Do you:", new string[]{"Go inside and get some spare cash, just in case", "Keep going. The shelter might close soon."});

    int count = 0;
    foreach( KeyValuePair<string,string[]> scenario in lostDogScenarios){
        if(count == pair){
            string[] options = scenario.Value;
            Console.WriteLine(scenario.Key + " ["+string.Join(",",options) + "]");
            string response = Console.ReadLine().ToLower();
            if(options[1].ToLower().Contains(response)){
                GenerateDogScenario(count+1);
            } else {
                break;
            }
        }
        else {
            count++;
        }
    }

}
}
}