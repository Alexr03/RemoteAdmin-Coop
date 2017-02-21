using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SolarRemoteAdminGUI
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public static Form1 Instance;

        public Form1()
        {
            Instance = this;
            InitializeComponent();
            ChangeName("Status");
            string location = AppDomain.CurrentDomain.BaseDirectory + "xulrunner";
            Gecko.Xpcom.Initialize(location);

            if (SolarRemoteAdminLibary.Networking.CheckForUpdate())
            {
                DialogResult box = MessageBox.Show("Update avaliable!, to download click Yes", "Update Manager", MessageBoxButtons.YesNo);
                if (box == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://eu-w101.solarsentinels.co.uk/svrLogs/update.zip");
                }
            }
            else { MessageBox.Show("Your running the latest version of RemoteAdmin!", "Update Manager", MessageBoxButtons.OK); }
        }

        public void ChangeName(string ServerID)
        {
            this.Text = "Solar Sentinels - Server " + ServerID;
        }

        #region ServerButtons
        private void Server1Log_Click(object sender, EventArgs e)
        {
            ChangeName("1");
            browser.Navigate("http://eu-w101.solarsentinels.co.uk/svrLogs/Server1/Logs.php");
        }

        private void Server1Execute_Click(object sender, EventArgs e)
        {
            SolarRemoteAdminLibary.Networking.send(CMDBox.Text, PassBox.Text, 1);
        }

        private void Server2Log_Click(object sender, EventArgs e)
        {
            ChangeName("2");
            browser.Navigate("http://eu-w101.solarsentinels.co.uk/svrLogs/Server2/Logs.php");
        }

        private void Server2Execute_Click(object sender, EventArgs e)
        {
            SolarRemoteAdminLibary.Networking.send(CMDBox.Text, PassBox.Text, 2);
        }

        private void Server5Execute_Click(object sender, EventArgs e)
        {
            SolarRemoteAdminLibary.Networking.send(CMDBox.Text, PassBox.Text, 5);
        }

        private void Server5Log_Click(object sender, EventArgs e)
        {
            ChangeName("5");
            browser.Navigate("http://eu-w101.solarsentinels.co.uk/svrLogs/Server5/Logs.php");
        }

        private void Server6Execute_Click(object sender, EventArgs e)
        {
            SolarRemoteAdminLibary.Networking.send(CMDBox.Text, PassBox.Text, 6);
        }

        private void Server6Logs_Click(object sender, EventArgs e)
        {
            ChangeName("6");
            browser.Navigate("http://eu-w101.solarsentinels.co.uk/svrLogs/Server6/Logs.php");
        }

        private void Server7Execute_Click(object sender, EventArgs e)
        {
            SolarRemoteAdminLibary.Networking.send(CMDBox.Text, PassBox.Text, 7);
        }

        private void Server7Log_Click(object sender, EventArgs e)
        {
            ChangeName("7");
            browser.Navigate("http://eu-w101.solarsentinels.co.uk/svrLogs/Server7/Logs.php");
        }

        private void Server8Execute_Click(object sender, EventArgs e)
        {
            SolarRemoteAdminLibary.Networking.send(CMDBox.Text, PassBox.Text, 8);
        }

        private void Server8Log_Click(object sender, EventArgs e)
        {
            ChangeName("8");
            browser.Navigate("http://eu-w101.solarsentinels.co.uk/svrLogs/Server8/Logs.php");
        }

        private void Status_Click(object sender, EventArgs e)
        {
            browser.Navigate("http://eu-w101.solarsentinels.co.uk/status/");
            ChangeName("Status");
        }
        #endregion


    }
}
