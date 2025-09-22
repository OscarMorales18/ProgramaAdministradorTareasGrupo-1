using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AdministradorTareasGrupo1
{
    public partial class VentanaAdmin : MetroFramework.Forms.MetroForm
    {
        private List<Process> listaProcesosFull; // Lista completa de procesos
        private TextBox txtBuscar; // TextBox para búsqueda
        private Label lblBuscar; // Label para el TextBox de búsqueda

        public VentanaAdmin()
        {
            InitializeComponent();
            this.Text = "";

            // Para MetroForm usa estas propiedades:
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Theme = MetroFramework.MetroThemeStyle.Light;

            // Crear título personalizado
            Label tituloPersonalizado = new Label();
            tituloPersonalizado.Name = "tituloPersonalizado";
            tituloPersonalizado.Text = "Administrador de Tareas Grupo #1";
            tituloPersonalizado.Font = new Font("Rockwell", 16, FontStyle.Bold);
            tituloPersonalizado.BackColor = Color.Transparent;
            tituloPersonalizado.Location = new Point(30, 15);
            tituloPersonalizado.Size = new Size(500, 30);
            tituloPersonalizado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Controls.Add(tituloPersonalizado);

            // Crear controles de búsqueda
            CrearControlesBusqueda();

            UpdateProcessList();
            timer1.Enabled = true;
            AplicarTemaSistema();
        }

        private void CrearControlesBusqueda()
        {
            // Label para búsqueda
            lblBuscar = new Label();
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Text = "Buscar Proceso:";
            lblBuscar.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblBuscar.Location = new Point(20, 60);//Debajo del título
            lblBuscar.Size = new Size(100, 20);
            lblBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Controls.Add(lblBuscar);

            // TextBox para búsqueda
            txtBuscar = new TextBox();
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            txtBuscar.Location = new Point(120, 56);
            txtBuscar.Size = new Size(200, 23);
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtBuscar.Text = "Escribe el nombre del proceso...";
            txtBuscar.ForeColor = Color.Transparent; // Color gris para el placeholder

            // Eventos para búsqueda en tiempo real
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            txtBuscar.Enter += TxtBuscar_Enter; // Cuando entra al campo
            txtBuscar.Leave += TxtBuscar_Leave; // Cuando sale del campo

            this.Controls.Add(txtBuscar);


        }

        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            // Cuando el usuario hace clic en el TextBox, limpiar el placeholder
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            // Cuando el usuario sale del TextBox, mostrar placeholder si está vacío
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Solo filtrar si no es el texto placeholder
            {
                FiltrarProcesos();
            }
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            // Si presiona Enter, buscar y seleccionar el primer resultado
            if (e.KeyCode == Keys.Enter && txtBuscar.Text != "")
            {
                if (dgvAdministrador.Rows.Count > 0)
                {
                    dgvAdministrador.ClearSelection();
                    dgvAdministrador.Rows[0].Selected = true;
                    dgvAdministrador.FirstDisplayedScrollingRowIndex = 0;

                    // Actualizar el proceso seleccionado
                    if (dgvAdministrador.Rows[0].Cells[0].Value != null)
                    {
                        txtProceso.Text = dgvAdministrador.Rows[0].Cells[0].Value.ToString();
                    }
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

            private void FiltrarProcesos()
        {
            string filtro = txtBuscar.Text.Trim().ToLower();

            // No filtrar si es el texto placeholder
            if (filtro == "escribe el nombre del proceso...")
            {
                filtro = "";
            }

            dgvAdministrador.Rows.Clear();

            if (listaProcesosFull == null) return;

            var procesosFiltrados = string.IsNullOrEmpty(filtro)
                ? listaProcesosFull
                : listaProcesosFull.Where(p => p.ProcessName.ToLower().Contains(filtro)).ToList();

            foreach (Process p in procesosFiltrados)
            {
                try
                {
                    int n = dgvAdministrador.Rows.Add();
                    dgvAdministrador.Rows[n].Cells[0].Value = p.ProcessName;
                    dgvAdministrador.Rows[n].Cells[1].Value = p.Id;
                    dgvAdministrador.Rows[n].Cells[2].Value = FormatBytes(p.WorkingSet64);
                    dgvAdministrador.Rows[n].Cells[3].Value = FormatBytes(p.VirtualMemorySize64);
                    dgvAdministrador.Rows[n].Cells[4].Value = p.SessionId;
                }
                catch
                {
                    // Algunos procesos pueden no estar disponibles
                }
            }

            // Actualizar contador
            if (string.IsNullOrEmpty(filtro))
            {
                txtContador.Text = $"Procesos Actuales: {dgvAdministrador.Rows.Count}";
            }
            else
            {
                txtContador.Text = $"Procesos Encontrados: {dgvAdministrador.Rows.Count} de {listaProcesosFull.Count}";
            }
        }

        private string FormatBytes(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int counter = 0;
            decimal number = bytes;

            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }

            return string.Format("{0:n1} {1}", number, suffixes[counter]);
        }

        private void AplicarTemaSistema()
        {
            bool esTemaOscuro = EsTemaOscuro();

            // Cambia el tema del formulario Metro
            this.Theme = esTemaOscuro ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light;

            // Aplicar color al título personalizado
            Label titulo = this.Controls["tituloPersonalizado"] as Label;
            if (titulo != null)
            {
                titulo.ForeColor = esTemaOscuro ? Color.White : Color.FromArgb(68, 68, 68);
            }

            // Aplicar colores a los controles de búsqueda
            if (lblBuscar != null)
            {
                lblBuscar.ForeColor = esTemaOscuro ? Color.White : Color.FromArgb(68, 68, 68);
                lblBuscar.BackColor = Color.Transparent;
            }

            if (txtBuscar != null)
            {
                // Solo cambiar colores si no es placeholder
                if (txtBuscar.Text != "Escribe el nombre del proceso...")
                {
                    txtBuscar.BackColor = esTemaOscuro ? Color.FromArgb(45, 45, 45) : Color.White;
                    txtBuscar.ForeColor = esTemaOscuro ? Color.White : Color.Black;
                }
                else
                {
                    txtBuscar.BackColor = esTemaOscuro ? Color.FromArgb(45, 45, 45) : Color.White;
                    txtBuscar.ForeColor = Color.Gray; // Mantener gris para placeholder
                }
            }

            // Cambia el tema de los controles Metro
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MetroFramework.Controls.MetroButton mb)
                    mb.Theme = this.Theme;
                if (ctrl is MetroFramework.Controls.MetroLabel ml)
                    ml.Theme = this.Theme;
                if (ctrl is MetroFramework.Controls.MetroTile mt)
                    mt.Theme = this.Theme;
                if (ctrl is MetroFramework.Controls.MetroTabControl mtc)
                    mtc.Theme = this.Theme;
                if (ctrl is MetroFramework.Controls.MetroTextBox mtx)
                    mtx.Theme = this.Theme;

                // Si el control tiene hijos, aplicar recursivamente
                if (ctrl.HasChildren)
                {
                    foreach (Control child in ctrl.Controls)
                    {
                        if (child is MetroFramework.Controls.MetroButton cmb)
                            cmb.Theme = this.Theme;
                        if (child is MetroFramework.Controls.MetroLabel cml)
                            cml.Theme = this.Theme;
                        if (child is MetroFramework.Controls.MetroTile cmt)
                            cmt.Theme = this.Theme;
                        if (child is MetroFramework.Controls.MetroTabControl cmtc)
                            cmtc.Theme = this.Theme;
                        if (child is MetroFramework.Controls.MetroTextBox cmtx)
                            cmtx.Theme = this.Theme;
                    }
                }
            }

            // DataGridView: aplica colores manualmente
            Color fondo = esTemaOscuro ? Color.FromArgb(32, 32, 32) : Color.White;
            Color texto = esTemaOscuro ? Color.White : Color.Black;
            dgvAdministrador.BackgroundColor = fondo;
            dgvAdministrador.DefaultCellStyle.BackColor = fondo;
            dgvAdministrador.DefaultCellStyle.ForeColor = texto;

            Color fondoEncabezado = esTemaOscuro ? Color.DarkSlateGray : Color.LightBlue;
            Color textoEncabezado = esTemaOscuro ? Color.White : Color.Black;
            dgvAdministrador.ColumnHeadersDefaultCellStyle.BackColor = fondoEncabezado;
            dgvAdministrador.ColumnHeadersDefaultCellStyle.ForeColor = textoEncabezado;
            dgvAdministrador.EnableHeadersVisualStyles = false;

            Color colorSeleccion = esTemaOscuro ? Color.Gray : Color.LightGray;
            Color textoSeleccion = esTemaOscuro ? Color.White : Color.Black;

            dgvAdministrador.DefaultCellStyle.SelectionBackColor = colorSeleccion;
            dgvAdministrador.DefaultCellStyle.SelectionForeColor = textoSeleccion;
            dgvAdministrador.RowHeadersDefaultCellStyle.SelectionBackColor = colorSeleccion;
            dgvAdministrador.RowHeadersDefaultCellStyle.SelectionForeColor = textoSeleccion;

            // Aplica colores a controles estándar (excluyendo los de búsqueda ya aplicados)
            AplicarColoresControles(this.Controls, fondo, texto);
        }

        private void AplicarColoresControles(Control.ControlCollection controles, Color fondo, Color texto)
        {
            foreach (Control ctrl in controles)
            {
                // No aplicar a controles específicos que ya tienen su tema
                if (ctrl.Name != "tituloPersonalizado" && ctrl.Name != "lblBuscar" && ctrl.Name != "txtBuscar")
                {
                    if (!ctrl.GetType().Name.StartsWith("Metro"))
                    {
                        ctrl.BackColor = fondo;
                        ctrl.ForeColor = texto;
                    }
                }

                if (ctrl.HasChildren)
                    AplicarColoresControles(ctrl.Controls, fondo, texto);
            }
        }

        private bool EsTemaOscuro()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    if (key != null)
                    {
                        object valor = key.GetValue("AppsUseLightTheme");
                        if (valor != null)
                        {
                            int useLightTheme = (int)valor;
                            return useLightTheme == 0;
                        }
                    }
                }
            }
            catch { }
            return false;
        }

        private void UpdateProcessList()
        {
            // Guardar la lista completa de procesos
            listaProcesosFull = Process.GetProcesses().ToList();

            // Si hay filtro aplicado, filtrar; si no, mostrar todos
            FiltrarProcesos();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProceso.Text))
                {
                    MessageBox.Show("Por favor selecciona un proceso primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show($"¿Estás seguro de que quieres terminar el proceso '{txtProceso.Text}'?",
                    "Confirmar terminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (Process p in Process.GetProcesses())
                    {
                        if (p.ProcessName == txtProceso.Text)
                        {
                            p.Kill();
                        }
                    }
                    UpdateProcessList(); // Actualizar después de terminar proceso
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proceso: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAdministrador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAdministrador.CurrentRow != null)
            {
                txtProceso.Text = dgvAdministrador.CurrentRow.Cells[0].Value?.ToString() ?? "";
            }
        }
        //-------------------------------------------Realizado por Andy Garcia--------------------------------------------------
        //herramienta para ejecutar un bloque de código de manera periódica en intervalos de tiempo definido
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                // obtienendo los valores actuales de CPU y RAM mediante la herramienta PerformanceCounters
                float cpu = pCPU.NextValue();
                float ram = pRAM.NextValue();

                // Asignaciion de los valores a las barras de progreso
                gCPU.Value = (int)Math.Min(cpu, 100); //Maximo 100%
                gRAM.Value = (int)Math.Min(ram, 100); //Maximo 100%

                // Mostrando los valores en etiquetas 
                labelCPU.Text = string.Format("{0:0.00}%", cpu); //Se utiliza formato con dos decimales y el símbolo de porcentaje
                labelRam.Text = string.Format("{0:0.00}%", ram); //Se utiliza formato con dos decimales y el símbolo de porcentaje

                // Se limita la cantidad de puntos en la gráfica (máximo de 50) para evitar exceso de uso de recursos
                if (grafica.Series["CPU"].Points.Count > 50)
                    grafica.Series["CPU"].Points.RemoveAt(0);
                if (grafica.Series["RAM"].Points.Count > 50)
                    grafica.Series["RAM"].Points.RemoveAt(0);

                // Agregando los nuevos valores a las series de la gráfica
                grafica.Series["CPU"].Points.AddY(cpu);
                grafica.Series["RAM"].Points.AddY(ram);
            }
            catch (Exception )
            {
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}