namespace ClienteApp.Views
{
    partial class FormCliente
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
            dgvClientes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtBuscar = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(63, 139);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(656, 209);
            dgvClientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 16);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 1;
            label1.Text = "Agregar un nuevo cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 48);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(123, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(403, 40);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(216, 23);
            txtCorreo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 48);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Correo:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(123, 110);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(216, 23);
            txtBuscar.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 118);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 82);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 8;
            label5.Text = "Buscar un cliente";
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(644, 40);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseMnemonic = false;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(365, 109);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuscar.UseMnemonic = false;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnListar
            // 
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Location = new Point(555, 109);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar todo";
            btnListar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnListar.UseMnemonic = false;
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 388);
            Controls.Add(btnListar);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvClientes);
            Name = "FormCliente";
            Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtBuscar;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnListar;
    }
}