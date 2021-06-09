using ExpCalc;
using NodaTime;
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
	/// Логика взаимодействия для UserControlAddWorker.xaml
	/// </summary>
	public partial class UserControlAddWorker : System.Windows.Controls.UserControl
    {
		public UserControlAddWorker()
		{
			InitializeComponent();
		}

		private void button_addWorker_Click(object sender, RoutedEventArgs e)
		{
			if(textBox_dateOfIssue.Text.Trim() is null || textBox_issuingAuthority.Text.Trim() is null || textBox_seriesAndNumber.Text.Trim() is null || textBox_workers.Text is null)
			{
				System.Windows.MessageBox.Show("Заповніть усі поля!", "Помилка!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
				return;
			}
			LocalDate localDate = new LocalDate();
			try
			{
				localDate = new ExperienceCalculator().ConvertStringToLocalDate(textBox_dateOfIssue.Text);
			}
			catch
			{
				System.Windows.MessageBox.Show("Некоректно введена дата!", "Помилка!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
			}
			finally
			{
				System.Windows.MessageBox.Show("Співробітник успішно додан!", "Успіх!", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Information);
				new ExperienceDataBase().SQL_InsertWorkers(textBox_workers.Text, textBox_seriesAndNumber.Text, new DateTime(localDate.Year, localDate.Month, localDate.Day), textBox_issuingAuthority.Text);
			}
		}
	}
}
