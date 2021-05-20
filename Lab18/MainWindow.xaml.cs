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

namespace Lab18
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

        public void Calc_Click(object sender, RoutedEventArgs e)
        {
            if (Radio4.IsChecked.GetValueOrDefault()) 
            {
                double p = Convert.ToDouble(r1TextD.Text);
                double x = Convert.ToDouble(r2TextD.Text);
                double f = Convert.ToDouble(r3TextD.Text);
                double y = Convert.ToDouble(r4TextD.Text);
                double N = Convert.ToDouble(r7TextD.Text);
                double K = Convert.ToDouble(r8TextD.Text);
                double res = 0;
                for (int i =1; i < N; i++)
                {
                    for(int j = 1; j < K; j++)
                    {
                        res = res + ((Math.Pow(p, i - 1) * x + Math.Pow(f, j - 1) * Math.Pow(y, 2)) / i * j);
                    }
                }
                this.Title = "Ответ"
                    + res.ToString("F");
            }
        }

    }
}
