namespace ExpCalc
{
    partial class UserControlList
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_data = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_checkBox = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_main.Controls.Add(this.label_data);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.button_checkBox);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(391, 39);
            this.panel_main.TabIndex = 0;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_data.Font = new System.Drawing.Font("Consolas", 9F);
            this.label_data.Location = new System.Drawing.Point(40, 8);
            this.label_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(0, 14);
            this.label_data.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(40, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 8);
            this.panel2.TabIndex = 3;
            // 
            // button_checkBox
            // 
            this.button_checkBox.BackColor = System.Drawing.Color.Snow;
            this.button_checkBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_checkBox.Location = new System.Drawing.Point(0, 0);
            this.button_checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.button_checkBox.Name = "button_checkBox";
            this.button_checkBox.Size = new System.Drawing.Size(40, 39);
            this.button_checkBox.TabIndex = 4;
            this.button_checkBox.UseVisualStyleBackColor = false;
            this.button_checkBox.Click += new System.EventHandler(this.Button_checkBox_Click);
            // 
            // UserControlList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel_main);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlList";
            this.Size = new System.Drawing.Size(391, 39);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button button_checkBox;
        public System.Windows.Forms.Panel panel_main;
        public System.Windows.Forms.Label label_data;
    }
}
