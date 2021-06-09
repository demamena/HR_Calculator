using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows;
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
	}

	interface IExperienceDataBase
	{
		void Sqlite_AddRecord(string name, LocalDate startDate, LocalDate endDate, Period generalPeriod, Period statePeriod);

		string[,] Sqlite_GetAllRecords(List<string> recordsDB);

		void Sqlite_DeleteRecord(List<int> listRowid);

		void DeleteCheckedRecords(System.Windows.Forms.Panel panel, System.Windows.Forms.Label avgExperience, System.Windows.Forms.Label stateExperience);

		List<int> GetCheckedRowids(System.Windows.Forms.Panel panel);

		bool Sqlite_IsRecordExists(string startDate, string endDate, string name, bool isState);

		List<string> Sqlite_GetAllNames();

		List<string> Sqlite_GetRecordsFromDBByName(string name);
	}

	class ExperienceDataBase : IExperienceDataBase
	{
		private string connection = "Data Source = experiencePeriods.db";

		public void Sqlite_AddRecord(string name, LocalDate startDate, LocalDate endDate, Period generalPeriod, Period statePeriod)
		{
			SQLiteConnection con = new SQLiteConnection(connection);
			con.Open();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					fmd.CommandText = $"INSERT INTO Experiences(name, startDate, endDate, generalPeriod, statePeriod, dateAdded)" +
						$" VALUES('{name}'," +
						$" '{new DateTime(startDate.Year, startDate.Month, startDate.Day):dd.MM.yyyy}'," +
						$" '{new DateTime(endDate.Year, endDate.Month, endDate.Day):dd.MM.yyyy}'," +
						$" '{generalPeriod.Years + " р. " + generalPeriod.Months + " м. " + generalPeriod.Days + " д."}'," +
						$" '{statePeriod.Years + " р. " + statePeriod.Months + " м. " + statePeriod.Days + " д."}', '{DateTime.Today:dd.MM.yyyy}')";
					fmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			con.Close();
		}

		public List<string> Sqlite_GetAllRecordsFromDataBase()
		{
			SQLiteConnection con = new SQLiteConnection(connection);
			con.Open();
			List<string> records = new List<string>();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					fmd.CommandText = $"SELECT startDate, endDate, generalPeriod, statePeriod, dateAdded, name, rowid FROM Experiences ORDER BY rowid";
					SQLiteDataReader reader = fmd.ExecuteReader();

					while (reader.Read())
					{
						records.Add(reader["startDate"].ToString() + "/" + reader["endDate"].ToString()
							+ "/" + reader["generalPeriod"].ToString() + "/" + reader["statePeriod"].ToString()
							+ "/" + reader["dateAdded"].ToString() + "/" + reader["name"].ToString() 
							+ "/" + reader["rowid"].ToString());
					}
					reader.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			con.Close();
			return records;
		}

		public string[,] Sqlite_GetAllRecords(List<string> recordsDB)
		{
			const int recordLength = 7;
			string[,] records = new string[recordsDB.Count, recordLength];
			string[] recordSplit = new string[recordLength];
			int counter = 0;
			foreach(var record in recordsDB)
			{
				recordSplit = record.Split('/');
				for(int i = 0; i < recordLength; i++)
					records[counter, i] = recordSplit[i];
				counter++;
			}
			return records;
		}

		public void Sqlite_CreateTables(string file)
        {
			if (File.Exists(file))
				return;
			SQLiteConnection con = new SQLiteConnection(connection);
			con.Open();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					fmd.CommandText = "CREATE TABLE [Experiences] ([startDate] TEXT NOT NULL," +
						" [endDate] TEXT NOT NULL," +
						" [generalPeriod] TEXT NOT NULL," +
						" [statePeriod] TEXT NOT NULL," +
						" [dateAdded] TEXT NOT NULL," +
						" [name] TEXT NOT NULL)";
					fmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			con.Close();
			File.SetAttributes(file, FileAttributes.Hidden);
		}

        public void Sqlite_DeleteRecord(List<int> listRowid)
        {
			SQLiteConnection con = new SQLiteConnection(connection);
			con.Open();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					foreach (var rowid in listRowid)
					{
						fmd.CommandText = $"DELETE FROM Experiences WHERE rowid = {rowid}";
						fmd.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			con.Close();
		}

		public void DeleteCheckedRecords(System.Windows.Forms.Panel panel, System.Windows.Forms.Label avgExperience, System.Windows.Forms.Label stateExperience)
		{
			List<System.Windows.Forms.Control> listControls = new List<System.Windows.Forms.Control>();
			foreach (System.Windows.Forms.Control control in panel.Controls)
			{
				UserControlList userControlList = (UserControlList)control;
				if (userControlList.isChecked)
				{
					listControls.Add(control);
					new ExperienceCalculator().SubtractCheckedRecord(userControlList.record, avgExperience, stateExperience);
				}
			}
			Sqlite_DeleteRecord(GetCheckedRowids(panel));
			foreach (var control in listControls)
				panel.Controls.Remove(control);
		}

        public List<int> GetCheckedRowids(System.Windows.Forms.Panel panel)
        {
			List<int> listRowid = new List<int>();
			foreach (System.Windows.Forms.Control control in panel.Controls)
			{
				UserControlList userControlList = (UserControlList)control;
				UserControlList.Record record = userControlList.record;
				if (userControlList.isChecked)
					listRowid.Add(record.rowid);
			}
			return listRowid;
		}

        public bool Sqlite_IsRecordExists(string startDate, string endDate, string name, bool isState)
        {
			var expCalc = new ExperienceCalculator();
			LocalDate[] localDates = expCalc.GetDate(startDate, endDate);
			SQLiteConnection con = new SQLiteConnection(connection);
			con.Open();
			List<string> records = new List<string>();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					fmd.CommandText = $"SELECT statePeriod FROM Experiences WHERE name = '{name}'" +
						$" AND startDate = '{new DateTime(localDates[0].Year, localDates[0].Month, localDates[0].Day):dd.MM.yyyy}'" +
						$" AND endDate = '{new DateTime(localDates[1].Year, localDates[1].Month, localDates[1].Day):dd.MM.yyyy}'";
					SQLiteDataReader reader = fmd.ExecuteReader();
					while (reader.Read())
					{
						if (isState && reader["statePeriod"].ToString() == "0 р. 0 м. 0 д.")
							continue;
                        reader.Close();
                        con.Close();
                        return true;

                    }
					reader.Close();
				}
				catch
				{
				}
			}
			con.Close();
			return false;
        }

        public List<string> Sqlite_GetAllNames()
        {
			List<string> namesList = new List<string>();
			SQLiteConnection con = new SQLiteConnection(connection);
			con.Open();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					fmd.CommandText = $"SELECT name FROM Experiences ORDER BY rowid DESC";
					SQLiteDataReader reader = fmd.ExecuteReader();
					while (reader.Read())
					{
						namesList.Add(reader["name"].ToString());
					}
					reader.Close();
				}
				catch
				{
				}
			}
			con.Close();
			HashSet<string> hashSet = new HashSet<string>(namesList);
			namesList.Clear();
            namesList = hashSet.ToList();
			namesList.Sort();
			return namesList;
		}

        public List<string> Sqlite_GetRecordsFromDBByName(string name)
        {
			SQLiteConnection con = new SQLiteConnection(connection);
			con.Open();
			List<string> records = new List<string>();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					fmd.CommandText = $"SELECT startDate, endDate, generalPeriod, statePeriod, dateAdded, name, rowid FROM Experiences WHERE name = '{name}' ORDER BY rowid";
					SQLiteDataReader reader = fmd.ExecuteReader();

					while (reader.Read())
					{
						records.Add(reader["startDate"].ToString() + "/" + reader["endDate"].ToString()
							+ "/" + reader["generalPeriod"].ToString() + "/" + reader["statePeriod"].ToString()
							+ "/" + reader["dateAdded"].ToString() + "/" + reader["name"].ToString()
							+ "/" + reader["rowid"].ToString());
					}
					reader.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			con.Close();
			return records;
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
			if (addToDB && !expDB.Sqlite_IsRecordExists(startDate, endDate, name, isState))
			{
				ExperienceDataBase experienceData = new ExperienceDataBase();
				if (isState)
					experienceData.Sqlite_AddRecord(name, localDates[0], localDates[1], periodDiff, periodDiff);
				else
					experienceData.Sqlite_AddRecord(name, localDates[0], localDates[1], periodDiff, Period.Zero);
				using (var f = new FormMain())
					f.FillComboBoxNames();
			}
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
			string text = maskedTextBox.Text.Replace(".", "").Trim();
			text = text.Replace("_", "");
			if (text == "")
				maskedTextBox.Select(0, 0);
			else
				maskedTextBox.Select(maskedTextBox.Text.Replace("_", "").Length, 0);
		}

        public string ConvertPeriodToString(Period period)
        {
			return period.Years + " р. "
				+ period.Months + " м. "
				+ period.Days + " д. ";
		}
    }
}