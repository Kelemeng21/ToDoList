using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Menu : Form
    {
        public string taskpath = @"C:\Users\Kelemen Gábor\source\repos\ToDoList\Tasks\bin\Debug\Tasks.exe";
        public string informationspath = @"C:\Users\Kelemen Gábor\source\repos\ToDoList\Informations\bin\Debug\Informations.exe";
        public Menu()
        {
            InitializeComponent();
            Tasks.Click += Tasks_Click;
            Informations.Click += Informations_Click;
            Exit.Click += Exit_Click;
        }
        private void Tasks_Click(object sender, EventArgs e)
        {
            RunExecutable(taskpath);
        }
        private void Informations_Click(object sender, EventArgs e)
        {
            RunExecutable(informationspath);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}

