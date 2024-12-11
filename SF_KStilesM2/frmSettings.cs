using System;
using System.Drawing;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Form used for changing the colors of the application.
    /// </summary>
    public partial class frmSettings : Form
    {
        //Variables
        public static Color mainBackDefault = Color.FromArgb(92, 40, 73),
            mainBackLight = SystemColors.Control,
            mainBackDark = Color.FromArgb(64, 64, 64),
            mainTextDefault = Color.FromArgb(255, 210, 133),
            mainTextLight = SystemColors.ControlText,
            mainTextDark = Color.White,
            boxBackDefault = Color.FromArgb(255, 115, 63),
            boxBackLight = Color.LightGray,
            boxBackDark = Color.Gray,
            infoBackDefault = Color.White,
            infoBackLight = Color.DarkGray,
            infoBackDark = Color.Silver;

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Allows user to open help files
        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpSettings.HelpNamespace);
        }

        public frmSettings()
        {
            InitializeComponent();
        }


        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.mainBack == mainBackDefault)
            {
                rbtnDefault.Checked = true;
            }
            if (Properties.Settings.Default.mainBack == mainBackLight)
            {
                rbtnLight.Checked = true;
            }
            if (Properties.Settings.Default.mainBack == mainBackDark)
            {
                rbtnDark.Checked = true;
            }
        }

        /// <summary>
        /// Holds data for changing color of application.
        /// </summary>
        private void ColorChange()
        {
            if (rbtnDefault.Checked)
            {
                Properties.Settings.Default.mainBack = mainBackDefault;
                Properties.Settings.Default.mainText = mainTextDefault;
                Properties.Settings.Default.boxBack = boxBackDefault;
                Properties.Settings.Default.infoBack = infoBackDefault;
            }
            if (rbtnLight.Checked)
            {
                Properties.Settings.Default.mainBack = mainBackLight;
                Properties.Settings.Default.mainText = mainTextLight;
                Properties.Settings.Default.boxBack = boxBackLight;
                Properties.Settings.Default.infoBack = infoBackLight;
            }
            if (rbtnDark.Checked)
            {
                Properties.Settings.Default.mainBack = mainBackDark;
                Properties.Settings.Default.mainText = mainTextDark;
                Properties.Settings.Default.boxBack = boxBackDark;
                Properties.Settings.Default.infoBack = infoBackDark;
            }
        }

        //Doesn't save changes and takes user back to login form
        private void btnClose_Click(object sender, EventArgs e)
        {            
            new frmLogon().Show();
            this.Dispose();
        }

        //Saves changes and takes user back to login form
        private void btnOK_Click(object sender, EventArgs e)
        {
            ColorChange();
            
            new frmLogon().Show();
            this.Dispose();
        }        
    }
}
