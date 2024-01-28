namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            panel1 = new Panel();
            btn_o_pl_1 = new RadioButton();
            btn_x_pl_1 = new RadioButton();
            choose1_lbl = new Label();
            player1_name = new TextBox();
            name1_lbl = new Label();
            player1_lbl = new Label();
            panel2 = new Panel();
            btn_o_pl_2 = new RadioButton();
            btn_x_pl_2 = new RadioButton();
            label1 = new Label();
            player2_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            start_btn = new Button();
            nvg_panel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveBorder;
            panel1.Controls.Add(btn_o_pl_1);
            panel1.Controls.Add(btn_x_pl_1);
            panel1.Controls.Add(choose1_lbl);
            panel1.Controls.Add(player1_name);
            panel1.Controls.Add(name1_lbl);
            panel1.Controls.Add(player1_lbl);
            panel1.Font = new Font("Segoe UI", 8F);
            panel1.Location = new Point(40, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 190);
            panel1.TabIndex = 0;
            // 
            // btn_o_pl_1
            // 
            btn_o_pl_1.AutoSize = true;
            btn_o_pl_1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_o_pl_1.Location = new Point(174, 116);
            btn_o_pl_1.Name = "btn_o_pl_1";
            btn_o_pl_1.Size = new Size(47, 25);
            btn_o_pl_1.TabIndex = 5;
            btn_o_pl_1.TabStop = true;
            btn_o_pl_1.Text = "O";
            btn_o_pl_1.UseVisualStyleBackColor = true;
            btn_o_pl_1.Click += btn_o_pl_1_Click;
            // 
            // btn_x_pl_1
            // 
            btn_x_pl_1.AutoSize = true;
            btn_x_pl_1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_x_pl_1.Location = new Point(113, 118);
            btn_x_pl_1.Name = "btn_x_pl_1";
            btn_x_pl_1.Size = new Size(45, 25);
            btn_x_pl_1.TabIndex = 4;
            btn_x_pl_1.TabStop = true;
            btn_x_pl_1.Text = "X";
            btn_x_pl_1.UseVisualStyleBackColor = true;
            btn_x_pl_1.Click += btn_x_pl_1_Click;
            // 
            // choose1_lbl
            // 
            choose1_lbl.AutoSize = true;
            choose1_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            choose1_lbl.Location = new Point(22, 116);
            choose1_lbl.Name = "choose1_lbl";
            choose1_lbl.Size = new Size(72, 25);
            choose1_lbl.TabIndex = 3;
            choose1_lbl.Text = "choose";
            // 
            // player1_name
            // 
            player1_name.Location = new Point(103, 61);
            player1_name.Name = "player1_name";
            player1_name.Size = new Size(150, 29);
            player1_name.TabIndex = 2;
            // 
            // name1_lbl
            // 
            name1_lbl.AutoSize = true;
            name1_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            name1_lbl.Location = new Point(22, 61);
            name1_lbl.Name = "name1_lbl";
            name1_lbl.Size = new Size(62, 25);
            name1_lbl.TabIndex = 1;
            name1_lbl.Text = "Name";
            // 
            // player1_lbl
            // 
            player1_lbl.AutoSize = true;
            player1_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            player1_lbl.Location = new Point(22, 16);
            player1_lbl.Name = "player1_lbl";
            player1_lbl.Size = new Size(89, 28);
            player1_lbl.TabIndex = 0;
            player1_lbl.Text = "Player 1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(btn_o_pl_2);
            panel2.Controls.Add(btn_x_pl_2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(player2_name);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Font = new Font("Segoe UI", 8F);
            panel2.Location = new Point(441, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 190);
            panel2.TabIndex = 6;
            // 
            // btn_o_pl_2
            // 
            btn_o_pl_2.AutoSize = true;
            btn_o_pl_2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_o_pl_2.Location = new Point(174, 116);
            btn_o_pl_2.Name = "btn_o_pl_2";
            btn_o_pl_2.Size = new Size(47, 25);
            btn_o_pl_2.TabIndex = 5;
            btn_o_pl_2.TabStop = true;
            btn_o_pl_2.Text = "O";
            btn_o_pl_2.UseVisualStyleBackColor = true;
            btn_o_pl_2.Click += btn_o_pl_2_Click;
            // 
            // btn_x_pl_2
            // 
            btn_x_pl_2.AutoSize = true;
            btn_x_pl_2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_x_pl_2.Location = new Point(113, 118);
            btn_x_pl_2.Name = "btn_x_pl_2";
            btn_x_pl_2.Size = new Size(45, 25);
            btn_x_pl_2.TabIndex = 4;
            btn_x_pl_2.TabStop = true;
            btn_x_pl_2.Text = "X";
            btn_x_pl_2.UseVisualStyleBackColor = true;
            btn_x_pl_2.Click += btn_x_pl_2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(22, 116);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 3;
            label1.Text = "choose";
            // 
            // player2_name
            // 
            player2_name.Location = new Point(103, 61);
            player2_name.Name = "player2_name";
            player2_name.Size = new Size(150, 29);
            player2_name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(22, 61);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(22, 16);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 0;
            label3.Text = "Player 2";
            // 
            // start_btn
            // 
            start_btn.BackColor = SystemColors.InactiveBorder;
            start_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            start_btn.Location = new Point(338, 319);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(112, 52);
            start_btn.TabIndex = 7;
            start_btn.Text = "Start";
            start_btn.UseVisualStyleBackColor = false;
            start_btn.Click += start_btn_Click;
            // 
            // nvg_panel
            // 
            nvg_panel.Location = new Point(0, 437);
            nvg_panel.Name = "nvg_panel";
            nvg_panel.Size = new Size(819, 14);
            nvg_panel.TabIndex = 8;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(nvg_panel);
            Controls.Add(start_btn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TicTacToe";
            Text = "TicTacToe";
            Load += TicTacToe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label name1_lbl;
        private Label player1_lbl;
        private Label choose1_lbl;
        private TextBox player1_name;
        private RadioButton btn_o_pl_1;
        private RadioButton btn_x_pl_1;
        private Panel panel2;
        private RadioButton btn_o_pl_2;
        private RadioButton btn_x_pl_2;
        private Label label1;
        private TextBox player2_name;
        private Label label2;
        private Label label3;
        private Button start_btn;
        public Panel nvg_panel;
    }
}
