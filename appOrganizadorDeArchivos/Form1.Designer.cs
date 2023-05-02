namespace appOrganizadorDeArchivos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnopen = new System.Windows.Forms.Button();
            this.btnorganize = new System.Windows.Forms.Button();
            this.tuvFiles = new System.Windows.Forms.TreeView();
            this.picimagenes = new System.Windows.Forms.PictureBox();
            this.rtbtext = new System.Windows.Forms.RichTextBox();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.btnPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(52, 53);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(136, 42);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "OPEN FOLDER";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnorganize
            // 
            this.btnorganize.Location = new System.Drawing.Point(219, 53);
            this.btnorganize.Name = "btnorganize";
            this.btnorganize.Size = new System.Drawing.Size(148, 42);
            this.btnorganize.TabIndex = 1;
            this.btnorganize.Text = "ORGANIZE FILES";
            this.btnorganize.UseVisualStyleBackColor = true;
            this.btnorganize.Click += new System.EventHandler(this.btnorganize_Click);
            // 
            // tuvFiles
            // 
            this.tuvFiles.Location = new System.Drawing.Point(52, 136);
            this.tuvFiles.Name = "tuvFiles";
            this.tuvFiles.Size = new System.Drawing.Size(349, 563);
            this.tuvFiles.TabIndex = 2;
            this.tuvFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tuvFiles_AfterSelect);
            // 
            // picimagenes
            // 
            this.picimagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picimagenes.Location = new System.Drawing.Point(520, 133);
            this.picimagenes.Name = "picimagenes";
            this.picimagenes.Size = new System.Drawing.Size(827, 442);
            this.picimagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimagenes.TabIndex = 3;
            this.picimagenes.TabStop = false;
            // 
            // rtbtext
            // 
            this.rtbtext.Location = new System.Drawing.Point(520, 136);
            this.rtbtext.Name = "rtbtext";
            this.rtbtext.Size = new System.Drawing.Size(827, 439);
            this.rtbtext.TabIndex = 4;
            this.rtbtext.Text = "";
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(520, 136);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(827, 439);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 5;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(905, 611);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 763);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.rtbtext);
            this.Controls.Add(this.picimagenes);
            this.Controls.Add(this.tuvFiles);
            this.Controls.Add(this.btnorganize);
            this.Controls.Add(this.btnopen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picimagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnorganize;
        private System.Windows.Forms.TreeView tuvFiles;
        private System.Windows.Forms.PictureBox picimagenes;
        private System.Windows.Forms.RichTextBox rtbtext;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Button btnPause;
    }
}

