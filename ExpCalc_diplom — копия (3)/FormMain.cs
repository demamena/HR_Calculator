using FontAwesome.Sharp;

using HRCalculator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExpCalc
{
	public partial class FormMain : Form
	{
		ExperienceDataBase experienceDB = new ExperienceDataBase();
		private bool isRecordsChecked;
		List<UserControlList> userControlLists = new List<UserControlList>();


		public FormMain()
		{
			InitializeComponent();
		}

		private void button_bar_Click(object sender, EventArgs e)
		{
			panel_bar.Visible = !panel_bar.Visible;
		}

		private void button_expirience_Click(object sender, EventArgs e)
		{
			bool active;
			if (button_expirience.BackColor == Color.Transparent)
				active = false;
			else
				active = true;
			ChangeAllButtonsBackColor(panel_bar);

			if (!active)
				button_expirience.BackColor = Color.FromArgb(49, 64, 78);

			else
				button_expirience.BackColor = Color.Transparent;

			HidePanels();
			elementHost_form.Child = new UserControlExperience();
		}

		private void Button_dataBase_Click(object sender, EventArgs e)
		{
			bool active;
			if (button_dataBase.BackColor == Color.Transparent)
				active = false;
			else
				active = true;
			ChangeAllButtonsBackColor(panel_bar);

			if (!active)
				button_dataBase.BackColor = Color.FromArgb(49, 64, 78);

			else
				button_dataBase.BackColor = Color.Transparent;

			ShowPanels();
			FillComboBoxNames();
			ShowDataBase(comboBox_names.Text);
		}

		private void Button_deleteChekedRecords_Click(object sender, EventArgs e)
		{
			experienceDB.DeleteCheckedRecords(panel_form, label_avgExperience, label_stateExperience);
			isRecordsChecked = !isRecordsChecked;
			FillComboBoxNames();
		}

		private void ShowDataBase(string name)
		{
			panel_form.Controls.Clear();
			const int recordLength = 7;
			int arrLength;
			if (name == "")
				arrLength = experienceDB.Sqlite_GetAllRecordsFromDataBase().Count;
			else
				arrLength = experienceDB.Sqlite_GetRecordsFromDBByName(name).Count;

			string[,] records = new string[arrLength, 7];

			if (name == "")
				records = experienceDB.Sqlite_GetAllRecords(experienceDB.Sqlite_GetAllRecordsFromDataBase());
			else
				records = experienceDB.Sqlite_GetAllRecords(experienceDB.Sqlite_GetRecordsFromDBByName(name));
			
			string[] record = new string[recordLength];
			for (int i = 0; i < records.Length / recordLength; i++)
			{
				for (int j = 0; j < recordLength; j++)
					record[j] = records[i, j];
				var userControlList = new UserControlList(record)
				{
					Dock = DockStyle.Top
				};
				userControlList.button_checkBox.Click += Button_CheckBox_Click;
				panel_form.Controls.Add(userControlList);
			}
		}

		private void Button_CheckBox_Click(object sender, EventArgs e)
		{
			var userControlList = (UserControlList)(sender as Button).Parent.Parent;
			if (userControlList.isChecked)
				new ExperienceCalculator().AddCheckedRecord(userControlList.record, label_avgExperience, label_stateExperience);
			else
				new ExperienceCalculator().SubtractCheckedRecord(userControlList.record, label_avgExperience, label_stateExperience);
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			experienceDB.Sqlite_CreateTables("experiencePeriods.db");
			FillComboBoxNames();
		}

		public void FillComboBoxNames()
		{
			var namesList = experienceDB.Sqlite_GetAllNames();
			namesList.Add("");
			comboBox_names.DataSource = namesList;
		}

		private void iconButton_selectAllRecords_Click(object sender, EventArgs e)
		{
			isRecordsChecked = !isRecordsChecked;
			foreach (var control in panel_form.Controls)
			{
				UserControlList userControlList = (UserControlList)control;
				if (isRecordsChecked)
				{
					if (!userControlList.isChecked)
						new ExperienceCalculator().AddCheckedRecord(userControlList.record, label_avgExperience, label_stateExperience);
				}
				else
					if (userControlList.isChecked)
						new ExperienceCalculator().SubtractCheckedRecord(userControlList.record, label_avgExperience, label_stateExperience);

				userControlList.CheckRecord(isRecordsChecked);
				
			}
		}

		private void comboBox_names_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void comboBox_names_TextChanged(object sender, EventArgs e)
		{
			ShowDataBase(comboBox_names.Text);
		}

		private void HidePanels()
		{
			panel_form.Visible = false;
			panel_formMenu.Visible = false;
			panel_experiences.Visible = false;
		}

		private void ShowPanels()
		{
			panel_form.Visible = true;
			panel_formMenu.Visible = true;
			panel_experiences.Visible = true;
			label_avgExperience.Text = "0 р. 0 м. 0 д.";
			label_stateExperience.Text = "0 р. 0 м. 0 д.";
		}

		private void button_vacationCalc_Click(object sender, EventArgs e)
		{
			bool active;
			if (button_vacationCalc.BackColor == Color.Transparent)
				active = false;
			else
				active = true;
			ChangeAllButtonsBackColor(panel_bar);

			if (!active)
				button_vacationCalc.BackColor = Color.FromArgb(49, 64, 78);

			else
				button_vacationCalc.BackColor = Color.Transparent;

			HidePanels();
			elementHost_form.Child = new UserControlVacation();
		}

		private void iconButton_givenDate_Click(object sender, EventArgs e)
		{
			using (var f = new FormGivenDate(label_stateExperience.Text))
				f.ShowDialog();
		}

		private void button_rankAfterDecree_Click(object sender, EventArgs e)
		{
			bool active;
			if (button_rankAfterDecree.BackColor == Color.Transparent)
				active = false;
			else
				active = true;
			ChangeAllButtonsBackColor(panel_bar);

			if (!active)
				button_rankAfterDecree.BackColor = Color.FromArgb(49, 64, 78);

			else
				button_rankAfterDecree.BackColor = Color.Transparent;

			HidePanels();
			elementHost_form.Child = new UserControlRankAfterDecree();
		}

		private void button_vacationAfterDecree_Click(object sender, EventArgs e)
		{
			bool active;
			if (button_vacationAfterDecree.BackColor == Color.Transparent)
				active = false;
			else
				active = true;
			ChangeAllButtonsBackColor(panel_bar);

			if (!active)
				button_vacationAfterDecree.BackColor = Color.FromArgb(49, 64, 78);

			else
				button_vacationAfterDecree.BackColor = Color.Transparent;

			HidePanels();
			elementHost_form.Child = new UserControlVacationAfterDecree();
		}

		private void iconButton_experiences_Click(object sender, EventArgs e)
		{
			panel_experiencesMenu.Visible = !panel_experiencesMenu.Visible;
		}

		private void iconButton_vacations_Click(object sender, EventArgs e)
		{
			panel_vacationsMenu.Visible = !panel_vacationsMenu.Visible;
		}

		private void pictureBox_logo_Click(object sender, EventArgs e)
		{
			HidePanels();
			elementHost_form.Child = new UserControlMainMenu();
		}

		private void button_decreeHospitalVacation_Click(object sender, EventArgs e)
		{
			bool active;
			if (button_decreeHospitalVacation.BackColor == Color.Transparent)
				active = false;
			else
				active = true;
			ChangeAllButtonsBackColor(panel_bar);

			if (!active)
				button_decreeHospitalVacation.BackColor = Color.FromArgb(49, 64, 78);

			else
				button_decreeHospitalVacation.BackColor = Color.Transparent;

			HidePanels();
			elementHost_form.Child = new UserControlDecreeHospitalVacation();
		}

		private void ChangeAllButtonsBackColor(Panel mainPanel)
		{
			foreach (var panel in mainPanel.Controls)
			{
				if(panel.GetType().Name == "Panel")
					ChangeAllButtonsBackColor((Panel)panel);

                else
                {
					var button = (IconButton)panel;
					button.BackColor = Color.Transparent;
				}
			}
		}
	}
}