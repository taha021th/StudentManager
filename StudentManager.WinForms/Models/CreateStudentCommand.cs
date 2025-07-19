using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.WinForms.Models
{
    public class CreateStudentCommand
    {
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public System.DateTime BirthDate { get; set; }
    }
}
