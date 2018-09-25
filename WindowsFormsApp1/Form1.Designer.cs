namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPalabras = new System.Windows.Forms.Label();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.lblEspacios = new System.Windows.Forms.Label();
            this.lblTabuladores = new System.Windows.Forms.Label();
            this.lblLineas = new System.Windows.Forms.Label();
            this.lblVocales = new System.Windows.Forms.Label();
            this.lblConsonantes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cboQuitar = new System.Windows.Forms.ComboBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(82, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(389, 26);
            this.txtPath.TabIndex = 1;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(477, 13);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(96, 34);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(15, 53);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(558, 116);
            this.txtContent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palabras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caracteres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Espacios en Blanco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tabuladores:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Líneas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Vocales:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Consonantes:";
            // 
            // lblPalabras
            // 
            this.lblPalabras.AutoSize = true;
            this.lblPalabras.Location = new System.Drawing.Point(175, 187);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(51, 20);
            this.lblPalabras.TabIndex = 11;
            this.lblPalabras.Text = "label9";
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Location = new System.Drawing.Point(175, 207);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(51, 20);
            this.lblCaracteres.TabIndex = 12;
            this.lblCaracteres.Text = "label9";
            // 
            // lblEspacios
            // 
            this.lblEspacios.AutoSize = true;
            this.lblEspacios.Location = new System.Drawing.Point(175, 227);
            this.lblEspacios.Name = "lblEspacios";
            this.lblEspacios.Size = new System.Drawing.Size(51, 20);
            this.lblEspacios.TabIndex = 13;
            this.lblEspacios.Text = "label9";
            // 
            // lblTabuladores
            // 
            this.lblTabuladores.AutoSize = true;
            this.lblTabuladores.Location = new System.Drawing.Point(175, 247);
            this.lblTabuladores.Name = "lblTabuladores";
            this.lblTabuladores.Size = new System.Drawing.Size(51, 20);
            this.lblTabuladores.TabIndex = 14;
            this.lblTabuladores.Text = "label9";
            // 
            // lblLineas
            // 
            this.lblLineas.AutoSize = true;
            this.lblLineas.Location = new System.Drawing.Point(175, 267);
            this.lblLineas.Name = "lblLineas";
            this.lblLineas.Size = new System.Drawing.Size(51, 20);
            this.lblLineas.TabIndex = 15;
            this.lblLineas.Text = "label9";
            // 
            // lblVocales
            // 
            this.lblVocales.AutoSize = true;
            this.lblVocales.Location = new System.Drawing.Point(175, 287);
            this.lblVocales.Name = "lblVocales";
            this.lblVocales.Size = new System.Drawing.Size(51, 20);
            this.lblVocales.TabIndex = 16;
            this.lblVocales.Text = "label9";
            // 
            // lblConsonantes
            // 
            this.lblConsonantes.AutoSize = true;
            this.lblConsonantes.Location = new System.Drawing.Point(175, 307);
            this.lblConsonantes.Name = "lblConsonantes";
            this.lblConsonantes.Size = new System.Drawing.Size(51, 20);
            this.lblConsonantes.TabIndex = 17;
            this.lblConsonantes.Text = "label9";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.lblConsonantes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblVocales);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.lblLineas);
            this.panel1.Controls.Add(this.btnExaminar);
            this.panel1.Controls.Add(this.lblTabuladores);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblEspacios);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCaracteres);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPalabras);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 359);
            this.panel1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Quitar:";
            // 
            // cboQuitar
            // 
            this.cboQuitar.FormattingEnabled = true;
            this.cboQuitar.Location = new System.Drawing.Point(74, 383);
            this.cboQuitar.Name = "cboQuitar";
            this.cboQuitar.Size = new System.Drawing.Size(121, 28);
            this.cboQuitar.TabIndex = 20;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(201, 383);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(96, 34);
            this.btnProcess.TabIndex = 21;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 34);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Guardar como...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.cboQuitar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label lblEspacios;
        private System.Windows.Forms.Label lblTabuladores;
        private System.Windows.Forms.Label lblLineas;
        private System.Windows.Forms.Label lblVocales;
        private System.Windows.Forms.Label lblConsonantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboQuitar;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSave;
    }
}

