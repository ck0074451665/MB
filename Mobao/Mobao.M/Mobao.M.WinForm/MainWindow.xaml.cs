using Mobao.M.Interface;
using Mobao.M.Interface.Moudle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mobao.M.WinForm
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.ServiceModel.ChannelFactory<IService1> channel = new System.ServiceModel.ChannelFactory<IService1>
            ("serviceEndpoint");
            channel.Endpoint.EndpointBehaviors.Add(new EndpointBehavior());
          IService1 service=   channel.CreateChannel();
          MessageBox.Show(string.Format("{0}", service.GetData(6)));
        }   
    }
}
