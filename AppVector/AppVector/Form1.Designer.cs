namespace AppVector
{
    partial class Frmvectores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidaddeParesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarMenorAmayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElementoPosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contarNCapicuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contarNPrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbvalor
            // 
            this.lbvalor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbvalor.AutoSize = true;
            this.lbvalor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvalor.Location = new System.Drawing.Point(73, 58);
            this.lbvalor.Name = "lbvalor";
            this.lbvalor.Size = new System.Drawing.Size(40, 18);
            this.lbvalor.TabIndex = 0;
            this.lbvalor.Text = "Valor";
            this.lbvalor.Click += new System.EventHandler(this.lbvalor_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(139, 56);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 1;
            this.txtvalor.TextChanged += new System.EventHandler(this.txtvalor_TextChanged);
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.Yellow;
            this.btnadicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadicionar.Location = new System.Drawing.Point(262, 54);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(114, 23);
            this.btnadicionar.TabIndex = 2;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresultado.Location = new System.Drawing.Point(43, 109);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(70, 18);
            this.lbresultado.TabIndex = 3;
            this.lbresultado.Text = "Resultado";
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackColor = System.Drawing.Color.Violet;
            this.btnmostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmostrar.Location = new System.Drawing.Point(139, 109);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = false;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicaToolStripMenuItem,
            this.invertirToolStripMenuItem,
            this.avanzadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basicaToolStripMenuItem
            // 
            this.basicaToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.basicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.basicaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.basicaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.basicaToolStripMenuItem.Name = "basicaToolStripMenuItem";
            this.basicaToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.basicaToolStripMenuItem.Text = "Basica";
            this.basicaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // invertirToolStripMenuItem
            // 
            this.invertirToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.invertirToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            this.invertirToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.invertirToolStripMenuItem.Text = "invertir";
            this.invertirToolStripMenuItem.Click += new System.EventHandler(this.invertirToolStripMenuItem_Click);
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine;
            this.avanzadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertirVectorToolStripMenuItem,
            this.cantidaddeParesToolStripMenuItem,
            this.contarNCapicuaToolStripMenuItem,
            this.contarNPrimosToolStripMenuItem,
            this.ordenarMenorAmayorToolStripMenuItem,
            this.eliminarElementoPosToolStripMenuItem});
            this.avanzadoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            // 
            // cantidaddeParesToolStripMenuItem
            // 
            this.cantidaddeParesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cantidaddeParesToolStripMenuItem.Name = "cantidaddeParesToolStripMenuItem";
            this.cantidaddeParesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cantidaddeParesToolStripMenuItem.Text = "CantidaddePares";
            this.cantidaddeParesToolStripMenuItem.Click += new System.EventHandler(this.cantidaddeParesToolStripMenuItem_Click);
            // 
            // ordenarMenorAmayorToolStripMenuItem
            // 
            this.ordenarMenorAmayorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ordenarMenorAmayorToolStripMenuItem.Name = "ordenarMenorAmayorToolStripMenuItem";
            this.ordenarMenorAmayorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ordenarMenorAmayorToolStripMenuItem.Text = "OrdenarMenorAmayor";
            this.ordenarMenorAmayorToolStripMenuItem.Click += new System.EventHandler(this.ordenarMenorAmayorToolStripMenuItem_Click);
            // 
            // eliminarElementoPosToolStripMenuItem
            // 
            this.eliminarElementoPosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.eliminarElementoPosToolStripMenuItem.Name = "eliminarElementoPosToolStripMenuItem";
            this.eliminarElementoPosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.eliminarElementoPosToolStripMenuItem.Text = "Eliminar Elemento Pos";
            this.eliminarElementoPosToolStripMenuItem.Click += new System.EventHandler(this.eliminarElementoPosToolStripMenuItem_Click);
            // 
            // invertirVectorToolStripMenuItem
            // 
            this.invertirVectorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.invertirVectorToolStripMenuItem.Name = "invertirVectorToolStripMenuItem";
            this.invertirVectorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.invertirVectorToolStripMenuItem.Text = "Invertir el Vector";
            this.invertirVectorToolStripMenuItem.Click += new System.EventHandler(this.invertirVectorToolStripMenuItem_Click);
            // 
            // contarNCapicuaToolStripMenuItem
            // 
            this.contarNCapicuaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contarNCapicuaToolStripMenuItem.Name = "contarNCapicuaToolStripMenuItem";
            this.contarNCapicuaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.contarNCapicuaToolStripMenuItem.Text = "Contar N. Capicua";
            this.contarNCapicuaToolStripMenuItem.Click += new System.EventHandler(this.contarNCapicuaToolStripMenuItem_Click);
            // 
            // contarNPrimosToolStripMenuItem
            // 
            this.contarNPrimosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.contarNPrimosToolStripMenuItem.Name = "contarNPrimosToolStripMenuItem";
            this.contarNPrimosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.contarNPrimosToolStripMenuItem.Text = "Contar N. Primos";
            this.contarNPrimosToolStripMenuItem.Click += new System.EventHandler(this.contarNPrimosToolStripMenuItem_Click);
            // 
            // Frmvectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(737, 349);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lbvalor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmvectores";
            this.Text = "Vectores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidaddeParesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarMenorAmayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElementoPosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirVectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contarNCapicuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contarNPrimosToolStripMenuItem;
    }
}

