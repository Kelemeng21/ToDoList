namespace Tasks
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.easyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.mediumRichTextBox = new System.Windows.Forms.RichTextBox();
            this.hardRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TaskInputTextBox = new System.Windows.Forms.TextBox();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SelectedTaskInput = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // easyRichTextBox
            // 
            this.easyRichTextBox.BackColor = System.Drawing.Color.Lavender;
            this.easyRichTextBox.Location = new System.Drawing.Point(4, 100);
            this.easyRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.easyRichTextBox.Name = "easyRichTextBox";
            this.easyRichTextBox.ReadOnly = true;
            this.easyRichTextBox.Size = new System.Drawing.Size(150, 285);
            this.easyRichTextBox.TabIndex = 0;
            this.easyRichTextBox.Text = "";
            // 
            // mediumRichTextBox
            // 
            this.mediumRichTextBox.BackColor = System.Drawing.Color.Lavender;
            this.mediumRichTextBox.Location = new System.Drawing.Point(169, 100);
            this.mediumRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mediumRichTextBox.Name = "mediumRichTextBox";
            this.mediumRichTextBox.ReadOnly = true;
            this.mediumRichTextBox.Size = new System.Drawing.Size(150, 285);
            this.mediumRichTextBox.TabIndex = 1;
            this.mediumRichTextBox.Text = "";
            // 
            // hardRichTextBox
            // 
            this.hardRichTextBox.BackColor = System.Drawing.Color.Lavender;
            this.hardRichTextBox.Location = new System.Drawing.Point(334, 100);
            this.hardRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.hardRichTextBox.Name = "hardRichTextBox";
            this.hardRichTextBox.ReadOnly = true;
            this.hardRichTextBox.Size = new System.Drawing.Size(150, 285);
            this.hardRichTextBox.TabIndex = 2;
            this.hardRichTextBox.Text = "";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "easy",
            "hard",
            "medium"});
            this.CategoryComboBox.Location = new System.Drawing.Point(334, 400);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(150, 21);
            this.CategoryComboBox.Sorted = true;
            this.CategoryComboBox.TabIndex = 3;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // TaskInputTextBox
            // 
            this.TaskInputTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TaskInputTextBox.Location = new System.Drawing.Point(4, 400);
            this.TaskInputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskInputTextBox.Multiline = true;
            this.TaskInputTextBox.Name = "TaskInputTextBox";
            this.TaskInputTextBox.Size = new System.Drawing.Size(150, 40);
            this.TaskInputTextBox.TabIndex = 4;
            this.TaskInputTextBox.TextChanged += new System.EventHandler(this.TaskInputTextBox_TextChanged);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(170, 400);
            this.AddTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(150, 40);
            this.AddTaskButton.TabIndex = 5;
            this.AddTaskButton.Text = "Add Task";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click_1);
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.Location = new System.Drawing.Point(170, 454);
            this.RemoveTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Size = new System.Drawing.Size(150, 40);
            this.RemoveTaskButton.TabIndex = 6;
            this.RemoveTaskButton.Text = "Remove Task";
            this.RemoveTaskButton.UseVisualStyleBackColor = true;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click_1);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(334, 454);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 40);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save Tasks";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // SelectedTaskInput
            // 
            this.SelectedTaskInput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SelectedTaskInput.Location = new System.Drawing.Point(4, 454);
            this.SelectedTaskInput.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedTaskInput.Multiline = true;
            this.SelectedTaskInput.Name = "SelectedTaskInput";
            this.SelectedTaskInput.Size = new System.Drawing.Size(150, 40);
            this.SelectedTaskInput.TabIndex = 8;
            this.SelectedTaskInput.TextChanged += new System.EventHandler(this.SelectedTaskInput_TextChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LevelLabel.Location = new System.Drawing.Point(8, 13);
            this.LevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(67, 21);
            this.LevelLabel.TabIndex = 9;
            this.LevelLabel.Text = "Level: 1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Easy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(160, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 53);
            this.label2.TabIndex = 10;
            this.label2.Text = "medium";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(330, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 53);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hard";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(3, 558);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(150, 40);
            this.Menu.TabIndex = 11;
            this.Menu.Text = "Home";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(334, 558);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 40);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.progressBar1.Location = new System.Drawing.Point(114, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 12;
            this.progressBar1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Tasks.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(488, 661);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.SelectedTaskInput);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RemoveTaskButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.TaskInputTextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.hardRichTextBox);
            this.Controls.Add(this.mediumRichTextBox);
            this.Controls.Add(this.easyRichTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RichTextBox easyRichTextBox;
        private System.Windows.Forms.RichTextBox mediumRichTextBox;
        private System.Windows.Forms.RichTextBox hardRichTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox TaskInputTextBox;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button RemoveTaskButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SelectedTaskInput;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
