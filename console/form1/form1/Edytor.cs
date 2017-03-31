using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Edytor : Form
    {
        #region Private fields
        bool changes = false;
        #endregion
        
        public Edytor()
        {
            InitializeComponent();
        }

        #region Methods
        public static string[] CzytajPlikTekstowy(string nazwaPliku)
        {
            List<string> tekst = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(nazwaPliku)) //gwarantuje usunięcei sr po wyjściu z bloku using
                {
                    string wiersz;
                    while ((wiersz = sr.ReadLine()) != null)
                    {
                        tekst.Add(wiersz);
                    }
                }
                    
                return tekst.ToArray();
            }
            catch(Exception e)
            {
                MessageBox.Show("Błąd odczytu pliku " + nazwaPliku + " (" + e.Message + ")");
                return null;
            }
        }

        public void ZapisDoPliku(string nazwaPliku, string[] tekst)
        {
            using (StreamWriter sw = new StreamWriter(nazwaPliku))
            {
                foreach(string wiersz in tekst)
                {
                    sw.WriteLine(wiersz);
                }
            }
        }

        private void Edytor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes == true)
            {
                DialogResult dr = MessageBox.Show("Zapisać zmiany w dokumencie?",
                                                    this.Text,
                                                    MessageBoxButtons.YesNoCancel,
                                                    MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button3);
                switch (dr)
                {
                    case DialogResult.Yes: zapiszJakoToolStripMenuItem_Click(null, null); break;
                    case DialogResult.No: break;
                    case DialogResult.Cancel: e.Cancel = true; break;
                    default: e.Cancel = true; break;
                }
            }
            else
                e.Cancel = false;
        }

        #endregion


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) //otwarcie okna dialogowego, które wcześniej dodałem do widoku formy
            {
                string nazwaPliku = openFileDialog1.FileName;
                textBox1.Lines = CzytajPlikTekstowy(nazwaPliku);
                int ostatniSlach = nazwaPliku.LastIndexOf('\\');
                toolStripStatusLabel1.Text = nazwaPliku.Substring(ostatniSlach + 1, nazwaPliku.Length - ostatniSlach - 1);
                changes = false;
            }
            //else
            //{
            //    MessageBox.Show("Błąd otwarcia okna",
            //                    this.Text,
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Error);
            //}


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changes = true;
        }

        private void pasekStanuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = pasekStanuToolStripMenuItem.Checked;
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dir = System.AppDomain.CurrentDomain.BaseDirectory;
                saveFileDialog1.InitialDirectory = dir;
                string nazwaPliku = openFileDialog1.FileName;
                if (nazwaPliku.Length > 0) saveFileDialog1.FileName = nazwaPliku;
                else
                {
                    nazwaPliku = saveFileDialog1.FileName;
                    ZapisDoPliku(nazwaPliku, textBox1.Lines);
                    int ostatniSlash = nazwaPliku.LastIndexOf('\\');
                    toolStripStatusLabel1.Text = nazwaPliku.Substring(ostatniSlash + 1, nazwaPliku.Length - ostatniSlash - 1);
                }
            }
            //else
            //{
            //    MessageBox.Show("Błąd otwarcia okna",
            //                    this.Text,
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Error);
            //}
        }


        private void tłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = textBox1.BackColor;
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            fontDialog1.Color = textBox1.ForeColor;
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = fontDialog1.Color;
                textBox1.Font = fontDialog1.Font;
            }
                
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
