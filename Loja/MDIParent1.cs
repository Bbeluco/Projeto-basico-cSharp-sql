using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loja.UI
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        
        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
       
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form childForm = new Cadastro_usuario();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
