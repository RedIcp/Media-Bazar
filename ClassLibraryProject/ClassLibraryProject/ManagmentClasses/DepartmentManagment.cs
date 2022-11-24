using ClassLibraryProject.Interfaces;
using System.Data;

namespace ClassLibraryProject.ManagmentClasses
{
    public class DepartmentManagment: IDepartment
    {
        IDepartmentManagment iDepartmentManagment;

        public DepartmentManagment(IDepartmentManagment departmentManagment)
        { 
            iDepartmentManagment = departmentManagment;
        }

        //Get all departments
        public DataTable ViewAllDepartments()
        {
            return iDepartmentManagment.ViewAllDepartments();
        }

        //Add a new department
        public void AddDepartment(string Name, string Head, string CompanyID)
        {
            iDepartmentManagment.AddDepartment(Name, Head, CompanyID);
        }

        // edit a department
        public int EditDepartment(string Name, string Head, string DepartmetnID)
        {
           return iDepartmentManagment.EditDepartment(Name, Head, DepartmetnID);
        }

        public int DeleteDepartment(int departmentID)
        {
            return iDepartmentManagment.DeleteDepartment(departmentID);
        }
    }
}
