using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models;

public class Dog : Animal
{
    public   bool BreedingStatus { get; set; }
    public string Temperament { get; set; }
    public string MicrochipNumber { get; set; }
    public string BarkVolume { get; set; }
    public string CoatType { get; set; }

    // constructor
    public Dog(string name, DateOnly birthDate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType) : base(name, birthDate, breed, color, weightInKg)
    {
        BreedingStatus = breedingStatus;
        Temperament = temperament;
        MicrochipNumber = microchipNumber;
        BarkVolume = barkVolume;
        CoatType = coatType;
    }

    //metodos
    public override void ShowInformation()
    {
        Console.WriteLine($"Dog: {Name}, Birth Date: {BirthDate}, Breed: {Breed}, Color: {Color}, Weight: {WeightInKg}kg, Breeding Status: {BreedingStatus}, Temperament: {Temperament}, Microchip Number: {MicrochipNumber}, Bark Volume: {BarkVolume}, Coat Type: {CoatType}");
        
    }

    public  void CastrateAnimal(){
        if (BreedingStatus) 
        {

            Console.WriteLine($"{Name} is already castrated.");

        }
        else
        {
            Console.WriteLine($"{Name} is being castrated.");
            BreedingStatus = true;
        }
    }

    public  void HairDress(){
        //si el perro tiene el pelo short no se puede motilar
        if (CoatType == "Short")
        {
            Console.WriteLine($"{Name} has short coat, cannot be hair dressed.");
        }
        else
        {
            Console.WriteLine($"{Name} is being hair dressed.");
        }
    }

    //llamar la lista de dogs
    public static List<Dog> dogs = new List<Dog>{
        new Dog("Buddy", new DateOnly(2021, 2, 15), "Golden Retriever", "Golden", 3.5, false, "Intelligent", "1234567890", "High", "Short"),
        new Dog("Max", new DateOnly(2020, 8, 10), "Labrador Retriever", "White", 4.0, true, "Active", "9876543210", "Medium", "Medium"),
        new Dog("Rex", new DateOnly(2019, 12, 5), "Bulldog", "Brown", 2.8, false, "Calm", "0987654321", "Low", "Long")
    };
    public static void ShowInfo (){
        Console.WriteLine("Dogs:");
        foreach (var dog in dogs)
        {
            dog.ShowInformation();
        }
        Thread.Sleep(5000);
    }

}
