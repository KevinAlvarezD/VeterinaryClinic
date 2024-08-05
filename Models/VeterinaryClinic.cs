using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryCenter.Models;

public class VeterinaryClinic
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Dog> Dogs { get; set; } = new List<Dog>();
    /* public List<Cat> Cats { get; set; } = new List<Cat>(); */

}
