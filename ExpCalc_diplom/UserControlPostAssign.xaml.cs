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
	/// Логика взаимодействия для UserControlPostAssign.xaml
	/// </summary>
	public partial class UserControlPostAssign : System.Windows.Controls.UserControl
    {
		public UserControlPostAssign()
		{
			InitializeComponent();
		}

		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			
			comboBox_workers.ItemsSource = new ExperienceDataBase().SQL_SelectWorkersNames();
			comboBox_posts.ItemsSource = new ExperienceDataBase().SQL_SelectPostNames();
		}

		private void button_addOrder_Click(object sender, RoutedEventArgs e)
		{
			new ExperienceDataBase().SQL_InsertHeldPosts(Convert.ToInt32(comboBox_workers.Text.Split('.')[0]), Convert.ToInt32(comboBox_posts.Text.Split('.')[0]));
			System.Windows.MessageBox.Show("Посада успішно створена!", "Успіх!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Information);
		}
	}
}
