using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class PlaysDB : Form
    {
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private int lastId = 0;

        private int currentId = 0;

        public PlaysDB()
        {
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-9PT8N4J\\MSSQLSERVER1;Database=tictactoe;Trusted_Connection=True;TrustServerCertificate=True");
            adapter = new SqlDataAdapter();
            dataTable = new DataTable();
        }

        private void PlaysDB_Load(object sender, EventArgs e)
        {
            GetInstructors();
        }

        private void GetInstructors()
        {
            // select command
            SqlCommand selectCmd = new SqlCommand("select [id], [play1], [play1_score], [play2],[play2_score],[playDate] from plays", con);

            // adaptor
            adapter.SelectCommand = selectCmd;

            dataTable.Clear();
            adapter.Fill(dataTable);
            lastId = (int)dataTable.Rows[dataTable.Rows.Count - 1]["id"];

            // display in UI
            dgv_plays.DataSource = dataTable;
            // dgv_instructors.Columns["Dept_Id"].Visible = false;
        }

        void saveChanges()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                Debug.WriteLine($"RowState: {row.RowState}");
            }



            SqlCommand DeleteCmd = new SqlCommand("delete from plays where id = @id", con);
            DeleteCmd.Parameters.Add("id", SqlDbType.Int, 4, "id");

            adapter.DeleteCommand = DeleteCmd;

            adapter.Update(dataTable);

            GetInstructors();
        }

        private void Back_btn_db_Click(object sender, EventArgs e)
        {
            saveChanges();
            TicTacToe.nvg.Dock = DockStyle.Bottom;


        }

        private void dgv_plays_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).SelectedRows[0];
            currentId = (int)row.Cells["id"].Value;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dataTable.NewRow();
            foreach (DataRow row in dataTable.Rows)
            {
                if (row.RowState != DataRowState.Deleted && (int)row["id"] == currentId)
                {
                    dataRow = row; break;
                }
            }
            dataRow.Delete();
        }
    }
}
