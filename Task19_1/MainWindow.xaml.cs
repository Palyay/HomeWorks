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

namespace Task19_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CheckBox_Checked(object sender, RoutedEventArgs e)
    {

    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        if (!MailingCheckBox.IsChecked??false)
        {
            MessageBox.Show("Оштбка: необходимо согласиться на обработку данных!", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        var SelectedСourse = СourseListBox.SelectedItems
            .Cast<ListBoxItem>()
            .Select(item => item.Content.ToString())
            .ToList();

        string message = $"Профиль сохранен!\n\n" +
                        $"Имя: {NameTextBox.Text}\n" +
                        $"Факультета: {FacultyComboBox.Text}\n" +
                        $"Форма обучения: {(FormaRadioButton1.IsChecked == true ? "Очная" : "Заочная")}\n" +
                        $"Выбранный курс: {string.Join(", ", SelectedСourse)}\n" +
                        $"Количество часов: {TimeSlider.Value}\n" +
                        $"Согласие на обработку данных: {(MailingCheckBox.IsChecked == true ? "Да" : "Нет")}";
        MessageBox.Show(message, "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}