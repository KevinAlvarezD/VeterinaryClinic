using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models;

public abstract class Animal
{
    protected int Id { get; set; }
    protected string Name { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string Breed { get; set; }
    protected string Color { get; set; }
    protected double WeightInKg { get; set; }

    //constructor
    public Animal(string name, DateOnly birthDate, string breed, string color, double weightInKg)
    {
        Name = name;
        BirthDate = birthDate;
        Breed = breed;
        Color = color;
        WeightInKg = weightInKg;
    }

   //Metodo de get y set para usar atributos protected en otros archivos
    public int IdPublic()
    {
        return Id;
    }
    public string NamePublic()
    {
        return Name;
    }
    public DateOnly BirthDatePublic()
    {
        return BirthDate;
    }
    public string BreedPublic()
    {
        return Breed;
    }
    public string ColorPublic()
    {
        return Color;
    }
    public double WeightInKgPublic()
    {
        return WeightInKg;
    }
  
   


}
