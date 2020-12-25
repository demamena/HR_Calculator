using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using HRCalculator;
using NodaTime;

namespace ExpCalc
{
	/// <summary>
	/// Логика взаимодействия для UserControlExpirience.xaml
	/// </summary>
	public partial class UserControlExperience : System.Windows.Controls.UserControl
	{
		ExperienceCalculator experienceCalculator = new ExperienceCalculator();

		public UserControlExperience()
		{
			InitializeComponent();
		}

		private void Button_calculate_Click(object sender, RoutedEventArgs e)
		{
			CalcExpirience();
		}

		void CalcExpirience()
		{
			try
			{
				experienceCalculator.CalculateToGlobalPeriod(textBox_startDate.Text, textBox_endDate.Text, textBox_name.Text, (bool)checkBox_state.IsChecked, textBox_name.Text.Trim() != "");
				textBlock_general.Text = experienceCalculator.ConvertPeriodToString(experienceCalculator.periodGeneral);
				if ((bool)checkBox_state.IsChecked)
					textBlock_state.Text = experienceCalculator.ConvertPeriodToString(experienceCalculator.periodState);
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show("Помилка! Неккоректно введені дані!\n" + ex.Message, "Помилка!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
			}
		}

		private void Button_clear_Click(object sender, RoutedEventArgs e)
		{
			textBox_startDate.Text = "";
			textBox_endDate.Text = "";
		}

		private void ClearAllFields()
		{
			textBox_startDate.Text = "";
			textBox_endDate.Text = "";
			textBlock_general.Text = "";
			textBlock_state.Text = "";
		}

		private void textBox_startDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
        {
			experienceCalculator.SelectCursorMaskedTextBox(textBox_startDate);
		}

        private void textBox_endDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
        {
			experienceCalculator.SelectCursorMaskedTextBox(textBox_endDate);
		}

        private void textBox_startDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
				textBox_endDate.Focus();
		}

        private void textBox_endDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
            {
				CalcExpirience();
			}								
		}

        private void button_calcSpecialExp_Click(object sender, RoutedEventArgs e)
        {
			using (var f = new FormGivenDate(textBlock_state.Text))
				f.ShowDialog();
        }

        private void button_clearExperience_Click(object sender, RoutedEventArgs e)
        {
			experienceCalculator.periodGeneral = Period.Zero;
			experienceCalculator.periodState = Period.Zero;
			textBlock_general.Text = experienceCalculator.ConvertPeriodToString(Period.Zero);
			textBlock_state.Text = experienceCalculator.ConvertPeriodToString(Period.Zero);
		}
    }
}
