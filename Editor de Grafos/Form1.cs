using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.Platform.Windows;
using Tao.Platform;

namespace Editor_de_Grafos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openGL.InitializeContexts();
            openGL.BackColor = Color.White;

        }

        private void openGL_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(openGL.BackColor.R, openGL.BackColor.G, openGL.BackColor.B, 0);
            //Limpia la pantalla
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(openGL.Left, openGL.Right, openGL.Bottom, openGL.Top);
            //para evitar que se reescale la imagen de fondo.
            Gl.glViewport(0, 0, openGL.Width, openGL.Height);




        }
    }
}
