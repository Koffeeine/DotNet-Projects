using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Models
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int YearOfProduction { get; set; }
        public string Description { get; set; }

        public Movie(int id, string name, int length, int yearOfProduction, string description)
        {
            Id = id;
            Name = name;
            Length = length;
            YearOfProduction = yearOfProduction;
            Description = description;
        }
    }
}
