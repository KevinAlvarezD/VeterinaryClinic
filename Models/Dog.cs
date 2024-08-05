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
}
