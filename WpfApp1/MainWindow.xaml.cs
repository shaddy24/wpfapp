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
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
        }


        DATABASE db = new DATABASE();
        INFO info = new INFO();
        OPR opr = new OPR();
        DataTable dt = new DataTable();

       

        public void disp()
        {
            dt = opr.selectQ();
            dgv1.ItemsSource = dt.DefaultView;
           
        }


        private void Form_Loaded(object sender, RoutedEventArgs e)
        {


     

        }

        private void Dgv1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Form1_Loaded(object sender, RoutedEventArgs e)
        {
            disp();
            MessageBox.Show("Hello Handsom ! Keep it Up!");
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            info.name1 = txtname.Text;
            info.email1 = txtemail.Text;
            info.gender1 = cmbgender.Text;
            info.bday1 = dtpbday.Text;
            info.phone1 =txtphone.Text;

                opr.inserQ(info);

            MessageBox.Show("Hello Handsom ! Saved!");
            disp();
        }
    }
}
