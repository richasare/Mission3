using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OracleClient;
using MySql.Data.MySqlClient;


namespace Connecté
{
    public partial class Form1 : Form
    {


        private string provider = "localhost";

        private string dataBase = "bdentreprise";

        private string uid = "root" ;

        private string mdp = "" ;

        
        
        private  ConnexionSql   maConnexionSql;

        
        private MySqlCommand oCom,oCom1;

        private DataTable dt;


      
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

         

       maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


        maConnexionSql.OpenConnection();

        
        affiche();
        }

        public void affiche()

        {


            try
            {

                dt = new DataTable();

                oCom = maConnexionSql.reqExec("Select * from employe");

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

                string req = "update employe set login = '" + tbNom.Text + "' where id = " + tbId.Text;

                oCom1 = maConnexionSql.reqExec(req);

                int affectedrows = oCom1.ExecuteNonQuery();

                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {


            string req = "delete from employe where id = " + tbDel.Text;

            oCom1 = maConnexionSql.reqExec(req);

            int affectedrows = oCom1.ExecuteNonQuery();

            affiche();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // string req = "insert into employe1 values (" + tId.Text + ",'" + tLogin.Text + "')";


            // requête paramétrée
            string req = "insert into employe(id,login) values (@id,@login)";



            oCom1 = maConnexionSql.reqExecParametree(req);

       
          oCom1.Parameters.Add( "@id", MySqlDbType.Int32,3);

          oCom1.Parameters["@id"].Value = Convert.ToInt32(tId.Text);


           oCom1.Parameters.Add("@login", MySqlDbType.VarChar, 30);

           oCom1.Parameters["@login"].Value = tLogin.Text;


           
            int affectedrows = oCom1.ExecuteNonQuery();

            affiche();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                maConnexionSql.CloseConnection() ;
            }

                }

              
              


            }

           
            
            
        
            
           
        
    

