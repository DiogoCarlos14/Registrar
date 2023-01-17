using Microsoft.Win32;

namespace Registrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_nome.ForeColor = Color.Black;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void txt_nome_Click(object sender, EventArgs e)
        {
            txt_nome.Text = string.Empty;
            txt_nome.ForeColor = Color.Black;
        }
        private void Limpar()
        {
            txt_nome.ResetText();
            txt_email.ResetText();
            txt_login.ResetText();
            txt_senha.ResetText();
            txt_nome.Focus();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nome.Equals("") || txt_nome.Text.Length < 3)
                {
                    throw new Exception("O nome deve ter pelo menos 3 caracteres");
                }
                if (txt_login.Equals("") || txt_nome.Text.Length < 3)
                {
                    throw new Exception("O nome deve ter pelo menos 3 caracteres");
                }
                if (txt_email.Equals("") || txt_nome.Text.Length < 3)
                {
                    throw new Exception("O nome deve ter pelo menos 3 caracteres");
                }
                if (txt_senha.Equals("") || txt_nome.Text.Length < 3)
                {
                    throw new Exception("O nome deve ter pelo menos 5 caracteres");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            try
            {
                Stream ficheiro = File.Open("utilizadores.txt", FileMode.Create, FileAccess.Write);
                StreamWriter registo = new StreamWriter(ficheiro);

                registo.WriteLine(txt_senha.Text);
                registo.WriteLine(txt_nome.Text);
                registo.WriteLine(txt_login.Text);
                registo.WriteLine(txt_email.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

             /*
            //Leitura do ficheiro
            try
            {
                string caminho = "utilizadores.dat";
                Stream ficheiro = File.Open(caminho, FileMode.Open, FileAccess.Read);
                StreamWriter registo = new StreamWriter(ficheiro);

                registo.Close();
                ficheiro.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             */
        }
        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}  