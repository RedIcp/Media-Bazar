using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
    class DepotDepartmentsManagment : IViewDepartments
    {
        public IDBViewAllDepartments DBViewAllDepartments;
        public DepotDepartmentsManagment(IDBViewAllDepartments DBViewAllDepartments)
        {
            this.DBViewAllDepartments = DBViewAllDepartments;
        }

        public List<Department> ViewAllDepartments()
        {
            return DBViewAllDepartments.ViewAllDepartments();
        }
    }
}
