using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Class
{
    public abstract class Transport
    {
        public string? Name { get; set; }
        abstract public void Show();
    }
}