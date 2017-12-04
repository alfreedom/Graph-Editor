namespace Editor_de_Grafos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGL = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // openGL
            // 
            this.openGL.AccumBits = ((byte)(0));
            this.openGL.AutoCheckErrors = false;
            this.openGL.AutoFinish = false;
            this.openGL.AutoMakeCurrent = true;
            this.openGL.AutoSwapBuffers = true;
            this.openGL.BackColor = System.Drawing.Color.DarkGray;
            this.openGL.ColorBits = ((byte)(32));
            this.openGL.DepthBits = ((byte)(16));
            this.openGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGL.Location = new System.Drawing.Point(0, 0);
            this.openGL.Name = "openGL";
            this.openGL.Size = new System.Drawing.Size(761, 465);
            this.openGL.StencilBits = ((byte)(0));
            this.openGL.TabIndex = 0;
            this.openGL.Paint += new System.Windows.Forms.PaintEventHandler(this.openGL_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 465);
            this.Controls.Add(this.openGL);
            this.Name = "Form1";
            this.Text = "Editor de Grafos";
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl openGL;

    }
}

