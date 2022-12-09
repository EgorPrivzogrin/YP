using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Employment
    {
        public int Id { get; set; }
        public int EploymentId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string Department { get; set; }

     

        public Employment()
        {
            Surname = "";
            Name = "";
            Patronymic = "";
            DateOfBirth = "";
            ContactNumber = "";
            Department = "";
        }
    }
}
