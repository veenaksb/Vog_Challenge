using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Department
    {
        private string name;
        private string address;
        private List<Employees> empLst;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public List<Employees> LstEmployee
        {
            get { return empLst; }
            set { empLst = value; }
        }
    }
}
