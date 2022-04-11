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

            label_laison_a_changer.Visible = false;
            label_nvl_duree.Visible = false;
            tb_idliaison_uppd.Visible = false;
            tb_duree_uppd.Visible = false;
            tb_tarif_uppd.Visible = false;
            lb_nvTarif.Visible = false;


        }


        //CETTE METHODE PERMET L'AFFICHAGE DE LA TABLE LIAISON
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

        //CETTE METHODE N'EST PAS UTIL
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.MultiSelect = false;
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

        //CETTE REQUETE PERMET L'INSERTION D'UNE LIAISON
        private void btn_insert_Click(object sender, EventArgs e)
        {
           
            // requête paramétrée
            string req = "insert into liaison(duree,port_depart_id, port_arrivee_id, le_secteur_id) values (" +(tb_duree.Text + "," + tb_idportdepart.Text + "," + tb_idportarrivee.Text + "," + tb_idsecteur.Text + ")";

            com2 = maConnexionSql.reqExecParametree(req);


            //CE GROUPE DE COMMANDE PERMET DE CONTROLER LE TYPE, AINSI QUE LA QUANTITE DE CARACTERE QUE PEUVENT CONTENIR LES TEXTBOX AFIN D'ETRE EN ACCORD AVEC LA BASE DE DONNEE
            com2.Parameters.Add("@tb_duree", MySqlDbType.VarChar, 10);
            com2.Parameters["@tb_duree"].Value = tb_duree.Text;

            com2.Parameters.Add("@tb_idportdepart", MySqlDbType.Int32, 3);
            com2.Parameters["@tb_idportdepart"].Value = Convert.ToInt32(tb_idportdepart.Text);

            com2.Parameters.Add("@tb_idportarrivee", MySqlDbType.Int32, 3);
            com2.Parameters["@tb_idportarrivee"].Value = Convert.ToInt32(tb_idportarrivee.Text);

            com2.Parameters.Add("@tb_idsecteur", MySqlDbType.Int32, 3);
            com2.Parameters["@tb_idsecteur"].Value = Convert.ToInt32(tb_idsecteur.Text);

            int affectedrows = com2.ExecuteNonQuery();

            affiche();
        }


        //CETTE METHODE PERMET DE MODIFIER LA DUREE EN FONCTION DE LA LIAISON
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
 
                //c'est cette requête qui sera exécuter lors du click sur le boutton "update".
                string req = "update liaison set duree = '" + tb_duree_uppd.Text + "' where id = " + tb_idliaison_uppd.Text;
                com2 = maConnexionSql.reqExec(req);
                int affectedrows = com2.ExecuteNonQuery();
                
                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //CETTE METHODE PERMET DE SUPPRIMER UNE LIAISON
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //c'est la requête 
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
            label_laison_a_changer.Visible = false;
            label_nvl_duree.Visible = false;
            tb_idliaison_uppd.Visible = false;
            tb_duree_uppd.Visible = false;


        }

        //CETTE METHODE PERMET DE VOIR TOUT LES TARIF POUR UNE LIAISON SELECTIONNER DANS LA DVG1
        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_laison_a_changer.Visible = true;
            label_nvl_duree.Visible = true;
            tb_idliaison_uppd.Visible = true;
            tb_duree_uppd.Visible = true;
            tb_tarif_uppd.Visible = false;
            lb_nvTarif.Visible = false;

            try
            {
                dt2 = new DataTable();

                //idliaison va prendre en valeur id (qui est en string) de la table liaison et va le convertir en int.
                int idliaison = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                oCom = maConnexionSql.reqExec("SELECT la_liaison_id, clibelle, libelle  ,la_periode_id,tarif FROM tarifer as ta JOIN type as ty ON ta.le_type_id = ty.id JOIN categorie as c ON ty.la_categorie_id = c.id where la_liaison_id='" + idliaison + "'");

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(oCom);

                myDataAdapter.Fill(dt2);

                dgv2.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_laison_a_changer.Visible = false;
            label_nvl_duree.Visible = false;
            tb_idliaison_uppd.Visible = false;
            tb_duree_uppd.Visible = false;
            tb_tarif_uppd.Visible = true;
            lb_nvTarif.Visible = true;


        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            maConnexionSql.CloseConnection();
        }

    }
}