namespace EducationSystemApp {
    public partial class ProfileComparor : Form {
        public ProfileComparor() {
            InitializeComponent();

            // Assign your scores
            yourMathScore.Text = ProfileSystem.profile.mathScore.ToString();
            yourMemoryScore.Text = ProfileSystem.profile.memoryScore.ToString();
            yourWordScore.Text = ProfileSystem.profile.wordScore.ToString();
            yourSpeedScore.Text = ProfileSystem.profile.speedScore.ToString();
            yourTotalScore.Text = (ProfileSystem.profile.mathScore + ProfileSystem.profile.memoryScore + ProfileSystem.profile.wordScore).ToString();
        }

        private void compareButton_Click(object sender, EventArgs e) {
            // Find profile to compare to
            ProfileSystem? profile = null;
            if (!ProfileSystem.profiles.TryGetValue(compareInput.Text, out profile)) {
                MessageBox.Show($"Profile with name {compareInput.Text} doesn't exist!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assign their scores
            theirMathScore.Text = profile.mathScore.ToString();
            theirMemoryScore.Text = profile.memoryScore.ToString();
            theirWordScore.Text = profile.wordScore.ToString();
            theirTotalScore.Text = (profile.mathScore + profile.memoryScore + profile.wordScore).ToString();
            theirSpeedScore.Text = profile.speedScore.ToString();

            // Colors to show who has better score
            yourMathScore.ForeColor = ProfileSystem.profile.mathScore >= profile.mathScore ? Color.Green : Color.Red;
            theirMathScore.ForeColor = ProfileSystem.profile.mathScore <= profile.mathScore ? Color.Green : Color.Red;
            yourMemoryScore.ForeColor = ProfileSystem.profile.memoryScore >= profile.memoryScore ? Color.Green : Color.Red;
            theirMemoryScore.ForeColor = ProfileSystem.profile.memoryScore <= profile.memoryScore ? Color.Green : Color.Red;
            yourWordScore.ForeColor = ProfileSystem.profile.wordScore >= profile.wordScore ? Color.Green : Color.Red;
            theirWordScore.ForeColor = ProfileSystem.profile.wordScore <= profile.wordScore ? Color.Green : Color.Red;
            yourTotalScore.ForeColor = ProfileSystem.profile.mathScore+ProfileSystem.profile.memoryScore+ProfileSystem.profile.wordScore >= profile.mathScore+profile.memoryScore+profile.wordScore ? Color.Green : Color.Red;
            theirTotalScore.ForeColor = ProfileSystem.profile.mathScore+ProfileSystem.profile.memoryScore+ProfileSystem.profile.wordScore <= profile.mathScore+profile.memoryScore+profile.wordScore ? Color.Green : Color.Red;
            yourSpeedScore.ForeColor = ProfileSystem.profile.speedScore <= profile.speedScore ? Color.Green : Color.Red;
            theirSpeedScore.ForeColor = ProfileSystem.profile.speedScore >= profile.speedScore ? Color.Green : Color.Red;
        }
    }
}
