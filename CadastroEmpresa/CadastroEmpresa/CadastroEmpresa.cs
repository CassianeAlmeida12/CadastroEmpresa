using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CadastroEmpresa
{
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Cnpj = cnpj.Text;
                string RazaoSocial = razaoSocial.Text;
                string NomeFantasia = nomeFantasia.Text;
                string SituacaoCadastral = situacaoCadastral.Text;
                string Regimetributario = "";
                string DataInicioAt = dataInicioAt.Text;
                string MaskedTextBox1 = maskedTextBox1.Text;
                double CapitalSocial = Convert.ToDouble(capitalSocial.Text);
                string Cidade = cidade.Text;
                string Estado = estado.Text;
                string TextBox4 = textBox4.Text;
                string TipoEmpresa = "";
                string PorteEmpresa = "";
                string ComboBox1 = comboBox1.Text;
                string TextBox3 = textBox3.Text;
                string Cpf = cpf.Text;



                //Regimetributario
                if (SimplesNacional.Checked == true)
                {
                    Regimetributario = SimplesNacional.Text;
                }
                else if (LucroPresumido.Checked == true)
                {
                    Regimetributario = LucroPresumido.Text;
                }
                else
                {
                    Regimetributario = Real.Text;
                }


                //TipoEmpresa
                if (radioButton1.Checked == true)
                {
                    TipoEmpresa = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    TipoEmpresa = radioButton2.Text;
                }


                //PorteEmpresa
                if (radioButton3.Checked == true)
                {
                    PorteEmpresa = radioButton3.Text;
                }
                else if (radioButton4.Checked == true)
                {
                    PorteEmpresa = radioButton4.Text;
                }
                else
                {
                    PorteEmpresa = radioButton5.Text;
                }

                if (Validacao.ValidaCpf(Cpf))
                {
                    MessageBox.Show($"{Cnpj}\n{RazaoSocial}\n{NomeFantasia}\n{SituacaoCadastral}\n{Regimetributario}\n{DataInicioAt}\n" +
                        $"{MaskedTextBox1}\n{CapitalSocial}\n{Cidade}\n{Estado}\n{TextBox4}\n{TipoEmpresa}\n{PorteEmpresa}\n{ComboBox1}\n{TextBox3}\n{Cpf}");
                }
                else
                {
                    MessageBox.Show("Cpf invalido");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message);
            }
    

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void novo_Click(object sender, EventArgs e)
        {
            cnpj.Clear();
            razaoSocial.Clear();
            nomeFantasia.Clear();
            dataInicioAt.Clear();
            maskedTextBox1.Clear();
            capitalSocial.Clear();
            cidade.Clear();
            textBox4.Clear();
            textBox3.Clear();
            cpf.Clear();
            comboBox1.ResetText();
            estado.ResetText();
            situacaoCadastral.ResetText();
        }
    }
}
