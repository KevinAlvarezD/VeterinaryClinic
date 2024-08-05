using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models;

public class Administrator
{
   
    public static void Menu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("================================================================================================");
            Console.WriteLine("                 Veterinary Center                                             ");
            Console.WriteLine ("================================================================================================");
            Console.WriteLine("Hola bienvenido a nuestra Veterinary Center");
            Console.WriteLine(" que deseas hacer el dia de hoy?, aca te mostrare las opciones de nuestro MENU!");
            Console.WriteLine("| 1. Presiona (1)  = Ver los animales registrados                |");
            Console.WriteLine("| 2. Presiona (2)  = Ver todos los pacientes registrados         |");
            Console.WriteLine("| 3. Presiona (3)  = Registrar un nuevo animal! :)               |");
            Console.WriteLine("| 4. Presiona (4)  = Eliminar un animal :(                       |");
            Console.WriteLine("| 5. Presiona (5)  = Castrar  un animal                          |");
            Console.WriteLine("| 6. Presiona (6)  = Mostrar Informacion                         |"); 
            Console.WriteLine("| 7. Presiona (7)  = Actualizar un animal                        |");
            Console.WriteLine("| 8. Presiona (8)  = Buscar Paciente por nombre                  |");  
            Console.WriteLine("| 9. Presiona (9)  = Ver Encabezado                              |");
            Console.WriteLine("| 10.Presiona (10) = Ver informacion de Pagina                   |");
            Console.WriteLine("| 11.Presiona (11) = Salir ====>                                 |");

            Console.WriteLine("================================================================================================");
            Console.Write("Ingrese una opcion: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: 
                VeterinaryClinic.ShowAnimals();
                Thread.Sleep(7000);                   
                    break;
                case 2:
                VeterinaryClinic.ShowAllPatients();
                Thread.Sleep(7000);
                    break;
                case 3:
                Console.WriteLine("¿Qué tipo de animal deseas registrar? (1) Perro / (2) Gato");
                int animalType = Convert.ToInt32(Console.ReadLine());
                switch(animalType){
                    case 1:
                        ManagerApp.CreateDog();
                        break;
                    case 2:
                        ManagerApp.CreateCat();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }    
                    break;
                case 4:
                Console.WriteLine("Que tipo de animal deseas eliminar (1) Perro / (2) Gato");
                int animalToDelete = Convert.ToInt32(Console.ReadLine());
                switch(animalToDelete){
                    case 1:
                        VeterinaryClinic.DeleteDog();
                        break;
                    case 2:
                        VeterinaryClinic.DeleteCat();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
                    break;
                case 5:
                Console.WriteLine("¿Qué tipo de animal deseas castrar? (1) Perro / (2) Gato");
                int animalToCastrate = Convert.ToInt32(Console.ReadLine());
                switch(animalToCastrate){
                    case 1:
                        /* Dog.CastrateAnimal(); */
                        break;
                    case 2:
                        /* Cat.CastrateAnimal(); */
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    }   
                     break;
                case 6:
                Console.WriteLine("¿Que tipo de animal deseas ver la información? (1) Perro / (2) Gato");
                int animalToShowInfo = Convert.ToInt32(Console.ReadLine());
                switch(animalToShowInfo){
                    case 1:
                         Dog.ShowInfo();
                        break;
                    case 2:
                         Cat.ShowInfo();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    }   
                     break;
                case 7:
                Console.WriteLine("¿Qué tipo de animal deseas actualizar? (1) Perro / (2) Gato");
                int animalToUpdate = Convert.ToInt32(Console.ReadLine());
                switch(animalToUpdate){
                    case 1:
                    VeterinaryClinic.UpdateDog();
                        break;
                    case 2:
                    VeterinaryClinic.UpdateCat();   
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    }   
                     break;
                case 8:
                VeterinaryClinic.ShowPatient();
                     break;  
                case 9:
                ManagerApp.ShowHeader(); 
                Thread.Sleep(4000);
                break;
                case 10:
                ManagerApp.ShowFooter(); 
                Thread.Sleep(4000);

                break;      
                case 11:
                     Console.WriteLine("Gracias por usar nuestro sistema. Adiós...");
                     Thread.Sleep(3000);
                     Environment.Exit(0);
                     break;
                default:
                 Console.WriteLine("Opcion invalida. Presione cualquier tecla para continuar...");
                 Console.ReadKey();
                 break;
            }
        }  
    }

}
