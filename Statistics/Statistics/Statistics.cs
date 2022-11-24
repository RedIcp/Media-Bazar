using Statistics.ProductData;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Statistics
{
    public partial class Statistics : Form
    {
        Atendance a;
        int Zoom1, Zoom2, Zoom3, Zoom4, Zoom5;
        public Statistics()
        {
            InitializeComponent();
            a = new Atendance();

            labYear.Text = DateTime.Now.Year.ToString();
            labMonth.Text = DateTime.Now.Month.ToString();

            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            Zoom1 = 0;
            Zoom2 = 0;
            Zoom3 = 0;
            Zoom4 = 0;
            Zoom5 = 0;

            chart1.MouseWheel += chart1_MouseWheel;

            CRestockAmount.MouseWheel += CRestockAmount_MouseWheel;
            CRestockRequest.MouseWheel += CRestockRequest_MouseWheel;

            CReshelfAmount.MouseWheel += CReshelfAmount_MouseWheel;
            CReshelfRequest.MouseWheel += CReshelfRequest_MouseWheel;

            ShowData();
            ShowRestockAmountData();
            ShowRestockRequestData();
            ShowReshelfAmountData();
            ShowReshelfRequestData();
        }

        //Zoom
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;

            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;

            int IntervalX = 4;
            try
            {
                if (e.Delta < 0 && Zoom1 > 0) // Scrolled down.
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX * 2 / Math.Pow(2, Zoom1);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX * 2 / Math.Pow(2, Zoom1);

                    if (posXStart < 0) posXStart = 0;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    Zoom1--;
                }
                else if (e.Delta < 0 && Zoom1 == 0) //Last scrolled dowm
                {
                    xAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, Zoom1);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, Zoom1);

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    Zoom1++;
                }

                if (Zoom1 < 0) Zoom1 = 0;
            }
            catch { }
        }
        private void CRestockAmount_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;

            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;

            int IntervalX = 4;
            try
            {
                if (e.Delta < 0 && Zoom2 > 0) // Scrolled down.
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX * 2 / Math.Pow(2, Zoom2);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX * 2 / Math.Pow(2, Zoom2);

                    if (posXStart < 0) posXStart = 0;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    Zoom2--;
                }
                else if (e.Delta < 0 && Zoom2 == 0) //Last scrolled dowm
                {
                    xAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, Zoom2);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, Zoom2);

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    Zoom2++;
                }

                if (Zoom2 < 0) Zoom2 = 0;
            }
            catch { }
        }
        private void CRestockRequest_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;

            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;

            int IntervalX = 4;
            try
            {
                if (e.Delta < 0 && Zoom3 > 0) // Scrolled down.
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX * 2 / Math.Pow(2, Zoom3);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX * 2 / Math.Pow(2, Zoom3);

                    if (posXStart < 0) posXStart = 0;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    Zoom3--;
                }
                else if (e.Delta < 0 && Zoom3 == 0) //Last scrolled dowm
                {
                    xAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, Zoom3);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, Zoom3);

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    Zoom3++;
                }

                if (Zoom3 < 0) Zoom3 = 0;
            }
            catch { }
        }
        private void CReshelfAmount_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;

            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;

            int IntervalX = 4;
            try
            {
                if (e.Delta < 0 && Zoom4 > 0) // Scrolled down.
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX * 2 / Math.Pow(2, Zoom4);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX * 2 / Math.Pow(2, Zoom4);

                    if (posXStart < 0) posXStart = 0;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    Zoom4--;
                }
                else if (e.Delta < 0 && Zoom4 == 0) //Last scrolled dowm
                {
                    xAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, Zoom4);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, Zoom4);

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    Zoom4++;
                }

                if (Zoom4 < 0) Zoom4 = 0;
            }
            catch { }
        }
        private void CReshelfRequest_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;

            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;

            int IntervalX = 4;
            try
            {
                if (e.Delta < 0 && Zoom5 > 0) // Scrolled down.
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX * 2 / Math.Pow(2, Zoom5);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX * 2 / Math.Pow(2, Zoom5);

                    if (posXStart < 0) posXStart = 0;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    Zoom5--;
                }
                else if (e.Delta < 0 && Zoom5 == 0) //Last scrolled dowm
                {
                    xAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, Zoom5);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, Zoom5);

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    Zoom5++;
                }

                if (Zoom5 < 0) Zoom5 = 0;
            }
            catch { }
        }

        //Close
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }

        // connect to database
        public void GetAtendeance()
        {
            int year = 0, month = 0;
            try
            {
                year = Convert.ToInt32(labYear.Text);
                month = Convert.ToInt32(labMonth.Text);
            }
            catch { }
            a.GetAtendanceData(year, month);
        }

        // chose year and month
        private void btnIncreaseYear_Click(object sender, EventArgs e)
        {
            int year = 0;
            try
            { year = Convert.ToInt16(labYear.Text); }
            catch { }
            year++;
            labYear.Text = year.ToString();
            ShowData();
        }
        private void btnDecreaseYear_Click(object sender, EventArgs e)
        {
            int year = 0;
            try
            { year = Convert.ToInt16(labYear.Text); }
            catch { }
            year--;
            labYear.Text = year.ToString();
            ShowData();
        }
        private void btnIncreaseMonth_Click(object sender, EventArgs e)
        {
            int month = 0;
            try { month = Convert.ToInt16(labMonth.Text); }
            catch { }

            if (month == 12)
            {
                month = 1;
                labMonth.Text = month.ToString();
            }
            else
            {
                month++;
                labMonth.Text = month.ToString();
            }
            ShowData();
        }
        private void btnDecreaseMonth_Click(object sender, EventArgs e)
        {
            int month = 0;
            try
            {
                month = Convert.ToInt16(labMonth.Text);
            }
            catch { }

            if (month == 1)
            {
                month = 12;
                labMonth.Text = month.ToString();
            }
            else
            {
                month--;
                labMonth.Text = month.ToString();
            }
            ShowData();
        }

        // show data
        public void ShowData()
        {
            GetAtendeance();

            this.chart1.Series["TimeWorked"].Points.Clear();
            this.chart1.Series["WorkHours"].Points.Clear();

            foreach (EmployeeWorkTime ee in a.emp)
            {
                try
                {
                    this.chart1.Series["TimeWorked"].Points.AddXY(ee.EmployeeName, Convert.ToInt32(ee.Timeworked.TotalHours));
                    this.chart1.Series["WorkHours"].Points.AddXY(ee.EmployeeName, ee.WorkHours * 4);
                }
                catch { }
            }
        }
        public void ShowRestockAmountData()
        {
            RestockData rd = new RestockData();

            this.CRestockAmount.Series["Amount"].Points.Clear();

            foreach (ProductsData ee in rd.RestockAmount())
            {
                this.CRestockAmount.Series["Amount"].Points.AddXY(ee.ProductName, ee.Amount);
            }
        }
        public void ShowRestockRequestData()
        {
            RestockData rd = new RestockData();

            this.CRestockRequest.Series["Amount"].Points.Clear();

            foreach (ProductsData ee in rd.RestockProductAmount())
            {
                this.CRestockRequest.Series["Amount"].Points.AddXY(ee.ProductName, ee.Amount);
            }
        }
        public void ShowReshelfAmountData()
        {
            ReshelfData rd = new ReshelfData();

            this.CReshelfAmount.Series["Amount"].Points.Clear();

            foreach (ProductsData ee in rd.ReshelfAmount())
            {
                this.CReshelfAmount.Series["Amount"].Points.AddXY(ee.ProductName, ee.Amount);
            }
        }
        public void ShowReshelfRequestData()
        {
            ReshelfData rd = new ReshelfData();

            this.CReshelfRequest.Series["Amount"].Points.Clear();

            foreach (ProductsData ee in rd.ReshelfProductAmount())
            {
                this.CReshelfRequest.Series["Amount"].Points.AddXY(ee.ProductName, ee.Amount);
            }
        }
    }
}
