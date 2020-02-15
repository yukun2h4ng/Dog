using System;
namespace Dog
{
  public enum Gender{Male, Female};
  class Dog
  {
    public string name, owner;
    public int age;
    public Gender gender;
    
    public Dog(string name1, string owner1, int age1, Gender gender1)
    {
      name = name1;
      owner = owner1;
      age = age1;
      gender = gender1;
    }
    
    public void Bark(int times)
    {
      for(int i = 0; i< times; i++)
      {
        Console.Write("Woof!");
      }
      Console.WriteLine();
    }
    public string GetTag()
    {
      string tag = "If lost, call "+owner+". ";
      if(gender == 0)
      {
        tag += "His name is " +name+ " he is " +age.ToString();
      }
      else
      {
        tag += "Her name is " +name+ " she is " +age.ToString();
      }
      if(age > 1)
      {
        tag += " years old.";
      }
      else
      {
        tag += " year old.";
      }
      return tag;
    }
  }
  class Test
  {
        static void Main(string[] args)
        {
        Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
        puppy.Bark(3); // output: Woof!Woof!Woof!
        Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

        Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
        myDog.Bark(1); // output: Woof!
        Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
        }
  }
  
}
