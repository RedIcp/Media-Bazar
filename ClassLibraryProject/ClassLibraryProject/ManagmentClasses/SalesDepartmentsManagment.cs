using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
    public class SalesDepartmentsManagment : IViewDepartments
    {
        public IDBViewAllDepartments DBViewAllDepartments;
        public SalesDepartmentsManagment(IDBViewAllDepartments DBViewAllDepartments)
        {
            this.DBViewAllDepartments = DBViewAllDepartments;
        }

        public List<Department> ViewAllDepartments()
        {
            return DBViewAllDepartments.ViewAllDepartments();
        }
    }
}
