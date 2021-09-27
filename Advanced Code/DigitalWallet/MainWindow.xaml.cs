using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Decimal enCaja = 0, SubTotal = 0, SubTotal2 = 0;
        Decimal B1000 = 0, B500 = 0, B200 = 0, B100 = 0, B50 = 0, B20 = 0;
        Decimal M20 = 0, M10 = 0, M5 = 0, M2 = 0, M1 = 0;
        double M5C = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Agregar_Click(object sender, RoutedEventArgs e)
        {
            SubTotal2 = Convert.ToDecimal(txt_Parcial.Text);
            enCaja = enCaja + SubTotal2;
            txt_Total.Text = Convert.ToString(enCaja);
            desmarcar();

        }

        private void Btn_Quitar_Click(object sender, RoutedEventArgs e)
        {
            SubTotal2 = Convert.ToDecimal(txt_Parcial.Text);
            enCaja = enCaja - SubTotal2;
            txt_Total.Text = Convert.ToString(enCaja);
            desmarcar();
        }

        private void Btn_Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void desmarcar()
        {
            cbb1000.IsChecked = false;
            cbb500.IsChecked = false;
            cbb200.IsChecked = false;
            cbb100.IsChecked = false;
            cbb50.IsChecked = false;
            cbb20.IsChecked = false;
            cbm20.IsChecked = false;
            cbm10.IsChecked = false;
            cbm5.IsChecked = false;
            cbm2.IsChecked = false;
            cbm1.IsChecked = false;
            cbm50C.IsChecked = false;
            txt_Parcial.Text = "";
            
        }
        private void SumaParcial()
        {
            SubTotal = B1000 * 1000 + B500 * 500 + B200 * 200 + B100 * 100 + B50 * 50 + B20 * 20 + M20 * 20 + M10 * 10 + M5 * 5 +
            M2 * 2 + M1 * 1;
            if (M5C == 1)
            {
                double SubTotal3 = (double)SubTotal;
                double cent = M5C/2;
                SubTotal3 = SubTotal3+cent;A
                txt_Parcial.Text = Convert.ToString(SubTotal3);
            }
            else {
                txt_Parcial.Text = Convert.ToString(SubTotal);
            }
        }

        private void Cbb1000_Checked(object sender, RoutedEventArgs e)
        {
            if (cbb1000.IsChecked == true)
            {
                B1000 = 1;
            }
            SumaParcial();
        }
        private void Cbb1000_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbb1000.IsChecked == false)
            {
                B1000 = 0;
            }
            SumaParcial();
        }

        private void Cbb500_Checked(object sender, RoutedEventArgs e)
        {
            if(cbb500.IsChecked == true)
            {
                B500 = 1;
            }
            SumaParcial();
        }

        private void Cbb500_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbb500.IsChecked == false)
            {
                B500 = 0;
            }
            SumaParcial();
        }

        private void Cbb200_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbb200.IsChecked == false)
            {
                B200 = 0;
            }
            SumaParcial();
        }

        private void Cbb200_Checked(object sender, RoutedEventArgs e)
        {
            if (cbb200.IsChecked == true)
            {
                B200 = 1;
            }
            SumaParcial();
        }

        private void Cbb100_Checked(object sender, RoutedEventArgs e)
        {
            if (cbb100.IsChecked == true)
            {
                B100 = 1;
            }
            SumaParcial();
        }

        private void Cbb100_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbb100.IsChecked == false)
            {
                B100 = 0;
            }
            SumaParcial();
        }

        private void Cbb50_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbb50.IsChecked == false)
            {
                B50 = 0;
            }
            SumaParcial();
        }

        private void Cbb50_Checked(object sender, RoutedEventArgs e)
        {
            if (cbb50.IsChecked == true)
            {
                B50 = 1;
            }
            SumaParcial();
        }

        private void Cbb20_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbb20.IsChecked == false)
            {
                B20 = 0;
            }
            SumaParcial();
        }
        private void Cbb20_Checked(object sender, RoutedEventArgs e)
        {
            if (cbb20.IsChecked == true)
            {
                B20 = 1;
            }
            SumaParcial();
        }

        private void Cbm20_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbm20.IsChecked == false)
            {
                M20 = 0;
            }
            SumaParcial();
        }

        private void Cbm20_Checked(object sender, RoutedEventArgs e)
        {
            if (cbm20.IsChecked == true)
            {
                M20 = 1;
            }
            SumaParcial();
        }

        private void Cbm10_Checked(object sender, RoutedEventArgs e)
        {
            if (cbm10.IsChecked == true)
            {
                M10 = 1;
            }
            SumaParcial();
        }

        private void Cbm10_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbm10.IsChecked == false)
            {
                M10 = 0;
            }
            SumaParcial();
        }

        private void Cbm5_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbm5.IsChecked == false)
            {
                M5 = 0;
            }
            SumaParcial();
        }

        private void Cbm5_Checked(object sender, RoutedEventArgs e)
        {
            if (cbm5.IsChecked == true)
            {
                M5 = 1;
            }
            SumaParcial();
        }

        private void Cbm2_Checked(object sender, RoutedEventArgs e)
        {
            if (cbm2.IsChecked == true)
            {
                M2 = 1;
            }
            SumaParcial();
        }

        private void Cbm2_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbm2.IsChecked == false)
            {
                M2 = 0;
            }
            SumaParcial();
        }

        private void Cbm1_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbm1.IsChecked == false)
            {
                M1 = 0;
            }
            SumaParcial();
        }

        private void Cbm1_Checked(object sender, RoutedEventArgs e)
        {
            if (cbm1.IsChecked == true)
            {
                M1 = 1;
            }
            SumaParcial();
        }

        private void Cbm50C_Checked(object sender, RoutedEventArgs e)
        {
            if (cbm50C.IsChecked == true)
            {
                M5C = 1;
            }
            SumaParcial();
        }

        private void Cbm50C_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cbm50C.IsChecked == false)
            {
                M5C = 0;
            }
            SumaParcial();
        }
    }
}
