using Microsoft.Reporting.WinForms;
using PantallasSalidas.Modelo;
using PantallasSalidas.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallasSalidas
{
   public partial class Form1 : Form

   {
     List <Estudiante> estudiantes = new List <Estudiante> ();


   
      public Form1()
      {
         InitializeComponent();
      }

      private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }

      private void formulariosToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }

      private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Este es un mensaje informativo", "Analisis y Diseño", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      private void opcion2ToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Oscar");
      }

      private void opcion3ToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Este es un mensaje de Advertencia", "Analisis y Diseño", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }

      private void errorToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Error", "Analisis y Diseño", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      private void salirToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var respuesta = MessageBox.Show("¿Desea Salir?", "Analisis y Diseño", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

         if (respuesta == DialogResult.Yes)
         {
           Application.Exit();   
         }
         
      }

      private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
      {
         ReportDataSource reportDataSource = new ReportDataSource("DsDatos", estudiantes);
         FrmVistaPrevia frm = new FrmVistaPrevia();
         frm.reportViewer1.LocalReport.DataSources.Clear();
         frm.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
         frm.reportViewer1.LocalReport.ReportEmbeddedResource = "PantallasSalidas.Reportes.RptInforme1.rdlc";
         frm.reportViewer1.Refresh();
         frm.Show();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         estudiantes.Add(new Estudiante("2302", "Oscar", "Alvarado", "ISI", "oscar@gmail.com", new DateTime(2004, 03, 08)));
         estudiantes.Add(new Estudiante("2335", "Oscar", "Arnueroo", "ISI", "oscar@gmail.com", new DateTime(2004, 03, 08)));
         estudiantes.Add(new Estudiante("23366", "Camilo", "Furai", "ISI", "oscar@gmail.com", new DateTime(2004, 03, 08)));

       
      }

   }
}
