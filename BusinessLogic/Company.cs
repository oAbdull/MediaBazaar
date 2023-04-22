using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace BusinessLogic
{
    public class Company
    {
        private UserService userService;
        private SectionService sectionService;
        /*
         * the security levels are still optional, just an idea that i thought of
         */
        //private List<SecurityLevel> securityLevels;
        private List<User> users;
        private int sectionId;
        private Section section = new Section("Sales");

        // Constructors
        public Company(IUserRepo userRepo, ISectionRepo sectionRepo)
        {
            // Create instances of the lists
            //securityLevels = new List<SecurityLevel>()
            //{
            //    new SecurityLevel("Admin", 0),
            //    new SecurityLevel("Low", 1),
            //    new SecurityLevel("Medium", 2),
            //    new SecurityLevel("High", 3)
            //};

            users = new List<User>();





            // repo is given in parameter so the whole class
            // library can be run with a different repo without it being hardcoded.
            // this comes in handy with unit testing so that the db is not needed for it.
            userService = new UserService(userRepo);
            sectionService = new SectionService(sectionRepo);

        }

        // Properties
        //public List<SecurityLevel> SecurityLevels // used to display securitylevels when admin is creating a user
        //{
        //    get { return securityLevels; }
        //}

        //private Section GetSectionOfId(int id)
        //{
        //    return sectionService.GetSectionOfId(id);
        //}
        //private Department GetDepartmentOfId(int id)
        //{
        //    return sectionService.GetDepartmentOfId(id);
        //}


        //public int GetLatestDepartmentId()
        //{
        //    return sectionService.GetLatestDepartmentId();
        //}
        //public int GetLatestEmployeeId()
        //{
        //    return sectionService.GetLatestEmployeeId();
        //}
        //public int GetLatestProductId()
        //{
        //    return sectionService.GetLatestProductId();
        //}
        //public int GetLatestShiftId()
        //{
        //    return GetLatestShiftId();
        //}


        ////---------EMPLOYEES---------------------------------------------------------------//

        //public string CreateEmployee(Employee employee)
        //{
        //    sectionService.CreateEmployee(section, employee);

        //    return "saved";
        //}

        //public string UpdateEmployee(Employee employee)
        //{
        //    //employee = sectionService.GetEmployees(GetSectionOfId(sectionId)).FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
        //    sectionService.UpdateEmployee(employee);

        //    return "saved";
        //}

        //public string DeleteEmployee(Employee employee)
        //{
        //    sectionService.DeleteEmployee(employee);

        //    return "saved";
        //}

        ////----------Shifts--------------------------------------------------------------------//

        //public string CreateShift(Shift shift)
        //{
        //    sectionService.CreateShift(section, shift);

        //    return "saved";
        //}

        //public string UpdateShift(Shift shift)
        //{
        //    shift = sectionService.GetShifts(section).FirstOrDefault(s => s.Id == shift.Id);
        //    sectionService.UpdateShift(shift);

        //    return "saved";
        //}

        //public string DeleteShift(Shift shift)
        //{
        //    sectionService.DeleteShift(shift);

        //    return "saved";
        //}


        ////----------Departments----------------------------------------------------------------------//


        //public void CreateDepartment(Department department)
        //{
        //    sectionService.CreateDepartment(section, department);
        //}

        //public void UpdateDepartment(Department department)
        //{
        //    department = sectionService.GetDepartments(section).FirstOrDefault(d => d.Id == department.Id);
        //    sectionService.UpdateDepartment(department);
        //}

        //public void DeleteDepartment(Department department)
        //{
        //    sectionService.DeleteDepartment(department);
        //}


        ////------Products-------------------------------------------------------------------------------//


        //public string CreateProduct(Product product)
        //{
        //    sectionService.CreateProduct(section, product);

        //    return "saved";
        //}

        //public string UpdateProduct(Product product)
        //{
        //    product = sectionService.GetProducts(section).FirstOrDefault(p => p.Id == product.Id);
        //    sectionService.UpdateProduct(product);

        //    return "saved";
        //}

        //public string DeleteProduct(Product product)
        //{
        //    sectionService.DeleteProduct(product);

        //    return "saved";
        //}


        ////--------Other--------------------------------------------------------------------------------//


        //public void SetSectionByName(string name) // used to load data from 'sales' section
        //{
        //    this.sectionId = sectionService.GetSectionIdByName(name);
        //}
        //public List<Section> GetSections()
        //{
        //    return sectionService.GetSections();
        //}
        //public List<Department> GetDepartments()
        //{
        //    return sectionService.GetDepartments(section);
        //}
        //public List<Employee> GetEmployees()
        //{
        //    return sectionService.GetEmployees(section);
        //}
        //public List<Employee> GetEmployees(int departmentId)
        //{
        //    return sectionService.GetEmployees(section, GetDepartmentOfId(departmentId));
        //}
        //public List<Product> GetProducts()
        //{
        //    return sectionService.GetProducts(section);
        //}
        //public List<Product> GetProducts(int departmentId)
        //{
        //    return sectionService.GetProducts(section, GetDepartmentOfId(departmentId));
        //}
        //public List<Shift> GetShifts()
        //{
        //    return sectionService.GetShifts(section);
        //}
        //public List<Shift> GetShifts(int departmentId)
        //{
        //    return sectionService.GetShifts(section, GetDepartmentOfId(departmentId));
        //}
    }
}
