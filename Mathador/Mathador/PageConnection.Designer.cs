﻿namespace Mathador
{
    partial class PageConnection
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
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErreurPseudo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ErreurMDP = new System.Windows.Forms.Label();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.buttonValiderConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(114, 85);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPseudo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pseudo :";
            // 
            // ErreurPseudo
            // 
            this.ErreurPseudo.AutoSize = true;
            this.ErreurPseudo.Location = new System.Drawing.Point(220, 85);
            this.ErreurPseudo.Name = "ErreurPseudo";
            this.ErreurPseudo.Size = new System.Drawing.Size(10, 13);
            this.ErreurPseudo.TabIndex = 3;
            this.ErreurPseudo.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe :";
            // 
            // ErreurMDP
            // 
            this.ErreurMDP.AutoSize = true;
            this.ErreurMDP.Location = new System.Drawing.Point(220, 140);
            this.ErreurMDP.Name = "ErreurMDP";
            this.ErreurMDP.Size = new System.Drawing.Size(10, 13);
            this.ErreurMDP.TabIndex = 5;
            this.ErreurMDP.Text = "-";
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(114, 140);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(100, 20);
            this.textBoxMDP.TabIndex = 6;
            // 
            // buttonValiderConnection
            // 
            this.buttonValiderConnection.Location = new System.Drawing.Point(126, 184);
            this.buttonValiderConnection.Name = "buttonValiderConnection";
            this.buttonValiderConnection.Size = new System.Drawing.Size(75, 23);
            this.buttonValiderConnection.TabIndex = 7;
            this.buttonValiderConnection.Text = "Valider";
            this.buttonValiderConnection.UseVisualStyleBackColor = true;
            this.buttonValiderConnection.Click += new System.EventHandler(this.buttonValiderConnection_Click);
            // 
            // PageConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 317);
            this.Controls.Add(this.buttonValiderConnection);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.ErreurMDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ErreurPseudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPseudo);
            this.Name = "PageConnection";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErreurPseudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErreurMDP;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Button buttonValiderConnection;
    }
}