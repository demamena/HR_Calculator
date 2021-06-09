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

using Xceed.Wpf.Toolkit;

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
				System.Windows.MessageBox.Show("Помилка! Неккоректно введені дані!\n" + ex.Message, "Помилка!", MessageBoxButton.OK, (MessageBoxImage)System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		private void textBox_endDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
				CalcVacation();

			else if (e.Key == Key.Space || e.Key == Key.Escape)
				e.Handled = true;

			else if ((sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text[0] == '_')
				new ExperienceCalculator().SelectCursorMaskedTextBox(sender as Xceed.Wpf.Toolkit.MaskedTextBox);
		}

		private void textBox_startDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
				textBox_endDate.Focus();

			else if (e.Key == Key.Space || e.Key == Key.Escape)
				e.Handled = true;

			else if ((sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text[0] == '_') 
				new ExperienceCalculator().SelectCursorMaskedTextBox(sender as Xceed.Wpf.Toolkit.MaskedTextBox);
		}

		private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			new ExperienceCalculator().CheckDateCorrect(sender, e);
		}
    }
}

