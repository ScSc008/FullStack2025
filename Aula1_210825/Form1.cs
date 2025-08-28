using Microsoft.Data.SqlClient;

namespace Aula1_210825
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txt1.Text),
                    num2 = int.Parse(txt2.Text),
                    resultado = 0;

                resultado = num1 / num2;
                MessageBox.Show("Resultado: " + resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não foi possivel processar, " + "verifique os valores informados nos campos!");

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não foi possivel processar, " + "divisão por zero!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ops.. ocorreu um erro na operação");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private tipoPagamento SelecTipoPag()
        {
            switch (tipoPag.SelectedIndex)
            {
                case 0: return tipoPagamento.credito;
                case 1: return tipoPagamento.debito;
                case 2: return tipoPagamento.dinheiro;
                case 3: return tipoPagamento.pix;
                default: return tipoPagamento.dinheiro;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (valortxt.Text != "" && datatxt.Text != "" && tipoPag.Text != "")
                {
                    Pagamento pagamento = new Pagamento()
                    {

                        Id = 0,
                        data = datatxt.Value,
                        valor = decimal.Parse(valortxt.Text),
                        tipoPagamento = SelecTipoPag()



                    };

                    string conexao = "Server=localhost;Database=Aula2108;Integrated Security=True;TrustserverCertificate=True;";

                    SqlConnection con = new SqlConnection(conexao);
                    con.Open(); //abrir conexao

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into pagamentos (data, valor, tipopagamento)" +
                    "values (@data, @valor, @tipopag)"; // comando

                    cmd.Parameters.Add("@data", System.Data.SqlDbType.DateTime).Value = pagamento.data;
                    cmd.Parameters.Add("@valor", System.Data.SqlDbType.Decimal).Value = pagamento.valor;
                    cmd.Parameters.Add("@tipopag", System.Data.SqlDbType.Int).Value = pagamento.tipoPagamento;

                    cmd.ExecuteNonQuery(); // executar conexao

                    con.Close(); // fechar conexao

                    idtxt.Text = "";
                    valortxt.Text = "";
                    MessageBox.Show("Dados salvos!");

                }
                else MessageBox.Show("Preencha os campos!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormularioConsulta frm = new FormularioConsulta();
            frm.ShowDialog();
        }
    }
}
