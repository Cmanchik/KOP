using EmployeeBusinessLogic.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessLogic.BindingModel
{
    public class EmployeeBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Subdivision Subdivision { get; set; }
        public int Phone { get; set; }
    }
}
