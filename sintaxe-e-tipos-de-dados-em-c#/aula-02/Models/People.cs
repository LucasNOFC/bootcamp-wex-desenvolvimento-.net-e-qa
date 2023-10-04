using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_02.Models
{
    public class People
    {
        public string? Name { get; set; }
        public int Years { get; set; }
        public void Apresentation()
        {
            Console.WriteLine($"My Name is {Name}, And i Have {Years} Years.");
        }
    }
}