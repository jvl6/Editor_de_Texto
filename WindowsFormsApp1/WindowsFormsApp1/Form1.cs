using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        private string filePath;
        private string fileText;
        private OpenFileDialog opf;

        public Form1() {
            InitializeComponent();
            Init();
        }

        private void SetLabelToZero() {
            lblPalabras.Text = "0";
            lblCaracteres.Text = "0";
            lblEspacios.Text = "0";
            lblTabuladores.Text = "0";
            lblLineas.Text = "0";
            lblVocales.Text = "0";
            lblConsonantes.Text = "0";
        }

        private void Init() {
            this.Text = "Procesador de Texto";
            this.CenterToScreen();

            SetLabelToZero();

            txtPath.ReadOnly = true;
            txtContent.ReadOnly = true;

            cboQuitar.Items.AddRange(new string[] { "Espacios", "Vocales", "Consonantes", "Reset" });
            cboQuitar.SelectedIndex = 0;
        }

        private void btnExaminar_Click(object sender, EventArgs e) {
            SetLabelToZero();

            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Abrir";
            opf.Filter = "Documentos de texto|*.txt";

            if (opf.ShowDialog() == DialogResult.OK) {
                filePath = opf.InitialDirectory + opf.FileName;
                txtPath.Text = filePath;
                fileText = System.IO.File.ReadAllText(filePath);
                txtContent.Text = fileText;

                foreach (string text in fileText.Split()) {
                    if (new Regex("[a-z]").Match(text).Success) {
                        lblPalabras.Text = (int.Parse(lblPalabras.Text) + 1).ToString();
                    }
                }

                lblCaracteres.Text = fileText.Replace(" ", "").Trim().ToCharArray().Length.ToString();
                lblEspacios.Text = fileText.Count(ch => ch == ' ').ToString();
                lblTabuladores.Text = fileText.Count(ch => ch == '\t').ToString();
                lblLineas.Text = fileText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length.ToString();

                foreach (char text in fileText.Replace(" ", "").Trim().ToCharArray()) {
                    if (new Regex("[aeiou]").Match(text.ToString()).Success) {
                        lblVocales.Text = ((int.Parse(lblVocales.Text)) + 1).ToString();
                    } else if (new Regex("[a-z-[aeiou]]").Match(text.ToString()).Success) {
                        lblConsonantes.Text = (int.Parse(lblConsonantes.Text) + 1).ToString();
                    }
                }
            }
        }

        private void CountTextBoxContent() {
            SetLabelToZero();

            foreach (string text in txtContent.Text.Split()) {
                if (new Regex("[a-z]").Match(text).Success) {
                    lblPalabras.Text = (int.Parse(lblPalabras.Text) + 1).ToString();
                }
            }

            lblCaracteres.Text = txtContent.Text.Replace(" ", "").Trim().ToCharArray().Length.ToString();
            lblEspacios.Text = txtContent.Text.Count(ch => ch == ' ').ToString();
            lblTabuladores.Text = txtContent.Text.Count(ch => ch == '\t').ToString();
            lblLineas.Text = txtContent.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length.ToString();

            foreach (char text in txtContent.Text.Replace(" ", "").Trim().ToCharArray()) {
                if (new Regex("[aeiou]").Match(text.ToString()).Success) {
                    lblVocales.Text = ((int.Parse(lblVocales.Text)) + 1).ToString();
                } else if (new Regex("[a-z-[aeiou]]").Match(text.ToString()).Success) {
                    lblConsonantes.Text = (int.Parse(lblConsonantes.Text) + 1).ToString();
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e) {
            if (cboQuitar.SelectedItem.Equals("Espacios")) {
                StringBuilder sb = new StringBuilder(txtContent.Text);
                //txtContent.Text = txtContent.Text.Replace(" ", "").Trim();
                sb.Replace(" ", "");
                sb.Replace("\t", "");
                txtContent.Text = sb.ToString();
                CountTextBoxContent();
            } else if (cboQuitar.SelectedItem.Equals("Vocales")) {
                txtContent.Text = Regex.Replace(txtContent.Text, "[aeiou]", "");
                CountTextBoxContent();
            } else if (cboQuitar.SelectedItem.Equals("Consonantes")) {
                txtContent.Text = Regex.Replace(txtContent.Text, "[a-z-[aeiou]]", "");
                CountTextBoxContent();
            } else {
                txtContent.Text = fileText;
                CountTextBoxContent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Guardar";
            sfd.Filter = "Documentos de texto|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK) {
                StreamWriter writer = new StreamWriter(sfd.OpenFile());
                writer.WriteLine(txtContent.Text);
                writer.Dispose();
                writer.Close();
            }
        }
    }
}
