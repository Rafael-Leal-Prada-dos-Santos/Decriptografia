using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tp_Decriptografia_RafaelLeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string arqCriptografado;
        private string arqDecriptografado;


        private void btnEscolherArquivoCriptografado_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarArquivoCriptografado = new OpenFileDialog();
            selecionarArquivoCriptografado.DefaultExt = "txt";
            selecionarArquivoCriptografado.InitialDirectory = @"C:\";
            selecionarArquivoCriptografado.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; ;

            if (selecionarArquivoCriptografado.ShowDialog() == DialogResult.OK)
            {
                    arqCriptografado = selecionarArquivoCriptografado.FileName;
                    txtCaminhoArquivoCriptografado.Text = arqCriptografado;                
                                                  
            }
        }

        private void btnEscolherArquivoDeSaida_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarArquivoDecriptografado = new OpenFileDialog();
            selecionarArquivoDecriptografado.DefaultExt = "txt";
            selecionarArquivoDecriptografado.InitialDirectory = @"C:\";
            selecionarArquivoDecriptografado.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; ;

            if (selecionarArquivoDecriptografado.ShowDialog() == DialogResult.OK)
            {
                arqDecriptografado = selecionarArquivoDecriptografado.FileName;

                if (File.Exists(arqDecriptografado))
                {
                    arqDecriptografado = selecionarArquivoDecriptografado.FileName;
                    txtCaminhoArquivoDecriptografado.Text = arqDecriptografado;
                }
                else
                {
                    File.Create(arqCriptografado);
                    arqCriptografado = selecionarArquivoDecriptografado.FileName;
                    txtCaminhoArquivoCriptografado.Text = arqCriptografado;
                }
            }
        }

        private void btnDecriptografar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtChave.Text) && txtChave.Text.Length == 8 && !string.IsNullOrEmpty(arqCriptografado) && !string.IsNullOrEmpty(arqDecriptografado)) {

                try
                {

                    FileStream le = new FileStream(arqCriptografado, FileMode.Open);
                    BinaryReader br = new BinaryReader(le);

                    byte[] bytesTexto = br.ReadBytes((int)le.Length);
                    char[] textoCriptografado = Encoding.UTF8.GetString(bytesTexto).ToCharArray();
                    char[] textoDecriptografado = new char[textoCriptografado.Length];

                    char[] textoChave = txtChave.Text.ToCharArray();
                    long valorChave = 0;

                    for (int i = 0; i < textoChave.Length; i++)
                    {
                        long valorIndice = textoChave[i];
                        valorChave += valorIndice;
                    }


                    char[,] subBytes = new char[8, 8] {

                        { '!', '´', 'ç', 'ô', 'A', ',', '~', '[' },
                        { 'l', 'î', 'Ö', 'B', 'ƒ', 'Ñ', 'Ñ', 'a'},
                        { '£', 'l', 'Ê', '0', 'ú', 'z', 'æ', '{' },
                        { '}', '2', 'P', 'z', '|', ']', '%', '&' },
                        { '$', '*', '<', '.', 'B', 'h', 'o', '?' },
                        { 'j', '#', '@', 'C', 'v', '6', ':', '-' },
                        { ';', 'K', 'V', 'û', 'f', 't', 'T', 'R' },
                        { '=', 'G', 'L', 'S', 'y', 'W', '7', '9' }
                    };

                    for (int i = 0; i < textoCriptografado.Length;)
                    {

                        int l = 0;
                        int c = i;


                        while ((c < subBytes.GetLength(0)) && (i < textoCriptografado.Length))
                        {

                            char valorVetor = subBytes[l, c];


                            textoDecriptografado[i] = (char)(textoCriptografado[i] - valorChave - valorVetor);

                            c++;
                            i++;

                            if (!(c < subBytes.GetLength(0)) && (l < subBytes.GetLength(1)))
                            {
                                c = 0;
                                l++;
                                i++;
                            }
                            if (!(l < subBytes.GetLength(1)))
                            {
                                l = 0;
                                c = 0;
                            }

                        }

                        FileStream escreve = new FileStream(arqDecriptografado, FileMode.Open);
                        BinaryWriter bw = new BinaryWriter(escreve);

                        bw.Write(textoDecriptografado);
                        

                        MessageBox.Show("Decriptografia Bem Sucedida!");

                        le.Close();
                        escreve.Close();
                        br.Close();
                        bw.Close();

                    }
                }
                catch
                {
                    throw new Exception("Não Foi possível Decriptografar o Arquivo!");
                }
                                               
                

            }
            else if (string.IsNullOrEmpty(arqCriptografado))
            {

                MessageBox.Show("Arquivo não escolhido, Selecione  o Arquivo a ser criptografado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(arqDecriptografado))
            {

                MessageBox.Show("Arquivo não escolhido, Selecione  o arquivo de saída ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtChave.Text))
            {

                MessageBox.Show(" Chave não pode estar vazia, Digite uma chave. ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                MessageBox.Show("A chave tem que conter 8 dígitos", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
