namespace TicTacToe
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            homePage = new Button();
            player1_lbl_game = new Label();
            player2_lbl_game = new Label();
            player2_result = new Button();
            player1_result = new Button();
            reset_btn = new Button();
            button2 = new Button();
            save_btn = new Button();
            a1 = new Button();
            a2 = new Button();
            a3 = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            c3 = new Button();
            c2 = new Button();
            c1 = new Button();
            res_btn = new Button();
            SuspendLayout();
            // 
            // homePage
            // 
            homePage.BackColor = SystemColors.InactiveBorder;
            homePage.ForeColor = SystemColors.ActiveCaptionText;
            homePage.Location = new Point(2, 1);
            homePage.Name = "homePage";
            homePage.Size = new Size(112, 34);
            homePage.TabIndex = 0;
            homePage.Text = "Back";
            homePage.UseVisualStyleBackColor = false;
            homePage.Click += button1_Click;
            // 
            // player1_lbl_game
            // 
            player1_lbl_game.AutoSize = true;
            player1_lbl_game.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            player1_lbl_game.Location = new Point(509, 43);
            player1_lbl_game.Name = "player1_lbl_game";
            player1_lbl_game.Size = new Size(63, 25);
            player1_lbl_game.TabIndex = 1;
            player1_lbl_game.Text = "label1";
            // 
            // player2_lbl_game
            // 
            player2_lbl_game.AutoSize = true;
            player2_lbl_game.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            player2_lbl_game.Location = new Point(509, 103);
            player2_lbl_game.Name = "player2_lbl_game";
            player2_lbl_game.Size = new Size(63, 25);
            player2_lbl_game.TabIndex = 2;
            player2_lbl_game.Text = "label2";
            // 
            // player2_result
            // 
            player2_result.BackColor = SystemColors.InactiveBorder;
            player2_result.Location = new Point(609, 98);
            player2_result.Name = "player2_result";
            player2_result.Size = new Size(167, 34);
            player2_result.TabIndex = 4;
            player2_result.Text = "0";
            player2_result.UseVisualStyleBackColor = false;
            // 
            // player1_result
            // 
            player1_result.BackColor = SystemColors.InactiveBorder;
            player1_result.Location = new Point(609, 38);
            player1_result.Name = "player1_result";
            player1_result.Size = new Size(167, 34);
            player1_result.TabIndex = 5;
            player1_result.Text = "0";
            player1_result.UseVisualStyleBackColor = false;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = SystemColors.Window;
            reset_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reset_btn.Location = new Point(509, 225);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(254, 34);
            reset_btn.TabIndex = 6;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += reset_btn_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(509, 293);
            button2.Name = "button2";
            button2.Size = new Size(254, 34);
            button2.TabIndex = 7;
            button2.Text = "New Game";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = SystemColors.ControlLightLight;
            save_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            save_btn.Location = new Point(509, 355);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(254, 34);
            save_btn.TabIndex = 8;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // a1
            // 
            a1.BackColor = SystemColors.ControlLightLight;
            a1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            a1.Location = new Point(30, 88);
            a1.Name = "a1";
            a1.Size = new Size(125, 98);
            a1.TabIndex = 9;
            a1.UseVisualStyleBackColor = false;
            a1.Click += button_click;
            // 
            // a2
            // 
            a2.BackColor = SystemColors.ControlLightLight;
            a2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            a2.Location = new Point(190, 88);
            a2.Name = "a2";
            a2.Size = new Size(125, 98);
            a2.TabIndex = 10;
            a2.UseVisualStyleBackColor = false;
            a2.Click += button_click;
            // 
            // a3
            // 
            a3.BackColor = SystemColors.ControlLightLight;
            a3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            a3.ForeColor = SystemColors.ControlText;
            a3.Location = new Point(338, 88);
            a3.Name = "a3";
            a3.Size = new Size(125, 98);
            a3.TabIndex = 11;
            a3.UseVisualStyleBackColor = false;
            a3.Click += button_click;
            // 
            // b3
            // 
            b3.BackColor = SystemColors.ControlLightLight;
            b3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            b3.Location = new Point(338, 207);
            b3.Name = "b3";
            b3.Size = new Size(125, 98);
            b3.TabIndex = 14;
            b3.UseVisualStyleBackColor = false;
            b3.Click += button_click;
            // 
            // b2
            // 
            b2.BackColor = SystemColors.ControlLightLight;
            b2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            b2.Location = new Point(190, 207);
            b2.Name = "b2";
            b2.Size = new Size(125, 98);
            b2.TabIndex = 13;
            b2.UseVisualStyleBackColor = false;
            b2.Click += button_click;
            // 
            // b1
            // 
            b1.BackColor = SystemColors.ControlLightLight;
            b1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            b1.Location = new Point(30, 207);
            b1.Name = "b1";
            b1.Size = new Size(125, 98);
            b1.TabIndex = 12;
            b1.UseVisualStyleBackColor = false;
            b1.Click += button_click;
            // 
            // c3
            // 
            c3.BackColor = SystemColors.ControlLightLight;
            c3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            c3.Location = new Point(338, 323);
            c3.Name = "c3";
            c3.Size = new Size(125, 98);
            c3.TabIndex = 17;
            c3.UseVisualStyleBackColor = false;
            c3.Click += button_click;
            // 
            // c2
            // 
            c2.BackColor = SystemColors.ControlLightLight;
            c2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            c2.Location = new Point(190, 323);
            c2.Name = "c2";
            c2.Size = new Size(125, 98);
            c2.TabIndex = 16;
            c2.UseVisualStyleBackColor = false;
            c2.Click += button_click;
            // 
            // c1
            // 
            c1.BackColor = SystemColors.ControlLightLight;
            c1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            c1.Location = new Point(30, 323);
            c1.Name = "c1";
            c1.Size = new Size(125, 98);
            c1.TabIndex = 15;
            c1.UseVisualStyleBackColor = false;
            c1.Click += button_click;
            // 
            // res_btn
            // 
            res_btn.BackColor = SystemColors.Window;
            res_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            res_btn.Location = new Point(509, 164);
            res_btn.Name = "res_btn";
            res_btn.Size = new Size(254, 34);
            res_btn.TabIndex = 18;
            res_btn.Text = "DB";
            res_btn.UseVisualStyleBackColor = false;
            res_btn.Click += res_btn_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(res_btn);
            Controls.Add(c3);
            Controls.Add(c2);
            Controls.Add(c1);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(a3);
            Controls.Add(a2);
            Controls.Add(a1);
            Controls.Add(save_btn);
            Controls.Add(button2);
            Controls.Add(reset_btn);
            Controls.Add(player1_result);
            Controls.Add(player2_result);
            Controls.Add(player2_lbl_game);
            Controls.Add(player1_lbl_game);
            Controls.Add(homePage);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button homePage;
        private Label player1_lbl_game;
        private Label player2_lbl_game;
        private Button player2_result;
        private Button player1_result;
        private Button reset_btn;
        private Button button2;
        private Button save_btn;
        private Button a1;
        private Button a2;
        private Button a3;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button c3;
        private Button c2;
        private Button c1;
        private Button res_btn;
    }
}