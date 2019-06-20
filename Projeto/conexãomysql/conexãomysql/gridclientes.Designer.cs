namespace conexãomysql
{
    partial class gridclientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gridclientes));
            this.cadastrarcliente = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridClientesConexao1 = new conexãomysql.GridClientesConexao();
            this.gridClientesConexao = new conexãomysql.GridClientesConexao();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter1 = new conexãomysql.GridClientesConexaoTableAdapters.clientesTableAdapter();
            this.idcliente = new System.Windows.Forms.TextBox();
            this.NomeC = new System.Windows.Forms.TextBox();
            this.TelefoneC = new System.Windows.Forms.TextBox();
            this.EndC = new System.Windows.Forms.TextBox();
            this.BairroC = new System.Windows.Forms.TextBox();
            this.CidadeC = new System.Windows.Forms.TextBox();
            this.UFC = new System.Windows.Forms.TextBox();
            this.EmailC = new System.Windows.Forms.TextBox();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesConexao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesConexao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastrarcliente
            // 
            this.cadastrarcliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cadastrarcliente.BackgroundImage")));
            this.cadastrarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cadastrarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarcliente.Location = new System.Drawing.Point(12, 23);
            this.cadastrarcliente.Name = "cadastrarcliente";
            this.cadastrarcliente.Size = new System.Drawing.Size(54, 53);
            this.cadastrarcliente.TabIndex = 3;
            this.cadastrarcliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cadastrarcliente.UseVisualStyleBackColor = true;
            this.cadastrarcliente.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // editar
            // 
            this.editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar.BackgroundImage")));
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.Location = new System.Drawing.Point(12, 99);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(54, 53);
            this.editar.TabIndex = 4;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // excluir
            // 
            this.excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("excluir.BackgroundImage")));
            this.excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.excluir.Location = new System.Drawing.Point(12, 171);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(54, 53);
            this.excluir.TabIndex = 5;
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // voltar
            // 
            this.voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltar.BackgroundImage")));
            this.voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(734, 385);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(54, 53);
            this.voltar.TabIndex = 6;
            this.voltar.Text = "Voltar";
            this.voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Editar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Excluir";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.Bairro,
            this.cidadeDataGridViewTextBoxColumn,
            this.UF,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(716, 370);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.DataPropertyName = "UF";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.gridClientesConexao1;
            // 
            // gridClientesConexao1
            // 
            this.gridClientesConexao1.DataSetName = "GridClientesConexao";
            this.gridClientesConexao1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridClientesConexao
            // 
            this.gridClientesConexao.DataSetName = "GridClientesConexao";
            this.gridClientesConexao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this.gridClientesConexao;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // idcliente
            // 
            this.idcliente.Location = new System.Drawing.Point(470, 437);
            this.idcliente.Name = "idcliente";
            this.idcliente.Size = new System.Drawing.Size(25, 20);
            this.idcliente.TabIndex = 8;
            this.idcliente.Visible = false;
            // 
            // NomeC
            // 
            this.NomeC.Location = new System.Drawing.Point(501, 437);
            this.NomeC.Name = "NomeC";
            this.NomeC.Size = new System.Drawing.Size(23, 20);
            this.NomeC.TabIndex = 9;
            this.NomeC.Visible = false;
            // 
            // TelefoneC
            // 
            this.TelefoneC.Location = new System.Drawing.Point(530, 437);
            this.TelefoneC.Name = "TelefoneC";
            this.TelefoneC.Size = new System.Drawing.Size(23, 20);
            this.TelefoneC.TabIndex = 10;
            this.TelefoneC.Visible = false;
            // 
            // EndC
            // 
            this.EndC.Location = new System.Drawing.Point(559, 437);
            this.EndC.Name = "EndC";
            this.EndC.Size = new System.Drawing.Size(23, 20);
            this.EndC.TabIndex = 11;
            this.EndC.Visible = false;
            // 
            // BairroC
            // 
            this.BairroC.Location = new System.Drawing.Point(588, 437);
            this.BairroC.Name = "BairroC";
            this.BairroC.Size = new System.Drawing.Size(23, 20);
            this.BairroC.TabIndex = 12;
            this.BairroC.Visible = false;
            // 
            // CidadeC
            // 
            this.CidadeC.Location = new System.Drawing.Point(617, 437);
            this.CidadeC.Name = "CidadeC";
            this.CidadeC.Size = new System.Drawing.Size(23, 20);
            this.CidadeC.TabIndex = 13;
            this.CidadeC.Visible = false;
            // 
            // UFC
            // 
            this.UFC.Location = new System.Drawing.Point(646, 437);
            this.UFC.Name = "UFC";
            this.UFC.Size = new System.Drawing.Size(23, 20);
            this.UFC.TabIndex = 14;
            this.UFC.Visible = false;
            // 
            // EmailC
            // 
            this.EmailC.Location = new System.Drawing.Point(675, 437);
            this.EmailC.Name = "EmailC";
            this.EmailC.Size = new System.Drawing.Size(23, 20);
            this.EmailC.TabIndex = 15;
            this.EmailC.Visible = false;
            // 
            // txtbusca
            // 
            this.txtbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusca.Location = new System.Drawing.Point(72, 385);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(407, 31);
            this.txtbusca.TabIndex = 16;
            // 
            // Buscar
            // 
            this.Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buscar.BackgroundImage")));
            this.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Buscar.Location = new System.Drawing.Point(483, 382);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(39, 38);
            this.Buscar.TabIndex = 17;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // gridclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtbusca);
            this.Controls.Add(this.EmailC);
            this.Controls.Add(this.UFC);
            this.Controls.Add(this.CidadeC);
            this.Controls.Add(this.BairroC);
            this.Controls.Add(this.EndC);
            this.Controls.Add(this.TelefoneC);
            this.Controls.Add(this.NomeC);
            this.Controls.Add(this.idcliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.cadastrarcliente);
            this.Name = "gridclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Gridclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesConexao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesConexao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrarcliente;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GridClientesConexao gridClientesConexao;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private GridClientesConexaoTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private GridClientesConexao gridClientesConexao1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idcliente;
        private System.Windows.Forms.TextBox NomeC;
        private System.Windows.Forms.TextBox TelefoneC;
        private System.Windows.Forms.TextBox EndC;
        private System.Windows.Forms.TextBox BairroC;
        private System.Windows.Forms.TextBox CidadeC;
        private System.Windows.Forms.TextBox UFC;
        private System.Windows.Forms.TextBox EmailC;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Button Buscar;
    }
}