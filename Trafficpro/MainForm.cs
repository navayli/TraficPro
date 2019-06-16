using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafficpro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void DriverInfoToForm(Driver driver)
        {
            lblDriverName.Text = driver.Name;
            lblDriverSurname.Text = driver.Surname;
            lblExpireDate.Text = driver.LicenseExpireDate.ToString();
            lblPenalty.Text = driver.PenaltyQuota.ToString();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int inputNumber = Convert.ToInt32(txbxDrNumİnput.Text);
            Driver driver = RadarDb.PenaltyDrivers.FindDriverByNumber(inputNumber);
            Session.Driver = driver;
            DriverInfoToForm(driver);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach(Driver driver in DbContext.Drivers.GetAll())
            {
                if(driver.Speed > 100)
                {
                    lxbxDriverNumber.Items.Add(driver.LicenseNumber.ToString());
                    RadarDb.PenaltyDrivers.Add(driver);
                }
            }
        }

        private void lnkProtocolForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ProtocolForm(this).ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
