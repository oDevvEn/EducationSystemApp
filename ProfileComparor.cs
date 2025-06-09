namespace EducationSystemApp {
    public partial class ProfileComparor : Form {
        public ProfileComparor() {
            InitializeComponent();

            // Assign your scores
            yourMathScore.Text = tempProfile.profile.mathScore.ToString();
            yourMemoryScore.Text = tempProfile.profile.memoryScore.ToString();
            yourWordScore.Text = tempProfile.profile.wordScore.ToString();
            yourSpeedScore.Text = tempProfile.profile.speedScore.ToString();
            yourTotalScore.Text = (tempProfile.profile.mathScore + tempProfile.profile.memoryScore + tempProfile.profile.wordScore).ToString();
        }

        private void compareButton_Click(object sender, EventArgs e) {
            // Find profile to compare to
            tempProfile? profile = null;
            if (!tempProfile.profiles.TryGetValue(compareInput.Text, out profile)) {
                MessageBox.Show($"Profile with name {compareInput.Text} doesn't exist!", null, MessageBoxButtons.OK);
                return;
            }

            // Assign their scores
            theirMathScore.Text = profile.mathScore.ToString();
            theirMemoryScore.Text = profile.memoryScore.ToString();
            theirWordScore.Text = profile.wordScore.ToString();
            theirTotalScore.Text = (profile.mathScore + profile.memoryScore + profile.wordScore).ToString();
            theirSpeedScore.Text = profile.speedScore.ToString();

            // Colors to show who has better score
            yourMathScore.ForeColor = tempProfile.profile.mathScore >= profile.mathScore ? Color.Green : Color.Red;
            theirMathScore.ForeColor = tempProfile.profile.mathScore <= profile.mathScore ? Color.Green : Color.Red;
            yourMemoryScore.ForeColor = tempProfile.profile.memoryScore >= profile.memoryScore ? Color.Green : Color.Red;
            theirMemoryScore.ForeColor = tempProfile.profile.memoryScore <= profile.memoryScore ? Color.Green : Color.Red;
            yourWordScore.ForeColor = tempProfile.profile.wordScore >= profile.wordScore ? Color.Green : Color.Red;
            theirWordScore.ForeColor = tempProfile.profile.wordScore <= profile.wordScore ? Color.Green : Color.Red;
            yourTotalScore.ForeColor = tempProfile.profile.mathScore+tempProfile.profile.memoryScore+tempProfile.profile.wordScore >= profile.mathScore+profile.memoryScore+profile.wordScore ? Color.Green : Color.Red;
            theirTotalScore.ForeColor = tempProfile.profile.mathScore+tempProfile.profile.memoryScore+tempProfile.profile.wordScore <= profile.mathScore+profile.memoryScore+profile.wordScore ? Color.Green : Color.Red;
            yourSpeedScore.ForeColor = tempProfile.profile.speedScore <= profile.speedScore ? Color.Green : Color.Red;
            theirSpeedScore.ForeColor = tempProfile.profile.speedScore >= profile.speedScore ? Color.Green : Color.Red;
        }
    }
}
