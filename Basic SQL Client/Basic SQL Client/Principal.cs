using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Basic_SQL_Client
{
    public partial class Principal : Form
    {
        Resaltado r;
        public Principal()
        {
            InitializeComponent();
        }

        
        private void Principal_Load(object sender, EventArgs e)
        {
            ConexionSQLite conexion = new ConexionSQLite();

            r = new Resaltado(editor);
            r.resaltar();
        }

        private void editor_TextChanged(object sender, EventArgs e)
        {
            r.resaltar();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {


        }
    }
}
