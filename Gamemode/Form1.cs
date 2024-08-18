using System;
using System.Windows.Forms;
using Gamemode.Classes;

namespace Gamemode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ExplorerKill_Click(object sender, EventArgs e)
        {
            try
            {
                SystemCommands.KillExplorer();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnIdleDisable_Click(object sender, EventArgs e)
        {
            try
            {
                SystemCommands.DisableIdle();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnExplorerEnable_Click(object sender, EventArgs e)
        {
            try
            {
                SystemCommands.StartTaskManager();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnIdleEnable_Click(object sender, EventArgs e)
        {
            try
            {
                SystemCommands.EnableIdle();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
