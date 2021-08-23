
namespace Ejercicio1Guia2_MM200149
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.rbtnGerente = new System.Windows.Forms.RadioButton();
            this.rbtnSubgerente = new System.Windows.Forms.RadioButton();
            this.rbtnSecretaria = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSBruto = new System.Windows.Forms.TextBox();
            this.txtMDescuento = new System.Windows.Forms.TextBox();
            this.txtSNeto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(271, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "DESCUENTOS";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(467, 136);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(140, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // rbtnGerente
            // 
            this.rbtnGerente.AutoSize = true;
            this.rbtnGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGerente.Location = new System.Drawing.Point(467, 197);
            this.rbtnGerente.Name = "rbtnGerente";
            this.rbtnGerente.Size = new System.Drawing.Size(74, 20);
            this.rbtnGerente.TabIndex = 6;
            this.rbtnGerente.TabStop = true;
            this.rbtnGerente.Text = "Gerente";
            this.rbtnGerente.UseVisualStyleBackColor = true;
            this.rbtnGerente.CheckedChanged += new System.EventHandler(this.rbtnGerente_CheckedChanged);
            // 
            // rbtnSubgerente
            // 
            this.rbtnSubgerente.AutoSize = true;
            this.rbtnSubgerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSubgerente.Location = new System.Drawing.Point(467, 230);
            this.rbtnSubgerente.Name = "rbtnSubgerente";
            this.rbtnSubgerente.Size = new System.Drawing.Size(96, 20);
            this.rbtnSubgerente.TabIndex = 7;
            this.rbtnSubgerente.TabStop = true;
            this.rbtnSubgerente.Text = "Subgerente";
            this.rbtnSubgerente.UseVisualStyleBackColor = true;
            this.rbtnSubgerente.CheckedChanged += new System.EventHandler(this.rbtnSubgerente_CheckedChanged);
            // 
            // rbtnSecretaria
            // 
            this.rbtnSecretaria.AutoSize = true;
            this.rbtnSecretaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSecretaria.Location = new System.Drawing.Point(467, 264);
            this.rbtnSecretaria.Name = "rbtnSecretaria";
            this.rbtnSecretaria.Size = new System.Drawing.Size(88, 20);
            this.rbtnSecretaria.TabIndex = 8;
            this.rbtnSecretaria.TabStop = true;
            this.rbtnSecretaria.Text = "Secretaria";
            this.rbtnSecretaria.UseVisualStyleBackColor = true;
            this.rbtnSecretaria.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salario Bruto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto Descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salario neto";
            // 
            // txtSBruto
            // 
            this.txtSBruto.Location = new System.Drawing.Point(226, 197);
            this.txtSBruto.Name = "txtSBruto";
            this.txtSBruto.Size = new System.Drawing.Size(127, 20);
            this.txtSBruto.TabIndex = 12;
            // 
            // txtMDescuento
            // 
            this.txtMDescuento.Location = new System.Drawing.Point(226, 231);
            this.txtMDescuento.Name = "txtMDescuento";
            this.txtMDescuento.Size = new System.Drawing.Size(127, 20);
            this.txtMDescuento.TabIndex = 13;
            this.txtMDescuento.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSNeto
            // 
            this.txtSNeto.Location = new System.Drawing.Point(226, 265);
            this.txtSNeto.Name = "txtSNeto";
            this.txtSNeto.Size = new System.Drawing.Size(127, 20);
            this.txtSNeto.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 405);
            this.Controls.Add(this.txtSNeto);
            this.Controls.Add(this.txtMDescuento);
            this.Controls.Add(this.txtSBruto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnSecretaria);
            this.Controls.Add(this.rbtnSubgerente);
            this.Controls.Add(this.rbtnGerente);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Salario Bruto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.RadioButton rbtnGerente;
        private System.Windows.Forms.RadioButton rbtnSubgerente;
        private System.Windows.Forms.RadioButton rbtnSecretaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSBruto;
        private System.Windows.Forms.TextBox txtMDescuento;
        private System.Windows.Forms.TextBox txtSNeto;
    }
}

