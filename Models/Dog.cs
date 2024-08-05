using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models;

public class Dog : Animal
{
    public bool BreedingStatus { get; set; }
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
