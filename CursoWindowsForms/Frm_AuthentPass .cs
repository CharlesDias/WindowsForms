using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_AuthentPass : Form
    {

        bool ShowPasswordTxt = false;

        public Frm_AuthentPass()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Password.Text = "";
            Lbl_Result.Text = "";
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha checkPass = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha strongPass;
            strongPass = checkPass.GetForcaDaSenha(Txt_Password.Text);
            Lbl_Result.Text = strongPass.ToString();

            if(Lbl_Result.Text == "Inaceitavel" || Lbl_Result.Text == "Fraca")
            {
                Lbl_Result.ForeColor = Color.Red;
            }
            else if (Lbl_Result.Text == "Aceitavel")
            {
                Lbl_Result.ForeColor = Color.Yellow;
            }
            else if (Lbl_Result.Text == "Forte" || Lbl_Result.Text == "Segura")
            {
                Lbl_Result.ForeColor = Color.Green;
            }
        }

        private void Btn_ShowPassword_Click(object sender, EventArgs e)
        {
            if(ShowPasswordTxt == false)
            {
                Btn_ShowPassword.Text = "Hide Password";
                Txt_Password.PasswordChar = '\0';
                ShowPasswordTxt = true;
            }
            else
            {
                Btn_ShowPassword.Text = "Show Password";
                Txt_Password.PasswordChar = '*';
                ShowPasswordTxt = false;
            }
        }
    }


    public class ChecaForcaSenha
    {

        public enum ForcaDaSenha
        {
            Inaceitavel,
            Fraca,
            Aceitavel,
            Forte,
            Segura
        }

        public int geraPontosSenha(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPontoPorTamanho(senha);
            int pontosPorMinusculas = GetPontoPorMinusculas(senha);
            int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
            int pontosPorDigitos = GetPontoPorDigitos(senha);
            int pontosPorSimbolos = GetPontoPorSimbolos(senha);
            int pontosPorRepeticao = GetPontoPorRepeticao(senha);
            return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
        }

        private int GetPontoPorTamanho(string senha)
        {
            return Math.Min(10, senha.Length) * 7;
        }

        private int GetPontoPorMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorDigitos(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 6;
        }

        private int GetPontoPorSimbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorRepeticao(string senha)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }


        public ForcaDaSenha GetForcaDaSenha(string senha)
        {
            int placar = geraPontosSenha(senha);

            if (placar < 50)
                return ForcaDaSenha.Inaceitavel;
            else if (placar < 60)
                return ForcaDaSenha.Fraca;
            else if (placar < 80)
                return ForcaDaSenha.Aceitavel;
            else if (placar < 100)
                return ForcaDaSenha.Forte;
            else
                return ForcaDaSenha.Segura;
        }
    }
}
