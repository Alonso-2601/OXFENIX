    using System;

namespace OSFENIXGDI2.Forms
{
    partial class FormRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarProducto));
            this.button1 = new System.Windows.Forms.Button();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaPRODUCTO = new System.Windows.Forms.DataGridView();
            this.id_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Composicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtDescp = new System.Windows.Forms.TextBox();
            this.txtfechacreacion = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spConsultarProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oXFENIXDataSet = new OSFENIXGDI2.OXFENIXDataSet();
            this.spConsultarProductoTableAdapter = new OSFENIXGDI2.OXFENIXDataSetTableAdapters.spConsultarProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPRODUCTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oXFENIXDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BUSCAR
            // 
            resources.ApplyResources(this.BUSCAR, "BUSCAR");
            this.BUSCAR.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.UseVisualStyleBackColor = true;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCompo
            // 
            resources.ApplyResources(this.txtCompo, "txtCompo");
            this.txtCompo.Name = "txtCompo";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tablaPRODUCTO
            // 
            this.tablaPRODUCTO.AllowUserToOrderColumns = true;
            this.tablaPRODUCTO.AllowUserToResizeRows = false;
            this.tablaPRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPRODUCTO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prod,
            this.nombre_prod,
            this.descrip_prod,
            this.Composicion,
            this.fechafabricacion});
            resources.ApplyResources(this.tablaPRODUCTO, "tablaPRODUCTO");
            this.tablaPRODUCTO.Name = "tablaPRODUCTO";
            this.tablaPRODUCTO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPRODUCTO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPRODUCTO_CellContentClick);
            // 
            // id_prod
            // 
            resources.ApplyResources(this.id_prod, "id_prod");
            this.id_prod.Name = "id_prod";
            // 
            // nombre_prod
            // 
            resources.ApplyResources(this.nombre_prod, "nombre_prod");
            this.nombre_prod.Name = "nombre_prod";
            // 
            // descrip_prod
            // 
            resources.ApplyResources(this.descrip_prod, "descrip_prod");
            this.descrip_prod.Name = "descrip_prod";
            // 
            // Composicion
            // 
            resources.ApplyResources(this.Composicion, "Composicion");
            this.Composicion.Name = "Composicion";
            // 
            // fechafabricacion
            // 
            resources.ApplyResources(this.fechafabricacion, "fechafabricacion");
            this.fechafabricacion.Name = "fechafabricacion";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcod
            // 
            resources.ApplyResources(this.txtcod, "txtcod");
            this.txtcod.Name = "txtcod";
            this.txtcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged);
            // 
            // txtDescp
            // 
            resources.ApplyResources(this.txtDescp, "txtDescp");
            this.txtDescp.Name = "txtDescp";
            // 
            // txtfechacreacion
            // 
            resources.ApplyResources(this.txtfechacreacion, "txtfechacreacion");
            this.txtfechacreacion.Name = "txtfechacreacion";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::OSFENIXGDI2.Properties.Resources.box;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // spConsultarProductoBindingSource
            // 
            this.spConsultarProductoBindingSource.DataMember = "spConsultarProducto";
            this.spConsultarProductoBindingSource.DataSource = this.oXFENIXDataSet;
            // 
            // oXFENIXDataSet
            // 
            this.oXFENIXDataSet.DataSetName = "OXFENIXDataSet";
            this.oXFENIXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spConsultarProductoTableAdapter
            // 
            this.spConsultarProductoTableAdapter.ClearBeforeFill = true;
            // 
            // FormRegistrarProducto
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::OSFENIXGDI2.Properties.Resources.fondoas;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtfechacreacion);
            this.Controls.Add(this.txtDescp);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tablaPRODUCTO);
            this.Controls.Add(this.txtCompo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.button1);
            this.MinimizeBox = false;
            this.Name = "FormRegistrarProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRegistrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPRODUCTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oXFENIXDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaPRODUCTO;
        private System.Windows.Forms.Label label5;
        private OXFENIXDataSet oXFENIXDataSet;
        private System.Windows.Forms.BindingSource spConsultarProductoBindingSource;
        private OXFENIXDataSetTableAdapters.spConsultarProductoTableAdapter spConsultarProductoTableAdapter;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtDescp;
        private System.Windows.Forms.TextBox txtfechacreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Composicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafabricacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}