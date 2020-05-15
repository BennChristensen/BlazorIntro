using BlazorApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public partial class Search
    {
        public List<Person> People { get; set; }
        public string SearchTerm { get; set; } = "";
        public List<Person> FilteredPeople
        {
            get
            {
                return People
                    .Where(p => p.Name
                        .ToLower()
                        .Contains(SearchTerm.ToLower()))
                        .ToList();
            }
        }

        public Search()
        {
            People = new List<Person>
            {
                new Person { Name="Markus Bertelsen" },
                new Person { Name="Kasper Dueholm Borg" },
                new Person { Name="Patrick Bruun" },
                new Person { Name="Nicolai Bergstrøm Christensen" },
                new Person { Name="Oliver Alexander Christensen" },
                new Person { Name="Asger Boye Dinesen" },
                new Person { Name="Loke Lindblad Ebdrup" },
            };
        }
    }
}
