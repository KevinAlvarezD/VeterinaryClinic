using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models;

public class Cat: Animal
{
    public bool BreedingStatus { get; set; }
    public string FurLength { get; set; }

    // constructor
    public Cat(string name, DateOnly birthDate, string breed, string color, double weightInKg, bool breedingStatus, string furLength) : base(name, birthDate, breed, color, weightInKg)
    {
        BreedingStatus = breedingStatus;
        FurLength = furLength;
    }

    //metodos
    public override void ShowInformation()
    {
        Console.WriteLine($"Cat: {Name}, Birth Date: {BirthDate}, Breed: {Breed}, Color: {Color}, Weight: {WeightInKg}kg, Breeding Status: {BreedingStatus}, Fur Length: {FurLength}");
    }

    public void CastrateAnimal(){
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

    public void HairDress(){
        Console.WriteLine($"{Name} is being hair dressed.");
    }

    

}
