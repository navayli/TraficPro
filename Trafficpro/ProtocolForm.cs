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
    public partial class ProtocolForm : Form
    {
        private MainForm mainForm;

        public ProtocolForm()
        {
            InitializeComponent();
        }

        public ProtocolForm(MainForm mainForm) :this()
        {
            this.mainForm = mainForm;
        }

       
        private void btnDrawProtocol_Click(object sender, EventArgs e)
        {
            PenaltyBallType penaltyBallType = PenaltyBallType.Zero; 

            if ((Session.Driver.Speed - 100) > 10)
            {
                penaltyBallType = PenaltyBallType.One;
            }
            else if ((Session.Driver.Speed - 100) > 30)
            {
                penaltyBallType = PenaltyBallType.Three;
            }
            else if ((Session.Driver.Speed - 100) > 50)
            {
                penaltyBallType = PenaltyBallType.Four;
            }


            PenaltyData penaltyData = new PenaltyData();
            PenaltyAmountType penaltyAmountType = penaltyData.GetPenaltyAmount(penaltyBallType);
            lblPnAmaount.Text = ((int)penaltyAmountType).ToString();
            lblPenBall.Text = ((int)Session.Driver.PenaltyQuota).ToString();
            int sumPenalty = (int)penaltyBallType + (int)Session.Driver.PenaltyQuota;
            lblSumPnBall.Text = sumPenalty.ToString();
            lblSpeed.Text = Session.Driver.Speed.ToString();
            lblCrNumber.Text = Session.Driver.CarNumber;
            lblDriverName.Text = Session.Driver.Name + " " + Session.Driver.Surname;



            Protocol protocol = new Protocol();
            protocol.Number = GenerateHelper.GenerateProtocolNumber();
            dataGridView1.Rows.Add(protocol.Number, Session.Driver.LicenseNumber, Session.Driver.CarNumber);
            
           
        }
    }
}
