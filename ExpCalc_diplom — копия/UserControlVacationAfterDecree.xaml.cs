using System;
using ExpCalc;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Forms;
using NodaTime;

namespace HRCalculator
{
    /// <summary>
    /// Логика взаимодействия для UserControlVacationAfterDecree.xaml
    /// </summary>
    public partial class UserControlVacationAfterDecree : System.Windows.Controls.UserControl
    {
        public UserControlVacationAfterDecree()
        {
            InitializeComponent();
        }
		private void Button_calculate_Click(object sender, RoutedEventArgs e)
		{
			CalcVacation();
		}

		private void CalcVacation()
		{
			try
			{
				textBlock_afterDecreePeriod.Text = textBox_startDate.Text + '\n' +
					new ExperienceCalculator().ConvertStringToLocalDate(textBox_decreeStartDate.Text).Minus(new PeriodBuilder() { Days = 1 }.Build()).ToString("dd.MM.yyyy", null) + "\n" +
					new ExperienceCalculator().ConvertStringToLocalDate(textBox_decreeEndDate.Text).Minus(new PeriodBuilder() { Days = 1 }.Build()).ToString("dd.MM.yyyy", null) + '\n' +
					new DecreeVacation().CalculateDateAfterDecree(textBox_startDate.Text, textBox_decreeStartDate.Text, textBox_decreeEndDate.Text);
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show(ex + "\nПомилка! Неккоректно введені дані!\n" + ex.Message, "Помилка!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
			}
		}

		private void Button_clear_Click(object sender, RoutedEventArgs e)
		{
			ClearAllFields();
		}

		private void ClearAllFields()
		{
			textBox_startDate.Text = "";
			textBox_decreeStartDate.Text = "";
			textBox_decreeEndDate.Text = "";
			textBlock_afterDecreePeriod.Text = "";
		}

		private void TextBox_startDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
		{
			new ExperienceCalculator().SelectCursorMaskedTextBox(textBox_startDate);
		}

		private void TextBox_endDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
		{
			new ExperienceCalculator().SelectCursorMaskedTextBox(textBox_decreeStartDate);
		}

		private void TextBox_currentDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
		{
			new ExperienceCalculator().SelectCursorMaskedTextBox(textBox_decreeEndDate);
		}

		private void textBox_endDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
				textBox_decreeStartDate.Focus();
		}

		private void textBox_startDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
				textBox_startDate.Focus();
		}

		private void textBox_currentDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
			{
				CalcVacation();
			}
		}
	}
}
