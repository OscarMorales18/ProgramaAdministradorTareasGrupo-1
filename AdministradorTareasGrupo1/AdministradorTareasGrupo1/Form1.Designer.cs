namespace AdministradorTareasGrupo1
{
    partial class VentanaAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAdmin));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCPU = new MetroFramework.Controls.MetroLabel();
            this.labelRam = new MetroFramework.Controls.MetroLabel();
            this.gRAM = new MetroFramework.Controls.MetroProgressBar();
            this.gCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PROCESOS = new System.Windows.Forms.TabPage();
            this.txtProceso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContador = new System.Windows.Forms.Label();
            this.dgvAdministrador = new MetroFramework.Controls.MetroGrid();
            this.dgvProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVirtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.btnDetener = new MetroFramework.Controls.MetroTile();
            this.btnActualizar = new MetroFramework.Controls.MetroTile();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.PROCESOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grafica);
            this.tabPage2.Controls.Add(this.labelCPU);
            this.tabPage2.Controls.Add(this.labelRam);
            this.tabPage2.Controls.Add(this.gRAM);
            this.tabPage2.Controls.Add(this.gCPU);
            this.tabPage2.Controls.Add(this.metroLabel2);
            this.tabPage2.Controls.Add(this.metroLabel1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1077, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RENDIMIENTO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(17, 81);
            this.grafica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 3;
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.grafica.Series.Add(series1);
            this.grafica.Series.Add(series2);
            this.grafica.Size = new System.Drawing.Size(1033, 319);
            this.grafica.TabIndex = 20;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(247, 17);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(29, 20);
            this.labelCPU.TabIndex = 19;
            this.labelCPU.Text = "0%";
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Location = new System.Drawing.Point(691, 17);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(29, 20);
            this.labelRam.TabIndex = 18;
            this.labelRam.Text = "0%";
            // 
            // gRAM
            // 
            this.gRAM.Location = new System.Drawing.Point(501, 40);
            this.gRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gRAM.Name = "gRAM";
            this.gRAM.Size = new System.Drawing.Size(371, 35);
            this.gRAM.TabIndex = 17;
            // 
            // gCPU
            // 
            this.gCPU.Location = new System.Drawing.Point(43, 40);
            this.gCPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gCPU.Name = "gCPU";
            this.gCPU.Size = new System.Drawing.Size(368, 35);
            this.gCPU.TabIndex = 16;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(647, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 20);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "RAM";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(205, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 20);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "CPU";
            // 
            // PROCESOS
            // 
            this.PROCESOS.Controls.Add(this.txtProceso);
            this.PROCESOS.Controls.Add(this.label1);
            this.PROCESOS.Controls.Add(this.txtContador);
            this.PROCESOS.Controls.Add(this.dgvAdministrador);
            this.PROCESOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROCESOS.Location = new System.Drawing.Point(4, 26);
            this.PROCESOS.Margin = new System.Windows.Forms.Padding(4);
            this.PROCESOS.Name = "PROCESOS";
            this.PROCESOS.Padding = new System.Windows.Forms.Padding(4);
            this.PROCESOS.Size = new System.Drawing.Size(1077, 495);
            this.PROCESOS.TabIndex = 0;
            this.PROCESOS.Text = "PROCESOS";
            this.PROCESOS.UseVisualStyleBackColor = true;
            this.PROCESOS.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtProceso
            // 
            this.txtProceso.AutoSize = true;
            this.txtProceso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtProceso.Location = new System.Drawing.Point(210, 403);
            this.txtProceso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(19, 20);
            this.txtProceso.TabIndex = 13;
            this.txtProceso.Text = "0";
            this.txtProceso.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(8, 403);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "NOMBRE DEL PROCESO:";
            // 
            // txtContador
            // 
            this.txtContador.AutoSize = true;
            this.txtContador.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtContador.Location = new System.Drawing.Point(7, 461);
            this.txtContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(30, 20);
            this.txtContador.TabIndex = 11;
            this.txtContador.Text = "---";
            // 
            // dgvAdministrador
            // 
            this.dgvAdministrador.AllowUserToResizeRows = false;
            this.dgvAdministrador.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdministrador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdministrador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdministrador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministrador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProceso,
            this.dgvID,
            this.dgvFisica,
            this.dgvVirtual,
            this.dgvCPU});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdministrador.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAdministrador.EnableHeadersVisualStyles = false;
            this.dgvAdministrador.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAdministrador.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAdministrador.Location = new System.Drawing.Point(9, 0);
            this.dgvAdministrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdministrador.Name = "dgvAdministrador";
            this.dgvAdministrador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdministrador.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAdministrador.RowHeadersWidth = 51;
            this.dgvAdministrador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdministrador.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAdministrador.RowTemplate.Height = 24;
            this.dgvAdministrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdministrador.Size = new System.Drawing.Size(1061, 371);
            this.dgvAdministrador.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvAdministrador.TabIndex = 7;
            this.dgvAdministrador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdministrador_CellContentClick);
            // 
            // dgvProceso
            // 
            this.dgvProceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProceso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProceso.HeaderText = "Proceso";
            this.dgvProceso.MinimumWidth = 6;
            this.dgvProceso.Name = "dgvProceso";
            this.dgvProceso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvID
            // 
            this.dgvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvID.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvID.HeaderText = "ID";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            // 
            // dgvFisica
            // 
            this.dgvFisica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFisica.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFisica.HeaderText = "Memoria Física";
            this.dgvFisica.MinimumWidth = 6;
            this.dgvFisica.Name = "dgvFisica";
            // 
            // dgvVirtual
            // 
            this.dgvVirtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVirtual.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVirtual.HeaderText = "Memoria Virtual";
            this.dgvVirtual.MinimumWidth = 6;
            this.dgvVirtual.Name = "dgvVirtual";
            // 
            // dgvCPU
            // 
            this.dgvCPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCPU.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCPU.HeaderText = "CPU";
            this.dgvCPU.MinimumWidth = 6;
            this.dgvCPU.Name = "dgvCPU";
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveControl = null;
            this.btnSalir.Location = new System.Drawing.Point(1138, 589);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(205, 49);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.ActiveControl = null;
            this.btnDetener.Location = new System.Drawing.Point(1138, 444);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(205, 49);
            this.btnDetener.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDetener.TabIndex = 9;
            this.btnDetener.Text = "Detener";
            this.btnDetener.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetener.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDetener.UseSelectable = true;
            this.btnDetener.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ActiveControl = null;
            this.btnActualizar.BackColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(1138, 297);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(205, 49);
            this.btnActualizar.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.UseWaitCursor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PROCESOS);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 173);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1085, 525);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 14;
            // 
            // VentanaAdmin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1381, 684);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnActualizar);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaAdmin";
            this.Padding = new System.Windows.Forms.Padding(20, 79, 20, 21);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.VentanaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.PROCESOS.ResumeLayout(false);
            this.PROCESOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrador)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private MetroFramework.Controls.MetroLabel labelCPU;
        private MetroFramework.Controls.MetroLabel labelRam;
        private MetroFramework.Controls.MetroProgressBar gRAM;
        private MetroFramework.Controls.MetroProgressBar gCPU;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TabPage PROCESOS;
        private System.Windows.Forms.Label txtProceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtContador;
        private MetroFramework.Controls.MetroTile btnSalir;
        private MetroFramework.Controls.MetroTile btnDetener;
        private MetroFramework.Controls.MetroTile btnActualizar;
        private MetroFramework.Controls.MetroGrid dgvAdministrador;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVirtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCPU;
    }
}

