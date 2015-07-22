using Mobao.M.Interface;
using Mobao.M.Interface.Moudle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mobao.M.Winform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.ServiceModel.ChannelFactory<IPatient> chanel =
                new System.ServiceModel.ChannelFactory<IPatient>("bascEndpoint");
            IPatient iPat = chanel.CreateChannel();
            List<PatientInfo> query = iPat.GetPatientInfo();
            dataGridView1.DataSource = query;
        }
    }
}
