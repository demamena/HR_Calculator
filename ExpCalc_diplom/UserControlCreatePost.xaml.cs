using ExpCalc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HRCalculator
{
    /// <summary>
    /// Логика взаимодействия для UserControlCreatePost.xaml
    /// </summary>
    public partial class UserControlCreatePost : System.Windows.Controls.UserControl
    {
        public UserControlCreatePost()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox_department.ItemsSource = new ExperienceDataBase().SQL_SelectDepartmentNames();
        }

        private void button_addPost_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_post.Text.Trim() is null || comboBox_department.Text.Trim() is null)
            {
                System.Windows.MessageBox.Show("Заповніть усі поля!", "Помилка!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
                return;
            }
            new ExperienceDataBase().SQL_InsertPost(comboBox_department.Text.Split('|')[0], textBox_post.Text);
            System.Windows.MessageBox.Show("Посада успішно створена!", "Успіх!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Information);
        }
    }
}
