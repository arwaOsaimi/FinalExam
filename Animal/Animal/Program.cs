using System;
using System.Diagnostics.Contracts;

public class Animal{
    public string Name {get; set;}
    private int Health {get; set;}

    public static int TotalAnimals; 

    public Animal (string Name, int Health){
        this.Name= Name;
        this.Health= Health;
        TotalAnimals++;

    }

    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound!");
    }

     public virtual void TakeDamage(int damage){
        Health-=damage;
        Console.WriteLine("Name:"+ Name, "Health:" + Health);
    }

    public virtual int GetHealth(int Health){ 
    return Health;
    }
}

public class Dog : Animal{
    public bool HasLeash {get; set;}

    public Dog(string Name, int Health, bool HasLeash) : base(Name, Health)
    {
     Console.WriteLine(""+ HasLeash);
    }
 

    public override void MakeSound(){
    Console.WriteLine("The dog barks loudly!");

}

}

public class Cat : Animal
{
    public Cat(string Name, int Health) : base(Name, Health)
    {
    }
    public override void MakeSound(){
    Console.WriteLine("The cat meows softly!");
    }

    public override void TakeDamage(int damage){
       damage/=2; 
       base.TakeDamage(damage);
   }
}

 public class Bird : Animal{
    public bool InCage {get; set;}
    public Bird(string Name, int Health, bool InCage) : base(Name, Health)
    {
             Console.WriteLine(""+ InCage);

    }
public override void MakeSound(){
    Console.WriteLine("The bird chirps melodiously!");
    }
 }
public class Program{

public static void Main(string[] args){

Animal [] animal = new Animal[3];

animal[0]= new Dog("Dog",5,true);
animal[1]= new Cat("Cat",5);
animal[2]= new Bird("Dog",5,true);

foreach(var Animal in animal){
    Animal.MakeSound();
}
foreach(var Animal in animal){
    Animal.TakeDamage(5);
    Animal.TakeDamage(10);
    Animal.TakeDamage(20);
    Animal.GetHealth(8);

}

for(int i=0; i <animal.Length; i++ ){
    Console.WriteLine("Total animals created:" + Animal.TotalAnimals);

}
}

}