namespace ExpCalc
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_bar = new System.Windows.Forms.Panel();
            this.button_dataBase = new FontAwesome.Sharp.IconButton();
            this.button_rankAfterDecree = new FontAwesome.Sharp.IconButton();
            this.button_vacationCalc = new FontAwesome.Sharp.IconButton();
            this.button_expirience = new FontAwesome.Sharp.IconButton();
            this.button_bar = new FontAwesome.Sharp.IconButton();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.elementHost_form = new System.Windows.Forms.Integration.ElementHost();
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel_formMenu = new System.Windows.Forms.Panel();
            this.iconButton_givenDate = new FontAwesome.Sharp.IconButton();
            this.comboBox_names = new System.Windows.Forms.ComboBox();
            this.iconButton_selectAllRecords = new FontAwesome.Sharp.IconButton();
            this.iconButton_deleteCheckedRecords = new FontAwesome.Sharp.IconButton();
            this.panel_experiences = new System.Windows.Forms.Panel();
            this.label_avgExperience = new System.Windows.Forms.Label();
            this.label_stateExperience = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.panel_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_formMenu.SuspendLayout();
            this.panel_experiences.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_menu.BackColor = System.Drawing.Color.LightCyan;
            this.panel_menu.Controls.Add(this.panel_bar);
            this.panel_menu.Controls.Add(this.button_bar);
            this.panel_menu.Controls.Add(this.pictureBox_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(175, 561);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_bar
            // 
            this.panel_bar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_bar.BackColor = System.Drawing.Color.FloralWhite;
            this.panel_bar.Controls.Add(this.button_dataBase);
            this.panel_bar.Controls.Add(this.button_rankAfterDecree);
            this.panel_bar.Controls.Add(this.button_vacationCalc);
            this.panel_bar.Controls.Add(this.button_expirience);
            this.panel_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_bar.Location = new System.Drawing.Point(0, 153);
            this.panel_bar.Name = "panel_bar";
            this.panel_bar.Size = new System.Drawing.Size(175, 123);
            this.panel_bar.TabIndex = 3;
            // 
            // button_dataBase
            // 
            this.button_dataBase.BackColor = System.Drawing.Color.Wheat;
            this.button_dataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dataBase.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.button_dataBase.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.button_dataBase.IconColor = System.Drawing.Color.Black;
            this.button_dataBase.IconSize = 28;
            this.button_dataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dataBase.Location = new System.Drawing.Point(0, 91);
            this.button_dataBase.Name = "button_dataBase";
            this.button_dataBase.Rotation = 0D;
            this.button_dataBase.Size = new System.Drawing.Size(175, 31);
            this.button_dataBase.TabIndex = 1;
            this.button_dataBase.Text = "            База даних";
            this.button_dataBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dataBase.UseVisualStyleBackColor = false;
            this.button_dataBase.Click += new System.EventHandler(this.Button_dataBase_Click);
            // 
            // button_rankAfterDecree
            // 
            this.button_rankAfterDecree.BackColor = System.Drawing.Color.FloralWhite;
            this.button_rankAfterDecree.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_rankAfterDecree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rankAfterDecree.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.button_rankAfterDecree.IconChar = FontAwesome.Sharp.IconChar.BabyCarriage;
            this.button_rankAfterDecree.IconColor = System.Drawing.Color.Black;
            this.button_rankAfterDecree.IconSize = 32;
            this.button_rankAfterDecree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rankAfterDecree.Location = new System.Drawing.Point(0, 60);
            this.button_rankAfterDecree.Name = "button_rankAfterDecree";
            this.button_rankAfterDecree.Rotation = 0D;
            this.button_rankAfterDecree.Size = new System.Drawing.Size(175, 31);
            this.button_rankAfterDecree.TabIndex = 3;
            this.button_rankAfterDecree.Text = "            Ранг після ДВ";
            this.button_rankAfterDecree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rankAfterDecree.UseVisualStyleBackColor = false;
            this.button_rankAfterDecree.Click += new System.EventHandler(this.button_rankAfterDecree_Click);
            // 
            // button_vacationCalc
            // 
            this.button_vacationCalc.BackColor = System.Drawing.Color.FloralWhite;
            this.button_vacationCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_vacationCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vacationCalc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.button_vacationCalc.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.button_vacationCalc.IconColor = System.Drawing.Color.Black;
            this.button_vacationCalc.IconSize = 32;
            this.button_vacationCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_vacationCalc.Location = new System.Drawing.Point(0, 29);
            this.button_vacationCalc.Name = "button_vacationCalc";
            this.button_vacationCalc.Rotation = 0D;
            this.button_vacationCalc.Size = new System.Drawing.Size(175, 31);
            this.button_vacationCalc.TabIndex = 2;
            this.button_vacationCalc.Text = "            Розрахунок відпусток";
            this.button_vacationCalc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_vacationCalc.UseVisualStyleBackColor = false;
            this.button_vacationCalc.Click += new System.EventHandler(this.iconButton_vacationCalc_Click);
            // 
            // button_expirience
            // 
            this.button_expirience.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_expirience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_expirience.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.button_expirience.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.button_expirience.IconColor = System.Drawing.Color.Black;
            this.button_expirience.IconSize = 32;
            this.button_expirience.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_expirience.Location = new System.Drawing.Point(0, 0);
            this.button_expirience.Name = "button_expirience";
            this.button_expirience.Rotation = 0D;
            this.button_expirience.Size = new System.Drawing.Size(175, 29);
            this.button_expirience.TabIndex = 0;
            this.button_expirience.Text = "            Розрахунок стажів";
            this.button_expirience.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_expirience.UseVisualStyleBackColor = true;
            this.button_expirience.Click += new System.EventHandler(this.button_expirience_Click);
            // 
            // button_bar
            // 
            this.button_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.button_bar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_bar.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.button_bar.IconColor = System.Drawing.Color.Black;
            this.button_bar.IconSize = 32;
            this.button_bar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_bar.Location = new System.Drawing.Point(0, 114);
            this.button_bar.Name = "button_bar";
            this.button_bar.Rotation = 0D;
            this.button_bar.Size = new System.Drawing.Size(175, 39);
            this.button_bar.TabIndex = 4;
            this.button_bar.Text = "Функції";
            this.button_bar.UseVisualStyleBackColor = true;
            this.button_bar.Click += new System.EventHandler(this.button_bar_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(175, 114);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 1;
            this.pictureBox_logo.TabStop = false;
            // 
            // elementHost_form
            // 
            this.elementHost_form.BackColor = System.Drawing.Color.White;
            this.elementHost_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost_form.Location = new System.Drawing.Point(175, 0);
            this.elementHost_form.Name = "elementHost_form";
            this.elementHost_form.Size = new System.Drawing.Size(809, 561);
            this.elementHost_form.TabIndex = 1;
            this.elementHost_form.Text = "elementHost1";
            this.elementHost_form.Child = null;
            // 
            // panel_form
            // 
            this.panel_form.AutoScroll = true;
            this.panel_form.BackColor = System.Drawing.Color.White;
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(175, 46);
            this.panel_form.Margin = new System.Windows.Forms.Padding(2);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(809, 469);
            this.panel_form.TabIndex = 2;
            this.panel_form.Visible = false;
            // 
            // panel_formMenu
            // 
            this.panel_formMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.panel_formMenu.Controls.Add(this.iconButton_givenDate);
            this.panel_formMenu.Controls.Add(this.comboBox_names);
            this.panel_formMenu.Controls.Add(this.iconButton_selectAllRecords);
            this.panel_formMenu.Controls.Add(this.iconButton_deleteCheckedRecords);
            this.panel_formMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_formMenu.Location = new System.Drawing.Point(175, 0);
            this.panel_formMenu.Name = "panel_formMenu";
            this.panel_formMenu.Size = new System.Drawing.Size(809, 46);
            this.panel_formMenu.TabIndex = 4;
            this.panel_formMenu.Visible = false;
            // 
            // iconButton_givenDate
            // 
            this.iconButton_givenDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_givenDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_givenDate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_givenDate.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.iconButton_givenDate.IconColor = System.Drawing.Color.Black;
            this.iconButton_givenDate.IconSize = 28;
            this.iconButton_givenDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_givenDate.Location = new System.Drawing.Point(236, 0);
            this.iconButton_givenDate.Name = "iconButton_givenDate";
            this.iconButton_givenDate.Rotation = 0D;
            this.iconButton_givenDate.Size = new System.Drawing.Size(118, 46);
            this.iconButton_givenDate.TabIndex = 5;
            this.iconButton_givenDate.Text = "     Приведена дата";
            this.iconButton_givenDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_givenDate.UseVisualStyleBackColor = true;
            this.iconButton_givenDate.Click += new System.EventHandler(this.iconButton_givenDate_Click);
            // 
            // comboBox_names
            // 
            this.comboBox_names.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox_names.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_names.FormattingEnabled = true;
            this.comboBox_names.Location = new System.Drawing.Point(399, 0);
            this.comboBox_names.Name = "comboBox_names";
            this.comboBox_names.Size = new System.Drawing.Size(410, 40);
            this.comboBox_names.TabIndex = 4;
            this.comboBox_names.TextChanged += new System.EventHandler(this.comboBox_names_TextChanged);
            this.comboBox_names.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_names_KeyPress);
            // 
            // iconButton_selectAllRecords
            // 
            this.iconButton_selectAllRecords.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_selectAllRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_selectAllRecords.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_selectAllRecords.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButton_selectAllRecords.IconColor = System.Drawing.Color.Black;
            this.iconButton_selectAllRecords.IconSize = 32;
            this.iconButton_selectAllRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_selectAllRecords.Location = new System.Drawing.Point(118, 0);
            this.iconButton_selectAllRecords.Name = "iconButton_selectAllRecords";
            this.iconButton_selectAllRecords.Rotation = 0D;
            this.iconButton_selectAllRecords.Size = new System.Drawing.Size(118, 46);
            this.iconButton_selectAllRecords.TabIndex = 3;
            this.iconButton_selectAllRecords.Text = "            Вибрати все";
            this.iconButton_selectAllRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_selectAllRecords.UseVisualStyleBackColor = true;
            this.iconButton_selectAllRecords.Click += new System.EventHandler(this.iconButton_selectAllRecords_Click);
            // 
            // iconButton_deleteCheckedRecords
            // 
            this.iconButton_deleteCheckedRecords.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_deleteCheckedRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_deleteCheckedRecords.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_deleteCheckedRecords.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton_deleteCheckedRecords.IconColor = System.Drawing.Color.Black;
            this.iconButton_deleteCheckedRecords.IconSize = 32;
            this.iconButton_deleteCheckedRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_deleteCheckedRecords.Location = new System.Drawing.Point(0, 0);
            this.iconButton_deleteCheckedRecords.Name = "iconButton_deleteCheckedRecords";
            this.iconButton_deleteCheckedRecords.Rotation = 0D;
            this.iconButton_deleteCheckedRecords.Size = new System.Drawing.Size(118, 46);
            this.iconButton_deleteCheckedRecords.TabIndex = 2;
            this.iconButton_deleteCheckedRecords.Text = "            Видалити";
            this.iconButton_deleteCheckedRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_deleteCheckedRecords.UseVisualStyleBackColor = true;
            this.iconButton_deleteCheckedRecords.Click += new System.EventHandler(this.Button_deleteChekedRecords_Click);
            // 
            // panel_experiences
            // 
            this.panel_experiences.BackColor = System.Drawing.Color.GhostWhite;
            this.panel_experiences.Controls.Add(this.label_avgExperience);
            this.panel_experiences.Controls.Add(this.label_stateExperience);
            this.panel_experiences.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_experiences.Location = new System.Drawing.Point(175, 515);
            this.panel_experiences.Name = "panel_experiences";
            this.panel_experiences.Size = new System.Drawing.Size(809, 46);
            this.panel_experiences.TabIndex = 5;
            this.panel_experiences.Visible = false;
            // 
            // label_avgExperience
            // 
            this.label_avgExperience.AutoSize = true;
            this.label_avgExperience.BackColor = System.Drawing.Color.Transparent;
            this.label_avgExperience.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_avgExperience.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_avgExperience.Location = new System.Drawing.Point(393, 0);
            this.label_avgExperience.Name = "label_avgExperience";
            this.label_avgExperience.Size = new System.Drawing.Size(208, 36);
            this.label_avgExperience.TabIndex = 1;
            this.label_avgExperience.Text = "0 р. 0 м. 0 д. ";
            // 
            // label_stateExperience
            // 
            this.label_stateExperience.AutoSize = true;
            this.label_stateExperience.BackColor = System.Drawing.Color.Transparent;
            this.label_stateExperience.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_stateExperience.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_stateExperience.Location = new System.Drawing.Point(601, 0);
            this.label_stateExperience.Name = "label_stateExperience";
            this.label_stateExperience.Size = new System.Drawing.Size(208, 36);
            this.label_stateExperience.TabIndex = 0;
            this.label_stateExperience.Text = "0 р. 0 м. 0 д. ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_experiences);
            this.Controls.Add(this.panel_formMenu);
            this.Controls.Add(this.elementHost_form);
            this.Controls.Add(this.panel_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(868, 402);
            this.Name = "FormMain";
            this.Text = "HR Calculator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_formMenu.ResumeLayout(false);
            this.panel_experiences.ResumeLayout(false);
            this.panel_experiences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_bar;
        private FontAwesome.Sharp.IconButton button_dataBase;
        private FontAwesome.Sharp.IconButton button_expirience;
        private FontAwesome.Sharp.IconButton button_bar;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Integration.ElementHost elementHost_form;
        private System.Windows.Forms.Panel panel_formMenu;
        private FontAwesome.Sharp.IconButton iconButton_deleteCheckedRecords;
        private FontAwesome.Sharp.IconButton iconButton_selectAllRecords;
        public System.Windows.Forms.Label label_stateExperience;
        public System.Windows.Forms.Label label_avgExperience;
        public System.Windows.Forms.Panel panel_experiences;
        public System.Windows.Forms.Panel panel_form;
        public System.Windows.Forms.ComboBox comboBox_names;
        private FontAwesome.Sharp.IconButton button_vacationCalc;
        private FontAwesome.Sharp.IconButton iconButton_givenDate;
        private FontAwesome.Sharp.IconButton button_rankAfterDecree;
    }
}

