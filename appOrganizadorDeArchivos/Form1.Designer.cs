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
            this.btnopen = new System.Windows.Forms.Button();
            this.btnorganize = new System.Windows.Forms.Button();
            this.lstArchivos = new System.Windows.Forms.ListBox();
            this.txtPath = new System.Windows.Forms.TextBox();
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
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.ItemHeight = 16;
            this.lstArchivos.Location = new System.Drawing.Point(52, 187);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(315, 532);
            this.lstArchivos.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(52, 121);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(315, 22);
            this.txtPath.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 763);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.btnorganize);
            this.Controls.Add(this.btnopen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnorganize;
        private System.Windows.Forms.ListBox lstArchivos;
        private System.Windows.Forms.TextBox txtPath;
    }
}

