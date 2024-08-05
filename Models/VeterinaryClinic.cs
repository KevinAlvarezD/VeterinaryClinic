using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models;
public class VeterinaryClinic
{
    public  string Name { get; set; }
    public string Address { get; set; }

    //constructor
    public  VeterinaryClinic(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public static List<Dog> Dogs { get; set; } = new List<Dog>{
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
    public static List<Cat> Cats { get; set; } = new List<Cat>{
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
    //metodos 
    public void SaveDog(Dog newDog){
        Dogs.Add(newDog);
    }

    public void SaveCat(Cat newCat){
        Cats.Add(newCat);
    }

    public static void UpdateDog(){
        Console.WriteLine("Cual es el nombre de tu perro");
        string newName = Console.ReadLine();
        Console.WriteLine("Que campo deseas actualizar?");
        string fieldToUpdate = Console.ReadLine();
        Dog dog = Dogs.FirstOrDefault(d => d.NamePublic() == newName);
        switch (fieldToUpdate)
        {
            case "Name":
                dog.UpdateName(newName); 
                break;
            case "BirthDate":
                Console.WriteLine("Ingrese la nueva fecha de nacimiento (YYYY-MM-DD):");
                string newBirthDateString = Console.ReadLine();
                dog.UpdateBirthDate(DateOnly.Parse(newBirthDateString));
                break;
            case "Breed":
                Console.WriteLine("Ingrese la nueva raza:");
                dog.UpdateBreed(Console.ReadLine());
                break;
            case "Color":
                Console.WriteLine("Ingrese el nuevo color:");
                dog.UpdateColor(Console.ReadLine());
                break;
            case "WeightInKg":
                Console.WriteLine("Ingrese el nuevo peso (en kg):");
                dog.UpdateWeightInKg(double.Parse(Console.ReadLine())) ;
                break;
            case "BreedingStatus":
                Console.WriteLine("Ingrese el nuevo estado de castración (true/false):");
                dog.BreedingStatus = bool.Parse(Console.ReadLine());
            break;
            case "Temperament":
                Console.WriteLine("Ingrese el nuevo temperamento:");
                dog.Temperament = Console.ReadLine();
            break;
            case "MicrochipNumber":
                Console.WriteLine("Ingrese el nuevo número del microchip:");
                dog.MicrochipNumber = Console.ReadLine();
            break;
            case "BarkVolume":
                Console.WriteLine("Ingrese el nuevo volumen del ruido de ladrido:");
                dog.BarkVolume = Console.ReadLine();
            break;
            case "CoatType":
                Console.WriteLine("Ingrese el nuevo tipo de pelo:");
                dog.CoatType = Console.ReadLine();
            break;
            default: 
            Console.WriteLine("El campo ingresado no es válido");
            break;  
        }

        Console.WriteLine($"El perro {dog.NamePublic} ha sido actualizado con éxito");
    }

    public static void UpdateCat(){
        Console.WriteLine("Cual es el nombre de tu gato");
        string newName = Console.ReadLine();
        Console.WriteLine("Que campo deseas actualizar?");
        string fieldToUpdate = Console.ReadLine();
        Cat cat = Cats.FirstOrDefault(c => c.NamePublic() == newName);
        switch (fieldToUpdate)
        {
            case "Name":
                cat.UpdateName(newName); 
                break;
            case "BirthDate":
                Console.WriteLine("Ingrese la nueva fecha de nacimiento (YYYY-MM-DD):");
                string newBirthDateString = Console.ReadLine();
                cat.UpdateBirthDate(DateOnly.Parse(newBirthDateString));
                break;
            case "Breed":
                Console.WriteLine("Ingrese la nueva raza:");
                cat.UpdateBreed(Console.ReadLine());
                break;
            case "Color":
                Console.WriteLine("Ingrese el nuevo color:");
                cat.UpdateColor(Console.ReadLine());
                break;
            case "WeightInKg":
            Console.WriteLine("Ingrese el nuevo peso (en kg):");
            cat.UpdateWeightInKg(double.Parse(Console.ReadLine())) ;
            break;
            case "BreedingStatus":
            Console.WriteLine("Ingrese el nuevo estado de castración (true/false):");
            cat.BreedingStatus = bool.Parse(Console.ReadLine());
            break;
            case "FurLength":
            Console.WriteLine("Ingrese el nuevo tamaño del pelaje:");
            cat.FurLength = Console.ReadLine();
            break;
            default:
            Console.WriteLine("El campo ingresado no es válido");
            break;

        }    
                
    }

    public static void DeleteDog(){
        Console.WriteLine("Ingrese el nombre del perro a eliminar");
        string dogName = Console.ReadLine();
        Dog dogToRemove = Dogs.FirstOrDefault(d => d.NamePublic() == dogName);
        Console.WriteLine($"¿Estás seguro de eliminar el perro {dogToRemove.NamePublic()}?");
        string confirmation = Console.ReadLine();
        if(confirmation.ToLower() == "si"){
            Dogs.Remove(dogToRemove);
        } else {
            Console.WriteLine("El perro no ha sido eliminado");
        }
        Console.WriteLine($"El perro {dogToRemove.NamePublic()} ha sido eliminado con éxito");
    }

    public static void DeleteCat(){
        Console.WriteLine("Ingrese el nombre del gato a eliminar");
        string catName = Console.ReadLine();
        Cat catToRemove = Cats.FirstOrDefault(c => c.NamePublic() == catName);
        Console.WriteLine($"¿Estás seguro de eliminar el gato {catToRemove.NamePublic()}?");
        string confirmation = Console.ReadLine();
        if(confirmation.ToLower() == "si"){
            Cats.Remove(catToRemove);
        } else {
            Console.WriteLine("El gato no ha sido eliminado");
        }
        Console.WriteLine($"El gato {catToRemove.NamePublic()} ha sido eliminado con éxito");
    }

    public static void ShowAllPatients() {
        foreach (var dog in Dogs)
        {
            Console.WriteLine(dog.NamePublic());
        }
        foreach (var cat in Cats)
        {
            Console.WriteLine(cat.NamePublic());
        }
        
   
    }

    public static void ShowAnimals(){
        Console.WriteLine("Perros:");
        foreach (var dog in Dogs)
        {
            Console.WriteLine(dog.NamePublic());
            Console.WriteLine("====================================");
        }
        Console.WriteLine("Gatos:");
        foreach (var cat in Cats)
        {
            Console.WriteLine(cat.NamePublic());
            Console.WriteLine("====================================");
        }
    }

    public static void ShowPatient(){
        Console.WriteLine("Cual es el nombre del perro o gato?");
        string animalName = Console.ReadLine();
        Dog dogToShow = Dogs.FirstOrDefault(d => d.NamePublic() == animalName);
        Cat catToShow = Cats.FirstOrDefault(c => c.NamePublic() == animalName);
        if(dogToShow!= null){
            Console.WriteLine($"Nombre: {dogToShow.NamePublic()}");
            Console.WriteLine($"Fecha de nacimiento: {dogToShow.BirthDatePublic().ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Raza: {dogToShow.BreedPublic()}");
            Console.WriteLine($"Color: {dogToShow.ColorPublic}");
            Console.WriteLine($"Peso: {dogToShow.WeightInKgPublic} kg");
            Console.WriteLine($"Castración: {dogToShow.BreedingStatus}");
            Console.WriteLine($"Temperamento: {dogToShow.Temperament}");
            Console.WriteLine($"Microchip: {dogToShow.MicrochipNumber}");
            Console.WriteLine($"Volumen de ruido de ladrido: {dogToShow.BarkVolume}");
            Console.WriteLine($"Tipo de pelo: {dogToShow.CoatType}");
        }
        else if(catToShow!= null){
            Console.WriteLine($"Nombre: {catToShow.NamePublic()}");
            Console.WriteLine($"Fecha de nacimiento: {catToShow.BirthDatePublic().ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Raza: {catToShow.BreedPublic()}");
            Console.WriteLine($"Color: {catToShow.ColorPublic}");
            Console.WriteLine($"Peso: {catToShow.WeightInKgPublic} kg");
            Console.WriteLine($"Castración: {catToShow.BreedingStatus}");
            Console.WriteLine($"Tamaño del pelaje: {catToShow.FurLength}");
        }
    }

}
