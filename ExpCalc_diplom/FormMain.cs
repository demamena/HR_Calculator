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

		public FormMain()
		{
			InitializeComponent();
		}

		private void button_bar_Click(object sender, EventArgs e)
		{
			panel_bar.Visible = !panel_bar.Visible;
		}

		private void Button_expirience_Click(object sender, EventArgs e)
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

		private void Button_deleteCheckedRecords_Click(object sender, EventArgs e)
		{
			DeleteCheckedRows();
		}

		private void DeleteCheckedRows()
        {
			if (MessageBox.Show("Ви впевнені?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				foreach (var row in dataGridView_DB.SelectedRows)
				{
					experienceDB.SQL_DeleteTables(comboBox_names.Text, Convert.ToInt32((row as DataGridViewRow).Cells[0].Value));
					dataGridView_DB.Rows.Remove((row as DataGridViewRow));
				}
			}
		}

		private void ShowDataBase(string name)
		{
			dataGridView_DB.DataSource = experienceDB.dataSet.Tables[experienceDB.SQL_SelectTables(name)];
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
			//experienceDB.Sqlite_CreateTables("experiencePeriods.db");
			//FillComboBoxNames();
		}

		public void FillComboBoxNames()
		{
			List<string> tablesList = new List<string>();
			tablesList.Add("Співробітники");
			tablesList.Add("Посади");
			tablesList.Add("Займані посади");
			tablesList.Add("Департаменти");
			comboBox_names.DataSource = tablesList;
		}

		private void iconButton_selectAllRecords_Click(object sender, EventArgs e)
		{
			dataGridView_DB.SelectAll();
		}

		private void ComboBox_names_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void comboBox_names_TextChanged(object sender, EventArgs e)
		{
			ShowDataBase(comboBox_names.Text);
		}

		private void HidePanels()
		{
			dataGridView_DB.Visible = false;
			panel_formMenu.Visible = false;
			panel_experiences.Visible = false;
		}

		private void ShowPanels()
		{
			panel_formMenu.Visible = true;
			panel_experiences.Visible = true;
			dataGridView_DB.Visible = true;
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

		private void Button_rankAfterDecree_Click(object sender, EventArgs e)
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

		private void Button_vacationAfterDecree_Click(object sender, EventArgs e)
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

		private void Button_decreeHospitalVacation_Click(object sender, EventArgs e)
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

        private void dataGridView_DB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			try
			{
				MessageBox.Show(dataGridView_DB.Rows[e.RowIndex].ToString());
            }
            catch
            {

            }
        }
    }
}