using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _494KazantsevAM_Variant_7
{
    public class OptimizationMethod
    {
        public int id { get; set; }
        private string name;
        private string active;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Active
        {
            get { return active; }
            set { active = value; }
        }
        public OptimizationMethod() { }
        public OptimizationMethod(string name, string active)
        {
            this.name = name;
            this.active = active;
        }
    }
}
