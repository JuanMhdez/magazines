namespace MagazinesSMT.Forms
{
    partial class RegistroAutomatico
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMagazine = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblSerialMagazine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registroSerialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreMagazineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numParteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroSerialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1911, 728);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro automatico de magazine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estatus";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Estatus:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMagazine);
            this.groupBox2.Controls.Add(this.btnIniciar);
            this.groupBox2.Controls.Add(this.lblSerialMagazine);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSerial);
            this.groupBox2.Location = new System.Drawing.Point(6, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 368);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresar Paneles";
            // 
            // lblMagazine
            // 
            this.lblMagazine.AutoSize = true;
            this.lblMagazine.Location = new System.Drawing.Point(234, 281);
            this.lblMagazine.Name = "lblMagazine";
            this.lblMagazine.Size = new System.Drawing.Size(117, 29);
            this.lblMagazine.TabIndex = 8;
            this.lblMagazine.Text = "Magazine";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(16, 58);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(172, 54);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblSerialMagazine
            // 
            this.lblSerialMagazine.AutoSize = true;
            this.lblSerialMagazine.Location = new System.Drawing.Point(11, 281);
            this.lblSerialMagazine.Name = "lblSerialMagazine";
            this.lblSerialMagazine.Size = new System.Drawing.Size(192, 29);
            this.lblSerialMagazine.TabIndex = 6;
            this.lblSerialMagazine.Text = "Serial Magazine:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial:";
            // 
            // txtSerial
            // 
            this.txtSerial.Enabled = false;
            this.txtSerial.Location = new System.Drawing.Point(239, 182);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(275, 34);
            this.txtSerial.TabIndex = 3;
            this.txtSerial.TextChanged += new System.EventHandler(this.txtSerial_TextChanged);
            this.txtSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(292, 636);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(26, 29);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            // registroSerialBindingSource
            // 
            this.registroSerialBindingSource.DataSource = typeof(MagazinesSMT.Modelos.RegistroSerial);
            // 
            // nombreMagazineDataGridViewTextBoxColumn
            // 
            this.nombreMagazineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreMagazineDataGridViewTextBoxColumn.DataPropertyName = "NombreMagazine";
            this.nombreMagazineDataGridViewTextBoxColumn.HeaderText = "Serial Magazine";
            this.nombreMagazineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreMagazineDataGridViewTextBoxColumn.Name = "nombreMagazineDataGridViewTextBoxColumn";
            this.nombreMagazineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Carrier ID";
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
            // RegistroAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 728);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroAutomatico";
            this.Text = "RegistroAutomatico";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSerialMagazine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblMagazine;
        private System.Windows.Forms.BindingSource registroSerialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMagazineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numParteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moddateDataGridViewTextBoxColumn;
    }
}