
namespace Calculadora_Ejercicio
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
            this.cbxOperaciones = new System.Windows.Forms.ComboBox();
            this.cmdResultado = new System.Windows.Forms.Button();
            this.lblv1 = new System.Windows.Forms.Label();
            this.lblv2 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxOperaciones
            // 
            this.cbxOperaciones.FormattingEnabled = true;
            this.cbxOperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.cbxOperaciones.Location = new System.Drawing.Point(181, 181);
            this.cbxOperaciones.Name = "cbxOperaciones";
            this.cbxOperaciones.Size = new System.Drawing.Size(170, 21);
            this.cbxOperaciones.TabIndex = 0;
            // 
            // cmdResultado
            // 
            this.cmdResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdResultado.Location = new System.Drawing.Point(198, 268);
            this.cmdResultado.Name = "cmdResultado";
            this.cmdResultado.Size = new System.Drawing.Size(85, 31);
            this.cmdResultado.TabIndex = 1;
            this.cmdResultado.Text = "Resultado";
            this.cmdResultado.UseVisualStyleBackColor = false;
            this.cmdResultado.Click += new System.EventHandler(this.cmdResultado_Click);
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.Location = new System.Drawing.Point(115, 85);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(63, 13);
            this.lblv1.TabIndex = 2;
            this.lblv1.Text = "Primer Valor";
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.Location = new System.Drawing.Point(115, 134);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(77, 13);
            this.lblv2.TabIndex = 3;
            this.lblv2.Text = "Segundo Valor";
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(198, 85);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(133, 20);
            this.txtv1.TabIndex = 4;
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(198, 134);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(135, 20);
            this.txtv2.TabIndex = 5;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(231, 239);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(13, 13);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "0";
            // 
            // lblop
            // 
            this.lblop.AutoSize = true;
            this.lblop.Location = new System.Drawing.Point(115, 184);
            this.lblop.Name = "lblop";
            this.lblop.Size = new System.Drawing.Size(56, 13);
            this.lblop.TabIndex = 7;
            this.lblop.Text = "Operación";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 372);
            this.Controls.Add(this.lblop);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.lblv1);
            this.Controls.Add(this.cmdResultado);
            this.Controls.Add(this.cbxOperaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxOperaciones;
        private System.Windows.Forms.Button cmdResultado;
        private System.Windows.Forms.Label lblv1;
        private System.Windows.Forms.Label lblv2;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblop;
    }
}

