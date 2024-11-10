namespace Basic_SQL_Client
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            editor = new RichTextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            splitContainer2 = new SplitContainer();
            resultado = new DataGridView();
            consola = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultado).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(editor);
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(979, 565);
            splitContainer1.SplitterDistance = 196;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // editor
            // 
            editor.BorderStyle = BorderStyle.FixedSingle;
            editor.Dock = DockStyle.Fill;
            editor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editor.Location = new Point(0, 25);
            editor.Name = "editor";
            editor.Size = new Size(979, 171);
            editor.TabIndex = 1;
            editor.Text = "select * from usuario;";
            editor.TextChanged += editor_TextChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(979, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.run;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(69, 22);
            toolStripButton1.Text = "Ejecutar";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.historial;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(71, 22);
            toolStripButton2.Text = "Historial";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(resultado);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(consola);
            splitContainer2.Size = new Size(979, 365);
            splitContainer2.SplitterDistance = 262;
            splitContainer2.TabIndex = 0;
            // 
            // resultado
            // 
            resultado.AllowUserToAddRows = false;
            resultado.AllowUserToDeleteRows = false;
            resultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultado.Dock = DockStyle.Fill;
            resultado.Location = new Point(0, 0);
            resultado.Name = "resultado";
            resultado.ReadOnly = true;
            resultado.Size = new Size(979, 262);
            resultado.TabIndex = 0;
            // 
            // consola
            // 
            consola.Dock = DockStyle.Fill;
            consola.Location = new Point(0, 0);
            consola.Name = "consola";
            consola.Size = new Size(979, 99);
            consola.TabIndex = 0;
            consola.Text = "";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 565);
            Controls.Add(splitContainer1);
            Name = "Principal";
            Text = "Principal";
            FormClosing += Principal_FormClosing;
            Load += Principal_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private RichTextBox editor;
        private ToolStrip toolStrip1;
        private SplitContainer splitContainer2;
        private RichTextBox consola;
        private DataGridView resultado;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
    }
}
