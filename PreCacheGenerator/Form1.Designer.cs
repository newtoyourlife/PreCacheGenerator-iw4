
namespace PreCacheGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbExplosions = new System.Windows.Forms.CheckBox();
            this.cbMovement = new System.Windows.Forms.CheckBox();
            this.cbDeaths = new System.Windows.Forms.CheckBox();
            this.cbStandIdle = new System.Windows.Forms.CheckBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.cbMisc = new System.Windows.Forms.CheckBox();
            this.tbExplosions = new System.Windows.Forms.TrackBar();
            this.tbMovement = new System.Windows.Forms.TrackBar();
            this.tbDeaths = new System.Windows.Forms.TrackBar();
            this.tbStandIdle = new System.Windows.Forms.TrackBar();
            this.tbMisc = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbExplosions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStandIdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMisc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(81, 129);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(69, 40);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Precache";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbExplosions
            // 
            this.cbExplosions.AutoSize = true;
            this.cbExplosions.Location = new System.Drawing.Point(7, 54);
            this.cbExplosions.Name = "cbExplosions";
            this.cbExplosions.Size = new System.Drawing.Size(76, 17);
            this.cbExplosions.TabIndex = 2;
            this.cbExplosions.Text = "Explosions";
            this.cbExplosions.UseVisualStyleBackColor = true;
            this.cbExplosions.CheckedChanged += new System.EventHandler(this.cbExplosions_CheckedChanged);
            // 
            // cbMovement
            // 
            this.cbMovement.AutoSize = true;
            this.cbMovement.Location = new System.Drawing.Point(7, 10);
            this.cbMovement.Name = "cbMovement";
            this.cbMovement.Size = new System.Drawing.Size(76, 17);
            this.cbMovement.TabIndex = 3;
            this.cbMovement.Text = "Movement";
            this.cbMovement.UseVisualStyleBackColor = true;
            this.cbMovement.CheckedChanged += new System.EventHandler(this.cbMovement_CheckedChanged);
            // 
            // cbDeaths
            // 
            this.cbDeaths.AutoSize = true;
            this.cbDeaths.Location = new System.Drawing.Point(7, 32);
            this.cbDeaths.Name = "cbDeaths";
            this.cbDeaths.Size = new System.Drawing.Size(60, 17);
            this.cbDeaths.TabIndex = 4;
            this.cbDeaths.Text = "Deaths";
            this.cbDeaths.UseVisualStyleBackColor = true;
            this.cbDeaths.CheckedChanged += new System.EventHandler(this.cbDeaths_CheckedChanged);
            // 
            // cbStandIdle
            // 
            this.cbStandIdle.AutoSize = true;
            this.cbStandIdle.Location = new System.Drawing.Point(7, 75);
            this.cbStandIdle.Name = "cbStandIdle";
            this.cbStandIdle.Size = new System.Drawing.Size(76, 17);
            this.cbStandIdle.TabIndex = 5;
            this.cbStandIdle.Text = "Stand/Idle";
            this.cbStandIdle.UseVisualStyleBackColor = true;
            this.cbStandIdle.CheckedChanged += new System.EventHandler(this.cbProne_CheckedChanged);
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(10, 140);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(19, 20);
            this.txtLimit.TabIndex = 6;
            this.txtLimit.Text = "25";
            this.txtLimit.TextChanged += new System.EventHandler(this.txtLimit_TextChanged);
            // 
            // cbMisc
            // 
            this.cbMisc.AutoSize = true;
            this.cbMisc.Location = new System.Drawing.Point(7, 97);
            this.cbMisc.Name = "cbMisc";
            this.cbMisc.Size = new System.Drawing.Size(48, 17);
            this.cbMisc.TabIndex = 7;
            this.cbMisc.Text = "Misc";
            this.cbMisc.UseVisualStyleBackColor = true;
            this.cbMisc.CheckedChanged += new System.EventHandler(this.cbMisc_CheckedChanged);
            // 
            // tbExplosions
            // 
            this.tbExplosions.LargeChange = 4;
            this.tbExplosions.Location = new System.Drawing.Point(81, 53);
            this.tbExplosions.Maximum = 18;
            this.tbExplosions.Name = "tbExplosions";
            this.tbExplosions.Size = new System.Drawing.Size(129, 45);
            this.tbExplosions.TabIndex = 8;
            this.tbExplosions.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbMovement
            // 
            this.tbMovement.Location = new System.Drawing.Point(81, 9);
            this.tbMovement.Maximum = 31;
            this.tbMovement.Name = "tbMovement";
            this.tbMovement.Size = new System.Drawing.Size(129, 45);
            this.tbMovement.TabIndex = 9;
            this.tbMovement.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbDeaths
            // 
            this.tbDeaths.Location = new System.Drawing.Point(81, 30);
            this.tbDeaths.Maximum = 35;
            this.tbDeaths.Name = "tbDeaths";
            this.tbDeaths.Size = new System.Drawing.Size(129, 45);
            this.tbDeaths.TabIndex = 10;
            this.tbDeaths.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbStandIdle
            // 
            this.tbStandIdle.LargeChange = 1;
            this.tbStandIdle.Location = new System.Drawing.Point(81, 75);
            this.tbStandIdle.Maximum = 15;
            this.tbStandIdle.Name = "tbStandIdle";
            this.tbStandIdle.Size = new System.Drawing.Size(129, 45);
            this.tbStandIdle.TabIndex = 11;
            this.tbStandIdle.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbMisc
            // 
            this.tbMisc.LargeChange = 1;
            this.tbMisc.Location = new System.Drawing.Point(81, 97);
            this.tbMisc.Maximum = 4;
            this.tbMisc.Name = "tbMisc";
            this.tbMisc.Size = new System.Drawing.Size(129, 45);
            this.tbMisc.TabIndex = 12;
            this.tbMisc.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 174);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbMisc);
            this.Controls.Add(this.tbStandIdle);
            this.Controls.Add(this.tbExplosions);
            this.Controls.Add(this.tbDeaths);
            this.Controls.Add(this.tbMovement);
            this.Controls.Add(this.cbMisc);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.cbStandIdle);
            this.Controls.Add(this.cbDeaths);
            this.Controls.Add(this.cbMovement);
            this.Controls.Add(this.cbExplosions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 213);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 213);
            this.Name = "Form1";
            this.Text = "PreCache Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbExplosions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStandIdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox cbExplosions;
        private System.Windows.Forms.CheckBox cbMovement;
        private System.Windows.Forms.CheckBox cbDeaths;
        private System.Windows.Forms.CheckBox cbStandIdle;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.CheckBox cbCrouchDeath;
        private System.Windows.Forms.CheckBox cbMisc;
        private System.Windows.Forms.TrackBar tbExplosions;
        private System.Windows.Forms.TrackBar tbMovement;
        private System.Windows.Forms.TrackBar tbDeaths;
        private System.Windows.Forms.TrackBar tbStandIdle;
        private System.Windows.Forms.TrackBar tbMisc;
    }
}

