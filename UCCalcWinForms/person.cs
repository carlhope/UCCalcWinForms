using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCCalcWinForms
{
    public class person
    {
        public string name;
        public DateTime dateOfBirth;

        public person(string Name, DateTime Dob) {
            this.name = Name;
            this.dateOfBirth = Dob;
        
        }
    }
}
