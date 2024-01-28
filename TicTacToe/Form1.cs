namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public Form activeForm = null;
        public static Panel nvg;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            var ff = new GameForm(this);
            activeForm = this;
            ff.TopLevel = false;
            ff.FormBorderStyle = FormBorderStyle.None;
            ff.Dock = DockStyle.Fill;

            nvg_panel.Controls.Add(ff);
            nvg_panel.Tag = ff;
            ff.BringToFront();
            ff.Show();
            nvg = nvg_panel;

            nvg_panel.Dock = DockStyle.Fill;

        }

        public string getPlayer1Name()
        {
            return player1_name.Text;
        }


        public string getPlayer2Name()
        {
            return player2_name.Text;
        }

        public bool getPlayer1Choice()
        {
            // x => true, else => false
            if (btn_x_pl_1.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #region control eithir X & O
        private void btn_x_pl_1_Click(object sender, EventArgs e)
        {
            btn_o_pl_2.Checked = true;

        }

        private void btn_o_pl_1_Click(object sender, EventArgs e)
        {
            btn_x_pl_2.Checked = true;

        }

        private void btn_x_pl_2_Click(object sender, EventArgs e)
        {
            btn_o_pl_1.Checked = true;
        }

        private void btn_o_pl_2_Click(object sender, EventArgs e)
        {
            btn_x_pl_1.Checked = true;
        }
        #endregion




      
    }
}
