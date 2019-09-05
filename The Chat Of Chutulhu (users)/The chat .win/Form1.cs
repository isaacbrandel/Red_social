using Chat.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_chat.win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cateBL = new CategoriaBL();
            var Lista_categorias = cateBL.MostrarCategorias();
            foreach (var Categoria in Lista_categorias)
            {
                MessageBox.Show(Categoria.Descripcion);

            }
        }
    }
}
