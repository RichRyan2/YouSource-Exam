namespace YouSource_Exam
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
            this.StringToSort = new System.Windows.Forms.TextBox();
            this.StringLabel = new System.Windows.Forms.Label();
            this.AlgoLabel = new System.Windows.Forms.Label();
            this.SortingAlgo = new System.Windows.Forms.ComboBox();
            this.Sort = new System.Windows.Forms.Button();
            this.SortedString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StringToSort
            // 
            this.StringToSort.Location = new System.Drawing.Point(28, 72);
            this.StringToSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StringToSort.Name = "StringToSort";
            this.StringToSort.Size = new System.Drawing.Size(214, 20);
            this.StringToSort.TabIndex = 0;
            // 
            // StringLabel
            // 
            this.StringLabel.AutoSize = true;
            this.StringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringLabel.Location = new System.Drawing.Point(24, 50);
            this.StringLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StringLabel.Name = "StringLabel";
            this.StringLabel.Size = new System.Drawing.Size(140, 20);
            this.StringLabel.TabIndex = 1;
            this.StringLabel.Text = "Place string below:";
            // 
            // AlgoLabel
            // 
            this.AlgoLabel.AutoSize = true;
            this.AlgoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgoLabel.Location = new System.Drawing.Point(24, 119);
            this.AlgoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlgoLabel.Name = "AlgoLabel";
            this.AlgoLabel.Size = new System.Drawing.Size(168, 20);
            this.AlgoLabel.TabIndex = 2;
            this.AlgoLabel.Text = "Select sorting method:";
            // 
            // SortingAlgo
            // 
            this.SortingAlgo.AllowDrop = true;
            this.SortingAlgo.AutoCompleteMode = global::YouSource_Exam.Properties.Settings.Default.SortingAlgoAutocomplete;
            this.SortingAlgo.Cursor = System.Windows.Forms.Cursors.Default;
            this.SortingAlgo.DataBindings.Add(new System.Windows.Forms.Binding("AutoCompleteMode", global::YouSource_Exam.Properties.Settings.Default, "SortingAlgoAutocomplete", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SortingAlgo.FormattingEnabled = true;
            this.SortingAlgo.Items.AddRange(new object[] {
            "Bubble Sort",
            "Quick Sort"});
            this.SortingAlgo.Location = new System.Drawing.Point(28, 142);
            this.SortingAlgo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SortingAlgo.MaxDropDownItems = 3;
            this.SortingAlgo.Name = "SortingAlgo";
            this.SortingAlgo.Size = new System.Drawing.Size(110, 21);
            this.SortingAlgo.TabIndex = 3;
            this.SortingAlgo.Tag = "";
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(28, 195);
            this.Sort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(70, 29);
            this.Sort.TabIndex = 4;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // SortedString
            // 
            this.SortedString.AutoSize = true;
            this.SortedString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortedString.Location = new System.Drawing.Point(26, 248);
            this.SortedString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SortedString.MaximumSize = new System.Drawing.Size(300, 300);
            this.SortedString.Name = "SortedString";
            this.SortedString.Size = new System.Drawing.Size(0, 20);
            this.SortedString.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.SortedString);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.SortingAlgo);
            this.Controls.Add(this.AlgoLabel);
            this.Controls.Add(this.StringLabel);
            this.Controls.Add(this.StringToSort);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StringToSort;
        private System.Windows.Forms.Label StringLabel;
        private System.Windows.Forms.Label AlgoLabel;
        private System.Windows.Forms.ComboBox SortingAlgo;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Label SortedString;
    }
}

