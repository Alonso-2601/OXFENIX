namespace OSFENIXGDI2.Forms
{
    partial class FormRegistrarCliente
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
            this.oXFENIXDataSet = new OSFENIXGDI2.OXFENIXDataSet();
            this.spConsultarProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spConsultarProductoTableAdapter = new OSFENIXGDI2.OXFENIXDataSetTableAdapters.spConsultarProductoTableAdapter();
            this.tableAdapterManager = new OSFENIXGDI2.OXFENIXDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtfechacreacion = new System.Windows.Forms.TextBox();
            this.txtDescp = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oXFENIXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oXFENIXDataSet
            // 
            this.oXFENIXDataSet.DataSetName = "OXFENIXDataSet";
            this.oXFENIXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spConsultarProductoBindingSource
            // 
            this.spConsultarProductoBindingSource.DataMember = "spConsultarProducto";
            this.spConsultarProductoBindingSource.DataSource = this.oXFENIXDataSet;
            // 
            // spConsultarProductoTableAdapter
            // 
            this.spConsultarProductoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = OSFENIXGDI2.OXFENIXDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtfechacreacion
            // 
            this.txtfechacreacion.Location = new System.Drawing.Point(349, 187);
            this.txtfechacreacion.Name = "txtfechacreacion";
            this.txtfechacreacion.Size = new System.Drawing.Size(204, 20);
            this.txtfechacreacion.TabIndex = 33;
            this.txtfechacreacion.TextChanged += new System.EventHandler(this.txtfechacreacion_TextChanged);
            // 
            // txtDescp
            // 
            this.txtDescp.Location = new System.Drawing.Point(349, 106);
            this.txtDescp.Name = "txtDescp";
            this.txtDescp.Size = new System.Drawing.Size(204, 20);
            this.txtDescp.TabIndex = 32;
            this.txtDescp.TextChanged += new System.EventHandler(this.txtDescp_TextChanged);
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(349, 29);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(204, 20);
            this.txtcod.TabIndex = 31;
            this.txtcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(136, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha de creación";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCompo
            // 
            this.txtCompo.Location = new System.Drawing.Point(349, 149);
            this.txtCompo.Name = "txtCompo";
            this.txtCompo.Size = new System.Drawing.Size(204, 20);
            this.txtCompo.TabIndex = 29;
            this.txtCompo.TextChanged += new System.EventHandler(this.txtCompo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(136, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "COMPOSICIÓN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(136, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "DESCRIPCIÓN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(349, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 20);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(136, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "NOMBRE Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(136, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "CODIGO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtfechacreacion);
            this.Controls.Add(this.txtDescp);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCompo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormRegistrarCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oXFENIXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OXFENIXDataSet oXFENIXDataSet;
        private System.Windows.Forms.BindingSource spConsultarProductoBindingSource;
        private OXFENIXDataSetTableAdapters.spConsultarProductoTableAdapter spConsultarProductoTableAdapter;
        private OXFENIXDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtfechacreacion;
        private System.Windows.Forms.TextBox txtDescp;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}