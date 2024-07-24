namespace rabbinate
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWriting = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.cmdday = new System.Windows.Forms.ComboBox();
            this.cmbyear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDayOfTheMonth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "כתיבת תאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "שנה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "חודש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "היום בחודש";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "היום בשבוע";
            // 
            // btnWriting
            // 
            this.btnWriting.Location = new System.Drawing.Point(346, 245);
            this.btnWriting.Name = "btnWriting";
            this.btnWriting.Size = new System.Drawing.Size(135, 58);
            this.btnWriting.TabIndex = 9;
            this.btnWriting.Text = "כתיבה";
            this.btnWriting.UseVisualStyleBackColor = true;
            this.btnWriting.Click += new System.EventHandler(this.btnWriting_Click);
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(131, 363);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(567, 30);
            this.txtResults.TabIndex = 11;
            // 
            // cmdday
            // 
            this.cmdday.FormattingEnabled = true;
            this.cmdday.Items.AddRange(new object[] {
            "ראשון ",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "ששי"});
            this.cmdday.Location = new System.Drawing.Point(592, 176);
            this.cmdday.Name = "cmdday";
            this.cmdday.Size = new System.Drawing.Size(121, 24);
            this.cmdday.TabIndex = 12;
            // 
            // cmbyear
            // 
            this.cmbyear.FormattingEnabled = true;
            this.cmbyear.Items.AddRange(new object[] {
            "תשפד",
            "תשפ\"ה",
            "תשפ\"ו",
            "תשפ\"ז",
            "תשפ\"ח",
            "תשפ\"ט",
            "תש\"צ",
            "תשצ\"א",
            "תשצ\"ב",
            "תשצ\"ג"});
            this.cmbyear.Location = new System.Drawing.Point(147, 176);
            this.cmbyear.Name = "cmbyear";
            this.cmbyear.Size = new System.Drawing.Size(121, 24);
            this.cmbyear.TabIndex = 13;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשון",
            "כסלו",
            "טבת ",
            "שבט",
            "אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול"});
            this.cmbMonth.Location = new System.Drawing.Point(297, 176);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbMonth.TabIndex = 14;
            // 
            // cmbDayOfTheMonth
            // 
            this.cmbDayOfTheMonth.FormattingEnabled = true;
            this.cmbDayOfTheMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbDayOfTheMonth.Location = new System.Drawing.Point(440, 176);
            this.cmbDayOfTheMonth.Name = "cmbDayOfTheMonth";
            this.cmbDayOfTheMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbDayOfTheMonth.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDayOfTheMonth);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbyear);
            this.Controls.Add(this.cmdday);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnWriting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWriting;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.ComboBox cmdday;
        private System.Windows.Forms.ComboBox cmbyear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDayOfTheMonth;
    }
}

