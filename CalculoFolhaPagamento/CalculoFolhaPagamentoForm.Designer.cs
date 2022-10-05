namespace CalculoFolhaPagamento
{
    partial class CalculoFolhaPagamentoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDependentes = new System.Windows.Forms.TextBox();
            this.txtDescontoIRRF = new System.Windows.Forms.TextBox();
            this.txtDescontoISSS = new System.Windows.Forms.TextBox();
            this.txtFGTS = new System.Windows.Forms.TextBox();
            this.txtDescontoVR = new System.Windows.Forms.TextBox();
            this.txtDescontoVT = new System.Windows.Forms.TextBox();
            this.txtDescontoConvenio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de Folha de Pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário Bruto";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(8, 107);
            this.txtSalarioBruto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(141, 23);
            this.txtSalarioBruto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dependentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Desconto ISSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "FGTS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Desconto VT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Desconto VR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Desconto IRRF";
            // 
            // txtDependentes
            // 
            this.txtDependentes.Location = new System.Drawing.Point(201, 107);
            this.txtDependentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDependentes.Name = "txtDependentes";
            this.txtDependentes.Size = new System.Drawing.Size(141, 23);
            this.txtDependentes.TabIndex = 9;
            // 
            // txtDescontoIRRF
            // 
            this.txtDescontoIRRF.Location = new System.Drawing.Point(201, 186);
            this.txtDescontoIRRF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescontoIRRF.Name = "txtDescontoIRRF";
            this.txtDescontoIRRF.Size = new System.Drawing.Size(141, 23);
            this.txtDescontoIRRF.TabIndex = 10;
            // 
            // txtDescontoISSS
            // 
            this.txtDescontoISSS.Location = new System.Drawing.Point(8, 186);
            this.txtDescontoISSS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescontoISSS.Name = "txtDescontoISSS";
            this.txtDescontoISSS.Size = new System.Drawing.Size(141, 23);
            this.txtDescontoISSS.TabIndex = 11;
            // 
            // txtFGTS
            // 
            this.txtFGTS.Location = new System.Drawing.Point(388, 186);
            this.txtFGTS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFGTS.Name = "txtFGTS";
            this.txtFGTS.Size = new System.Drawing.Size(141, 23);
            this.txtFGTS.TabIndex = 12;
            // 
            // txtDescontoVR
            // 
            this.txtDescontoVR.Location = new System.Drawing.Point(8, 339);
            this.txtDescontoVR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescontoVR.Name = "txtDescontoVR";
            this.txtDescontoVR.Size = new System.Drawing.Size(141, 23);
            this.txtDescontoVR.TabIndex = 13;
            // 
            // txtDescontoVT
            // 
            this.txtDescontoVT.Location = new System.Drawing.Point(201, 339);
            this.txtDescontoVT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescontoVT.Name = "txtDescontoVT";
            this.txtDescontoVT.Size = new System.Drawing.Size(141, 23);
            this.txtDescontoVT.TabIndex = 14;
            // 
            // txtDescontoConvenio
            // 
            this.txtDescontoConvenio.Location = new System.Drawing.Point(388, 339);
            this.txtDescontoConvenio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescontoConvenio.Name = "txtDescontoConvenio";
            this.txtDescontoConvenio.Size = new System.Drawing.Size(141, 23);
            this.txtDescontoConvenio.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 322);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Desconto Convênio";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(8, 265);
            this.txtSalarioBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(141, 23);
            this.txtSalarioBase.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 248);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Salário Base";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(8, 425);
            this.txtSalarioLiquido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(141, 23);
            this.txtSalarioLiquido.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 408);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Salário Líquido";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(437, 502);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 35);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(560, 9);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1, 227);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(560, 9);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(1, 304);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(560, 9);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(1, 385);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(560, 9);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // CalculoFolhaPagamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 548);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescontoConvenio);
            this.Controls.Add(this.txtDescontoVT);
            this.Controls.Add(this.txtDescontoVR);
            this.Controls.Add(this.txtFGTS);
            this.Controls.Add(this.txtDescontoISSS);
            this.Controls.Add(this.txtDescontoIRRF);
            this.Controls.Add(this.txtDependentes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CalculoFolhaPagamentoForm";
            this.Text = "Calculo de Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSalarioBruto;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDependentes;
        private TextBox txtDescontoIRRF;
        private TextBox txtDescontoISSS;
        private TextBox txtFGTS;
        private TextBox txtDescontoVR;
        private TextBox txtDescontoVT;
        private TextBox txtDescontoConvenio;
        private Label label9;
        private TextBox txtSalarioBase;
        private Label label10;
        private TextBox txtSalarioLiquido;
        private Label label11;
        private Button btnCalcular;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}