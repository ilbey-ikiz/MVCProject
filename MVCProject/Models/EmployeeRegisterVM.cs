﻿using MVCProject.Entities.Enums;

namespace MVCProject.Models
{
    public class EmployeeRegisterVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int CompanyId { get; set; }
    }
}
