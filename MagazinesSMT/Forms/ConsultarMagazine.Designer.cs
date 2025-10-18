namespace MagazinesSMT.Forms
{
    partial class ConsultarMagazine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarPanel = new System.Windows.Forms.Button();
            this.txtSerialPanel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultarMagazine = new System.Windows.Forms.Button();
            this.txtMagazine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreMagazineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numParteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroSerialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroSerialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnConsultarMagazine);
            this.groupBox1.Controls.Add(this.txtMagazine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1942, 775);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Magazine";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnConsultarPanel);
            this.groupBox2.Controls.Add(this.txtSerialPanel);
            this.groupBox2.Location = new System.Drawing.Point(26, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 241);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Serial:";
            // 
            // btnConsultarPanel
            // 
            this.btnConsultarPanel.Location = new System.Drawing.Point(18, 155);
            this.btnConsultarPanel.Name = "btnConsultarPanel";
            this.btnConsultarPanel.Size = new System.Drawing.Size(201, 52);
            this.btnConsultarPanel.TabIndex = 11;
            this.btnConsultarPanel.Text = "Consultar Panel";
            this.btnConsultarPanel.UseVisualStyleBackColor = true;
            this.btnConsultarPanel.Click += new System.EventHandler(this.btnConsultarPanel_Click);
            // 
            // txtSerialPanel
            // 
            this.txtSerialPanel.Location = new System.Drawing.Point(18, 98);
            this.txtSerialPanel.Name = "txtSerialPanel";
            this.txtSerialPanel.Size = new System.Drawing.Size(275, 34);
            this.txtSerialPanel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(211, 643);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(26, 29);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreMagazineDataGridViewTextBoxColumn,
            this.serialDataGridViewTextBoxColumn,
            this.numParteDataGridViewTextBoxColumn,
            this.moddateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registroSerialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(566, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1334, 639);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // btnConsultarMagazine
            // 
            this.btnConsultarMagazine.Location = new System.Drawing.Point(26, 163);
            this.btnConsultarMagazine.Name = "btnConsultarMagazine";
            this.btnConsultarMagazine.Size = new System.Drawing.Size(148, 52);
            this.btnConsultarMagazine.TabIndex = 4;
            this.btnConsultarMagazine.Text = "Consultar";
            this.btnConsultarMagazine.UseVisualStyleBackColor = true;
            this.btnConsultarMagazine.Click += new System.EventHandler(this.btnConsultarMagazine_Click);
            // 
            // txtMagazine
            // 
            this.txtMagazine.Location = new System.Drawing.Point(227, 80);
            this.txtMagazine.Name = "txtMagazine";
            this.txtMagazine.Size = new System.Drawing.Size(275, 34);
            this.txtMagazine.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Magazine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Estatus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estatus";
            // 
            // nombreMagazineDataGridViewTextBoxColumn
            // 
            this.nombreMagazineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreMagazineDataGridViewTextBoxColumn.DataPropertyName = "NombreMagazine";
            this.nombreMagazineDataGridViewTextBoxColumn.HeaderText = "Magazine";
            this.nombreMagazineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreMagazineDataGridViewTextBoxColumn.Name = "nombreMagazineDataGridViewTextBoxColumn";
            this.nombreMagazineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Serial";
            this.serialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numParteDataGridViewTextBoxColumn
            // 
            this.numParteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numParteDataGridViewTextBoxColumn.DataPropertyName = "NumParte";
            this.numParteDataGridViewTextBoxColumn.HeaderText = "Número de parte";
            this.numParteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numParteDataGridViewTextBoxColumn.Name = "numParteDataGridViewTextBoxColumn";
            this.numParteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moddateDataGridViewTextBoxColumn
            // 
            this.moddateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moddateDataGridViewTextBoxColumn.DataPropertyName = "Mod_date";
            this.moddateDataGridViewTextBoxColumn.HeaderText = "Fecha de modificación";
            this.moddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moddateDataGridViewTextBoxColumn.Name = "moddateDataGridViewTextBoxColumn";
            this.moddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registroSerialBindingSource
            // 
            this.registroSerialBindingSource.DataSource = typeof(MagazinesSMT.Modelos.RegistroSerial);
            // 
            // ConsultarMagazine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 775);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarMagazine";
            this.Text = "ConsultarMagazine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroSerialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultarMagazine;
        private System.Windows.Forms.TextBox txtMagazine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource registroSerialBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultarPanel;
        private System.Windows.Forms.TextBox txtSerialPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMagazineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numParteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}