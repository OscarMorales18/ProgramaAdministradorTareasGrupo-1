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

namespace AdministradorTareasGrupo1
{
    public partial class VentanaAdmin : MetroFramework.Forms.MetroForm
    {
        public VentanaAdmin()
        {
            InitializeComponent();
            UpdateProcessList();
            // timer1.Enable = true;
        }
        private void UpdateProcessList()
        {
            dgvAdministrador.Rows.Clear();
            foreach (Process p in Process.GetProcesses())
            {
                int n = dgvAdministrador.Rows.Add();
                dgvAdministrador.Rows[n].Cells[0].Value = p.ProcessName;
                dgvAdministrador.Rows[n].Cells[1].Value = p.Id;
                dgvAdministrador.Rows[n].Cells[2].Value = p.WorkingSet64;
                dgvAdministrador.Rows[n].Cells[3].Value = p.VirtualMemorySize64;
                dgvAdministrador.Rows[n].Cells[4].Value = p.SessionId;
            }
            txtContador.Text = "Procesos Actuales: " + dgvAdministrador.Rows.Count.ToString();
        }
        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process p in Process.GetProcesses())
                {

                    if (p.ProcessName == txtProceso.Text)
                    {
                        p.Kill(); //elimina proceso
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("NO selecciono ningun proceso " + x, "ERROR al eliminar", MessageBoxButtons.OK);
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
            txtProceso.Text = dgvAdministrador.CurrentRow.Cells[0].Value.ToString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            float cpu = pCPU.NextValue();
            float ram = pRAM.NextValue();
            gCPU.Value = (int)cpu;
            gRAM.Value = (int)ram;
            labelCPU.Text = string.Format("{0:0.00}%", cpu);
            labelRam.Text = string.Format("{0:0.00}%", ram);
            grafica.Series["CPU"].Points.AddY(cpu);
            grafica.Series["RAM"].Points.AddY(ram);
        }
    }
}
