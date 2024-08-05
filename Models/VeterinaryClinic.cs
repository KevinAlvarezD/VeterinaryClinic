using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models;

public class VeterinaryClinic
{
    public string Name { get; set; }
    public string Address { get; set; }

    //constructor
    public VeterinaryClinic(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public List<Dog> Dogs { get; set; } = new List<Dog>{
        // initialize some sample dogs
        new Dog("Buddy",
        new DateOnly(2010, 5, 15), 
        "Golden Retriever",
        "Golden",
        3.5,
        false,
        "Active",
        "1234567890",
        "Medium",
        "Short"),
        new Dog("Max",
        new DateOnly(2005, 8, 20),
        "Labrador Retriever",
        "Black",
        4.2,
        true,
        "Playful",
        "9876543210",
        "Large",
        "Long"),
        new Dog("Luna",
        new DateOnly(2015, 3, 10),
        "Poodle",
        "White",
        1.8,
        false,
        "Calm",
        "0987654321",
        "Short",
        "Medium")
    };
    public List<Cat> Cats { get; set; } = new List<Cat>{
        // initialize some sample cats
        new Cat("Whiskers",
        new DateOnly(2012, 7, 10),
        "Siamese",
        "White",
        3.0,
        true,
        "Long"),
        new Cat("Misty",
        new DateOnly(2008, 12, 5),
        "Persian",
        "Black",
        2.5,
        false,
        "Short"),
        new Cat("Ruffles",
        new DateOnly(2018, 4, 25),
        "Maine Coon",
        "Brown",
        3.7,
        true,
        "Medium")
    };

}
