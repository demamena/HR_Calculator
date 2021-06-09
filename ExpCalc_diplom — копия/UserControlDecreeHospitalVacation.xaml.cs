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
using ExpCalc;
using NodaTime;

namespace HRCalculator
{
    /// <summary>
    /// Логика взаимодействия для UserControlDecreeHospitalVacation.xaml
    /// </summary>
    public partial class UserControlDecreeHospitalVacation : UserControl
    {
        public UserControlDecreeHospitalVacation()
        {
            InitializeComponent();
        }

        private void Button_calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBlock_afterDecreePeriod.Text = textBox_startDate.Text + '\n' +
                        NumericUpDown.Text + " дн.\n" +
                        new ExperienceCalculator().ConvertStringToLocalDate(textBox_startDate.Text).Plus(new PeriodBuilder() { Days = Convert.ToInt32(NumericUpDown.Text) - 1 }.Build()).ToString("dd.MM.yyyy", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\nПомилка! Неккоректно введені дані!\n" + ex.Message, "Помилка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            textBox_startDate.Text = "";
            textBlock_afterDecreePeriod.Text = "";
        }

		private void TextBox_startDate_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
		{
			new ExperienceCalculator().SelectCursorMaskedTextBox(textBox_startDate);
		}

		private void textBox_startDate_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter && (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace("_", "").Length == (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Length)
				NumericUpDown.Focus();
		}
	}
}
