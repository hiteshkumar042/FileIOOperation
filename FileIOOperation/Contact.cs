using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    [Serializable]
    internal class Contact
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Age: {Age}";
        }
    }
}
