using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models;

public class ManagerApp
{
    //Esta clase va a crear un nuevo dog y un nuevo cat
    public void CreateDog(){
        //pedir al usuario la informacion
        Console.WriteLine("Ingrese el nombre del perro:");
        string name = Console.ReadLine();
        Console.WriteLine("Ingrese la fecha de nacimiento del perro (YYYY-MM-DD):");
        string birthDateString = Console.ReadLine();
        DateOnly birthDate = DateOnly.Parse(birthDateString);
        Console.WriteLine("Ingrese el raza del perro:");
        string breed = Console.ReadLine();
        Console.WriteLine("Ingrese el color del perro:");
        string color = Console.ReadLine();
        Console.WriteLine("Ingrese el peso del perro (en kg):");
        double weightInKg = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese si el perro es castrado o no (true/false):");
        bool breedingStatus = bool.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el temperamento del perro (Active/Playful/Calm):");
        string temperament = Console.ReadLine();
        Console.WriteLine("Ingrese el numero del microchip del perro:");
        string microchipNumber = Console.ReadLine();
        Console.WriteLine("Ingrese el volumen del pelaje del perro (Short/Medium/Long):");
        string furLength = Console.ReadLine();
        Console.WriteLine("Ingrese el tipo de pelo del perro (Short/Medium/Long):");
        string coatType = Console.ReadLine();

        //crear el perro con la informacion del usuario
        Dog newDog = new Dog(name, birthDate, breed, color, weightInKg, breedingStatus, temperament, microchipNumber, coatType, furLength);
        //agregar el perro a la clinica
        VeterinaryClinic clinic = new VeterinaryClinic("Clinica Veterinaria XYZ", "Calle 123, Colonia YZ, CP 12345");
        clinic.SaveDog(newDog);   
    }
    public void CreateCat(){
        //pedir al usuario la informacion
        Console.WriteLine("Ingrese el nombre del gato:");
        string name = Console.ReadLine();
        Console.WriteLine("Ingrese la fecha de nacimiento del gato (YYYY-MM-DD):");
        string birthDateString = Console.ReadLine();
        DateOnly birthDate = DateOnly.Parse(birthDateString);
        Console.WriteLine("Ingrese el raza del gato:");
        string breed = Console.ReadLine();
        Console.WriteLine("Ingrese el color del gato:");
        string color = Console.ReadLine();
        Console.WriteLine("Ingrese el peso del gato (en kg):");
        double weightInKg = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese si el gato es castrado o no (true/false):");
        bool breedingStatus = bool.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tamaño del pelaje del gato (Short/Medium/Long):");
        string furLength = Console.ReadLine();
        //crear el gato con la informacion del usuario
        Cat newCat = new Cat(name, birthDate, breed, color, weightInKg, breedingStatus, furLength);
        //agregar el gato a la clinica
        VeterinaryClinic clinic = new VeterinaryClinic("Clinica Veterinaria XYZ", "Calle 123, Colonia YZ, CP 12345");
        clinic.SaveCat(newCat);
       
    }

}
