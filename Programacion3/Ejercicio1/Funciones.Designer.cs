
namespace Ejercicio1
{
    partial class Funciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.Dividirbutton = new System.Windows.Forms.Button();
            this.Multiplicarbutton = new System.Windows.Forms.Button();
            this.Restabutton = new System.Windows.Forms.Button();
            this.Sumabutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Numero2TextBox);
            this.groupBox1.Controls.Add(this.Numero1TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(101, 78);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(352, 33);
            this.Numero2TextBox.TabIndex = 3;
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(101, 34);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(352, 33);
            this.Numero1TextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Limpiarbutton);
            this.groupBox2.Controls.Add(this.Dividirbutton);
            this.groupBox2.Controls.Add(this.Multiplicarbutton);
            this.groupBox2.Controls.Add(this.Restabutton);
            this.groupBox2.Controls.Add(this.Sumabutton);
            this.groupBox2.Location = new System.Drawing.Point(505, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Limpiarbutton.Location = new System.Drawing.Point(125, 119);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(185, 34);
            this.Limpiarbutton.TabIndex = 4;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = false;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // Dividirbutton
            // 
            this.Dividirbutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Dividirbutton.Location = new System.Drawing.Point(238, 79);
            this.Dividirbutton.Name = "Dividirbutton";
            this.Dividirbutton.Size = new System.Drawing.Size(185, 34);
            this.Dividirbutton.TabIndex = 3;
            this.Dividirbutton.Text = "Dividir";
            this.Dividirbutton.UseVisualStyleBackColor = false;
            this.Dividirbutton.Click += new System.EventHandler(this.Dividirbutton_Click);
            // 
            // Multiplicarbutton
            // 
            this.Multiplicarbutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Multiplicarbutton.Location = new System.Drawing.Point(26, 78);
            this.Multiplicarbutton.Name = "Multiplicarbutton";
            this.Multiplicarbutton.Size = new System.Drawing.Size(185, 34);
            this.Multiplicarbutton.TabIndex = 2;
            this.Multiplicarbutton.Text = "Multiplicar";
            this.Multiplicarbutton.UseVisualStyleBackColor = false;
            this.Multiplicarbutton.Click += new System.EventHandler(this.Multiplicarbutton_Click);
            // 
            // Restabutton
            // 
            this.Restabutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Restabutton.Location = new System.Drawing.Point(238, 25);
            this.Restabutton.Name = "Restabutton";
            this.Restabutton.Size = new System.Drawing.Size(185, 34);
            this.Restabutton.TabIndex = 1;
            this.Restabutton.Text = "Resta";
            this.Restabutton.UseVisualStyleBackColor = false;
            this.Restabutton.Click += new System.EventHandler(this.Restabutton_Click);
            // 
            // Sumabutton
            // 
            this.Sumabutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Sumabutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sumabutton.Location = new System.Drawing.Point(26, 29);
            this.Sumabutton.Name = "Sumabutton";
            this.Sumabutton.Size = new System.Drawing.Size(185, 34);
            this.Sumabutton.TabIndex = 0;
            this.Sumabutton.Text = "Suma";
            this.Sumabutton.UseVisualStyleBackColor = false;
            this.Sumabutton.Click += new System.EventHandler(this.Sumabutton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultadoLabel);
            this.groupBox3.Location = new System.Drawing.Point(14, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(938, 133);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ResultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.Location = new System.Drawing.Point(435, 51);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(79, 16);
            this.ResultadoLabel.TabIndex = 0;
            this.ResultadoLabel.Text = "Resultado";
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 357);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Funciones";
            this.Text = "Funciones y Procedimientos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.Button Dividirbutton;
        private System.Windows.Forms.Button Multiplicarbutton;
        private System.Windows.Forms.Button Restabutton;
        private System.Windows.Forms.Button Sumabutton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ResultadoLabel;
    }
}

