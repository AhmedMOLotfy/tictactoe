namespace TicTacToe
{
    partial class PlaysDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaysDB));
            Back_btn_db = new Button();
            dgv_plays = new DataGridView();
            delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_plays).BeginInit();
            SuspendLayout();
            // 
            // Back_btn_db
            // 
            Back_btn_db.BackColor = SystemColors.InactiveBorder;
            Back_btn_db.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Back_btn_db.Location = new Point(0, 0);
            Back_btn_db.Name = "Back_btn_db";
            Back_btn_db.Size = new Size(125, 39);
            Back_btn_db.TabIndex = 0;
            Back_btn_db.Text = "start game";
            Back_btn_db.UseVisualStyleBackColor = false;
            Back_btn_db.Click += Back_btn_db_Click;
            // 
            // dgv_plays
            // 
            dgv_plays.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_plays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_plays.Location = new Point(0, 105);
            dgv_plays.Name = "dgv_plays";
            dgv_plays.RowHeadersWidth = 62;
            dgv_plays.Size = new Size(806, 348);
            dgv_plays.TabIndex = 1;
            dgv_plays.RowHeaderMouseDoubleClick += dgv_plays_RowHeaderMouseDoubleClick;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = SystemColors.InactiveBorder;
            delete_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            delete_btn.Location = new Point(199, 35);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(368, 34);
            delete_btn.TabIndex = 2;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // PlaysDB
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(delete_btn);
            Controls.Add(dgv_plays);
            Controls.Add(Back_btn_db);
            Name = "PlaysDB";
            Text = "PlaysDB";
            Load += PlaysDB_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_plays).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Back_btn_db;
        private DataGridView dgv_plays;
        private Button delete_btn;
    }
}