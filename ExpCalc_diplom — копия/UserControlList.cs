using System;
using System.Drawing;
using System.Windows.Forms;
using NodaTime;

namespace ExpCalc
{
    public partial class UserControlList : UserControl
	{
		public bool isChecked = false;

		public struct Record
		{
			public LocalDate startDate;
			public LocalDate endDate;
			public Period avgExp;
			public Period stateExp;
			public LocalDate dateAdded;
			public string name;
			public int rowid;

			public Record(LocalDate startDate, LocalDate endDate, Period avgExp, Period stateExp, LocalDate dateAdded, string name, int rowid)
			{
				this.startDate = startDate;
				this.endDate = endDate;
				this.avgExp = avgExp;
				this.stateExp = stateExp;
				this.dateAdded = dateAdded;
				this.name = name;
				this.rowid = rowid;
			}
        }

		public Record record;

		public UserControlList(string[] records)
		{
			InitializeComponent();
			int counter = 0;
			foreach (var str in records)
			{
				if(counter != records.Length-1)
					label_data.Text += str.PadRight(19);
				counter++;
			}
			var expCalc = new ExperienceCalculator();
			record = new Record(expCalc.ConvertStringToLocalDate(records[0]),
				expCalc.ConvertStringToLocalDate(records[1]),
				expCalc.ConvertStringToPeriod(records[2]),
				expCalc.ConvertStringToPeriod(records[3]),
				expCalc.ConvertStringToLocalDate(records[4]),
				records[5], Convert.ToInt32(records[6]));
		}

        private void Button_checkBox_Click(object sender, EventArgs e)
        {
            CheckRecord(!isChecked);
        }

		public void CheckRecord(bool checkBox)
        {
			if (checkBox)
				button_checkBox.BackColor = Color.DarkBlue;
			else
				button_checkBox.BackColor = Color.Snow;
			isChecked = checkBox;
		}
    }
}
