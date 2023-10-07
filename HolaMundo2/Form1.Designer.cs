namespace HolaMundo2
{
    partial class Form1
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
            txtContrasenaUno = new TextBox();
            txtContrasenaDos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // txtContrasenaUno
            // 
            txtContrasenaUno.Location = new Point(249, 80);
            txtContrasenaUno.Name = "txtContrasenaUno";
            txtContrasenaUno.Size = new Size(313, 31);
            txtContrasenaUno.TabIndex = 0;
            // 
            // txtContrasenaDos
            // 
            txtContrasenaDos.Location = new Point(249, 132);
            txtContrasenaDos.Name = "txtContrasenaDos";
            txtContrasenaDos.Size = new Size(313, 31);
            txtContrasenaDos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 80);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 3;
            label1.Text = "Ingresa una contraseña";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 135);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 4;
            label2.Text = "Repite contraseña";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(384, 184);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(178, 34);
            btnValidar.TabIndex = 5;
            btnValidar.Text = "VALIDAR";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValidar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasenaDos);
            Controls.Add(txtContrasenaUno);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContrasenaUno;
        private TextBox txtContrasenaDos;
        private Label label1;
        private Label label2;
        private Button btnValidar;
    }
}