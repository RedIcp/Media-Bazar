using CardReader;
using Sydesoft.NfcDevice;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace acr122_demo
{
    public partial class Checks : Form
    {
        string last = "";
        DateTime date;
        private static MyACR122U acr122u = new MyACR122U();
        Atendance at;
        bool check = false;

        public Checks()
        {
            InitializeComponent();

            try
            {
                acr122u.Init(false, 50, 4, 4, 200);  // NTAG213
                acr122u.CardInserted += Acr122u_CardInserted;
                acr122u.CardRemoved += Acr122u_CardRemoved;
                timer1.Start();
                timer1.Interval = 100;
            }
            catch
            {
                MessageBox.Show("Make sure to connect the card reader");
            }
            at = new Atendance();
            try
            {
                GetAtendanceIn();
            }
            catch
            {
                Close();
            }
        }

        //On close
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        // Card reader
        private static void Acr122u_CardInserted(PCSC.ICardReader reader)
        {
            try
            {
                acr122u.ReadId = BitConverter.ToString(acr122u.GetUID(reader)).Replace("-", "");
            }
            catch { }
        }
        private static void Acr122u_CardRemoved()
        { }

        public void GetAtendanceIn()
        {
            lbCheck.Items.Clear();
           
            at.getAllAtendanceOnCheckIn();
           
            foreach (Ckecks k in at.check)
            {
                lbCheck.Items.Add(k);
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (check && date.AddSeconds(5) < DateTime.Now)
                {
                    labChekced.Text = "Please hold your card against the scaner.";
                    labChekced.ForeColor = System.Drawing.Color.Black;
                    check = false;
                }

                if ((acr122u.ReadId != null && last != acr122u.ReadId && at.GetEmployeeID(acr122u.ReadId.ToString()) != 0) || (acr122u.ReadId != null && date.AddSeconds(5) < DateTime.Now && at.GetEmployeeID(acr122u.ReadId.ToString()) != 0))
                {
                    if (at.IsAlreadyCheckedIn(at.GetEmployeeID(acr122u.ReadId.ToString())) == false)
                    {
                        at.AddCheckIn(at.GetEmployeeID(acr122u.ReadId.ToString()));

                        last = acr122u.ReadId;
                        date = DateTime.Now;
                        acr122u.ReadId = null;

                        labChekced.Text = "You have checkedin!";
                        labChekced.ForeColor = System.Drawing.Color.Yellow;

                        check = true;

                        GetAtendanceIn();

                        return;
                    }
                    else if (at.IsAlreadyCheckedIn(at.GetEmployeeID(acr122u.ReadId.ToString())) == true)
                    {
                        at.EditCheckOutTime(at.GetEmployeeID(acr122u.ReadId.ToString()));

                        last = acr122u.ReadId;
                        date = DateTime.Now;
                        acr122u.ReadId = null;

                        labChekced.Text = "You have ckeckedout.";
                        labChekced.ForeColor = System.Drawing.Color.Green;

                        check = true;

                        GetAtendanceIn();

                        return;
                    }
                }
            }
            catch { }
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
        {

        }
    }
}
