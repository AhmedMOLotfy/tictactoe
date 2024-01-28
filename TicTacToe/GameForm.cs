using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{

    public partial class GameForm : Form
    {
        SqlConnection con;


        bool turn = true; // true => x , false => o
        int turnCount = 0;
        List<Button> buttons = new List<Button>();
        public TicTacToe form1;
        private string player1_name;
        private string player2_name;
        bool player1_choice = false;
        bool player2_choice = false;

        public Panel playerpanel;

        public int player1_wins = 0;
        public int player2_wins = 0;

        public GameForm(Form form)
        {
            con = new SqlConnection("Server=DESKTOP-9PT8N4J\\MSSQLSERVER1;Database=tictactoe;Trusted_Connection=True;TrustServerCertificate=True");

            


            InitializeComponent();
            form1 = form as TicTacToe;

            player1_name = form1.getPlayer1Name();
            player2_name = form1.getPlayer2Name();


            player1_lbl_game.BackColor = System.Drawing.Color.Transparent;
            player2_lbl_game.BackColor = System.Drawing.Color.Transparent;

            player1_lbl_game.Text = player1_name;
            player2_lbl_game.Text = player2_name;

            buttons.Add(a1);
            buttons.Add(a2);
            buttons.Add(a3);
            buttons.Add(b1);
            buttons.Add(b2);
            buttons.Add(b3);
            buttons.Add(c1);
            buttons.Add(c2);
            buttons.Add(c3);

            // if true
            // player1_choice => x , player2_choice = o
            // else
            // player1_choice => o , player2_choice = x
            player1_choice = form1.getPlayer1Choice();
            player2_choice = !player1_choice;

            playerpanel = form1.nvg_panel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicTacToe.nvg.Dock = DockStyle.Bottom;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;

            b.Enabled = false;
            turnCount++;

            checkForWinner();
        }

        public void checkForWinner()
        {
            bool there_is_a_winner = false;

            // horizental check 
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                there_is_a_winner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                there_is_a_winner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                there_is_a_winner = true;

            // vertical check 
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                there_is_a_winner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                there_is_a_winner = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                there_is_a_winner = true;

            // diagonal checks
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                there_is_a_winner = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!b2.Enabled))
                there_is_a_winner = true;



            if (there_is_a_winner)
            {
                string winner = "";
                disable_buttons();
                if (turn)
                {
                    if (!player1_choice)
                    {
                        MessageBox.Show("O -> Winner is " + player1_name);
                        player1_wins++;
                    }
                    else
                    {
                        MessageBox.Show("O -> Winner is " + player2_name);
                        player2_wins++;
                    }

                }
                else
                {
                    if (player1_choice)
                    {
                        MessageBox.Show("X -> Winner is " + player1_name);
                        player1_wins++;
                    }
                    else
                    {
                        MessageBox.Show("X -> Winner is " + player2_name);
                        player2_wins++;

                    }

                }
            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
            setLabel();
        }


        private void disable_buttons()
        {
            try
            {
                foreach (Control c in buttons)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            {

            }
        }

        public void setLabel()
        {
            player1_result.Text = player1_wins.ToString();
            player2_result.Text = player2_wins.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            turn = true;
            turnCount = 0;
            try
            {
                foreach (Control c in buttons)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch
            {

            }
        }

        private void resestGame()
        {
            player1_wins = player2_wins = 0;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            resestGame();
            setLabel();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            //MessageBox.Show($"{player1_name},{player1_wins},{player2_name},{player2_wins},{dateTime.ToString("dd/MM/yyyy")}");
            SqlCommand cmd 
                = new SqlCommand($"insert into plays([play1], [play1_score], [play2],[play2_score],[playDate]) values(@p1,@pl_wins,@p2,@p2_wins,GETDATE())", con);
            cmd.Parameters.AddWithValue("@p1", player1_name);
            cmd.Parameters.AddWithValue("@pl_wins", player1_wins);
            cmd.Parameters.AddWithValue("@p2", player2_name);
            cmd.Parameters.AddWithValue("@p2_wins", player2_wins);
            //cmd.Parameters.AddWithValue("@dd", dateTime.ToString("dd/MM/yyyy"));
            int rowsEffected = 0;
            
            try
            {
                // open connection
                con.Open();
                // exceute
                rowsEffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close connection
                con.Close();
            }

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data was insereted");
            }
        }

        private void res_btn_Click(object sender, EventArgs e)
        {
            var ff = new PlaysDB();
            ff.TopLevel = false;
            ff.FormBorderStyle = FormBorderStyle.None;
            ff.Dock = DockStyle.Fill;

            form1.nvg_panel.Controls.Add(ff);
            form1.nvg_panel.Tag = ff;
            ff.BringToFront();
            ff.Show();

            form1.nvg_panel.Dock = DockStyle.Fill;
        }
    }
}
