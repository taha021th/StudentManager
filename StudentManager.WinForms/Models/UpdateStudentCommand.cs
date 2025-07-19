using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.WinForms.Models
{
    public class UpdateStudentCommand
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public System.DateTime BirthDate { get; set; }
    }
}
