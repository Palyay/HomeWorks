using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task17_2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (Top.Fill == Brushes.Red)
        {
            Top.Fill = Brushes.Gray;
            Center.Fill = Brushes.Yellow;
            Bottom.Fill = Brushes.Gray;
        }
        else
        {
            if (Center.Fill == Brushes.Yellow)
            {
                Top.Fill = Brushes.Gray;
                Center.Fill = Brushes.Gray;
                Bottom.Fill = Brushes.Green;
            }
            else
            {
                if (Bottom.Fill == Brushes.Green)
                {
                    Top.Fill = Brushes.Red;
                    Center.Fill = Brushes.Gray;
                    Bottom.Fill = Brushes.Gray;
                }
            }
        }       
    }
}
