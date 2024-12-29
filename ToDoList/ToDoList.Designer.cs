namespace ToDoList
{
    partial class Menu
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
            this.Tasks = new System.Windows.Forms.Button();
            this.Informations = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tasks
            // 
            this.Tasks.Location = new System.Drawing.Point(136, 115);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(215, 64);
            this.Tasks.TabIndex = 1;
            this.Tasks.Text = "Tasks";
            this.Tasks.UseVisualStyleBackColor = true;
            // 
            // Informations
            // 
            this.Informations.Location = new System.Drawing.Point(136, 205);
            this.Informations.Name = "Informations";
            this.Informations.Size = new System.Drawing.Size(215, 64);
            this.Informations.TabIndex = 1;
            this.Informations.Text = "Informations";
            this.Informations.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(136, 289);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(215, 64);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 661);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Informations);
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(504, 700);
            this.MinimumSize = new System.Drawing.Size(504, 700);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Tasks;
        private System.Windows.Forms.Button Informations;
        private System.Windows.Forms.Button Exit;
    }
}

