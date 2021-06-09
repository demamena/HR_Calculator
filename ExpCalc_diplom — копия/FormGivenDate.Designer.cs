namespace HRCalculator
{
    partial class FormGivenDate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGivenDate));
            this.elementHost_givenDate = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // elementHost_givenDate
            // 
            this.elementHost_givenDate.BackColor = System.Drawing.Color.White;
            this.elementHost_givenDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost_givenDate.Location = new System.Drawing.Point(0, 0);
            this.elementHost_givenDate.Name = "elementHost_givenDate";
            this.elementHost_givenDate.Size = new System.Drawing.Size(579, 181);
            this.elementHost_givenDate.TabIndex = 0;
            this.elementHost_givenDate.Text = "elementHost1";
            this.elementHost_givenDate.Child = null;
            // 
            // FormGivenDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 181);
            this.Controls.Add(this.elementHost_givenDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGivenDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Розрахунок приведенної дати";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost_givenDate;
    }
}