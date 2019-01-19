/*
 * Criado por SharpDevelop.
 * Usuário: Ronaldo
 * Data: 27/10/2018
 * Hora: 18:56
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoForcaV2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string palavra;
		int contaErros = 0;
		void Button27Click(object sender, EventArgs e)
		{
			palavra = textBox1.Text;
			panel2.Visible = false;
			
			string aux = "";
			for (int i = 0; i < palavra.Length; i++)
			{
				aux += "?";
			}
			label1.Text = aux;
		}
		void Button1Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			btn.Enabled = false;
			char letra = btn.Text[0];
			
			string aux = "";
			int contaLetra = 0;
			for (int i = 0; i < palavra.Length; i++)
			{
				if (palavra[i] == letra)
				{
					aux += letra;
					contaLetra++;
				}
				else
				{
					aux += label1.Text[i];
				}
			}
			label1.Text = aux;
			
			if (contaLetra == 0)
			{
				contaErros++;
				pictureBox1.Load("forca" + contaErros.ToString() + ".jpg");
				btn.BackColor = Color.Red;
				if (contaErros == 7)
				{
					MessageBox.Show("O jogo acabou!!!\nA palavra secreta era: " + palavra);
					panel1.Visible = false;
				}
			}
			else
			{
				btn.BackColor = Color.Green;
				if (label1.Text == palavra)
				{
					MessageBox.Show("Parabéns, é seu dia de sorte!");
					panel1.Visible = false;
				}
			}
		}
		void Button28Click(object sender, EventArgs e)
		{
			panel1.Visible = true;
			panel2.Visible = true;
			textBox1.Clear();
			pictureBox1.Load("forca0.jpg");
			contaErros = 0;
			
			Button[] btn = {button1, button2, button3, button4, button5, button6, button7,
			button8, button9, button10, button11, button12, button13, button14, button15, button16,
			button17, button18, button19, button20, button21, button22, button23, button24, button25,
			button26};
			for(int i = 0; i < 26; i++)
			{
				btn[i].BackColor = Color.LightGray;
				btn[i].Enabled = true;
			}
		}
	}
}
