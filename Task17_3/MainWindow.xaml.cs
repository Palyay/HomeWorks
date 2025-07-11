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

namespace Task17_3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button_MouseEnter(object sender, MouseEventArgs e)
    {       
        Random random = new Random();
        double currentLeft = random.Next(0, 750);
        double currentRight = random.Next(0, 430);
        button.Margin = new Thickness(currentLeft, currentRight, 0, 0);
    }
}