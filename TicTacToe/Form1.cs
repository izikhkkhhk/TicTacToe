namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Player p = new Player();
        public Form1()
        {
            InitializeComponent();
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
        }
        void SwitchPlayer()
        {
            p.SwitchPlayer();
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
        }
        private void GameButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text != "")
            {
                return;
            }
            button.Text = p.GetPlayer();
            CheckResult();
            SwitchPlayer();
        }
        void CheckResult()
        {
            List<Button> buttonList = tableLayoutPanel1.Controls.OfType<Button>().ToList();
            int empty = 0;
            foreach (Button button in buttonList)
            {
                if (button.Text == String.Empty)
                {
                    empty++;
                }
            }
            if(TopLeft.Text != String.Empty && TopCenter.Text != String.Empty && TopRight.Text != String.Empty)
            {
                if(TopLeft.Text == TopCenter.Text && TopCenter.Text == TopRight.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + TopLeft.Text);
                    RestartGame();
                }
            }
            if (CenterLeft.Text != String.Empty &&CenterCenter.Text != String.Empty && CenterRight.Text != String.Empty)
            {
                if (CenterLeft.Text == CenterCenter.Text && CenterCenter.Text == CenterRight.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + CenterLeft.Text);
                    RestartGame();
                }
            }
            if (BottomLeft.Text != String.Empty && BottomCenter.Text != String.Empty && BottomRight.Text != String.Empty)
            {
                if (BottomLeft.Text == BottomCenter.Text && BottomCenter.Text == BottomRight.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + BottomLeft.Text);
                    RestartGame();
                }
            }
            if (TopLeft.Text != String.Empty && CenterLeft.Text != String.Empty && BottomLeft.Text != String.Empty)
            {
                if (TopLeft.Text == CenterLeft.Text && CenterLeft.Text == BottomLeft.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + TopLeft.Text);
                    RestartGame();
                }
            }
            if (TopCenter.Text != String.Empty && CenterCenter.Text != String.Empty && BottomCenter.Text != String.Empty)
            {
                if (TopCenter.Text == CenterCenter.Text && CenterCenter.Text == BottomCenter.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + TopCenter.Text);
                    RestartGame();
                }
            }
            if (TopRight.Text != String.Empty && CenterRight.Text != String.Empty && BottomRight.Text != String.Empty)
            {
                if (TopRight.Text == CenterRight.Text && CenterRight.Text == BottomRight.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + TopCenter.Text);
                    RestartGame();
                }
            }
            if (TopLeft.Text != String.Empty && CenterCenter.Text != String.Empty && BottomRight.Text != String.Empty)
            {
                if (TopLeft.Text == CenterCenter.Text && CenterCenter.Text == BottomRight.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + TopLeft.Text);
                    RestartGame();
                }
            }
            if (TopRight.Text != String.Empty && CenterCenter.Text != String.Empty && BottomLeft.Text != String.Empty)
            {
                if (TopRight.Text == CenterCenter.Text && CenterCenter.Text == BottomLeft.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + TopRight.Text);
                    RestartGame();
                }
            }
            if (empty == 0)
            {
                MessageBox.Show("Remis");
                RestartGame();
            }
        }
        void RestartGame()
        {   
            List<Button> buttonList =
                        tableLayoutPanel1.Controls.OfType<Button>().ToList();
            foreach (Button button in buttonList)
            {

                button.Text = String.Empty;
            }
            p.Reset();
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
        }
    }
}
