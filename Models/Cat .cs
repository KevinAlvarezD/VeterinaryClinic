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

    

}
