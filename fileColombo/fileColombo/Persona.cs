using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileColombo
{
    public class Persona
    {
        private string id;
        private string surname;
        private string name;

        public Persona(string id, string surname, string name)
        {
            Id = id;
            Surname = surname;
            Name = name;
        }

        public string Id { get; protected set; }
        public string Surname { get => surname; protected set => surname = value; }
        public string Name { get => name; protected set => name = value; }
    }   
}
