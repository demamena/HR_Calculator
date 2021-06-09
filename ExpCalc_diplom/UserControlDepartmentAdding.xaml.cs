using ExpCalc;
using System;
using System.Collections.Generic;
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
	/// Логика взаимодействия для UserControlDepartmentAdding.xaml
	/// </summary>
	public partial class UserControlDepartmentAdding : System.Windows.Controls.UserControl
	{
		public UserControlDepartmentAdding()
		{
			InitializeComponent();
		}

		private void button_addOrder_Click(object sender, RoutedEventArgs e)
		{
			if(textBox_posts.Text.Trim() is null && textBox_workers.Text.Trim() is null)
			{
				System.Windows.MessageBox.Show("Заповніть усі поля!", "Помилка!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
				return;
			}
			System.Windows.MessageBox.Show("Відділ успішно додан!", "Успіх!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Information);
			new ExperienceDataBase().SQL_InsertDepartment(textBox_workers.Text, textBox_posts.Text);
		}
	}
}
