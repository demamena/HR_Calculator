using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;

using NodaTime;

namespace ExpCalc
{
    interface IExpirienceCalculator
	{
		LocalDate[] GetDate(string startDateString, string endDateString);

		Period CalculateCurrentPeriod(LocalDate startDate, LocalDate endDate);

		void CalculateToGlobalPeriod(string startDate, string endDate, string name, bool isState, bool addToDB);

		void CalculateToGlobalPeriod(Period periodDiff, bool isState);

		Period ConvertStringToPeriod(string period);

		LocalDate ConvertStringToLocalDate(string localDate);

		void AddCheckedRecord(UserControlList.Record record, System.Windows.Forms.Label label_avgExperience, System.Windows.Forms.Label label_stateExperience);

		void SubtractCheckedRecord(UserControlList.Record record, System.Windows.Forms.Label label_avgExperience, System.Windows.Forms.Label label_stateExperience);

		void SelectCursorMaskedTextBox(Xceed.Wpf.Toolkit.MaskedTextBox maskedTextBox);

		Period SubtractPeriods(Period firstPeriod, Period secondPeriod);

		Period AddingPeriods(Period firstPeriod, Period secondPeriod);

		string ConvertPeriodToString(Period period);

		void CheckDateCorrect(object sender, System.Windows.Input.TextCompositionEventArgs e);
	}

	interface IDataBase
	{
		void SQL_InsertDepartment(string Department, string DepartmentName);

		void SQL_InsertWorkers(string PIB, string SeriesAndNumber, DateTime dateOfIssue, string issuingAuthority);

		void SQL_InsertPost(string Department, string Post);

		void SQL_InsertHeldPosts(int idWorker, int idPost);

		string SQL_SelectTables(string tableName);

		void SQL_UpdateTables(string tableName, DataTable dataTable);
	}

	class ExperienceDataBase : IDataBase
	{
		public DataSet dataSet = new();

		SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog=HR_Calculator;Integrated Security=True");

