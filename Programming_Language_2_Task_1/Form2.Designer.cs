
namespace Programming_Language_2_Task_1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.average = new System.Windows.Forms.TextBox();
            this.final = new System.Windows.Forms.TextBox();
            this.midterm = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.lesson = new System.Windows.Forms.ComboBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.midtermLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.lessonLabel = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.average);
            this.panel1.Controls.Add(this.final);
            this.panel1.Controls.Add(this.midterm);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.fName);
            this.panel1.Controls.Add(this.lesson);
            this.panel1.Controls.Add(this.averageLabel);
            this.panel1.Controls.Add(this.finalLabel);
            this.panel1.Controls.Add(this.midtermLabel);
            this.panel1.Controls.Add(this.lNameLabel);
            this.panel1.Controls.Add(this.fNameLabel);
            this.panel1.Controls.Add(this.lessonLabel);
            this.panel1.Location = new System.Drawing.Point(55, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 233);
            this.panel1.TabIndex = 0;
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(112, 183);
            this.average.Margin = new System.Windows.Forms.Padding(2);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(147, 20);
            this.average.TabIndex = 44;
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(112, 149);
            this.final.Margin = new System.Windows.Forms.Padding(2);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(147, 20);
            this.final.TabIndex = 43;
            // 
            // midterm
            // 
            this.midterm.Location = new System.Drawing.Point(112, 116);
            this.midterm.Margin = new System.Windows.Forms.Padding(2);
            this.midterm.Name = "midterm";
            this.midterm.Size = new System.Drawing.Size(147, 20);
            this.midterm.TabIndex = 42;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(112, 85);
            this.lName.Margin = new System.Windows.Forms.Padding(2);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(147, 20);
            this.lName.TabIndex = 41;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(112, 54);
            this.fName.Margin = new System.Windows.Forms.Padding(2);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(147, 20);
            this.fName.TabIndex = 40;
            // 
            // lesson
            // 
            this.lesson.FormattingEnabled = true;
            this.lesson.Location = new System.Drawing.Point(112, 23);
            this.lesson.Margin = new System.Windows.Forms.Padding(2);
            this.lesson.Name = "lesson";
            this.lesson.Size = new System.Drawing.Size(148, 21);
            this.lesson.TabIndex = 39;
            this.lesson.SelectedIndexChanged += new System.EventHandler(this.lesson_SelectedIndexChanged);
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.Location = new System.Drawing.Point(39, 183);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(69, 17);
            this.averageLabel.TabIndex = 38;
            this.averageLabel.Text = "Average :";
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalLabel.Location = new System.Drawing.Point(62, 149);
            this.finalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(46, 17);
            this.finalLabel.TabIndex = 37;
            this.finalLabel.Text = "Final :";
            // 
            // midtermLabel
            // 
            this.midtermLabel.AutoSize = true;
            this.midtermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtermLabel.Location = new System.Drawing.Point(42, 116);
            this.midtermLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.midtermLabel.Name = "midtermLabel";
            this.midtermLabel.Size = new System.Drawing.Size(66, 17);
            this.midtermLabel.TabIndex = 36;
            this.midtermLabel.Text = "Midterm :";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLabel.Location = new System.Drawing.Point(24, 85);
            this.lNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(84, 17);
            this.lNameLabel.TabIndex = 35;
            this.lNameLabel.Text = "Last Name :";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(24, 54);
            this.fNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(84, 17);
            this.fNameLabel.TabIndex = 34;
            this.fNameLabel.Text = "First Name :";
            // 
            // lessonLabel
            // 
            this.lessonLabel.AutoSize = true;
            this.lessonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLabel.Location = new System.Drawing.Point(46, 23);
            this.lessonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lessonLabel.Name = "lessonLabel";
            this.lessonLabel.Size = new System.Drawing.Size(62, 17);
            this.lessonLabel.TabIndex = 33;
            this.lessonLabel.Text = "Lesson :";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(66, 284);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(131, 34);
            this.close.TabIndex = 56;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(221, 284);
            this.ok.Margin = new System.Windows.Forms.Padding(2);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(131, 34);
            this.ok.TabIndex = 57;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 363);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label midtermLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lessonLabel;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button ok;
        public System.Windows.Forms.ComboBox lesson;
        public System.Windows.Forms.TextBox lName;
        public System.Windows.Forms.TextBox fName;
        public System.Windows.Forms.TextBox average;
        public System.Windows.Forms.TextBox final;
        public System.Windows.Forms.TextBox midterm;
    }
}