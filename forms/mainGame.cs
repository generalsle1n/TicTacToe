using TicTacToe.classes;

namespace TicTacToe
{
    public partial class mainGame : Form
    {
        private singleGame game = new singleGame();
        private const int buttonCounter = 9;

        public mainGame()
        {
            InitializeComponent();            
        }

        private int getIdFromButtonName(Button button)
        {
            string buttonName = button.Name;
            int buttonId = int.Parse(buttonName.Split("_")[1]);
            return buttonId;
        }

        private void ticTacEvent(object sender)
        {
            Button currentButton = (Button)sender;
            currentButton.Enabled = false;
            game.setPlayerOnField(getIdFromButtonName(currentButton));
            updateField();
            if (game.checkIfFinished())
            {
                Close();
            }
        }

        private void updateField()
        {
            string[] playerField = game.getCurrentPlayField();
            button_0.Text = playerField[0];
            button_1.Text = playerField[1];
            button_2.Text = playerField[2];
            button_3.Text = playerField[3];
            button_4.Text = playerField[4];
            button_5.Text = playerField[5];
            button_6.Text = playerField[6];
            button_7.Text = playerField[7];
            button_8.Text = playerField[8];
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            ticTacEvent(sender);
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            ticTacEvent(sender);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            ticTacEvent(sender);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            ticTacEvent(sender);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            ticTacEvent(sender);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            ticTacEvent(sender);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            ticTacEvent(sender);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            ticTacEvent(sender);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            ticTacEvent(sender);
        }
    }
}