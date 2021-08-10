
namespace BaseExporter
{
    partial class FRMPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.grid_tabelas = new System.Windows.Forms.DataGridView();
            this.Tabelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_colunas = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Colunas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_service = new System.Windows.Forms.CheckBox();
            this.cb_model = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_service = new System.Windows.Forms.Button();
            this.lb_dest_services = new System.Windows.Forms.Label();
            this.bt_model = new System.Windows.Forms.Button();
            this.lb_dest_model = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tabelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_colunas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_tabelas
            // 
            this.grid_tabelas.AllowUserToAddRows = false;
            this.grid_tabelas.AllowUserToDeleteRows = false;
            this.grid_tabelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_tabelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tabelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tabelas});
            this.grid_tabelas.Location = new System.Drawing.Point(11, 12);
            this.grid_tabelas.Name = "grid_tabelas";
            this.grid_tabelas.ReadOnly = true;
            this.grid_tabelas.RowTemplate.Height = 25;
            this.grid_tabelas.Size = new System.Drawing.Size(195, 326);
            this.grid_tabelas.TabIndex = 1;
            this.grid_tabelas.DoubleClick += new System.EventHandler(this.grid_tabelas_DoubleClick);
            // 
            // Tabelas
            // 
            this.Tabelas.DataPropertyName = "TABLE_NAME";
            this.Tabelas.HeaderText = "Tabelas";
            this.Tabelas.Name = "Tabelas";
            this.Tabelas.ReadOnly = true;
            // 
            // grid_colunas
            // 
            this.grid_colunas.AllowUserToAddRows = false;
            this.grid_colunas.AllowUserToDeleteRows = false;
            this.grid_colunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_colunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_colunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Colunas,
            this.Tipo,
            this.Maximo});
            this.grid_colunas.Location = new System.Drawing.Point(229, 12);
            this.grid_colunas.Name = "grid_colunas";
            this.grid_colunas.RowTemplate.Height = 25;
            this.grid_colunas.Size = new System.Drawing.Size(438, 326);
            this.grid_colunas.TabIndex = 2;
            // 
            // Select
            // 
            this.Select.FillWeight = 50F;
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            // 
            // Colunas
            // 
            this.Colunas.DataPropertyName = "COLUMN_NAME";
            this.Colunas.HeaderText = "Colunas";
            this.Colunas.Name = "Colunas";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "DATA_TYPE";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Maximo
            // 
            this.Maximo.DataPropertyName = "CHARACTER_MAXIMUM_LENGTH";
            this.Maximo.HeaderText = "Maximo";
            this.Maximo.Name = "Maximo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_service);
            this.panel1.Controls.Add(this.cb_model);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.bt_service);
            this.panel1.Controls.Add(this.lb_dest_services);
            this.panel1.Controls.Add(this.bt_model);
            this.panel1.Controls.Add(this.lb_dest_model);
            this.panel1.Location = new System.Drawing.Point(11, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 94);
            this.panel1.TabIndex = 3;
            // 
            // cb_service
            // 
            this.cb_service.AutoSize = true;
            this.cb_service.Location = new System.Drawing.Point(13, 37);
            this.cb_service.Name = "cb_service";
            this.cb_service.Size = new System.Drawing.Size(69, 19);
            this.cb_service.TabIndex = 3;
            this.cb_service.Text = "Service.:";
            this.cb_service.UseVisualStyleBackColor = true;
            this.cb_service.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cb_model
            // 
            this.cb_model.AutoSize = true;
            this.cb_model.Location = new System.Drawing.Point(13, 6);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(66, 19);
            this.cb_model.TabIndex = 3;
            this.cb_model.Text = "Model.:";
            this.cb_model.UseVisualStyleBackColor = true;
            this.cb_model.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(515, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Exportar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_service
            // 
            this.bt_service.Location = new System.Drawing.Point(85, 33);
            this.bt_service.Name = "bt_service";
            this.bt_service.Size = new System.Drawing.Size(43, 23);
            this.bt_service.TabIndex = 1;
            this.bt_service.Text = "...";
            this.bt_service.UseVisualStyleBackColor = true;
            this.bt_service.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_dest_services
            // 
            this.lb_dest_services.AutoSize = true;
            this.lb_dest_services.Location = new System.Drawing.Point(134, 37);
            this.lb_dest_services.Name = "lb_dest_services";
            this.lb_dest_services.Size = new System.Drawing.Size(16, 15);
            this.lb_dest_services.TabIndex = 0;
            this.lb_dest_services.Text = "   ";
            // 
            // bt_model
            // 
            this.bt_model.Location = new System.Drawing.Point(85, 2);
            this.bt_model.Name = "bt_model";
            this.bt_model.Size = new System.Drawing.Size(43, 23);
            this.bt_model.TabIndex = 1;
            this.bt_model.Text = "...";
            this.bt_model.UseVisualStyleBackColor = true;
            this.bt_model.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_dest_model
            // 
            this.lb_dest_model.AutoSize = true;
            this.lb_dest_model.Location = new System.Drawing.Point(134, 6);
            this.lb_dest_model.Name = "lb_dest_model";
            this.lb_dest_model.Size = new System.Drawing.Size(16, 15);
            this.lb_dest_model.TabIndex = 0;
            this.lb_dest_model.Text = "   ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_colunas);
            this.Controls.Add(this.grid_tabelas);
            this.Name = "FRMPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Dados";
            this.Load += new System.EventHandler(this.FRMPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tabelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_colunas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_tabelas;
        private System.Windows.Forms.DataGridView grid_colunas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabelas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_model;
        private System.Windows.Forms.Label lb_dest_model;
        private System.Windows.Forms.Button bt_service;
        private System.Windows.Forms.Label lb_dest_services;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colunas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cb_service;
        private System.Windows.Forms.CheckBox cb_model;
    }
}

