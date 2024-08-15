namespace Libros1
{
    partial class frm_Libro
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
            btn_Guardar = new Button();
            btn_editar = new Button();
            btn_eliminar = new Button();
            btn_Cancelar = new Button();
            btn_Salir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lst_Libros = new ListBox();
            txt_Detalle = new TextBox();
            SuspendLayout();
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(37, 342);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(81, 79);
            btn_Guardar.TabIndex = 0;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(142, 342);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(81, 79);
            btn_editar.TabIndex = 1;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(251, 342);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(81, 79);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(361, 342);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(81, 79);
            btn_Cancelar.TabIndex = 3;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(464, 342);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(81, 79);
            btn_Salir.TabIndex = 4;
            btn_Salir.Text = "Regresar/salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 174);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre Libros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 26);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 6;
            label2.Text = "Datos Libros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 73);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "Lista";
            // 
            // lst_Libros
            // 
            lst_Libros.FormattingEnabled = true;
            lst_Libros.ItemHeight = 15;
            lst_Libros.Location = new Point(322, 107);
            lst_Libros.Name = "lst_Libros";
            lst_Libros.Size = new Size(223, 199);
            lst_Libros.TabIndex = 8;
            lst_Libros.SelectedIndexChanged += lst_Libros_SelectedIndexChanged;
            // 
            // txt_Detalle
            // 
            txt_Detalle.Location = new Point(37, 192);
            txt_Detalle.Name = "txt_Detalle";
            txt_Detalle.Size = new Size(252, 23);
            txt_Detalle.TabIndex = 9;
            txt_Detalle.TextChanged += textBox1_TextChanged;
            // 
            // frm_Libro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Detalle);
            Controls.Add(lst_Libros);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(btn_Guardar);
            Name = "frm_Libro";
            Text = "Formulario libro";
            Load += frm_Libro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Guardar;
        private Button btn_editar;
        private Button btn_eliminar;
        private Button btn_Cancelar;
        private Button btn_Salir;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lst_Libros;
        private TextBox txt_Detalle;
    }
}
