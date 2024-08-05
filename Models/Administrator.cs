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
            Console.WriteLine("===============================================");
            Console.WriteLine("                 Veterinary Center              ");
            Console.WriteLine("===============================================");
            Console.WriteLine("| 1.Mostrar todos los animales                 |");
            Console.WriteLine("| 2.                        |");
            Console.WriteLine("| 3.       |");
            Console.WriteLine("| 4.                       |");
            Console.WriteLine("| 5.                      |");
            Console.WriteLine("| 6.                |"); 
            Console.WriteLine("| 7.                    |");
            Console.WriteLine("| 8. |");
            Console.WriteLine("| 9.   |");
            Console.WriteLine("| 10.                      |");    
            Console.WriteLine("| 10.                                    |");
            Console.WriteLine("================================================");
            Console.Write("Ingrese una opcion: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: 
                VeterinaryClinic.ShowAnimals();
                                     
                    break;
                case 2:
               
                    break;
                case 3:
                
                    break;
                case 4:
                
                    break;
                case 5:
                
                     break;
                case 6:
                
                     break;
                case 7:
                
                     break;
                case 8:
                
                     break;  
                case 9:
                
                break;
                case 10:
                
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
