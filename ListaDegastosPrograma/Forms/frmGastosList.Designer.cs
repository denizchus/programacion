namespace ListaDegastosPrograma.Forms
{
    partial class frmGastosList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastosList));
            this.dslistadegastos = new ClasesVirtualesProgramacion.Data.dslistadegastos();
            this.gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmdBucar = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCriterio1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSeleccionar1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMostrarTodo = new System.Windows.Forms.ToolStripButton();
            this.gastosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo1 = new System.Windows.Forms.Button();
            this.btnEditar1 = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.btnCerrar1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dslistadegastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingNavigator)).BeginInit();
            this.gastosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gastosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dslistadegastos
            // 
            this.dslistadegastos.DataSetName = "dslistadegastos";
            this.dslistadegastos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gastosBindingSource
            // 
            this.gastosBindingSource.DataMember = "Gastos";
            this.gastosBindingSource.DataSource = this.dslistadegastos;
            // 
            // gastosBindingNavigator
            // 
            this.gastosBindingNavigator.AddNewItem = null;
            this.gastosBindingNavigator.BindingSource = this.gastosBindingSource;
            this.gastosBindingNavigator.CountItem = null;
            this.gastosBindingNavigator.DeleteItem = null;
            this.gastosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmdBucar,
            this.toolStripSeparator1,
            this.txtCriterio1,
            this.toolStripSeparator2,
            this.btnBuscar1,
            this.toolStripSeparator3,
            this.btnSeleccionar1,
            this.toolStripSeparator4,
            this.btnMostrarTodo});
            this.gastosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gastosBindingNavigator.MoveFirstItem = null;
            this.gastosBindingNavigator.MoveLastItem = null;
            this.gastosBindingNavigator.MoveNextItem = null;
            this.gastosBindingNavigator.MovePreviousItem = null;
            this.gastosBindingNavigator.Name = "gastosBindingNavigator";
            this.gastosBindingNavigator.PositionItem = null;
            this.gastosBindingNavigator.Size = new System.Drawing.Size(695, 25);
            this.gastosBindingNavigator.TabIndex = 0;
            this.gastosBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel1.Text = "Buscar Por:";
            // 
            // cmdBucar
            // 
            this.cmdBucar.Items.AddRange(new object[] {
            "Nombres",
            "Categoria",
            "Valor"});
            this.cmdBucar.Name = "cmdBucar";
            this.cmdBucar.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtCriterio1
            // 
            this.txtCriterio1.Name = "txtCriterio1";
            this.txtCriterio1.Size = new System.Drawing.Size(46, 22);
            this.txtCriterio1.Text = "Criterio";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBuscar1.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar1.Image")));
            this.btnBuscar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(46, 22);
            this.btnBuscar1.Text = "Buscar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSeleccionar1
            // 
            this.btnSeleccionar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSeleccionar1.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar1.Image")));
            this.btnSeleccionar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSeleccionar1.Name = "btnSeleccionar1";
            this.btnSeleccionar1.Size = new System.Drawing.Size(71, 22);
            this.btnSeleccionar1.Text = "Seleccionar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMostrarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTodo.Image")));
            this.btnMostrarTodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(83, 22);
            this.btnMostrarTodo.Text = "MostrarTodos";
            // 
            // gastosDataGridView
            // 
            this.gastosDataGridView.AllowUserToAddRows = false;
            this.gastosDataGridView.AllowUserToDeleteRows = false;
            this.gastosDataGridView.AutoGenerateColumns = false;
            this.gastosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gastosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gastosDataGridView.DataSource = this.gastosBindingSource;
            this.gastosDataGridView.Location = new System.Drawing.Point(12, 39);
            this.gastosDataGridView.Name = "gastosDataGridView";
            this.gastosDataGridView.ReadOnly = true;
            this.gastosDataGridView.RowHeadersWidth = 4;
            this.gastosDataGridView.Size = new System.Drawing.Size(611, 224);
            this.gastosDataGridView.TabIndex = 1;
            this.gastosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gastosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "categoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "subcategoria";
            this.dataGridViewTextBoxColumn4.HeaderText = "SubCategoria";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "formapago";
            this.dataGridViewTextBoxColumn7.HeaderText = "FormaPago";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // btnNuevo1
            // 
            this.btnNuevo1.Location = new System.Drawing.Point(12, 309);
            this.btnNuevo1.Name = "btnNuevo1";
            this.btnNuevo1.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo1.TabIndex = 2;
            this.btnNuevo1.Text = "Nuevo";
            this.btnNuevo1.UseVisualStyleBackColor = true;
            this.btnNuevo1.Click += new System.EventHandler(this.btnNuevo1_Click);
            // 
            // btnEditar1
            // 
            this.btnEditar1.Location = new System.Drawing.Point(122, 309);
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.Size = new System.Drawing.Size(75, 23);
            this.btnEditar1.TabIndex = 3;
            this.btnEditar1.Text = "Editar";
            this.btnEditar1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Location = new System.Drawing.Point(234, 309);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar1.TabIndex = 4;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            // 
            // btnCerrar1
            // 
            this.btnCerrar1.Location = new System.Drawing.Point(548, 309);
            this.btnCerrar1.Name = "btnCerrar1";
            this.btnCerrar1.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar1.TabIndex = 5;
            this.btnCerrar1.Text = "Cerrar";
            this.btnCerrar1.UseVisualStyleBackColor = true;
            // 
            // frmGastosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 365);
            this.Controls.Add(this.btnCerrar1);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnEditar1);
            this.Controls.Add(this.btnNuevo1);
            this.Controls.Add(this.gastosDataGridView);
            this.Controls.Add(this.gastosBindingNavigator);
            this.Name = "frmGastosList";
            this.Text = "frmGastosList";
            this.Load += new System.EventHandler(this.frmGastosList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dslistadegastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingNavigator)).EndInit();
            this.gastosBindingNavigator.ResumeLayout(false);
            this.gastosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gastosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.dslistadegastos dslistadegastos;
        private System.Windows.Forms.BindingSource gastosBindingSource;
        private System.Windows.Forms.BindingNavigator gastosBindingNavigator;
        private System.Windows.Forms.DataGridView gastosDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmdBucar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel txtCriterio1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnBuscar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSeleccionar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnMostrarTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnNuevo1;
        private System.Windows.Forms.Button btnEditar1;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Button btnCerrar1;
    }
}