		public void SQL_InsertDepartment(string Department, string DepartmentName)
		{
			con.Open();
			try
			{
				SqlCommand adapter = new SqlCommand($"INSERT INTO Department VALUES('{Department}', '{DepartmentName}')", con);
				adapter.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		public void SQL_InsertWorkers(string PIB, string SeriesAndNumber, DateTime dateOfIssue, string issuingAuthority)
		{
			con.Open();
			try
			{
				SqlCommand adapter = new SqlCommand($"INSERT INTO Workers VALUES('{PIB}', '{SeriesAndNumber}', '{dateOfIssue:MM/dd/yyyy}', '{issuingAuthority}')", con);
				adapter.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		public void SQL_InsertPost(string Department, string Post)
		{
			con.Open();
			try
			{
				SqlCommand adapter = new SqlCommand($"INSERT INTO Post VALUES('{Department}', '{Post}')", con);
				adapter.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		public void SQL_InsertHeldPosts(int idWorker, int idPost)
		{
			con.Open();
			try
			{
				SqlCommand adapter = new SqlCommand($"INSERT INTO HeldPosts VALUES('{idPost}', '{idWorker}', '{DateTime.Now:MM/dd/yyyy}')", con);
				adapter.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		public string SQL_SelectTables(string tableName)
		{
			string table = null;
			switch (tableName)
			{
				case "Співробітники":
					SQL_SelectAllWorkers();
					table = "Workers";
					break;
				case "Посади":
					SQL_SelectAllPosts();
					table = "Post";
					break;
				case "Займані посади":
					SQL_SelectAllHeldPosts();
					table = "HeldPosts";
					break;
				case "Департаменти":
					SQL_SelectAllDepartments();
					table = "Department";
					break;
			}
			return table;
		}

		public string ConvertNameToTableName(string name)
		{
			string table = null;
			switch (name)
			{
				case "Співробітники":
					table = "Workers";
					break;
				case "Посади":
					table = "Post";
					break;
				case "Займані посади":
					table = "HeldPosts";
					break;
				case "Накази на відпустку":
					table = "VacationOrder";
					break;
				case "Накази на присвоєння рангу":
					table = "RankOrder";
					break;
			}
			return table;
		}

		public int SQL_CountWorkers()
		{
			con.Open();
			int workersCount = 0;
			try
			{
				SqlCommand command = new SqlCommand($"SELECT COUNT(idWorker) AS [count] " +
					$"FROM Workers", con);
				SqlDataReader r = command.ExecuteReader();
				while (r.Read())
					workersCount = r.GetInt32(0);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
			return workersCount;
		}

		private void SQL_SelectAllWorkers()
		{
			con.Open();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter($"SELECT idWorker AS [Код працівника], " +
					$"PIB AS [ПІБ]," +
					$" seriesAndNumber AS [Серія та номер паспорту], " +
					$"dateOfIssue AS [Дата видачі], " +
					$"issuingAuthority AS [Орган, що видав]" +
					$"FROM Workers", con);
				adapter.Fill(dataSet, "Workers");
				dataSet.Tables["Workers"].Clear();
				adapter.Fill(dataSet, "Workers");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		public List<string> SQL_SelectWorkersNames()
		{
			con.Open();
			List<string> list = new List<string>();

			try
			{
				SqlCommand command = new SqlCommand($"SELECT idWorker, " +
					$"PIB " +
					$"FROM Workers", con);
				SqlDataReader r = command.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(r);
				foreach (DataRow row in dt.Rows)
					list.Add(row["idWorker"] + ". " + row["PIB"].ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
			return list;
		}

		public List<string> SQL_SelectPostNames()
		{
			con.Open();
			List<string> list = new List<string>();
			try
			{
				SqlCommand command = new SqlCommand($"SELECT idPost, " +
					$"PostName, " +
					$"Post.Department, " +
					$"DepartmentName " +
					$"FROM Post JOIN dbo.Department ON Post.Department = dbo.Department.Department", con);
				SqlDataReader r = command.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(r);
				foreach (DataRow row in dt.Rows)
					list.Add(row["idPost"] + ". " + row["PostName"].ToString() + "|" + row["Department"].ToString() + "|" + row["DepartmentName"].ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
			return list;
		}

		public List<string> SQL_SelectDepartmentNames()
		{
			con.Open();
			List<string> list = new List<string>();
			try
			{
				SqlCommand command = new SqlCommand($"SELECT Department, " +
					$"DepartmentName " +
					$"FROM Department", con);
				SqlDataReader r = command.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(r);
				foreach (DataRow row in dt.Rows)
					list.Add(row["Department"].ToString() + "|" + row["DepartmentName"].ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
			return list;
		}

		private void SQL_SelectAllDepartments()
		{
			con.Open();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter($"SELECT idDepartment AS [Код], " +
					$"DepartmentName AS [Відділ], " +
					$"Division AS [Департамент] "+
					$"FROM Department", con);
				adapter.Fill(dataSet, "Department");
				dataSet.Tables["Department"].Clear();
				adapter.Fill(dataSet, "Department");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		private void SQL_SelectAllPosts()
		{
			con.Open();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter($"SELECT idPost AS [Код посади], " +
					$"PostName AS [Посада] " +
					$"FROM Post", con);
				adapter.Fill(dataSet, "Post");
				dataSet.Tables["Post"].Clear();
				adapter.Fill(dataSet, "Post");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		private void SQL_SelectAllHeldPosts()
		{
			con.Open();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter($"SELECT h.idHeldPost AS [Код], p.PostName AS [Посада], " +
					$"w.PIB AS [ПІБ], " +
					$"d.DepartmentName AS [Відділ], " +
					$"d.Division AS [Департамент], " +
					$"dateOfAppointment AS [Дата призначення] " +
					$"FROM HeldPosts AS h INNER JOIN Workers AS w ON h.idWorker = w.idWorker " +
					$"INNER JOIN Post AS p INNER JOIN Department as d ON p.Department = d.idDepartment " +
					$"ON p.idPost = h.idPost", con);
				adapter.Fill(dataSet, "HeldPosts");
				dataSet.Tables["HeldPosts"].Clear();
				adapter.Fill(dataSet, "HeldPosts");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}


		public void SQL_UpdateTables(string tableName, DataTable dataTable)
		{
			switch (tableName)
			{
				case "Співробітники":
					SQL_UpdateWorker(dataTable);
					break;
				case "Посади":
					SQL_UpdatePost(dataTable);
					break;
				case "Займані посади":
					SQL_UpdateHeldPosts(dataTable);
					break;
            }
        }

		public void SQL_DeleteTables(string tableName, int id)
		{
			switch (tableName)
			{
				case "Співробітники":
					SQL_DeleteWorker(id);
					break;
				case "Посади":
					SQL_DeletePost(id);
					break;
				case "Займані посади":
					SQL_DeleteHeldPosts(id);
					break;
				case "Департаменти":
					SQL_DeleteDepartment(id);
					break;
			}
		}

		private void SQL_DeleteHeldPosts(int id)
		{
			con.Open();
			try
			{
				SqlCommand command = new SqlCommand($"DELETE FROM HeldPosts WHERE idHeldPost={id}", con);
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		private void SQL_DeleteWorker(int id)
		{
			con.Open();
			try
			{
				SqlCommand command = new SqlCommand($"DELETE FROM Workers WHERE idWorker={id}", con);
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		private void SQL_DeletePost(int id)
		{
			con.Open();
			try
			{
				SqlCommand command = new SqlCommand($"DELETE FROM Post WHERE idPost={id}", con);
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		private void SQL_DeleteDepartment(int id)
		{
			con.Open();
			try
			{
				SqlCommand command = new SqlCommand($"DELETE FROM Department WHERE idDepartment={id}", con);
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		private void SQL_UpdateWorker(DataTable dataTable)
        {
            con.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT idWorker AS [Код працівника], " +
                    $"PIB AS [ПІБ], " +
                    $"seriesAndNumber AS [Серія та номер паспорту], " +
                    $"dateOfIssue AS [Дата видачі], " +
                    $"issuingAuthority AS [Орган видачі]" +
                    $"FROM Workers", con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dataTable);
            }
            catch
            {
            }
            con.Close();
        }

        private void SQL_UpdateHeldPosts(DataTable dataTable)
		{
			con.Open();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter($"SELECT p.PostName AS [Код], " +
					$"w.PIB AS [ПІБ], " +
					$"d.DepartmentName AS [Відділ], " +
					$"d.Division AS [Департамент], " +
					$"dateOfAppointment AS [Дата призначення] " +
					$"FROM HeldPosts AS h INNER JOIN Workers AS w ON h.idWorker = w.idWorker " +
					$"INNER JOIN Department AS d ON d.idDepartment = h.Department " +
					$"INNER JOIN Post AS p ON p.idPost = h.idPost", con);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
				adapter.Update(dataTable);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		private void SQL_UpdatePost(DataTable dataTable)
		{
			con.Open();
			try
            {
				SqlDataAdapter adapter = new SqlDataAdapter($"SELECT p.PostName AS [Код], " +
					$"w.PIB AS [ПІБ], " +
					$"d.DepartmentName AS [Відділ], " +
					$"d.Division AS [Департамент], " +
					$"dateOfAppointment AS [Дата призначення] " +
					$"FROM HeldPosts AS h INNER JOIN Workers AS w ON h.idWorker = w.idWorker " +
					$"INNER JOIN Department AS d ON d.idDepartment = h.Department " +
					$"INNER JOIN Post AS p ON p.idPost = h.idPost", con);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
				adapter.Update(dataTable);
            }
            catch
			{

			}
			con.Close();
		}
	}

	class ExperienceCalculator : IExpirienceCalculator
	{
		public Period periodGeneral = Period.Zero;
		public Period periodState = Period.Zero;

		public ExperienceCalculator()
		{
			
		}

		public void CalculateToGlobalPeriod(Period periodDiff, bool isState)
		{
			periodGeneral = AddingPeriods(periodGeneral, periodDiff);

			if (isState)
			{
					periodState = AddingPeriods(periodState, periodDiff);
			}
		}

		public void CalculateToGlobalPeriod(string startDate, string endDate, string name ,bool isState, bool addToDB)
		{
			LocalDate[] localDates = GetDate(startDate, endDate); 
			Period periodDiff = CalculateCurrentPeriod(localDates[0], localDates[1]);
			CalculateToGlobalPeriod(periodDiff, isState);
			var expDB = new ExperienceDataBase();
			/*if (addToDB && !expDB.Sqlite_IsRecordExists(startDate, endDate, name, isState))
			{
				ExperienceDataBase experienceData = new ExperienceDataBase();
				if (isState)
					experienceData.Sqlite_AddRecord(name, localDates[0], localDates[1], periodDiff, periodDiff);
				else
					experienceData.Sqlite_AddRecord(name, localDates[0], localDates[1], periodDiff, Period.Zero);
				using (var f = new FormMain())
					f.FillComboBoxNames();
			}*/
		}

		public Period AddingPeriods(Period firstPeriod, Period secondPeriod)
		{
			firstPeriod += secondPeriod;
			int[] period = { firstPeriod.Days, firstPeriod.Months, firstPeriod.Years };

			if (period[0] > 30)
			{
				period[0] %= 30;
				period[1]++;
			}

			if (period[1] >= 12)
			{
				period[1] %= 12;
				period[2]++;
			}
			return new PeriodBuilder() { Days = period[0], Months = period[1], Years = period[2] }.Build();
		}

		public Period SubtractPeriods(Period firstPeriod, Period secondPeriod)
		{
			firstPeriod -= secondPeriod;
			int[] period = { firstPeriod.Days, firstPeriod.Months, firstPeriod.Years };

			while (period[0] < 0)
			{
				period[0] += 30;
				period[1]--;
			}

			while (period[1] < 0)
			{
				period[2]--;
				period[1] += 12;
			}
			return new PeriodBuilder() { Days = period[0], Months = period[1], Years = period[2] }.Build();
		}

		public Period CalculateCurrentPeriod(LocalDate startDate, LocalDate endDate)
		{
			Period differentPeriod = Period.Between(startDate, endDate);
			differentPeriod = new PeriodBuilder { Days = differentPeriod.Days + 1, Months = differentPeriod.Months, Years = differentPeriod.Years }.Build();
			return differentPeriod;
		}

		public LocalDate[] GetDate(string startDateString, string endDateString)
		{
			string[] dateNumbs = startDateString.Split('.');
			var startDate = new LocalDate(Convert.ToInt32(dateNumbs[2]), Convert.ToInt32(dateNumbs[1]), Convert.ToInt32(dateNumbs[0]));
			dateNumbs = endDateString.Split('.');
			var endDate = new LocalDate(Convert.ToInt32(dateNumbs[2]), Convert.ToInt32(dateNumbs[1]), Convert.ToInt32(dateNumbs[0]));
			LocalDate[] localDates = { startDate, endDate };
			return localDates;
		}

		public Period ConvertStringToPeriod(string period)
		{
			period = period.Replace(" ", "");
			period = period.Replace(".", "");
			period = period.Replace("_", "");
			period = period.Replace(" ", "");
			string[] periodArr = period.Split('д', 'р', 'м');
			return new PeriodBuilder { Years = Convert.ToInt32(periodArr[0]), Months = Convert.ToInt32(periodArr[1]), Days = Convert.ToInt32(periodArr[2]) }.Build();
		}

		public LocalDate ConvertStringToLocalDate(string localDate)
		{
			string[] periodArr = localDate.Split('.');
			return new LocalDate(Convert.ToInt32(periodArr[2]), Convert.ToInt32(periodArr[1]), Convert.ToInt32(periodArr[0]));
		}

		public void AddCheckedRecord(UserControlList.Record record, System.Windows.Forms.Label label_avgExperience, System.Windows.Forms.Label label_stateExperience)
		{
			Period periodAvg, periodState;
			periodAvg = AddingPeriods(record.avgExp, ConvertStringToPeriod(label_avgExperience.Text));
			periodState = AddingPeriods(record.stateExp, ConvertStringToPeriod(label_stateExperience.Text));
			label_avgExperience.Text = periodAvg.Years + " р. " + periodAvg.Months + " м. " + periodAvg.Days + " д.";
			label_stateExperience.Text = periodState.Years + " р. " + periodState.Months + " м. " + periodState.Days + " д.";
		}

		public void SubtractCheckedRecord(UserControlList.Record record, System.Windows.Forms.Label label_avgExperience, System.Windows.Forms.Label label_stateExperience)
		{
			Period periodAvg, periodState;
			periodAvg = SubtractPeriods(ConvertStringToPeriod(label_avgExperience.Text), record.avgExp);
			periodState = SubtractPeriods(ConvertStringToPeriod(label_stateExperience.Text), record.stateExp);
			label_avgExperience.Text = periodAvg.Years + " р. " + periodAvg.Months + " м. " + periodAvg.Days + " д.";
			label_stateExperience.Text = periodState.Years + " р. " + periodState.Months + " м. " + periodState.Days + " д.";
		}

		public void SelectCursorMaskedTextBox(Xceed.Wpf.Toolkit.MaskedTextBox maskedTextBox)
		{
			string text = maskedTextBox.Text.Replace(".", "").Replace("_", "").Trim();
			if (text == "")
				maskedTextBox.Select(0, 0);
			
		}

		public string ConvertPeriodToString(Period period)
		{
			return period.Years + " р. "
				+ period.Months + " м. "
				+ period.Days + " д. ";
		}

		public void CheckDateCorrect(object sender, TextCompositionEventArgs e)
		{
			if (Char.IsDigit(Convert.ToChar(e.Text)))
			{
				var text = (sender as Xceed.Wpf.Toolkit.MaskedTextBox).Text.Replace(".", "").Replace("_", "").Trim();
				if (text.Length % 2 == 1)
				{
					if (text.Length == 3)
					{
						if (Convert.ToInt32(text[text.Length - 1] + e.Text) > 12)
						{
							System.Windows.MessageBox.Show("Помилка! Такого місяця не існує!\n", "Помилка!", MessageBoxButton.OK, (MessageBoxImage)System.Windows.Forms.MessageBoxIcon.Error);
							e.Handled = true;
						}
					}
					else if (text.Length == 1)
					{
						if (Convert.ToInt32(text[text.Length - 1] + e.Text) > 31)
						{
							System.Windows.MessageBox.Show("Помилка! Такого дня не існує!\n", "Помилка!", MessageBoxButton.OK, (MessageBoxImage)System.Windows.Forms.MessageBoxIcon.Error);
							e.Handled = true;
						}
					}
				}
			}
		}
	}
}