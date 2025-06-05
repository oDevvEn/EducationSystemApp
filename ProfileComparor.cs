namespace EducationSystemApp {
    public partial class ProfileComparor : Form {
        tempProfile profile;

        public ProfileComparor() {
            InitializeComponent();

            // Assign your scores
            profile = tempProfile.profiles.GetValueOrDefault("a")!; //temp
            yourMathScore.Text = profile.mathScore.ToString();
            yourMemoryScore.Text = profile.memoryScore.ToString();
            yourWordScore.Text = profile.wordScore.ToString();
            yourTotalScore.Text = (profile.mathScore + profile.memoryScore + profile.wordScore).ToString();
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

            // Colors to show who has better score
            yourMathScore.ForeColor = this.profile.mathScore >= profile.mathScore ? Color.Green : Color.Red;
            theirMathScore.ForeColor = this.profile.mathScore <= profile.mathScore ? Color.Green : Color.Red;
            yourMemoryScore.ForeColor = this.profile.memoryScore >= profile.memoryScore ? Color.Green : Color.Red;
            theirMemoryScore.ForeColor = this.profile.memoryScore <= profile.memoryScore ? Color.Green : Color.Red;
            yourWordScore.ForeColor = this.profile.wordScore >= profile.wordScore ? Color.Green : Color.Red;
            theirWordScore.ForeColor = this.profile.wordScore <= profile.wordScore ? Color.Green : Color.Red;
            yourTotalScore.ForeColor = this.profile.mathScore+this.profile.memoryScore+this.profile.wordScore >= profile.mathScore+profile.memoryScore+profile.wordScore ? Color.Green : Color.Red;
            theirTotalScore.ForeColor = this.profile.mathScore+this.profile.memoryScore+this.profile.wordScore <= profile.mathScore+profile.memoryScore+profile.wordScore ? Color.Green : Color.Red;
        }
    }
}
