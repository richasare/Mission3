using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connecté;
using MySql.Data.MySqlClient;

namespace Mission3
{
    public partial class Form1 : Form
    {
        private string provider = "localhost";
        private string nomBdd = "sicilyLines";
        private string uid = "root";
        private string mdp = "";

        private ConnexionSql maConnexionSql;
        private MySqlCommand oCom, com2;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maConnexionSql = ConnexionSql.getInstance(provider, nomBdd, uid, mdp);
            maConnexionSql.OpenConnection();
            affiche();
        }

        public void affiche()

        {
            try
            {

                dt = new DataTable();

                oCom = maConnexionSql.reqExec("Select * from liaison");

                //      MySqlDataReader reader = oCom.ExecuteReader();

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(oCom);

                myDataAdapter.Fill(dt);

                dgv1.DataSource = dt;

                /*

                                for (int i = 0; i <= reader.FieldCount - 1; i++)
                                {

                                    dt.Columns.Add(reader.GetName(i));
                                }


                                while (reader.Read())
                                {




                                    DataRow dr = dt.NewRow();


                                    for (int i = 0; i <= reader.FieldCount - 1; i++)
                                    {

                                        dr[i] = reader.GetValue(i);
                                    }

                                    dt.Rows.Add(dr);

                                }

                    */


                // DATAGRIDVIEW
                //dgv1.DataSource = dt;

                //     dgv1.Columns[0].ReadOnly = true;

                //    reader.Close();


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }








        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string req = "update liaison set duree = '" + textBox1.Text + "' where id = " + tbId.Text;

                com2 = maConnexionSql.reqExec(req);

                int affectedrows = com2.ExecuteNonQuery();

                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {


            string req = "delete from liaison where id = " + tbId.Text;

            com2 = maConnexionSql.reqExec(req);

            int affectedrows = com2.ExecuteNonQuery();

            affiche();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // string req = "insert into employe1 values (" + tId.Text + ",'" + tLogin.Text + "')";


            // requête paramétrée
            string req = "insert into liaison(id,duree,port_depart_id, port_arrivee_id, le_secteur_id) values ("+tbId.Text+","+textBox1.Text+","+textBox2.Text+","+textBox4.Text+")";





            com2 = maConnexionSql.reqExecParametree(req);


            com2.Parameters.Add("@id", MySqlDbType.Int32, 3);

            com2.Parameters["@id"].Value = Convert.ToInt32(tbId.Text);


            com2.Parameters.Add("@login", MySqlDbType.VarChar, 30);

            com2.Parameters["@login"].Value = textBox1.Text;



            int affectedrows = com2.ExecuteNonQuery();

            affiche();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            maConnexionSql.CloseConnection();
        }

    }
}