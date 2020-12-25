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
using Xceed.Wpf.Toolkit.Obselete;

namespace HRCalculator
{
	/// <summary>
	/// Логика взаимодействия для UserControlRankAfterDecree.xaml
	/// </summary>
	public partial class UserControlRankAfterDecree : System.Windows.Controls.UserControl
	{
		public UserControlRankAfterDecree()
		{
			InitializeComponent();
		}

		private void Button_calculate_Click(object sender, RoutedEventArgs e)
		{
			CalcExpirience();
		}

		private void CalcExpirience()
		{
			try
			{
				string[] calculations = new DecreeRank().CalculateRanksAndDates(textBox_startDate.Text, textBox_endDate.Text, textBox_currentDate.Text);
				textBlock_periodOnRank.Text = calculations[0];
				textBlock_periodToNextRank.Text = calculations[1];
				textBlock_dateOfNextRank.Text = calculations[2];
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show("Помилка! Неккоректно введені дані!\n" + ex.Message, "Помилка!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
			}
		}

        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
			ClearAllFields();
        }

		private void ClearAllFields()
        {
			textBox_startDate.Text = "";
			textBox_endDate.Text = "";
			textBox_currentDate.Text = "";
			textBlock_dateOfNextRank.Text = "";
			textBlock_periodOnRank.Text = "";
			textBlock_periodToNextRank.Text = "";
		}

		private void TextBox_startDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
		{
			new ExperienceCalculator().SelectCursorMaskedTextBox(textBox_startDate);
		}

		private void TextBox_endDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
		{
			new ExperienceCalculator().SelectCursorMaskedTextBox(textBox_endDate);
		}

		private void TextBox_currentDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
		{
			new ExperienceCalculator().SelectCursorMaskedTextBox(textBox_currentDate);
		}

        private void textBox_endDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
				textBox_currentDate.Focus();
		}

        private void textBox_startDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
				textBox_endDate.Focus();
		}

        private void textBox_currentDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
			{ 
				CalcExpirience();
			}
		}
    }
}