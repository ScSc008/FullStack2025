using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1_210825
{
    public partial class FormularioConsulta : Form
    {
        List<Pagamento> lista = new List<Pagamento> { };

        public FormularioConsulta()
        {
            InitializeComponent();
        }

        private void FormularioConsulta_Load(object sender, EventArgs e)
        {

            //select * from pagamentos order by data
            string conexao = "Server=localhost;Database=Aula2108;Integrated Security=True;TrustserverCertificate=True;";

            SqlConnection con = new SqlConnection(conexao);
            con.Open(); //abrir conexao

            string sql = "select * from pagamentos order by data";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader(); // ler dados

            //percorrer todas as listas do selct para adc na lista
            while(dr.Read())//le uma linha do select
            {
                Pagamento obj = new Pagamento() { 
                    Id = int.Parse(dr["id"].ToString()),
                    data = DateTime.Parse(dr["data"].ToString()),
                    valor = decimal.Parse(dr["valor"].ToString()),
                    tipoPagamento = (tipoPagamento)int.Parse(dr["tipopagamento"].ToString())
                
                };

                lista.Add(obj);
            }

            //fechar as cvs
            dr.Close();
            con.Close();
            //atruir a lista na datagridview
            dataGridView1.DataSource = lista;

        }
    }
}
