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

namespace TuPromedio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n1 = double.Parse(txtn1.Text);
                double n2 = double.Parse(txtn2.Text);
                double n3 = double.Parse(txtn3.Text);
                double n4 = double.Parse(txtn4.Text);
                double n5 = double.Parse(txtn5.Text);
                double n6 = double.Parse(txtn6.Text);

                //double res = n1 + n2 + n3 + n4 + n5 + n6;
                //res = res / 6;
                //if (res > 0 )
                //{
                //    lblresultado.Content = string.Format("{0}", res);
                //}
                //else
                //{
                //    MessageBox.Show("Debe ser mayor a 0");    
                //}

                if (n1 >0 && n2>0 && n3>0 && n4>0 && n5>0 && n6>0)
                {
                    double res = n1 + n2 + n3 + n4 + n5 + n6;
                    res = res / 6;
                    lblresultado.Content = string.Format("{0}", res);
                }
                if (n1 > 0 && n2 > 0 && n3 > 0 && n4 > 0 && n5 > 0 && n6 == 0)
                {
                    double res = n1 + n2 + n3 + n4 + n5 ;
                    res = res / 5;
                    lblresultado.Content = string.Format("{0}", res);
                }
                if (n1 > 0 && n2 > 0 && n3 > 0 && n4 > 0 && n5 == 0 && n6 == 0)
                {
                    double res = n1 + n2 + n3 + n4 ;
                    res = res / 4;
                    lblresultado.Content = string.Format("{0}", res);
                }
                if (n1 > 0 && n2 > 0 && n3 > 0 && n4 == 0 && n5 == 0 && n6 == 0)
                {
                    double res = n1 + n2 + n3 ;
                    res = res / 3;
                    lblresultado.Content = string.Format("{0}", res);
                }
                if (n1 > 0 && n2 > 0 && n3 == 0 && n4 == 0 && n5 == 0 && n6 == 0)
                {
                    double res = n1 + n2 ;
                    res = res / 2;
                    lblresultado.Content = string.Format("{0}", res);
                }
                if (n1 > 0 && n2 == 0 && n3 == 0 && n4 == 0 && n5 == 0 && n6 == 0)
                {
                    double res = n1 ;
                    
                    lblresultado.Content = string.Format("{0}", res);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ingrese los valores correctamente",ex.Message);
            }
        }

        private void btnreset_Click(object sender, RoutedEventArgs e)
        {
            txtn1.Text = string.Format( "{0}",0);
            txtn2.Text = string.Format("{0}", 0);
            txtn3.Text = string.Format("{0}", 0);
            txtn4.Text = string.Format("{0}", 0);
            txtn5.Text = string.Format("{0}", 0);
            txtn6.Text = string.Format("{0}", 0);
        }
    }
}
