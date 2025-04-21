
namespace YearInputCalendarApp
{
    partial class EasterFormApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.bntOk = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a year:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(111, 14);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(78, 25);
            this.textBoxYear.TabIndex = 1;
            // 
            // bntOk
            // 
            this.bntOk.Location = new System.Drawing.Point(197, 10);
            this.bntOk.Margin = new System.Windows.Forms.Padding(4);
            this.bntOk.Name = "bntOk";
            this.bntOk.Size = new System.Drawing.Size(67, 30);
            this.bntOk.TabIndex = 2;
            this.bntOk.Text = "Ok";
            this.bntOk.UseVisualStyleBackColor = true;
            this.bntOk.Click += new System.EventHandler(this.bntOk_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(16, 55);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msg.Location = new System.Drawing.Point(0, 233);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 17);
            this.msg.TabIndex = 4;
            // 
            // EasterFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 250);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.bntOk);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EasterFormApp";
            this.Text = "Easter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button bntOk;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label msg;
    }
}

