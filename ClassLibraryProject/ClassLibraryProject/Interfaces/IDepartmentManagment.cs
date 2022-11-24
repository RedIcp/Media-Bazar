using System.Data;

namespace ClassLibraryProject.Interfaces
{
   public interface IDepartmentManagment
    {
        //Get all departments
        public DataTable ViewAllDepartments();


        //Add a new department
        public void AddDepartment(string Name, string Head, string CompanyID);

        // edit a department
        public int EditDepartment(string Name, string Head, string DepartmetnID);

        //Delete
        public int DeleteDepartment(int departmentID);
    }
}
