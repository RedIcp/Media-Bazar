namespace ClassLibraryProject.Class
{
    public class Department
    {
        //fields
        private string departmentID;
        private string head;
        private string name;

        //properties
        public string DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; }
        }
        public string Head
        {
            get { return head; }
            set { head = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //constructor
        public Department(string DepartmentID, string Head, string Name)
        {
            departmentID = DepartmentID;
            head = Head;
            name = Name;
        }


        //methods
        public override string ToString()
        {
            return name;
        }
    }
}
