using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jugadores
{
    public partial class Form1 : Form
    {
        private List<Jugador> listaJugador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JugadorNegocio negocio = new JugadorNegocio();
            listaJugador = negocio.listar();
            dgvJugadores.DataSource = listaJugador;

            cargarImagen(listaJugador[0].UrlImagen);

        }

        private void dgvJugadores_SelectionChanged(object sender, EventArgs e)
        {
            Jugador seleccionado = (Jugador)dgvJugadores.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
        private void cargarImagen(string imagen) 
        {
            try
            {
                pbxJugador.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxJugador.Load("https://png.pngtree.com/png-vector/20210604/ourmid/pngtree-gray-network-placeholder-png-image_3416659.jpg");

            }
        }
    }
}
