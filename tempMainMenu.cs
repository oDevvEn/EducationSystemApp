using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationSystemApp {
    public partial class tempMainMenu : Form {
        public tempMainMenu() {
            InitializeComponent();
        }

        private void speedTestButton_Click(object sender, EventArgs e) {

        }

        private void profileComparor_Click(object sender, EventArgs e) {
            this.Hide();
            new ProfileComparor().ShowDialog();
            this.Show();
        }

        private void save_Click(object sender, EventArgs e) {
            tempProfile.SaveProfiles();
        }
    }
}
