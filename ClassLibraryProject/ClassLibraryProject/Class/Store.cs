using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses;

namespace ClassLibraryProject.Class
{
    public class Store
    {
        public ProductManagement productManagment;
        public EmployeeManagement employeeManagement;

        public EmailManager emailManager;
        public BackUpManagment backUpManagment;

        public Store()
        {
            productManagment = new ProductManagement();

            employeeManagement = new EmployeeManagement();

            emailManager = new EmailManager();
            backUpManagment = new BackUpManagment();
        }
    }
}
