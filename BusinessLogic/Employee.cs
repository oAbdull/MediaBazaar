﻿namespace BusinessLogic
{
    public class Employee : User
    {
        private int employee_id;
        private string firstName;
        private string lastName;
        private string email;
        private int phoneNumber;
        private int departmentId;
        //private SecurityLevel security_level;

        public Employee()
        {
            // no idea< Need to fix this
        }

        private List<Shift> shifts;


        public Employee(int employee_id, string firstName, string lastName, string email, int phoneNumber, string username, string password) : base(username, password)
        {
            this.employee_id = employee_id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            //this.security_level = security_level;

            shifts = new List<Shift>();
        }

        

        public int EmployeeId
        {
            get { return employee_id; }
            set { employee_id = value; }
        }
        public string Name
        {
            get { return firstName + " " + lastName; }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        /*public SecurityLevel SecurityLevel
        {
            get { return security_level; }
        }*/
        public List<Shift> Shifts
        {
            get { return shifts; }
        }
    }
}
