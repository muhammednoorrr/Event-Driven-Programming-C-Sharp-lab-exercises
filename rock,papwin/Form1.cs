namespace rock_papwin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string player1Choice = comboBoxPlayer1.SelectedItem.ToString();
            string player2Choice = comboBoxPlayer2.SelectedItem.ToString();

            string result = DetermineWinner(player1Choice, player2Choice);

            labelResult.Text = result;
        }
        private string DetermineWinner(string choice1, string choice2)
        {
            if (choice1 == choice2)
            {
                return "It's a tie!";
            }
            else if ((choice1 == "Rock" && choice2 == "Scissors") ||
                     (choice1 == "Scissors" && choice2 == "Paper") ||
                     (choice1 == "Paper" && choice2 == "Rock"))
            {
                return "Player 1 wins!";
            }
            else
            {
                return "Player 2 wins!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}