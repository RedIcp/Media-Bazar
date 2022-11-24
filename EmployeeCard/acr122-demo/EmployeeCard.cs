using acr122_demo;
using acr122_demo.Class;
using Sydesoft.NfcDevice;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CardReader
{
    public partial class EmployeeCard : Form
    {
        private static MyACR122U acr122u;
        DBPersonManager personManager;

        public EmployeeCard()
        {
            InitializeComponent();
            acr122u = new MyACR122U();
            personManager = new DBPersonManager();

            try
            {
                acr122u.Init(false, 50, 4, 4, 200);  // NTAG213
                acr122u.CardInserted += Acr122u_CardInserted;
                acr122u.CardRemoved += Acr122u_CardRemoved;
            }
            catch
            {
                MessageBox.Show("Make sure to connect the card reader");
            }

            ViewAllEmployees(tbSearch.Text);

            timer1.Start();
        }

        //Close page
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        // CardReader
        private void Acr122u_CardInserted(PCSC.ICardReader reader)
        {
            try
            {
                acr122u.ReadId = BitConverter.ToString(acr122u.GetUID(reader)).Replace("-", "");
            }
            catch { }
        }
        private static void Acr122u_CardRemoved()
        { }

        //Update cart number
        private void btnConnectCardAndEmployee_Click(object sender, EventArgs e)
        {
            string ID = tbEmployeeID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show(" 'Select a employee' field is required.");
                return;
            }

            string CardNumber = tbCardNumber.Text;
            if (string.IsNullOrEmpty(CardNumber))
            {
                MessageBox.Show("Put a card that is not already in use against the card reader.");
                return;
            }
            personManager.changeID(ID, CardNumber);

            tbEmployeeID.Text = "";
            tbEmployeeName.Text = "";
            tbCardNumber.Text = "";
            tbPhoneNumber.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbDateOfBirth.Text = "";
            tbBSN.Text = "";

            ViewAllEmployees(tbSearch.Text);
        }

        //Select employee
        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployee.SelectedItem is Person)
            {
                try
                {
                    Person Person = (Person)lbEmployee.SelectedItem;

                    tbEmployeeID.Text = Person.EmployeeID.ToString();
                    tbEmployeeName.Text = Person.LastName + " " + Person.FirstName;
                    tbCardNumber.Text = Person.CardNumber.ToString();
                    tbPhoneNumber.Text = Person.PhoneNumber.ToString();
                    tbEmail.Text = Person.Email;
                    tbAddress.Text = Person.City.ToString();
                    tbDateOfBirth.Text = Person.DateOfBirth.ToString();
                    tbBSN.Text = Person.BSN.ToString();
                }
                catch { MessageBox.Show("Error!"); }
            }
        }

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (acr122u.ReadId != null && personManager.GetEmployeeID(acr122u.ReadId.ToString()) != 0)
                {
                    ViewAllEmployees(tbSearch.Text);
                    acr122u.ReadId = null;
                }
                else if (acr122u.ReadId != null)
                {
                    tbCardNumber.Text = acr122u.ReadId.ToString();
                    acr122u.ReadId = null;
                }
            }
            catch 
            { }
        }


        //View employees
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ViewAllEmployees(tbSearch.Text);
        }
        public void ViewAllEmployees(string search)
        {
            lbEmployee.Items.Clear();
            foreach (Person p in personManager.ViewAllEmployees(search))
            {
                lbEmployee.Items.Add(p);
            }
        }
    }

    internal class MyACR122U : ACR122U
    {
        private string readId;
        public string ReadId
        {
            get { return readId; }
            set { readId = value; }
        }
        public MyACR122U()
        { }
    }
}
