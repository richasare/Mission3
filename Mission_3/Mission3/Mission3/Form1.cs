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
        private string nomBdd = "sicilylines";
        private string uid = "root";
        private string mdp = "";

        private ConnexionSql maConnexionSql;
        private MySqlCommand oCom, com2; 
        private DataTable dt;
        private DataTable dt2;

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

        public void affiche2()

        {
            try
            {

                dt2 = new DataTable();

                oCom = maConnexionSql.reqExec("Select la_liaison_id, libelle, la_periode_id, le_type_id, tarif from tarifer as t join liaison as l ON t.la_liaison_id=l.id");

                //      MySqlDataReader reader = oCom.ExecuteReader();

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(oCom);

                myDataAdapter.Fill(dt2);

                dgv1.DataSource = dt2;

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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
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

        private void tb_idsecteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            // string req = "insert into employe1 values (" + tId.Text + ",'" + tLogin.Text + "')";


            // requête paramétrée
            string req = "insert into liaison(duree,port_depart_id, port_arrivee_id, le_secteur_id) values (" + tb_duree.Text + "," + tb_idportdepart.Text + "," + tb_idportarrivee.Text + "," + tb_idsecteur.Text + ")";





            com2 = maConnexionSql.reqExecParametree(req);


            com2.Parameters.Add("@tb_duree", MySqlDbType.VarChar, 10);
            com2.Parameters["@tb_duree"].Value = tb_duree.Text;

            /*com2.Parameters.Add("@tb_duree", MySqlDbType.Int32, 3);
            com2.Parameters["@tb_duree"].Value = Convert.ToInt32(tb_duree.Text);*/

            com2.Parameters.Add("@tb_idportdepart", MySqlDbType.Int32, 3);
            com2.Parameters["@tb_idportdepart"].Value = Convert.ToInt32(tb_idportdepart.Text);

            com2.Parameters.Add("@tb_idportarrivee", MySqlDbType.Int32, 3);
            com2.Parameters["@tb_idportarrivee"].Value = Convert.ToInt32(tb_idportarrivee.Text);

            com2.Parameters.Add("@tb_idsecteur", MySqlDbType.Int32, 3);
            com2.Parameters["@tb_idsecteur"].Value = Convert.ToInt32(tb_idsecteur.Text);

            int affectedrows = com2.ExecuteNonQuery();

            affiche();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                string req = "update liaison set duree = '" + tb_duree.Text + "' where id = " + tb_idliaison_supp.Text;

                com2 = maConnexionSql.reqExec(req);

                int affectedrows = com2.ExecuteNonQuery();

                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string req = "delete from liaison where id = " + tb_idliaison_supp.Text;
            com2 = maConnexionSql.reqExec(req);

            int affectedrows = com2.ExecuteNonQuery();

            affiche();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            maConnexionSql.CloseConnection();
        }

    }
}