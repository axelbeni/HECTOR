namespace Hector
{
    partial class FormModal
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonIntegAdd = new System.Windows.Forms.Button();
            this.buttonIntegEcrase = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(228, 195);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(117, 20);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Selectionner Fichier";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonIntegAdd
            // 
            this.buttonIntegAdd.Location = new System.Drawing.Point(19, 127);
            this.buttonIntegAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIntegAdd.Name = "buttonIntegAdd";
            this.buttonIntegAdd.Size = new System.Drawing.Size(169, 22);
            this.buttonIntegAdd.TabIndex = 1;
            this.buttonIntegAdd.Text = "Intégrer mode ajout";
            this.buttonIntegAdd.UseVisualStyleBackColor = true;
            this.buttonIntegAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonIntegEcrase
            // 
            this.buttonIntegEcrase.Location = new System.Drawing.Point(19, 75);
            this.buttonIntegEcrase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIntegEcrase.Name = "buttonIntegEcrase";
            this.buttonIntegEcrase.Size = new System.Drawing.Size(169, 26);
            this.buttonIntegEcrase.TabIndex = 2;
            this.buttonIntegEcrase.Text = "Intégrer mode écrasement";
            this.buttonIntegEcrase.UseVisualStyleBackColor = true;
            this.buttonIntegEcrase.Click += new System.EventHandler(this.buttonIntegEcrase_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(19, 28);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(170, 20);
            this.textBoxFileName.TabIndex = 3;
            this.textBoxFileName.Text = "Filename";
            this.textBoxFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Green;
            this.progressBar.Location = new System.Drawing.Point(19, 188);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(170, 26);
            this.progressBar.TabIndex = 4;
            // 
            // FormModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(356, 226);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonIntegEcrase);
            this.Controls.Add(this.buttonIntegAdd);
            this.Controls.Add(this.buttonSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormModal";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonIntegAdd;
        private System.Windows.Forms.Button buttonIntegEcrase;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}