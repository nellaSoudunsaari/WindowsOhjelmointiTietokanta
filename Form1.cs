using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsOhjelmointiTietokanta
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet Ds = new DataSet();

        String server = "localhost";
        String username = "root";
        String password = "";
        String database = "musiikkikirjasto";
        public Form1()
        {
            InitializeComponent();
        }

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "username =" + username + ";"
                + "password =" + password + ";" + "database =" + database + ";";

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM musiikkikirjasto.musiikkikirjasto";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {
                iExit = MessageBox.Show("Sulje ohjelma?", "Musiikkikirjasto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel3.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                }
                search.Text = "";
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        private void uusiKappaleBtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "username =" + username + ";"
                + "password =" + password + ";" + "database =" + database + ";";

            try
            {
                sqlConn.Open();
                sqlQuery = "INSERT INTO musiikkikirjasto.musiikkikirjasto (kappaleenLuku, kappaleenNimi, artisti, albumi, kesto)"
                    + "VALUES('" + kappaleenLuku.Text + "' , '" + kappaleenNimi.Text + "' , '" + artisti.Text + "' , '"
                    + albumi.Text + "' , '" + kesto.Text + "')";

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            upLoadData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "username =" + username + ";"
                + "password =" + password + ";" + "database =" + database + ";";
            sqlConn.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();

                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "UPDATE musiikkikirjasto.musiikkikirjasto SET kappaleenLuku = @kappaleenLuku,"+
                    "kappaleenNimi = @kappaleenNimi, artisti = @artisti, albumi = @albumi, kesto = @kesto " +
                    "WHERE kappaleenLuku = @kappaleenLuku";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@kappaleenLuku", kappaleenLuku.Text);
                sqlCmd.Parameters.AddWithValue("@kappaleenNimi", kappaleenNimi.Text);
                sqlCmd.Parameters.AddWithValue("@artisti", artisti.Text);
                sqlCmd.Parameters.AddWithValue("@albumi", albumi.Text);
                sqlCmd.Parameters.AddWithValue("@kesto", kesto.Text);

                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                upLoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kappaleenLuku.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                kappaleenNimi.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                artisti.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                albumi.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                kesto.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
