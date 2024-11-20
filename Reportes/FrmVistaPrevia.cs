using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallasSalidas.Reportes
{
   public partial class FrmVistaPrevia : Form
   {
      public FrmVistaPrevia()
      {
         InitializeComponent();
      }

      private void FrmVistaPrevia_Load(object sender, EventArgs e)
      {

            this.reportViewer1.RefreshReport();
        }

      private void reportViewer1_Load(object sender, EventArgs e)
      {

      }
   }
}
