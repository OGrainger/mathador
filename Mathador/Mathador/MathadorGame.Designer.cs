﻿namespace Mathador
{
    partial class MathadorGame
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
            this.components = new System.ComponentModel.Container();
            this.BouttonNombre1 = new System.Windows.Forms.Button();
            this.BouttonNombre2 = new System.Windows.Forms.Button();
            this.BouttonNombre3 = new System.Windows.Forms.Button();
            this.BouttonNombre4 = new System.Windows.Forms.Button();
            this.ButtonNombre5 = new System.Windows.Forms.Button();
            this.NombreCible = new System.Windows.Forms.Label();
            this.TextCible = new System.Windows.Forms.Label();
            this.TextTimer = new System.Windows.Forms.Label();
            this.TextTemps = new System.Windows.Forms.Label();
            this.TextAffichageScore = new System.Windows.Forms.Label();
            this.TextScore = new System.Windows.Forms.Label();
            this.ButtonSuivant = new System.Windows.Forms.Button();
            this.ButtonRetour = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMoins = new System.Windows.Forms.Button();
            this.ButtonFois = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.ButtonTestGenerer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TextPseudo = new System.Windows.Forms.Label();
            this.buttonSoluces = new System.Windows.Forms.Button();
            this.listBoxSoluces = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BouttonNombre1
            // 
            this.BouttonNombre1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BouttonNombre1.Location = new System.Drawing.Point(23, 225);
            this.BouttonNombre1.Name = "BouttonNombre1";
            this.BouttonNombre1.Size = new System.Drawing.Size(75, 23);
            this.BouttonNombre1.TabIndex = 0;
            this.BouttonNombre1.UseVisualStyleBackColor = false;
            this.BouttonNombre1.Click += new System.EventHandler(this.BouttonNombre1_Click);
            // 
            // BouttonNombre2
            // 
            this.BouttonNombre2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BouttonNombre2.Location = new System.Drawing.Point(104, 225);
            this.BouttonNombre2.Name = "BouttonNombre2";
            this.BouttonNombre2.Size = new System.Drawing.Size(75, 23);
            this.BouttonNombre2.TabIndex = 1;
            this.BouttonNombre2.UseVisualStyleBackColor = false;
            this.BouttonNombre2.Click += new System.EventHandler(this.BouttonNombre2_Click);
            // 
            // BouttonNombre3
            // 
            this.BouttonNombre3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BouttonNombre3.Location = new System.Drawing.Point(185, 225);
            this.BouttonNombre3.Name = "BouttonNombre3";
            this.BouttonNombre3.Size = new System.Drawing.Size(75, 23);
            this.BouttonNombre3.TabIndex = 2;
            this.BouttonNombre3.UseVisualStyleBackColor = false;
            this.BouttonNombre3.Click += new System.EventHandler(this.BouttonNombre3_Click);
            // 
            // BouttonNombre4
            // 
            this.BouttonNombre4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BouttonNombre4.Location = new System.Drawing.Point(266, 225);
            this.BouttonNombre4.Name = "BouttonNombre4";
            this.BouttonNombre4.Size = new System.Drawing.Size(75, 23);
            this.BouttonNombre4.TabIndex = 3;
            this.BouttonNombre4.UseVisualStyleBackColor = false;
            this.BouttonNombre4.Click += new System.EventHandler(this.BouttonNombre4_Click);
            // 
            // ButtonNombre5
            // 
            this.ButtonNombre5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNombre5.Location = new System.Drawing.Point(347, 225);
            this.ButtonNombre5.Name = "ButtonNombre5";
            this.ButtonNombre5.Size = new System.Drawing.Size(75, 23);
            this.ButtonNombre5.TabIndex = 4;
            this.ButtonNombre5.UseVisualStyleBackColor = false;
            this.ButtonNombre5.Click += new System.EventHandler(this.ButtonNombre5_Click);
            // 
            // NombreCible
            // 
            this.NombreCible.AutoSize = true;
            this.NombreCible.Location = new System.Drawing.Point(207, 160);
            this.NombreCible.Name = "NombreCible";
            this.NombreCible.Size = new System.Drawing.Size(13, 13);
            this.NombreCible.TabIndex = 5;
            this.NombreCible.Text = "0";
            // 
            // TextCible
            // 
            this.TextCible.AutoSize = true;
            this.TextCible.Location = new System.Drawing.Point(207, 134);
            this.TextCible.Name = "TextCible";
            this.TextCible.Size = new System.Drawing.Size(30, 13);
            this.TextCible.TabIndex = 6;
            this.TextCible.Text = "Cible";
            // 
            // TextTimer
            // 
            this.TextTimer.AutoSize = true;
            this.TextTimer.Location = new System.Drawing.Point(103, 160);
            this.TextTimer.Name = "TextTimer";
            this.TextTimer.Size = new System.Drawing.Size(49, 13);
            this.TextTimer.TabIndex = 7;
            this.TextTimer.Text = "00:00:00";
            // 
            // TextTemps
            // 
            this.TextTemps.AutoSize = true;
            this.TextTemps.Location = new System.Drawing.Point(103, 134);
            this.TextTemps.Name = "TextTemps";
            this.TextTemps.Size = new System.Drawing.Size(39, 13);
            this.TextTemps.TabIndex = 8;
            this.TextTemps.Text = "Temps";
            this.TextTemps.Click += new System.EventHandler(this.TextTemps_Click);
            // 
            // TextAffichageScore
            // 
            this.TextAffichageScore.AutoSize = true;
            this.TextAffichageScore.Location = new System.Drawing.Point(319, 160);
            this.TextAffichageScore.Name = "TextAffichageScore";
            this.TextAffichageScore.Size = new System.Drawing.Size(13, 13);
            this.TextAffichageScore.TabIndex = 9;
            this.TextAffichageScore.Text = "0";
            // 
            // TextScore
            // 
            this.TextScore.AutoSize = true;
            this.TextScore.Location = new System.Drawing.Point(306, 134);
            this.TextScore.Name = "TextScore";
            this.TextScore.Size = new System.Drawing.Size(35, 13);
            this.TextScore.TabIndex = 10;
            this.TextScore.Text = "Score";
            // 
            // ButtonSuivant
            // 
            this.ButtonSuivant.Location = new System.Drawing.Point(383, 160);
            this.ButtonSuivant.Name = "ButtonSuivant";
            this.ButtonSuivant.Size = new System.Drawing.Size(75, 23);
            this.ButtonSuivant.TabIndex = 11;
            this.ButtonSuivant.Text = "Suivant";
            this.ButtonSuivant.UseVisualStyleBackColor = true;
            this.ButtonSuivant.Click += new System.EventHandler(this.ButtonSuivant_Click);
            // 
            // ButtonRetour
            // 
            this.ButtonRetour.Location = new System.Drawing.Point(12, 160);
            this.ButtonRetour.Name = "ButtonRetour";
            this.ButtonRetour.Size = new System.Drawing.Size(75, 23);
            this.ButtonRetour.TabIndex = 12;
            this.ButtonRetour.Text = "Retour";
            this.ButtonRetour.UseVisualStyleBackColor = true;
            this.ButtonRetour.Click += new System.EventHandler(this.ButtonRetour_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(57, 280);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlus.TabIndex = 13;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonMoins
            // 
            this.ButtonMoins.Location = new System.Drawing.Point(145, 280);
            this.ButtonMoins.Name = "ButtonMoins";
            this.ButtonMoins.Size = new System.Drawing.Size(75, 23);
            this.ButtonMoins.TabIndex = 14;
            this.ButtonMoins.Text = "-";
            this.ButtonMoins.UseVisualStyleBackColor = true;
            this.ButtonMoins.Click += new System.EventHandler(this.ButtonMoins_Click);
            // 
            // ButtonFois
            // 
            this.ButtonFois.Location = new System.Drawing.Point(226, 280);
            this.ButtonFois.Name = "ButtonFois";
            this.ButtonFois.Size = new System.Drawing.Size(75, 23);
            this.ButtonFois.TabIndex = 15;
            this.ButtonFois.Text = "x";
            this.ButtonFois.UseVisualStyleBackColor = true;
            this.ButtonFois.Click += new System.EventHandler(this.ButtonFois_Click);
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.Location = new System.Drawing.Point(313, 280);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(75, 23);
            this.ButtonDiv.TabIndex = 16;
            this.ButtonDiv.Text = "/";
            this.ButtonDiv.UseVisualStyleBackColor = true;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // ButtonTestGenerer
            // 
            this.ButtonTestGenerer.Location = new System.Drawing.Point(185, 90);
            this.ButtonTestGenerer.Name = "ButtonTestGenerer";
            this.ButtonTestGenerer.Size = new System.Drawing.Size(75, 23);
            this.ButtonTestGenerer.TabIndex = 17;
            this.ButtonTestGenerer.Text = "Generer";
            this.ButtonTestGenerer.UseVisualStyleBackColor = true;
            this.ButtonTestGenerer.Click += new System.EventHandler(this.ButtonTestGenerer_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this._timer1_Tick);
            // 
            // TextPseudo
            // 
            this.TextPseudo.AutoSize = true;
            this.TextPseudo.Location = new System.Drawing.Point(12, 13);
            this.TextPseudo.Name = "TextPseudo";
            this.TextPseudo.Size = new System.Drawing.Size(75, 13);
            this.TextPseudo.TabIndex = 18;
            this.TextPseudo.Text = "PseudoJoueur";
            // 
            // buttonSoluces
            // 
            this.buttonSoluces.Location = new System.Drawing.Point(185, 406);
            this.buttonSoluces.Name = "buttonSoluces";
            this.buttonSoluces.Size = new System.Drawing.Size(75, 23);
            this.buttonSoluces.TabIndex = 19;
            this.buttonSoluces.Text = "Solutions";
            this.buttonSoluces.UseVisualStyleBackColor = true;
            this.buttonSoluces.Click += new System.EventHandler(this.buttonSoluces_Click);
            // 
            // listBoxSoluces
            // 
            this.listBoxSoluces.FormattingEnabled = true;
            this.listBoxSoluces.Location = new System.Drawing.Point(579, 31);
            this.listBoxSoluces.Name = "listBoxSoluces";
            this.listBoxSoluces.Size = new System.Drawing.Size(423, 407);
            this.listBoxSoluces.TabIndex = 20;
            this.listBoxSoluces.SelectedIndexChanged += new System.EventHandler(this.listBoxSoluces_SelectedIndexChanged);
            // 
            // MathadorGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 479);
            this.Controls.Add(this.listBoxSoluces);
            this.Controls.Add(this.buttonSoluces);
            this.Controls.Add(this.TextPseudo);
            this.Controls.Add(this.ButtonTestGenerer);
            this.Controls.Add(this.ButtonDiv);
            this.Controls.Add(this.ButtonFois);
            this.Controls.Add(this.ButtonMoins);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonRetour);
            this.Controls.Add(this.ButtonSuivant);
            this.Controls.Add(this.TextScore);
            this.Controls.Add(this.TextAffichageScore);
            this.Controls.Add(this.TextTemps);
            this.Controls.Add(this.TextTimer);
            this.Controls.Add(this.TextCible);
            this.Controls.Add(this.NombreCible);
            this.Controls.Add(this.ButtonNombre5);
            this.Controls.Add(this.BouttonNombre4);
            this.Controls.Add(this.BouttonNombre3);
            this.Controls.Add(this.BouttonNombre2);
            this.Controls.Add(this.BouttonNombre1);
            this.Name = "MathadorGame";
            this.Text = "MathadorGame";
            this.Load += new System.EventHandler(this.MathadorGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BouttonNombre1;
        private System.Windows.Forms.Button BouttonNombre2;
        private System.Windows.Forms.Button BouttonNombre3;
        private System.Windows.Forms.Button BouttonNombre4;
        private System.Windows.Forms.Button ButtonNombre5;
        private System.Windows.Forms.Label NombreCible;
        private System.Windows.Forms.Label TextCible;
        private System.Windows.Forms.Label TextTimer;
        private System.Windows.Forms.Label TextTemps;
        private System.Windows.Forms.Label TextAffichageScore;
        private System.Windows.Forms.Label TextScore;
        private System.Windows.Forms.Button ButtonSuivant;
        private System.Windows.Forms.Button ButtonRetour;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonMoins;
        private System.Windows.Forms.Button ButtonFois;
        private System.Windows.Forms.Button ButtonDiv;
        private System.Windows.Forms.Button ButtonTestGenerer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TextPseudo;
        private System.Windows.Forms.Button buttonSoluces;
        private System.Windows.Forms.ListBox listBoxSoluces;
    }
}

