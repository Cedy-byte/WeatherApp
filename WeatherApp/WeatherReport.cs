using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherReport : Form
    {
        // variable created to stop values from dublicating in the list everytime a new forcast is added
        static bool firstLoad = true;

        public WeatherReport()
        {
            InitializeComponent();
        }

        // This method  has been used for creating objects and adding them to the list to serve as dummy data.
        public void readWeather()
        {
            if (firstLoad)
            {
                DateTime dateTime = new DateTime(2020, 06, 21, 00, 00, 00);
                DateTime dateTime1 = new DateTime(2020, 06, 22, 00, 00, 00);
                DateTime dateTime2 = new DateTime(2020, 06, 23, 00, 00, 00);
                DateTime dateTime3 = new DateTime(2020, 06, 24, 00, 00, 00);
                DateTime dateTime4 = new DateTime(2020, 06, 25, 00, 00, 00);
                DateTime dateTime5 = new DateTime(2020, 06, 26, 00, 00, 00);
                DateTime dateTime6 = new DateTime(2020, 06, 27, 00, 00, 00);

                Weather wd1 = new Weather("Pretoria", dateTime, 6, 19, 0, 46, 3);
                Weather wd2 = new Weather("Pretoria", dateTime1, 4, 19, 0, 31, 14);
                Weather wd3 = new Weather("Pretoria", dateTime2, 5, 19, 10, 40, 10);
                Weather wd4 = new Weather("Pretoria", dateTime3, 4, 20, 0, 30, 10);
                Weather wd5 = new Weather("Pretoria", dateTime4, 4, 18, 0, 40, 10);
                Weather wd6 = new Weather("Pretoria", dateTime5, 6, 19, 0, 40, 18);
                Weather wd7 = new Weather("Pretoria", dateTime6, 4, 18, 0, 31, 19);

                WeatherWorker.weathersList.Add(wd1);
                WeatherWorker.weathersList.Add(wd2);
                WeatherWorker.weathersList.Add(wd3);
                WeatherWorker.weathersList.Add(wd4);
                WeatherWorker.weathersList.Add(wd5);
                WeatherWorker.weathersList.Add(wd6);
                WeatherWorker.weathersList.Add(wd7);

                Weather w1 = new Weather("Durban", dateTime, 12, 26, 10, 76, 8);
                Weather w2 = new Weather("Durban", dateTime1, 10, 22, 10, 72, 16);
                Weather w3 = new Weather("Durban", dateTime2, 11, 23, 0, 62, 11);
                Weather w4 = new Weather("Durban", dateTime3, 9, 23, 0, 58, 14);
                Weather w5 = new Weather("Durban", dateTime4, 10, 24, 0, 53, 23);
                Weather w6 = new Weather("Durban", dateTime5, 10, 24, 0, 48, 8);
                Weather w7 = new Weather("Durban", dateTime6, 12, 22, 10, 65, 18);

                WeatherWorker.weathersList.Add(w1);
                WeatherWorker.weathersList.Add(w2);
                WeatherWorker.weathersList.Add(w3);
                WeatherWorker.weathersList.Add(w4);
                WeatherWorker.weathersList.Add(w5);
                WeatherWorker.weathersList.Add(w6);
                WeatherWorker.weathersList.Add(w7);

                Weather wf1 = new Weather("Cape Town", dateTime, 11, 16, 10, 89, 10);
                Weather wf2 = new Weather("Cape Town", dateTime1, 11, 17, 10, 86, 16);
                Weather wf3 = new Weather("Cape Town", dateTime2, 10, 17, 10, 84, 21);
                Weather wf4 = new Weather("Cape Town", dateTime3, 13, 19, 10, 69, 21);
                Weather wf5 = new Weather("Cape Town", dateTime4, 12, 17, 70, 83, 37);
                Weather wf6 = new Weather("Cape Town", dateTime5, 12, 15, 80, 71, 32);
                Weather wf7 = new Weather("Cape Town", dateTime6, 12, 16, 70, 81, 45);

                WeatherWorker.weathersList.Add(wf1);
                WeatherWorker.weathersList.Add(wf2);
                WeatherWorker.weathersList.Add(wf3);
                WeatherWorker.weathersList.Add(wf4);
                WeatherWorker.weathersList.Add(wf5);
                WeatherWorker.weathersList.Add(wf6);
                WeatherWorker.weathersList.Add(wf7);


            }
            firstLoad = false;

            dataGridView1.Rows.Clear();

            foreach (Weather item in WeatherWorker.weathersList)
            {

                if (!cmbCity.Items.Contains(item.City))
                {
                    cmbCity.Items.Add(item.City);
                }
                if (!cmbCity2.Items.Contains(item.City))
                {
                    cmbCity2.Items.Add(item.City);
                }
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            readWeather();
        }

        // This button takes the user to a form which will allow them to capture a weather forcast
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeatherCapture form = new WeatherCapture();
            form.ShowDialog();
            this.Close();
        }

        private void radOne_CheckedChanged(object sender, EventArgs e)
        {
            lblMultipleCities.Visible = false;
            cmbCity2.Visible = false;
            cmbCity2.ResetText();
            cmbCity2.Refresh();
        }

        private void radMultiple_CheckedChanged(object sender, EventArgs e)
        {
            lblMultipleCities.Visible = true;
            cmbCity2.Visible = true;
        }

        // This button is used to exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d;
            string msg = "Are you sure you want to Exit the Application ?";
            string title = "Weather Display";
            d = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // This button is used to reset the application to allow the user to enter new values
        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpFrom.ResetText();
            dtpTo.ResetText();
            radOneCity.Checked = false;
            radMultipleCities.Checked = false;
            cmbCity.ResetText();
            cmbCity2.ResetText();
            dataGridView1.Rows.Clear();
        }

        // This method is used to display the weather forcast to the user
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                if ((dtpFrom.Value == null || dtpTo.Value == null || cmbCity.SelectedItem == null && cmbCity2.SelectedItem == null))
                {
                    MessageBox.Show("Please Select a date Range and City");
                }
                else if ((dtpFrom.Value > dtpTo.Value))
                {
                    MessageBox.Show("Please Select a Valid Date Range");
                }
                else if ((dtpFrom.Value != null && dtpTo.Value != null && cmbCity.SelectedItem != null && cmbCity2.SelectedItem == null))
                {

                    WeatherWorker.filtered = WeatherWorker.weathersList.Where(w => w.City.Equals(cmbCity.SelectedItem.ToString()) &&
                    w.Date >= dtpFrom.Value && w.Date <= dtpTo.Value).OrderBy(wn => wn.Date).ToList();

                    foreach (Weather item in WeatherWorker.filtered)
                    {
                        dataGridView1.Rows.Add(item.City, item.Date, item.MinTemp, item.MaxTemp, item.Prec, item.Hum, item.Wind);
                    }

                }
                else if (dtpFrom.Value != null && dtpTo.Value != null && cmbCity2.SelectedItem != null && cmbCity.SelectedItem != null)
                {
                    WeatherWorker.filtered = WeatherWorker.weathersList.Where(w => w.City.Equals(cmbCity.SelectedItem.ToString()) &&
                    w.Date >= dtpFrom.Value && w.Date <= dtpTo.Value || w.City.Equals(cmbCity2.SelectedItem.ToString()) &&
                    w.Date >= dtpFrom.Value && w.Date <= dtpTo.Value).OrderBy(wn => wn.Date).ToList();

                    foreach (Weather item in WeatherWorker.filtered)
                    {
                        dataGridView1.Rows.Add(item.City, item.Date, item.MinTemp, item.MaxTemp, item.Prec, item.Hum, item.Wind);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            lowest();
            highest();
            displayHighAndLow();

        }

        // Method used to workout the lowest values between the cities
        private void lowest()
        {
            int minTemp = 0;
            int maxTemp = 0;
            int prec = 0;
            int hum = 0;
            int wind = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (i == 0)
                {
                    minTemp = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    maxTemp = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    prec = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    hum = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    wind = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }

                if (minTemp > int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                {
                    minTemp = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
                lblMinTempLow.Text = minTemp.ToString() + " °C";
                if (maxTemp > int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                {
                    maxTemp = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }
                lblMaxTempLow.Text = maxTemp.ToString() + " °C";
                if (prec > int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                {
                    prec = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                lblPrecLow.Text = prec.ToString() + " %";
                if (hum > int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()))
                {
                    hum = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                }
                lblHumLow.Text = hum.ToString() + " %";
                if (wind > int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                {
                    wind = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }
                lblWindLow.Text = wind.ToString() + " Km/h";
            }

        }

        // Method used to workout the Highest values between the cities
        private void highest()
        {
            int minTemp = 0;
            int maxTemp = 0;
            int prec = 0;
            int hum = 0;
            int wind = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (i == 0)
                {
                    minTemp = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    maxTemp = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    prec = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    hum = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    wind = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }

                if (minTemp < int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                {
                    minTemp = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
                lblHighMinTemp.Text = minTemp.ToString() + " °C";
                if (maxTemp < int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                {
                    maxTemp = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }
                lblHighMaxTemp.Text = maxTemp.ToString() + " °C";
                if (prec < int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                {
                    prec = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                lblHighPrecipitation.Text = prec.ToString() + " %";
                if (hum < int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()))
                {
                    hum = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                }
                lblHighHumidity.Text = hum.ToString() + " %";
                if (wind < int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                {
                    wind = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }
                lblHighWindSpeed.Text = wind.ToString() + " Km/h";
            }
        }

        // This method displays the highest and lowest values between the cities
        private void displayHighAndLow()
        {
            lblHighMinTemp.Visible = true;
            lblHighMaxTemp.Visible = true;
            lblHighPrecipitation.Visible = true;
            lblHighHumidity.Visible = true;
            lblHighWindSpeed.Visible = true;
            lblMinTempLow.Visible = true;
            lblMaxTempLow.Visible = true;
            lblPrecLow.Visible = true;
            lblHumLow.Visible = true;
            lblWindLow.Visible = true;
        }

    }
}
