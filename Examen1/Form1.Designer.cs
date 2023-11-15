
namespace Examen1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAlturaT = new System.Windows.Forms.TextBox();
            this.txtBaseT = new System.Windows.Forms.TextBox();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.lblalturat = new System.Windows.Forms.Label();
            this.lblbaset = new System.Windows.Forms.Label();
            this.btbAgregaT = new System.Windows.Forms.Button();
            this.btbAreaT = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlturaP = new System.Windows.Forms.TextBox();
            this.txtBaseP = new System.Windows.Forms.TextBox();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btbAreaP = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Aqua;
            this.tabPage1.Controls.Add(this.txtAlturaT);
            this.tabPage1.Controls.Add(this.txtBaseT);
            this.tabPage1.Controls.Add(this.lblTriangulo);
            this.tabPage1.Controls.Add(this.lblalturat);
            this.tabPage1.Controls.Add(this.lblbaset);
            this.tabPage1.Controls.Add(this.btbAgregaT);
            this.tabPage1.Controls.Add(this.btbAreaT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Triangulo";
            // 
            // txtAlturaT
            // 
            this.txtAlturaT.Location = new System.Drawing.Point(176, 80);
            this.txtAlturaT.Name = "txtAlturaT";
            this.txtAlturaT.Size = new System.Drawing.Size(100, 20);
            this.txtAlturaT.TabIndex = 6;
            // 
            // txtBaseT
            // 
            this.txtBaseT.Location = new System.Drawing.Point(176, 45);
            this.txtBaseT.Name = "txtBaseT";
            this.txtBaseT.Size = new System.Drawing.Size(100, 20);
            this.txtBaseT.TabIndex = 5;
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(102, 199);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(35, 13);
            this.lblTriangulo.TabIndex = 4;
            this.lblTriangulo.Text = "label3";
            // 
            // lblalturat
            // 
            this.lblalturat.AutoSize = true;
            this.lblalturat.Location = new System.Drawing.Point(77, 87);
            this.lblalturat.Name = "lblalturat";
            this.lblalturat.Size = new System.Drawing.Size(34, 13);
            this.lblalturat.TabIndex = 3;
            this.lblalturat.Text = "Altura";
            // 
            // lblbaset
            // 
            this.lblbaset.AutoSize = true;
            this.lblbaset.Location = new System.Drawing.Point(77, 52);
            this.lblbaset.Name = "lblbaset";
            this.lblbaset.Size = new System.Drawing.Size(31, 13);
            this.lblbaset.TabIndex = 2;
            this.lblbaset.Text = "Base";
            // 
            // btbAgregaT
            // 
            this.btbAgregaT.Location = new System.Drawing.Point(201, 156);
            this.btbAgregaT.Name = "btbAgregaT";
            this.btbAgregaT.Size = new System.Drawing.Size(75, 23);
            this.btbAgregaT.TabIndex = 1;
            this.btbAgregaT.Text = "AGREGAR";
            this.btbAgregaT.UseVisualStyleBackColor = true;
            this.btbAgregaT.Click += new System.EventHandler(this.btbAgregaT_Click);
            // 
            // btbAreaT
            // 
            this.btbAreaT.Location = new System.Drawing.Point(62, 156);
            this.btbAreaT.Name = "btbAreaT";
            this.btbAreaT.Size = new System.Drawing.Size(75, 23);
            this.btbAreaT.TabIndex = 0;
            this.btbAreaT.Text = "AREA";
            this.btbAreaT.UseVisualStyleBackColor = true;
            this.btbAreaT.Click += new System.EventHandler(this.btbAreaT_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rectangulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(202, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lado B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lado A";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "AREA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtAlturaP);
            this.tabPage3.Controls.Add(this.txtBaseP);
            this.tabPage3.Controls.Add(this.btnAgregarP);
            this.tabPage3.Controls.Add(this.btbAreaP);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(438, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Paralelogramo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Altura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Base";
            // 
            // txtAlturaP
            // 
            this.txtAlturaP.Location = new System.Drawing.Point(182, 83);
            this.txtAlturaP.Name = "txtAlturaP";
            this.txtAlturaP.Size = new System.Drawing.Size(100, 20);
            this.txtAlturaP.TabIndex = 12;
            // 
            // txtBaseP
            // 
            this.txtBaseP.Location = new System.Drawing.Point(182, 48);
            this.txtBaseP.Name = "txtBaseP";
            this.txtBaseP.Size = new System.Drawing.Size(100, 20);
            this.txtBaseP.TabIndex = 11;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(207, 159);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarP.TabIndex = 8;
            this.btnAgregarP.Text = "AGREGAR";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // btbAreaP
            // 
            this.btbAreaP.Location = new System.Drawing.Point(68, 159);
            this.btbAreaP.Name = "btbAreaP";
            this.btbAreaP.Size = new System.Drawing.Size(75, 23);
            this.btbAreaP.TabIndex = 7;
            this.btbAreaP.Text = "AREA";
            this.btbAreaP.UseVisualStyleBackColor = true;
            this.btbAreaP.Click += new System.EventHandler(this.btbAreaP_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Mostrar Pila";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.Location = new System.Drawing.Point(22, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 126);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Location = new System.Drawing.Point(263, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 126);
            this.label9.TabIndex = 4;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(461, 477);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Examen1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAlturaT;
        private System.Windows.Forms.TextBox txtBaseT;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.Label lblalturat;
        private System.Windows.Forms.Label lblbaset;
        private System.Windows.Forms.Button btbAgregaT;
        private System.Windows.Forms.Button btbAreaT;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlturaP;
        private System.Windows.Forms.TextBox txtBaseP;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btbAreaP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

