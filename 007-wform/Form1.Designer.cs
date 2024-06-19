namespace _007_wform
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
            label1 = new Label();
            label2 = new Label();
            lstRazasDePerros = new ListBox();
            lstCiudadesPais = new ListBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Hola Coder!!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(35, 181);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Razas de perros";
            // 
            // lstRazasDePerros
            // 
            lstRazasDePerros.FormattingEnabled = true;
            lstRazasDePerros.ItemHeight = 15;
            lstRazasDePerros.Location = new Point(35, 208);
            lstRazasDePerros.Name = "lstRazasDePerros";
            lstRazasDePerros.Size = new Size(150, 109);
            lstRazasDePerros.TabIndex = 2;
            // 
            // lstCiudadesPais
            // 
            lstCiudadesPais.FormattingEnabled = true;
            lstCiudadesPais.ItemHeight = 15;
            lstCiudadesPais.Location = new Point(239, 208);
            lstCiudadesPais.Name = "lstCiudadesPais";
            lstCiudadesPais.Size = new Size(318, 109);
            lstCiudadesPais.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(239, 164);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(320, 164);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(401, 164);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(482, 164);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(791, 365);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(lstCiudadesPais);
            Controls.Add(lstRazasDePerros);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstRazasDePerros;
        private ListBox lstCiudadesPais;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnLimpiar;
    }
}
