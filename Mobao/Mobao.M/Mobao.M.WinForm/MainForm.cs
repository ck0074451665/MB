using Mobao.M.Interface;
using Mobao.M.Interface.Moudle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
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
            MessageBox.Show(iPat.Test());
            MessageBox.Show("basc成功");
        }

        private void tcp_Click(object sender, EventArgs e)
        {
            System.ServiceModel.ChannelFactory<IPatient> chanel =
            new System.ServiceModel.ChannelFactory<IPatient>("tcpEndpoint");
            IPatient iPat = chanel.CreateChannel();
            List<PatientInfo> query = iPat.GetPatientInfo();
            dataGridView1.DataSource = query;
            MessageBox.Show("tcp成功");
        }

        private void wsHttp_Click(object sender, EventArgs e)
        {
            System.ServiceModel.ChannelFactory<IPatient> chanel =
           new System.ServiceModel.ChannelFactory<IPatient>("wsHttpEndpoint");
            IPatient iPat = chanel.CreateChannel();
            List<PatientInfo> query = iPat.GetPatientInfo();
            dataGridView1.DataSource = query;
            MessageBox.Show("wsHttp成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.ServiceModel.ChannelFactory<IPatient> chanel =
       new System.ServiceModel.ChannelFactory<IPatient>("webHttpEndpoint");
            IPatient iPat = chanel.CreateChannel();
            List<PatientInfo> query = iPat.GetPatientInfo();
            dataGridView1.DataSource = query;
            MessageBox.Show("webHttp成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.ServiceModel.ChannelFactory<IPatient> chanel =
     new System.ServiceModel.ChannelFactory<IPatient>("wsHttpBiding22");
            IPatient iPat = chanel.CreateChannel();
            List<PatientInfo> query = iPat.GetPatientInfo();
            dataGridView1.DataSource = query;
            MessageBox.Show("wsHttpBinding22成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.ServiceModel.ChannelFactory<IPatient3> chanel =
   new System.ServiceModel.ChannelFactory<IPatient3>("wsHttpBiding33");
            IPatient3 iPat = chanel.CreateChannel();
            List<PatientInfo> query = iPat.GetPatientInfo();
            dataGridView1.DataSource = query;
            MessageBox.Show("wsHttpBinding33成功");
        }
    }
}
