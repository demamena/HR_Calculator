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

namespace ExpCalc
{
	/// <summary>
	/// Логика взаимодействия для UserControlVacation.xaml
	/// </summary>
	public partial class UserControlVacation : System.Windows.Controls.UserControl
	{
		public UserControlVacation()
		{
			InitializeComponent();
		}

		private void Button_clear_Click(object sender, RoutedEventArgs e)
		{
			textBox_startDate.Text = string.Empty;
			textBox_endDate.Text = string.Empty;
			textBlock_daysCount.Text = "0";
		}

		private void Button_calculate_Click(object sender, RoutedEventArgs e)
		{
			CalcVacation();
		}

		private void CalcVacation()
		{
			try
			{
				int days = 30;
				if ((bool)radioButton_twentryFourDays.IsChecked)
					days = 24;
				textBlock_daysCount.Text = new VacationCalculator().CalculateVacation(days, textBox_startDate.Text, textBox_endDate.Text).ToString();
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show("Помилка! Неккоректно введені дані!\n" + ex.Message, "Помилка!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
			}
		}

		private void TextBox_startDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
		{
			new ExperienceCalculator().SelectCursorMaskedTextBox(textBox_startDate);
		}

		private void TextBox_endDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
		{
			new ExperienceCalculator().SelectCursorMaskedTextBox(textBox_endDate);
		}

		private void textBox_endDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
				CalcVacation();
		}

		private void textBox_startDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
				textBox_endDate.Focus();
		}
	}
}
