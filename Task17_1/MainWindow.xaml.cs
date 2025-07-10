using System.Reflection;
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

namespace Task17_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    double result = 0;
   
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Button button = (Button)sender;
        if (button != null)
        {
            result = result + 1;            
        }
        ResultText.Text = $"{result}";
    }
}