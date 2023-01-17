namespace DentalClinic_V2_WindowsForm
{
    partial class Patients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListPacientes = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.DGVPatientList = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPagePacientes = new System.Windows.Forms.TabPage();
            this.DOBDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAllergy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageListPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatientList)).BeginInit();
            this.tabPagePacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListPacientes);
            this.tabControl1.Controls.Add(this.tabPagePacientes);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Hack Nerd Font", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 635);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageListPacientes
            // 
            this.tabPageListPacientes.BackColor = System.Drawing.Color.White;
            this.tabPageListPacientes.Controls.Add(this.textBox1);
            this.tabPageListPacientes.Controls.Add(this.btnBuscar);
            this.tabPageListPacientes.Controls.Add(this.btnBorrar);
            this.tabPageListPacientes.Controls.Add(this.DGVPatientList);
            this.tabPageListPacientes.Controls.Add(this.label8);
            this.tabPageListPacientes.Location = new System.Drawing.Point(4, 40);
            this.tabPageListPacientes.Name = "tabPageListPacientes";
            this.tabPageListPacientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListPacientes.Size = new System.Drawing.Size(1059, 591);
            this.tabPageListPacientes.TabIndex = 0;
            this.tabPageListPacientes.Text = "Lista de pacientes";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(124, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 34);
            this.textBox1.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Hack Nerd Font", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(511, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 34);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Hack Nerd Font", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(716, 31);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(122, 34);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // DGVPatientList
            // 
            this.DGVPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPatientList.BackgroundColor = System.Drawing.Color.White;
            this.DGVPatientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DGVPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPatientList.DefaultCellStyle = dataGridViewCellStyle14;
            this.DGVPatientList.Location = new System.Drawing.Point(6, 88);
            this.DGVPatientList.Name = "DGVPatientList";
            this.DGVPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPatientList.Size = new System.Drawing.Size(1047, 497);
            this.DGVPatientList.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Buscar";
            // 
            // tabPagePacientes
            // 
            this.tabPagePacientes.BackColor = System.Drawing.Color.White;
            this.tabPagePacientes.Controls.Add(this.btnEditar);
            this.tabPagePacientes.Controls.Add(this.DOBDate);
            this.tabPagePacientes.Controls.Add(this.btnCancel);
            this.tabPagePacientes.Controls.Add(this.btnGuardar);
            this.tabPagePacientes.Controls.Add(this.txtCedula);
            this.tabPagePacientes.Controls.Add(this.label7);
            this.tabPagePacientes.Controls.Add(this.txtAddress);
            this.tabPagePacientes.Controls.Add(this.label6);
            this.tabPagePacientes.Controls.Add(this.txtAllergy);
            this.tabPagePacientes.Controls.Add(this.label5);
            this.tabPagePacientes.Controls.Add(this.label4);
            this.tabPagePacientes.Controls.Add(this.txtLastname);
            this.tabPagePacientes.Controls.Add(this.label3);
            this.tabPagePacientes.Controls.Add(this.txtName);
            this.tabPagePacientes.Controls.Add(this.label2);
            this.tabPagePacientes.Font = new System.Drawing.Font("Hack Nerd Font", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePacientes.Location = new System.Drawing.Point(4, 40);
            this.tabPagePacientes.Name = "tabPagePacientes";
            this.tabPagePacientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePacientes.Size = new System.Drawing.Size(1059, 591);
            this.tabPagePacientes.TabIndex = 1;
            this.tabPagePacientes.Text = "Pacientes";
            // 
            // DOBDate
            // 
            this.DOBDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DOBDate.CustomFormat = "yyyy-mm-dd";
            this.DOBDate.Font = new System.Drawing.Font("Hack Nerd Font", 18F);
            this.DOBDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBDate.Location = new System.Drawing.Point(21, 140);
            this.DOBDate.Name = "DOBDate";
            this.DOBDate.Size = new System.Drawing.Size(291, 35);
            this.DOBDate.TabIndex = 18;
            this.DOBDate.Value = new System.DateTime(2023, 1, 17, 10, 49, 52, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(214, 516);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 37);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(21, 516);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 37);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(21, 232);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(291, 35);
            this.txtCedula.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hack Nerd Font", 18F);
            this.label7.Location = new System.Drawing.Point(16, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cedula";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(21, 329);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(414, 144);
            this.txtAddress.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hack Nerd Font", 18F);
            this.label6.Location = new System.Drawing.Point(16, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Direccion";
            // 
            // txtAllergy
            // 
            this.txtAllergy.Location = new System.Drawing.Point(500, 329);
            this.txtAllergy.Multiline = true;
            this.txtAllergy.Name = "txtAllergy";
            this.txtAllergy.Size = new System.Drawing.Size(414, 144);
            this.txtAllergy.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hack Nerd Font", 18F);
            this.label5.Location = new System.Drawing.Point(495, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alegias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hack Nerd Font", 18F);
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(373, 50);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(318, 35);
            this.txtLastname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hack Nerd Font", 18F);
            this.label3.Location = new System.Drawing.Point(368, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(21, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 35);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hack Nerd Font", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Hack Nerd Font", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1047, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(60)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(407, 516);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(160, 37);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 711);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.Text = "Patients";
            this.tabControl1.ResumeLayout(false);
            this.tabPageListPacientes.ResumeLayout(false);
            this.tabPageListPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatientList)).EndInit();
            this.tabPagePacientes.ResumeLayout(false);
            this.tabPagePacientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListPacientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView DGVPatientList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPagePacientes;
        private System.Windows.Forms.DateTimePicker DOBDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAllergy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditar;
    }
}