using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunfuankenda_NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Lunfuankenda NotePad";
            this.WindowState = FormWindowState.Maximized;
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Arquivo de Texto (.txt)|*.txt";
            open.Title = "Abra um Ficheiro";
            if(open.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader stream = new System.IO.StreamReader(open.FileName);
                richTextBox1.Text = stream.ReadToEnd();
                stream.Close();
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Arquivo de Texto (.txt)|*.txt";
            save.Title = "Salvar Arquivo...";
            if(save.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(save.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void refazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
        }

        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = document;
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string texto = richTextBox1.Text;
            Font fonteExemplo = new Font("Arial", 12, FontStyle.Regular);
            Point pontoInicial = new Point(100, 100);
            e.Graphics.DrawString(texto, fonteExemplo, Brushes.Black, pontoInicial);
        }

        private void símbolosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("charmap.exe");
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            //Verifica se há texto selecionado no RichTextBox
            if(richTextBox1.SelectionLength > 0)
            {
                //Obtém a fonte atual do texto selecionado
                Font currentFont = richTextBox1.SelectionFont;

                //Define as novas opções de formatação
                FontStyle fontStyle = FontStyle.Regular;
                if(negritoToolStripMenuItem.Checked) fontStyle |= FontStyle.Bold;
                if (itálicoToolStripMenuItem.Checked) fontStyle |= FontStyle.Italic;
                if (sublinhadoToolStripMenuItem.Checked) fontStyle |= FontStyle.Underline;

                //Aplica as novas opções de formatação ao texto selecionado
                richTextBox1.SelectionFont = new Font(currentFont, fontStyle);
            }

            //Atualiza o estado dos itens do menu de alinhamento com base no alinhamento do parágrafo atual
            esquerdaToolStripMenuItem.Checked = richTextBox1.SelectionAlignment == HorizontalAlignment.Left;
            centroToolStripMenuItem.Checked = richTextBox1.SelectionAlignment == HorizontalAlignment.Center;
            direitaToolStripMenuItem.Checked = richTextBox1.SelectionAlignment == HorizontalAlignment.Right;
            
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Inverte o estado da opção de negrito (pressionado/não pressionado)
            negritoToolStripMenuItem.Checked = !negritoToolStripMenuItem.Checked;
            richTextBox1.Focus();  //Retorne o foco ao RichTextBox após alterar o estado da opção
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itálicoToolStripMenuItem.Checked = !itálicoToolStripMenuItem.Checked;
            richTextBox1.Focus();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sublinhadoToolStripMenuItem.Checked = !sublinhadoToolStripMenuItem.Checked;
            richTextBox1.Focus();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void justificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 0;
            richTextBox1.SelectionRightIndent = 0;

            int charCount = richTextBox1.TextLength;
            int start = 0;

            //Percorre todo o texto para ajustar o alinhamento
            while(start < charCount)
            {
                int lineStart = richTextBox1.GetFirstCharIndexFromLine(richTextBox1.GetLineFromCharIndex(start));
                int lineEnd = richTextBox1.GetFirstCharIndexFromLine(richTextBox1.GetLineFromCharIndex(start) + 1);

                //Verifica se chegou ao fim do texto
                if(lineEnd == -1 || lineEnd >= charCount)
                {
                    lineEnd = charCount - 1;
                }

                //Obtém o texto da linha atual
                string lineText = richTextBox1.Text.Substring(lineStart, lineEnd - lineStart);
                //Calcula a quantidade de espaços em branco para justificar a linha
                int spacesCount = richTextBox1.Width - TextRenderer.MeasureText(lineText, richTextBox1.Font).Width;
                //Avança para a próxima linha
                start = lineEnd + 1;
            }
        }

        private void tamanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog tamanho = new FontDialog();
            tamanho.ShowEffects = false;
            tamanho.FontMustExist = true;
            if(tamanho.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = tamanho.Font;
                //Aplica o tamanho da fonte selecionada ao texto selecionado no RichTextBox
                richTextBox1.SelectionFont = new Font(selectedFont.FontFamily, richTextBox1.SelectionFont.Size, selectedFont.Style);
            }
        }

        private void AlterarTamanhoFonte(Font novaFonte)
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = novaFonte;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 8, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 9, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 10, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 11, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 12, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 14, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 16, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 18, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 20, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 22, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 24, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 28, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 32, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 36, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 48, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 54, richTextBox1.SelectionFont.Style));
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 60, richTextBox1.SelectionFont.Style));
        }

        private void tipoDeLetraFontesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font_family = new FontDialog();
            font_family.ShowEffects = false;
            font_family.FontMustExist = true;
            if (font_family.ShowDialog() == DialogResult.OK)
            {
                Font fontes = font_family.Font;
                richTextBox1.SelectionFont = new Font(fontes.FontFamily, richTextBox1.SelectionFont.Size, fontes.Style);
            }
        }

        private void AplicarFormatoLetras(Func<string, string> formatacao)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                int inicioSelecao = richTextBox1.SelectionStart;
                string textoSelecionado = richTextBox1.SelectedText;
                string textoFormatado = formatacao(textoSelecionado);

                richTextBox1.Select(inicioSelecao, richTextBox1.SelectionLength);
                richTextBox1.SelectedText = textoFormatado;
            }
        }

        private void mAIÚSCULASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarFormatoLetras(texto => texto.ToUpper());
        }

        private void minúsculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarFormatoLetras(texto => texto.ToLower());
        }

        private void primeiraLetraMaiúsculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarFormatoLetras(CapitalizarPrimeiraLetra);
        }

        private void cadaPalavraMaiúsculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarFormatoLetras(CapitalizarCadaPalavra);
        }

        private string CapitalizarPrimeiraLetra(string texto)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto);
        }

        private string CapitalizarCadaPalavra(string texto)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto.ToLower());
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                Color cor_selecionada = color.Color;

                if(richTextBox1.SelectionLength > 0)
                {
                    richTextBox1.SelectionColor = cor_selecionada;
                }
            }
        }

        private void avançarParágrafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarIndentacao(50);
        }

        private void recuarParágrafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarIndentacao(-50);
        }

        private void AplicarIndentacao(int indentacao)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                int inicioSelecao = richTextBox1.SelectionStart;
                int fimSelecao = inicioSelecao + richTextBox1.SelectionLength;
                int linhaInicial = richTextBox1.GetLineFromCharIndex(inicioSelecao);
                int linhaFinal = richTextBox1.GetLineFromCharIndex(fimSelecao);

                for(int linha = linhaInicial; linha <= linhaFinal; linha++)
                {
                    int inicioLinha = richTextBox1.GetFirstCharIndexFromLine(linha);
                    int fimLinha = inicioLinha + richTextBox1.Lines[linha].Length;

                    richTextBox1.Select(inicioLinha, fimLinha - inicioLinha);
                    if(indentacao > 0)
                    {
                        richTextBox1.SelectionIndent += indentacao;
                    }
                    else
                    {
                        richTextBox1.SelectionIndent = Math.Max(0, richTextBox1.SelectionIndent - Math.Abs(indentacao));
                    }
                }
                //Retorna a seleção para a posição original
                richTextBox1.Select(inicioSelecao, richTextBox1.SelectionLength);
            }
        }

        private int contador_lista = 1;

        private void marcasDeListasBulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarMarcasDeListas();
        }

        private void numeraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarNumeraçao();
        }

        private void AplicarMarcasDeListas()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                int inicioSelecao = richTextBox1.SelectionStart;
                int fimSelecao = inicioSelecao + richTextBox1.SelectionLength;

                richTextBox1.Select(inicioSelecao, richTextBox1.SelectionLength);

                //Define a formatação para a lista desordenada
                richTextBox1.SelectionBullet = true;
                richTextBox1.SelectionIndent = 50;

                //Retorna a seleção para a posição original
                richTextBox1.Select(inicioSelecao, richTextBox1.SelectionLength);
            }
        }

        private void AplicarNumeraçao()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                int inicioSelecao = richTextBox1.SelectionStart;
                int fimSelecao = inicioSelecao + richTextBox1.SelectionLength;

                richTextBox1.Select(inicioSelecao, richTextBox1.SelectionLength);

                //Define o formato para a numeração
                richTextBox1.SelectionBullet = false;
                richTextBox1.SelectionIndent = 50;

                //Percorre as linhas selecionadas e aplica a numeração
                for (int i = richTextBox1.GetLineFromCharIndex(inicioSelecao); i <= richTextBox1.GetLineFromCharIndex(fimSelecao); i++)
                {
                    int lineStart = richTextBox1.GetFirstCharIndexFromLine(i);
                    int lineEnd = lineStart + richTextBox1.Lines[i].Length;

                    //Verifica se a linha não está vazia
                    if (!string.IsNullOrWhiteSpace(richTextBox1.Lines[i]))
                    {
                        richTextBox1.Select(lineStart, lineEnd - lineStart);
                        richTextBox1.SelectedText = $"{contador_lista}. {richTextBox1.Lines[i]}";
                        contador_lista++;
                    }
                }
                //Retorna a seleção para a posição original
                richTextBox1.Select(inicioSelecao, richTextBox1.SelectionLength);
            }
        }

        private void dataEHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();

            //Define o formato do DateTimePicker para exibir a data e a hora
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            string dataHora_selecionada = dateTimePicker.Value.ToString(dateTimePicker.CustomFormat);
            //Insere a data/hora no RichTextBox na posição do cursor
            richTextBox1.SelectedText = dataHora_selecionada;
        }

        private void sobrescritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarSobrescricao();
        }

        private void subescritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarSubscrito();
        }

        private void AplicarSobrescricao()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionCharOffset = 7; //Define o valor adequado para ajustar o texto sobrescrito
                AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 8, richTextBox1.SelectionFont.Style));
            }
        }

        private void AplicarSubscrito()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionCharOffset = -7; //Define o valor adequado para ajustar o texto subscrito
                AlterarTamanhoFonte(new Font(richTextBox1.SelectionFont.FontFamily, 8, richTextBox1.SelectionFont.Style));
            }
        }

        private void AplicarSublinhado(FontStyle style)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                int inicioSelecao = richTextBox1.SelectionStart;
                int fimSelecao = inicioSelecao + richTextBox1.SelectionLength;
                richTextBox1.Select(inicioSelecao, richTextBox1.SelectionLength);

                //Define a formatação de fonte com o sublinhado desejado
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, style);
                //Retorna a seleção para a posição original
                richTextBox1.Select(inicioSelecao, richTextBox1.SelectionLength);
            }
        }

        private void sublinhadoDuploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarSublinhado(FontStyle.Underline | FontStyle.Underline);
        }
        
        private void rasuradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarSublinhado(FontStyle.Strikeout);
        }

        private void sobrelinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarSublinhado(FontStyle.Strikeout | FontStyle.Italic);
        }

        private PictureBox img;
        private string imagem_selecionada;

        private void imagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Arquivos de Imagem|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.ico;*.tif;*.wmf|Todos os Arquivos|*.*";
            if(open.ShowDialog() == DialogResult.OK)
            {
                imagem_selecionada = open.FileName;
                InserirImagem();
            }
        }

        private void InserirImagem()
        {
            if (!string.IsNullOrEmpty(imagem_selecionada))
            {
                if(img == null)
                {
                    img = new PictureBox();
                    img.SizeMode = PictureBoxSizeMode.AutoSize;
                    img.BorderStyle = BorderStyle.FixedSingle;
                    //Adiciona o PictureBox ao formulário
                    this.Controls.Add(img);
                }
                //Carrega a imagem no PictureBox
                img.Image = Image.FromFile(imagem_selecionada);
                //Move o PictureBox para a posição desejada
                img.Location = new Point(50, 50); //Define a posição inicial desejada
                //Exibe a imagem no RichTextBox como uma representação de espaço reservado
                richTextBox1.SelectedRtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1046{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n\viewkind4\\uc1\\pard\\qc\\f0\\fs20\\par\r\n\\par\r\n}\r\n";
            }
        }

        private void emojisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void contarPalavrasCaracteresELinhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numPalavras = ContarPalavras(richTextBox1.Text);
            int numCaracteres = richTextBox1.Text.Length;
            int numLinhas = richTextBox1.Lines.Length;
            string mensagem = $"Número de palavras: {numPalavras}\n" + $"Número de Caracteres: {numCaracteres}\n" + $"Número de Linhas: {numLinhas}";
            MessageBox.Show(mensagem, "Contagem de Palavras, Caracteres e Linhas");
        }

        private int ContarPalavras(string texto)
        {
            int count = 0;
            bool isWord = false;
            foreach(char c in texto)
            {
                if (char.IsLetter(c))
                {
                    if (!isWord)
                    {
                        count++;
                        isWord = true;
                    }
                }
                else if (char.IsWhiteSpace(c))
                {
                    isWord = false;
                }
            }

            return count;
        }

        private void selecionarCorDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if(color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = color.Color;
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Incrementa o ZomFactor em 0.1, limitando em 5.0 (500%)
            if(richTextBox1.ZoomFactor < 5.0f)
            {
                richTextBox1.ZoomFactor += 0.1f;
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Decrementa o ZomFactor em 0.1, limitando em 0.1 (10%)
            if (richTextBox1.ZoomFactor > 0.1f)
            {
                richTextBox1.ZoomFactor -= 0.1f;
            }
        }
    }
}
