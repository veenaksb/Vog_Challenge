using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Employees
    {
        private string firstname;
        private string lastname;
        private string jobtitle;
        private string address;
        private int departmentId;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string JobTitle
        {
            get { return jobtitle; }
            set { jobtitle = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
    }
}
