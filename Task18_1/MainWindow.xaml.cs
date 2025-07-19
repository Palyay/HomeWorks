using Microsoft.Win32;
using System.IO;
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

namespace Task18_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
        if (result == MessageBoxResult.No)
        {
            e.Cancel = true;
        }
    }

    private void Open_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Текстовый файл (.txt)|*.txt|Все файлы (*.*)|*.*";
        if (openFileDialog.ShowDialog() == true)
        {
            textBox1.Text = File.ReadAllText(openFileDialog.FileName);
            Statustext.Text = $"Отрыт файл: {openFileDialog.FileName}";
        }
    }

    private void Save_Click(object sender, RoutedEventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Текстовый файл (.txt)|*.txt|Все файлы (*.*)|*.*";
        if (saveFileDialog.ShowDialog() == true)
        {
            File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
            Statustext.Text = "Файл сохранён";
        }
    }

    private void Info_Click(object sender, RoutedEventArgs e)
    {
        NewWindow newWindow = new NewWindow();
        newWindow.WindowStyle = WindowStyle.ToolWindow;
        newWindow.ShowDialog();
    }

}