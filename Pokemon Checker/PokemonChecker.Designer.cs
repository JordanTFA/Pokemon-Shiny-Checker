namespace Pokemon_Checker
{
    partial class frmPokemonChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokemonChecker));
            this.lblEncounters = new System.Windows.Forms.Label();
            this.txtEncounters = new System.Windows.Forms.TextBox();
            this.lblChance = new System.Windows.Forms.Label();
            this.btnDexNav = new System.Windows.Forms.Button();
            this.grpShinyCharm = new System.Windows.Forms.GroupBox();
            this.chkCharm = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnMasuda = new System.Windows.Forms.Button();
            this.btnHordes = new System.Windows.Forms.Button();
            this.btnChain = new System.Windows.Forms.Button();
            this.btnFriend = new System.Windows.Forms.Button();
            this.btnRadar = new System.Windows.Forms.Button();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.grpShinyCharm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncounters
            // 
            this.lblEncounters.AutoSize = true;
            this.lblEncounters.Location = new System.Drawing.Point(49, 35);
            this.lblEncounters.Name = "lblEncounters";
            this.lblEncounters.Size = new System.Drawing.Size(64, 13);
            this.lblEncounters.TabIndex = 0;
            this.lblEncounters.Text = "Encounters:";
            // 
            // txtEncounters
            // 
            this.txtEncounters.Location = new System.Drawing.Point(52, 60);
            this.txtEncounters.Name = "txtEncounters";
            this.txtEncounters.Size = new System.Drawing.Size(100, 20);
            this.txtEncounters.TabIndex = 1;
            // 
            // lblChance
            // 
            this.lblChance.AutoSize = true;
            this.lblChance.Location = new System.Drawing.Point(69, 286);
            this.lblChance.Name = "lblChance";
            this.lblChance.Size = new System.Drawing.Size(0, 13);
            this.lblChance.TabIndex = 2;
            // 
            // btnDexNav
            // 
            this.btnDexNav.Location = new System.Drawing.Point(258, 97);
            this.btnDexNav.Name = "btnDexNav";
            this.btnDexNav.Size = new System.Drawing.Size(75, 23);
            this.btnDexNav.TabIndex = 3;
            this.btnDexNav.Text = "DexNav";
            this.btnDexNav.UseVisualStyleBackColor = true;
            this.btnDexNav.Click += new System.EventHandler(this.btnDexNav_Click);
            // 
            // grpShinyCharm
            // 
            this.grpShinyCharm.Controls.Add(this.chkCharm);
            this.grpShinyCharm.Controls.Add(this.pictureBox1);
            this.grpShinyCharm.Location = new System.Drawing.Point(52, 136);
            this.grpShinyCharm.Name = "grpShinyCharm";
            this.grpShinyCharm.Size = new System.Drawing.Size(100, 102);
            this.grpShinyCharm.TabIndex = 4;
            this.grpShinyCharm.TabStop = false;
            this.grpShinyCharm.Text = "Shiny Charm?";
            // 
            // chkCharm
            // 
            this.chkCharm.AutoSize = true;
            this.chkCharm.Checked = true;
            this.chkCharm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCharm.Location = new System.Drawing.Point(20, 49);
            this.chkCharm.Name = "chkCharm";
            this.chkCharm.Size = new System.Drawing.Size(15, 14);
            this.chkCharm.TabIndex = 5;
            this.chkCharm.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnFull
            // 
            this.btnFull.Location = new System.Drawing.Point(258, 60);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(75, 23);
            this.btnFull.TabIndex = 5;
            this.btnFull.Text = "Full Odds";
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnMasuda
            // 
            this.btnMasuda.Location = new System.Drawing.Point(258, 136);
            this.btnMasuda.Name = "btnMasuda";
            this.btnMasuda.Size = new System.Drawing.Size(75, 23);
            this.btnMasuda.TabIndex = 6;
            this.btnMasuda.Text = "Masuda";
            this.btnMasuda.UseVisualStyleBackColor = true;
            this.btnMasuda.Click += new System.EventHandler(this.btnMasuda_Click);
            // 
            // btnHordes
            // 
            this.btnHordes.Location = new System.Drawing.Point(375, 60);
            this.btnHordes.Name = "btnHordes";
            this.btnHordes.Size = new System.Drawing.Size(75, 23);
            this.btnHordes.TabIndex = 7;
            this.btnHordes.Text = "Hordes";
            this.btnHordes.UseVisualStyleBackColor = true;
            this.btnHordes.Click += new System.EventHandler(this.btnHordes_Click);
            // 
            // btnChain
            // 
            this.btnChain.Location = new System.Drawing.Point(313, 179);
            this.btnChain.Name = "btnChain";
            this.btnChain.Size = new System.Drawing.Size(89, 23);
            this.btnChain.TabIndex = 8;
            this.btnChain.Text = "Chain Fishing";
            this.btnChain.UseVisualStyleBackColor = true;
            this.btnChain.Click += new System.EventHandler(this.btnChain_Click);
            // 
            // btnFriend
            // 
            this.btnFriend.Location = new System.Drawing.Point(375, 97);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Size = new System.Drawing.Size(75, 23);
            this.btnFriend.TabIndex = 9;
            this.btnFriend.Text = "Friend Safari";
            this.btnFriend.UseVisualStyleBackColor = true;
            this.btnFriend.Click += new System.EventHandler(this.btnFriend_Click);
            // 
            // btnRadar
            // 
            this.btnRadar.Location = new System.Drawing.Point(375, 136);
            this.btnRadar.Name = "btnRadar";
            this.btnRadar.Size = new System.Drawing.Size(75, 23);
            this.btnRadar.TabIndex = 10;
            this.btnRadar.Text = "PokéRadar";
            this.btnRadar.UseVisualStyleBackColor = true;
            this.btnRadar.Click += new System.EventHandler(this.btnRadar_Click);
            // 
            // grpType
            // 
            this.grpType.Location = new System.Drawing.Point(233, 35);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(257, 203);
            this.grpType.TabIndex = 11;
            this.grpType.TabStop = false;
            this.grpType.Text = "Encounter Type";
            // 
            // grpDisplay
            // 
            this.grpDisplay.Location = new System.Drawing.Point(52, 253);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(438, 82);
            this.grpDisplay.TabIndex = 12;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "Your Chance of a Shiny";
            // 
            // frmPokemonChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 347);
            this.Controls.Add(this.btnRadar);
            this.Controls.Add(this.btnFriend);
            this.Controls.Add(this.btnChain);
            this.Controls.Add(this.btnHordes);
            this.Controls.Add(this.btnMasuda);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.grpShinyCharm);
            this.Controls.Add(this.btnDexNav);
            this.Controls.Add(this.lblChance);
            this.Controls.Add(this.txtEncounters);
            this.Controls.Add(this.lblEncounters);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.grpDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPokemonChecker";
            this.Text = "Shiny Pokemon Chance Checker";
            this.Load += new System.EventHandler(this.frmPokemonChecker_Load);
            this.grpShinyCharm.ResumeLayout(false);
            this.grpShinyCharm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncounters;
        private System.Windows.Forms.Button btnDexNav;
        private System.Windows.Forms.GroupBox grpShinyCharm;
        private System.Windows.Forms.CheckBox chkCharm;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnMasuda;
        private System.Windows.Forms.Button btnHordes;
        private System.Windows.Forms.Button btnChain;
        private System.Windows.Forms.Button btnFriend;
        private System.Windows.Forms.Button btnRadar;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtEncounters;
        protected System.Windows.Forms.Label lblChance;
        private System.Windows.Forms.GroupBox grpDisplay;
    }
}

