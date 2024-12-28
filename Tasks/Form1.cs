using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tasks
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public string EasyTasksFile = @"C:\\Users\\Kelemen Gábor\\source\\repos\\ToDoList\\Tasks\\ress\\easy.txt";

        public string MediumTasksFile = @"C:\\Users\\Kelemen Gábor\\source\\repos\\ToDoList\\Tasks\\ress\\medium.txt";

        public string HardTasksFile = @"C:\\Users\\Kelemen Gábor\\source\\repos\\ToDoList\\Tasks\\ress\\hard.txt";

        public string XpFile = @"C:\\Users\\Kelemen Gábor\\source\\repos\\ToDoList\\Tasks\\ress\\lvl.txt";

        public string Homepath = @"C:\\Users\\Kelemen Gábor\\source\\repos\\ToDoList\\ToDoList\\bin\\Debug\\ToDoList.exe";

        public Form1()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            Menu.Click += Menu_Click;
            exit.Click += Exit_Click;
            AddTaskButton.Click += AddTaskButton_Click;
            RemoveTaskButton.Click += RemoveTaskButton_Click;
            SaveButton.Click += SaveButton_Click;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            TaskInputTextBox.TextChanged += TaskInputTextBox_TextChanged;
            SelectedTaskInput.TextChanged += SelectedTaskInput_TextChanged;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            RunExecutable(Homepath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks(EasyTasksFile, easyRichTextBox);
            LoadTasks(MediumTasksFile, mediumRichTextBox);
            LoadTasks(HardTasksFile, hardRichTextBox);
            InitializeXpAndLevel();
        }

        private void LoadTasks(string filePath, RichTextBox richTextBox)
        {
            if (File.Exists(filePath))
            {
                richTextBox.Text = File.ReadAllText(filePath) ?? string.Empty;
            }
            else
            {
                richTextBox.Text = "";
            }
        }

        private void InitializeXpAndLevel()
        {
            int xp = File.Exists(XpFile)
                ? int.TryParse(File.ReadAllText(XpFile), out var result) ? result : 0
                : 0;

            if (!File.Exists(XpFile))
            {
                File.WriteAllText(XpFile, "0");
            }

            UpdateLevel(xp);
        }

        private void UpdateLevel(int xp)
        {
            int level = xp / 100;
            int progres = (xp - level * 100);
            progressBar1.Value = progres;
            LevelLabel.Text = $"Level: {level}";
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            string category = CategoryComboBox.SelectedItem?.ToString();
            string task = TaskInputTextBox.Text.Trim();

            if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Please select a category and enter a task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filePath = GetFilePath(category);

            File.AppendAllText(filePath, task + Environment.NewLine);
            RefreshTasks();
            TaskInputTextBox.Clear();
        }

        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            string category = CategoryComboBox.SelectedItem?.ToString();
            string task = SelectedTaskInput.Text.Trim();

            if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Please select a category and specify the task to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filePath = GetFilePath(category);

            if (File.Exists(filePath))
            {
                var tasks = File.ReadAllLines(filePath).Where(t => t != task).ToList();
                File.WriteAllLines(filePath, tasks);
                CompleteTask(category, task);
                RefreshTasks();
                SelectedTaskInput.Clear();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveTasks(EasyTasksFile, easyRichTextBox);
            SaveTasks(MediumTasksFile, mediumRichTextBox);
            SaveTasks(HardTasksFile, hardRichTextBox);
            MessageBox.Show("Tasks saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveTasks(string filePath, RichTextBox richTextBox)
        {
            File.WriteAllText(filePath, richTextBox.Text);
        }

        private void CompleteTask(string category, string task)
        {
            int xpGained = 0;

            if (category.Equals("easy", StringComparison.OrdinalIgnoreCase))
            {
                xpGained = 10;
            }
            else if (category.Equals("medium", StringComparison.OrdinalIgnoreCase))
            {
                xpGained = 20;
            }
            else if (category.Equals("hard", StringComparison.OrdinalIgnoreCase))
            {
                xpGained = 30;
            }

            AddXp(xpGained);
        }

        private void AddXp(int amount)
        {
            int currentXp = File.Exists(XpFile)
                ? int.TryParse(File.ReadAllText(XpFile), out var result) ? result : 0
                : 0;

            currentXp += amount;
            File.WriteAllText(XpFile, currentXp.ToString());
            UpdateLevel(currentXp);
        }

        private string GetFilePath(string category)
        {
            if (category.Equals("easy", StringComparison.OrdinalIgnoreCase))
            {
                return EasyTasksFile;
            }
            else if (category.Equals("medium", StringComparison.OrdinalIgnoreCase))
            {
                return MediumTasksFile;
            }
            else if (category.Equals("hard", StringComparison.OrdinalIgnoreCase))
            {
                return HardTasksFile;
            }

            throw new ArgumentException("Invalid category");
        }

        private void RefreshTasks()
        {
            LoadTasks(EasyTasksFile, easyRichTextBox);
            LoadTasks(MediumTasksFile, mediumRichTextBox);
            LoadTasks(HardTasksFile, hardRichTextBox);
        }

        private void RunExecutable(string redirect_path)
        {
            string path = redirect_path;

            try
            {
                if (File.Exists(path))
                {
                    Application.Exit();
                    Process.Start(path);
                }
                else
                {
                    MessageBox.Show("Executable not found at path: " + path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching the executable: " + ex.Message);
            }
        }

        private void AddTaskButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void RemoveTaskButton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            
        }
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TaskInputTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SelectedTaskInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
