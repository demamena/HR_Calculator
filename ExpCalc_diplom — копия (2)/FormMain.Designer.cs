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
            this.panel_vacationsMenu = new System.Windows.Forms.Panel();
            this.button_decreeHospitalVacation = new FontAwesome.Sharp.IconButton();
            this.button_vacationCalc = new FontAwesome.Sharp.IconButton();
            this.button_vacationAfterDecree = new FontAwesome.Sharp.IconButton();
            this.iconButton_vacations = new FontAwesome.Sharp.IconButton();
            this.panel_experiencesMenu = new System.Windows.Forms.Panel();
            this.button_expirience = new FontAwesome.Sharp.IconButton();
            this.button_rankAfterDecree = new FontAwesome.Sharp.IconButton();
            this.iconButton_experiences = new FontAwesome.Sharp.IconButton();
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
            this.panel_vacationsMenu.SuspendLayout();
            this.panel_experiencesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_formMenu.SuspendLayout();
            this.panel_experiences.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(110)))));
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.panel_bar);
            this.panel_menu.Controls.Add(this.button_bar);
            this.panel_menu.Controls.Add(this.pictureBox_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(175, 568);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_bar
            // 
            this.panel_bar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_bar.BackColor = System.Drawing.Color.Transparent;
            this.panel_bar.Controls.Add(this.button_dataBase);
            this.panel_bar.Controls.Add(this.panel_vacationsMenu);
            this.panel_bar.Controls.Add(this.iconButton_vacations);
            this.panel_bar.Controls.Add(this.panel_experiencesMenu);
            this.panel_bar.Controls.Add(this.iconButton_experiences);
            this.panel_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_bar.Location = new System.Drawing.Point(0, 153);
            this.panel_bar.Name = "panel_bar";
            this.panel_bar.Size = new System.Drawing.Size(173, 405);
            this.panel_bar.TabIndex = 3;
            // 
            // button_dataBase
            // 
            this.button_dataBase.BackColor = System.Drawing.Color.Transparent;
            this.button_dataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dataBase.FlatAppearance.BorderSize = 0;
            this.button_dataBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.button_dataBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.button_dataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dataBase.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_dataBase.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_dataBase.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.button_dataBase.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.button_dataBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_dataBase.IconSize = 28;
            this.button_dataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dataBase.Location = new System.Drawing.Point(0, 215);
            this.button_dataBase.Name = "button_dataBase";
            this.button_dataBase.Size = new System.Drawing.Size(173, 31);
            this.button_dataBase.TabIndex = 1;
            this.button_dataBase.Text = "База даних";
            this.button_dataBase.UseVisualStyleBackColor = false;
            this.button_dataBase.Click += new System.EventHandler(this.Button_dataBase_Click);
            // 
            // panel_vacationsMenu
            // 
            this.panel_vacationsMenu.BackColor = System.Drawing.Color.Transparent;
            this.panel_vacationsMenu.Controls.Add(this.button_decreeHospitalVacation);
            this.panel_vacationsMenu.Controls.Add(this.button_vacationCalc);
            this.panel_vacationsMenu.Controls.Add(this.button_vacationAfterDecree);
            this.panel_vacationsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_vacationsMenu.Location = new System.Drawing.Point(0, 122);
            this.panel_vacationsMenu.Name = "panel_vacationsMenu";
            this.panel_vacationsMenu.Size = new System.Drawing.Size(173, 93);
            this.panel_vacationsMenu.TabIndex = 8;
            this.panel_vacationsMenu.Visible = false;
            // 
            // button_decreeHospitalVacation
            // 
            this.button_decreeHospitalVacation.BackColor = System.Drawing.Color.Transparent;
            this.button_decreeHospitalVacation.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_decreeHospitalVacation.FlatAppearance.BorderSize = 0;
            this.button_decreeHospitalVacation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.button_decreeHospitalVacation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.button_decreeHospitalVacation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_decreeHospitalVacation.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_decreeHospitalVacation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_decreeHospitalVacation.IconChar = FontAwesome.Sharp.IconChar.None;
            this.button_decreeHospitalVacation.IconColor = System.Drawing.Color.Black;
            this.button_decreeHospitalVacation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_decreeHospitalVacation.IconSize = 32;
            this.button_decreeHospitalVacation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_decreeHospitalVacation.Location = new System.Drawing.Point(0, 62);
            this.button_decreeHospitalVacation.Name = "button_decreeHospitalVacation";
            this.button_decreeHospitalVacation.Size = new System.Drawing.Size(173, 31);
            this.button_decreeHospitalVacation.TabIndex = 5;
            this.button_decreeHospitalVacation.Text = "Декретний лікарняний";
            this.button_decreeHospitalVacation.UseVisualStyleBackColor = false;
            this.button_decreeHospitalVacation.Click += new System.EventHandler(this.button_decreeHospitalVacation_Click);
            // 
            // button_vacationCalc
            // 
            this.button_vacationCalc.BackColor = System.Drawing.Color.Transparent;
            this.button_vacationCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_vacationCalc.FlatAppearance.BorderSize = 0;
            this.button_vacationCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.button_vacationCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.button_vacationCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vacationCalc.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_vacationCalc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_vacationCalc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.button_vacationCalc.IconColor = System.Drawing.Color.Black;
            this.button_vacationCalc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_vacationCalc.IconSize = 32;
            this.button_vacationCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_vacationCalc.Location = new System.Drawing.Point(0, 31);
            this.button_vacationCalc.Name = "button_vacationCalc";
            this.button_vacationCalc.Size = new System.Drawing.Size(173, 31);
            this.button_vacationCalc.TabIndex = 2;
            this.button_vacationCalc.Text = "Відпустка";
            this.button_vacationCalc.UseVisualStyleBackColor = false;
            this.button_vacationCalc.Click += new System.EventHandler(this.button_vacationCalc_Click);
            // 
            // button_vacationAfterDecree
            // 
            this.button_vacationAfterDecree.BackColor = System.Drawing.Color.Transparent;
            this.button_vacationAfterDecree.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_vacationAfterDecree.FlatAppearance.BorderSize = 0;
            this.button_vacationAfterDecree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.button_vacationAfterDecree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.button_vacationAfterDecree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vacationAfterDecree.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_vacationAfterDecree.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_vacationAfterDecree.IconChar = FontAwesome.Sharp.IconChar.None;
            this.button_vacationAfterDecree.IconColor = System.Drawing.Color.Black;
            this.button_vacationAfterDecree.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_vacationAfterDecree.IconSize = 32;
            this.button_vacationAfterDecree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_vacationAfterDecree.Location = new System.Drawing.Point(0, 0);
            this.button_vacationAfterDecree.Name = "button_vacationAfterDecree";
            this.button_vacationAfterDecree.Size = new System.Drawing.Size(173, 31);
            this.button_vacationAfterDecree.TabIndex = 4;
            this.button_vacationAfterDecree.Text = "Відпустка після ДВ";
            this.button_vacationAfterDecree.UseVisualStyleBackColor = false;
            this.button_vacationAfterDecree.Click += new System.EventHandler(this.button_vacationAfterDecree_Click);
            // 
            // iconButton_vacations
            // 
            this.iconButton_vacations.BackColor = System.Drawing.Color.Transparent;
            this.iconButton_vacations.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_vacations.FlatAppearance.BorderSize = 0;
            this.iconButton_vacations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.iconButton_vacations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.iconButton_vacations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_vacations.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton_vacations.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton_vacations.IconChar = FontAwesome.Sharp.IconChar.GlobeAsia;
            this.iconButton_vacations.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.iconButton_vacations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_vacations.IconSize = 28;
            this.iconButton_vacations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_vacations.Location = new System.Drawing.Point(0, 91);
            this.iconButton_vacations.Name = "iconButton_vacations";
            this.iconButton_vacations.Size = new System.Drawing.Size(173, 31);
            this.iconButton_vacations.TabIndex = 6;
            this.iconButton_vacations.Text = "Відпустки";
            this.iconButton_vacations.UseVisualStyleBackColor = false;
            this.iconButton_vacations.Click += new System.EventHandler(this.iconButton_vacations_Click);
            // 
            // panel_experiencesMenu
            // 
            this.panel_experiencesMenu.BackColor = System.Drawing.Color.Transparent;
            this.panel_experiencesMenu.Controls.Add(this.button_expirience);
            this.panel_experiencesMenu.Controls.Add(this.button_rankAfterDecree);
            this.panel_experiencesMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_experiencesMenu.Location = new System.Drawing.Point(0, 31);
            this.panel_experiencesMenu.Name = "panel_experiencesMenu";
            this.panel_experiencesMenu.Size = new System.Drawing.Size(173, 60);
            this.panel_experiencesMenu.TabIndex = 7;
            this.panel_experiencesMenu.Visible = false;
            // 
            // button_expirience
            // 
            this.button_expirience.BackColor = System.Drawing.Color.Transparent;
            this.button_expirience.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_expirience.FlatAppearance.BorderSize = 0;
            this.button_expirience.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.button_expirience.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.button_expirience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_expirience.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_expirience.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_expirience.IconChar = FontAwesome.Sharp.IconChar.None;
            this.button_expirience.IconColor = System.Drawing.Color.Black;
            this.button_expirience.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_expirience.IconSize = 32;
            this.button_expirience.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_expirience.Location = new System.Drawing.Point(0, 31);
            this.button_expirience.Name = "button_expirience";
            this.button_expirience.Size = new System.Drawing.Size(173, 29);
            this.button_expirience.TabIndex = 0;
            this.button_expirience.Text = "Стаж";
            this.button_expirience.UseVisualStyleBackColor = false;
            this.button_expirience.Click += new System.EventHandler(this.button_expirience_Click);
            // 
            // button_rankAfterDecree
            // 
            this.button_rankAfterDecree.BackColor = System.Drawing.Color.Transparent;
            this.button_rankAfterDecree.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_rankAfterDecree.FlatAppearance.BorderSize = 0;
            this.button_rankAfterDecree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.button_rankAfterDecree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.button_rankAfterDecree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rankAfterDecree.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_rankAfterDecree.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_rankAfterDecree.IconChar = FontAwesome.Sharp.IconChar.None;
            this.button_rankAfterDecree.IconColor = System.Drawing.Color.Black;
            this.button_rankAfterDecree.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_rankAfterDecree.IconSize = 32;
            this.button_rankAfterDecree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rankAfterDecree.Location = new System.Drawing.Point(0, 0);
            this.button_rankAfterDecree.Name = "button_rankAfterDecree";
            this.button_rankAfterDecree.Size = new System.Drawing.Size(173, 31);
            this.button_rankAfterDecree.TabIndex = 3;
            this.button_rankAfterDecree.Text = "Ранг після ДВ";
            this.button_rankAfterDecree.UseVisualStyleBackColor = false;
            this.button_rankAfterDecree.Click += new System.EventHandler(this.button_rankAfterDecree_Click);
            // 
            // iconButton_experiences
            // 
            this.iconButton_experiences.BackColor = System.Drawing.Color.Transparent;
            this.iconButton_experiences.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_experiences.FlatAppearance.BorderSize = 0;
            this.iconButton_experiences.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.iconButton_experiences.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.iconButton_experiences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_experiences.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton_experiences.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton_experiences.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton_experiences.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.iconButton_experiences.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_experiences.IconSize = 28;
            this.iconButton_experiences.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_experiences.Location = new System.Drawing.Point(0, 0);
            this.iconButton_experiences.Name = "iconButton_experiences";
            this.iconButton_experiences.Size = new System.Drawing.Size(173, 31);
            this.iconButton_experiences.TabIndex = 5;
            this.iconButton_experiences.Text = "Стажі та ранги";
            this.iconButton_experiences.UseVisualStyleBackColor = false;
            this.iconButton_experiences.Click += new System.EventHandler(this.iconButton_experiences_Click);
            // 
            // button_bar
            // 
            this.button_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.button_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_bar.FlatAppearance.BorderSize = 0;
            this.button_bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bar.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_bar.ForeColor = System.Drawing.SystemColors.Window;
            this.button_bar.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.button_bar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.button_bar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_bar.IconSize = 32;
            this.button_bar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bar.Location = new System.Drawing.Point(0, 114);
            this.button_bar.Name = "button_bar";
            this.button_bar.Size = new System.Drawing.Size(173, 39);
            this.button_bar.TabIndex = 4;
            this.button_bar.Text = "Функції";
            this.button_bar.UseVisualStyleBackColor = false;
            this.button_bar.Click += new System.EventHandler(this.button_bar_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.pictureBox_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_logo.Image = global::HRCalculator.Properties.Resources.Emblem_of_the_State_Statistics_Service_of_Ukraine;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(173, 114);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 1;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox_logo_Click);
            // 
            // elementHost_form
            // 
            this.elementHost_form.BackColor = System.Drawing.Color.White;
            this.elementHost_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost_form.Location = new System.Drawing.Point(175, 0);
            this.elementHost_form.Name = "elementHost_form";
            this.elementHost_form.Size = new System.Drawing.Size(870, 568);
            this.elementHost_form.TabIndex = 1;
            this.elementHost_form.Text = "elementHost1";
            this.elementHost_form.Child = null;
            // 
            // panel_form
            // 
            this.panel_form.AutoScroll = true;
            this.panel_form.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(175, 46);
            this.panel_form.Margin = new System.Windows.Forms.Padding(2);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(870, 476);
            this.panel_form.TabIndex = 2;
            this.panel_form.Visible = false;
            // 
            // panel_formMenu
            // 
            this.panel_formMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(110)))));
            this.panel_formMenu.Controls.Add(this.iconButton_givenDate);
            this.panel_formMenu.Controls.Add(this.comboBox_names);
            this.panel_formMenu.Controls.Add(this.iconButton_selectAllRecords);
            this.panel_formMenu.Controls.Add(this.iconButton_deleteCheckedRecords);
            this.panel_formMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_formMenu.Location = new System.Drawing.Point(175, 0);
            this.panel_formMenu.Name = "panel_formMenu";
            this.panel_formMenu.Size = new System.Drawing.Size(870, 46);
            this.panel_formMenu.TabIndex = 4;
            this.panel_formMenu.Visible = false;
            // 
            // iconButton_givenDate
            // 
            this.iconButton_givenDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_givenDate.FlatAppearance.BorderSize = 0;
            this.iconButton_givenDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.iconButton_givenDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.iconButton_givenDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_givenDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton_givenDate.ForeColor = System.Drawing.Color.White;
            this.iconButton_givenDate.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.iconButton_givenDate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.iconButton_givenDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_givenDate.IconSize = 28;
            this.iconButton_givenDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_givenDate.Location = new System.Drawing.Point(248, 0);
            this.iconButton_givenDate.Name = "iconButton_givenDate";
            this.iconButton_givenDate.Size = new System.Drawing.Size(129, 46);
            this.iconButton_givenDate.TabIndex = 5;
            this.iconButton_givenDate.Text = "Приведена дата";
            this.iconButton_givenDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_givenDate.UseVisualStyleBackColor = true;
            this.iconButton_givenDate.Click += new System.EventHandler(this.iconButton_givenDate_Click);
            // 
            // comboBox_names
            // 
            this.comboBox_names.BackColor = System.Drawing.Color.White;
            this.comboBox_names.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox_names.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_names.FormattingEnabled = true;
            this.comboBox_names.Location = new System.Drawing.Point(498, 0);
            this.comboBox_names.Margin = new System.Windows.Forms.Padding(20);
            this.comboBox_names.Name = "comboBox_names";
            this.comboBox_names.Size = new System.Drawing.Size(372, 35);
            this.comboBox_names.TabIndex = 4;
            this.comboBox_names.TextChanged += new System.EventHandler(this.comboBox_names_TextChanged);
            this.comboBox_names.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_names_KeyPress);
            // 
            // iconButton_selectAllRecords
            // 
            this.iconButton_selectAllRecords.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_selectAllRecords.FlatAppearance.BorderSize = 0;
            this.iconButton_selectAllRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.iconButton_selectAllRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.iconButton_selectAllRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_selectAllRecords.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton_selectAllRecords.ForeColor = System.Drawing.Color.White;
            this.iconButton_selectAllRecords.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButton_selectAllRecords.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.iconButton_selectAllRecords.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_selectAllRecords.IconSize = 32;
            this.iconButton_selectAllRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_selectAllRecords.Location = new System.Drawing.Point(114, 0);
            this.iconButton_selectAllRecords.Name = "iconButton_selectAllRecords";
            this.iconButton_selectAllRecords.Size = new System.Drawing.Size(134, 46);
            this.iconButton_selectAllRecords.TabIndex = 3;
            this.iconButton_selectAllRecords.Text = "Вибрати все";
            this.iconButton_selectAllRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_selectAllRecords.UseVisualStyleBackColor = true;
            this.iconButton_selectAllRecords.Click += new System.EventHandler(this.iconButton_selectAllRecords_Click);
            // 
            // iconButton_deleteCheckedRecords
            // 
            this.iconButton_deleteCheckedRecords.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_deleteCheckedRecords.FlatAppearance.BorderSize = 0;
            this.iconButton_deleteCheckedRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.iconButton_deleteCheckedRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.iconButton_deleteCheckedRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_deleteCheckedRecords.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton_deleteCheckedRecords.ForeColor = System.Drawing.Color.White;
            this.iconButton_deleteCheckedRecords.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton_deleteCheckedRecords.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(33)))));
            this.iconButton_deleteCheckedRecords.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_deleteCheckedRecords.IconSize = 32;
            this.iconButton_deleteCheckedRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_deleteCheckedRecords.Location = new System.Drawing.Point(0, 0);
            this.iconButton_deleteCheckedRecords.Name = "iconButton_deleteCheckedRecords";
            this.iconButton_deleteCheckedRecords.Size = new System.Drawing.Size(114, 46);
            this.iconButton_deleteCheckedRecords.TabIndex = 2;
            this.iconButton_deleteCheckedRecords.Text = "Видалити";
            this.iconButton_deleteCheckedRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_deleteCheckedRecords.UseVisualStyleBackColor = true;
            this.iconButton_deleteCheckedRecords.Click += new System.EventHandler(this.Button_deleteChekedRecords_Click);
            // 
            // panel_experiences
            // 
            this.panel_experiences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(110)))));
            this.panel_experiences.Controls.Add(this.label_avgExperience);
            this.panel_experiences.Controls.Add(this.label_stateExperience);
            this.panel_experiences.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_experiences.Location = new System.Drawing.Point(175, 522);
            this.panel_experiences.Name = "panel_experiences";
            this.panel_experiences.Size = new System.Drawing.Size(870, 46);
            this.panel_experiences.TabIndex = 5;
            this.panel_experiences.Visible = false;
            // 
            // label_avgExperience
            // 
            this.label_avgExperience.AutoSize = true;
            this.label_avgExperience.BackColor = System.Drawing.Color.Transparent;
            this.label_avgExperience.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_avgExperience.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_avgExperience.ForeColor = System.Drawing.Color.White;
            this.label_avgExperience.Location = new System.Drawing.Point(454, 0);
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
            this.label_stateExperience.ForeColor = System.Drawing.Color.White;
            this.label_stateExperience.Location = new System.Drawing.Point(662, 0);
            this.label_stateExperience.Name = "label_stateExperience";
            this.label_stateExperience.Size = new System.Drawing.Size(208, 36);
            this.label_stateExperience.TabIndex = 0;
            this.label_stateExperience.Text = "0 р. 0 м. 0 д. ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 568);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_experiences);
            this.Controls.Add(this.panel_formMenu);
            this.Controls.Add(this.elementHost_form);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(868, 402);
            this.Name = "FormMain";
            this.Text = "HR Calculator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_bar.ResumeLayout(false);
            this.panel_vacationsMenu.ResumeLayout(false);
            this.panel_experiencesMenu.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton button_vacationAfterDecree;
        private System.Windows.Forms.Panel panel_experiencesMenu;
        private FontAwesome.Sharp.IconButton iconButton_vacations;
        private FontAwesome.Sharp.IconButton iconButton_experiences;
        private System.Windows.Forms.Panel panel_vacationsMenu;
        private FontAwesome.Sharp.IconButton button_decreeHospitalVacation;
    }
}

