using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Workshop
{
    public partial class ControlAsistencia : Form
    {
        // Lista de asistentes
        List<string> asistentes = new List<string>();

        // Lista de colaboradores
        List<string> colaboradores = new List<string>();

        // Lista total
        List<string> total = new List<string>();



        public ControlAsistencia()
        {
            InitializeComponent();

           /* 
            textBox1.Items.AddRange(asistentes);
            textBox2.Items.AddRange(colaboradores);

            // Definir el Selected Item del cuadro de lista de asistentes
            textBox1.SelectedItem = asistentes[0];

            // Definir el Selected Item del cuadro de lista de colaboradores
            textBox2.SelectedItem = colaboradores[0];*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del usuario seleccionado
            string usuarioSeleccionado = textBox2.Text;

            // Move the assistant to the attendees list
            moverALista(usuarioSeleccionado, "colaboradores", "asistentes");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Get the selected colaborador from the list
            string colaboradorSeleccionado = textBox1.Text;

            // Move the colaborador to the collaborators list
            moverALista(colaboradorSeleccionado, "asistentes", "colaboradores");
        }

        private void moverALista(string usuario, string listaOrigen, string listaDestino)
        {
            // Eliminar el usuario de la lista de origen
            if (listaOrigen == "colaboradores")
            {
                colaboradores.Remove(usuario);
            }
            else if (listaOrigen == "asistentes")
            {
                asistentes.Remove(usuario);
            }

            // Agregar el usuario a la lista de destino
            if (listaDestino == "colaboradores")
            {
                colaboradores.Add(usuario);
            }
            else if (listaDestino == "asistentes")
            {
                asistentes.Add(usuario);
            }
/*
            // Actualizar los cuadros de lista
            textBox1.Items.Clear();
            textBox2.Items.Clear();

            textBox1.Items.AddRange(asistentes);
            textBox2.Items.AddRange(colaboradores);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Historico historico = new Historico();
            historico.Show();
            this.Close();
        }
    }
}