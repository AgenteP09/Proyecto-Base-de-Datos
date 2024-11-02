using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Basic_SQL_Client
{
    public partial class Principal : Form
    {
        Resaltado r;
        ConexionMySQL conexion;

        public Principal()
        {
            InitializeComponent();
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            r = new Resaltado(editor);
            r.resaltar();
            Conexiones con = new Conexiones();
            this.Hide();
            con.ShowDialog();
            //CONDICIONAR EL FORMULARIO HASTA OBTENER SATISFACTORIAMENTE UNA CONEXIÓN
            if (!con.cancelado)
            {
                conexion = new ConexionMySQL(con.cadenaConexionMySQL);
                this.Show();
            }

        }

        private void editor_TextChanged(object sender, EventArgs e)
        {
            r.resaltar();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            conexion.ejecutarSQL(editor.Text, resultado, consola);
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexion.cerrarConexion();
        }
    }
}
