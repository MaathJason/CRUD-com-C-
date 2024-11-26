using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_com_C_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            // Consulta SQL para buscar todos os dados da tabela
            string query = "SELECT * FROM cadastroclientes";

            using (MySqlConnection connection = new MySqlConnection(conexaobanco.servidorbanco))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();  // Usado para armazenar os dados

                try
                {
                    connection.Open();
                    da.Fill(dt);  // Preenche o DataTable com os dados da consulta
                    dataGridView1.DataSource = dt;  // Define o DataSource do DataGridView
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
