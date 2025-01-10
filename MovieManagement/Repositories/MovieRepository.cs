using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagement.Models;

namespace MovieManagement.Repositories
{
    internal class MovieRepository
    {
        private List<Movie> _data = [
            new Movie(0, "The Shawshank Redemption", 142, 1994, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie(1, "The Godfather", 175, 1972, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie(2, "Pulp Fiction", 154, 1994, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption."),
            new Movie(3, "The Lord of the Rings: The Return of the King", 201, 2003, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."),
            new Movie(4, "The Matrix", 136, 1999, "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence."),
    ];

        public void Add(Movie movie)
        {
            _data.Add(movie);
        }

        public List<Movie> GetAll()
        {
            return _data;
        }

        public Movie GetById(int id)
        {
            return _data.Find(m => m.Id == id);
        }

        public void Remove(int id)
        {
            var movie = GetById(id);
            if (movie != null)
            {
                _data.Remove(movie);
            }
        }
    }
}
