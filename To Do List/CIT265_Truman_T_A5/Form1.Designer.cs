namespace CIT265_Truman_T_A5
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.quit_button = new System.Windows.Forms.Button();
            this.add_activity = new System.Windows.Forms.Button();
            this.remove_activity = new System.Windows.Forms.Button();
            this.sort_name = new System.Windows.Forms.Button();
            this.date_sort = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 12, 19, 2, 35, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // quit_button
            // 
            this.quit_button.Location = new System.Drawing.Point(342, 384);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(93, 23);
            this.quit_button.TabIndex = 7;
            this.quit_button.Text = "&Quit";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // add_activity
            // 
            this.add_activity.Location = new System.Drawing.Point(288, 81);
            this.add_activity.Name = "add_activity";
            this.add_activity.Size = new System.Drawing.Size(91, 23);
            this.add_activity.TabIndex = 1;
            this.add_activity.Text = "&Add an Activity";
            this.add_activity.UseVisualStyleBackColor = true;
            this.add_activity.Click += new System.EventHandler(this.add_activity_Click);
            // 
            // remove_activity
            // 
            this.remove_activity.Location = new System.Drawing.Point(380, 81);
            this.remove_activity.Name = "remove_activity";
            this.remove_activity.Size = new System.Drawing.Size(108, 23);
            this.remove_activity.TabIndex = 2;
            this.remove_activity.Text = "&Remove an Activity";
            this.remove_activity.UseVisualStyleBackColor = true;
            this.remove_activity.Click += new System.EventHandler(this.remove_activity_Click);
            // 
            // sort_name
            // 
            this.sort_name.Location = new System.Drawing.Point(288, 355);
            this.sort_name.Name = "sort_name";
            this.sort_name.Size = new System.Drawing.Size(93, 23);
            this.sort_name.TabIndex = 5;
            this.sort_name.Text = "Sort by &Name";
            this.sort_name.UseVisualStyleBackColor = true;
            this.sort_name.Click += new System.EventHandler(this.sort_name_Click);
            // 
            // date_sort
            // 
            this.date_sort.Location = new System.Drawing.Point(397, 355);
            this.date_sort.Name = "date_sort";
            this.date_sort.Size = new System.Drawing.Size(91, 23);
            this.date_sort.TabIndex = 6;
            this.date_sort.Text = "Sort by &Date";
            this.date_sort.UseVisualStyleBackColor = true;
            this.date_sort.Click += new System.EventHandler(this.date_sort_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(288, 228);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 121);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 97);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insert Event Description Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.date_sort);
            this.Controls.Add(this.sort_name);
            this.Controls.Add(this.remove_activity);
            this.Controls.Add(this.add_activity);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Button add_activity;
        private System.Windows.Forms.Button remove_activity;
        private System.Windows.Forms.Button sort_name;
        private System.Windows.Forms.Button date_sort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

