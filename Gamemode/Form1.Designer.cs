namespace Gamemode
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
            this.btn_ExplorerKill = new System.Windows.Forms.Button();
            this.btn_IdleDisable = new System.Windows.Forms.Button();
            this.btn_ExplorerEnable = new System.Windows.Forms.Button();
            this.btn_IdleEnable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ExplorerKill
            // 
            this.btn_ExplorerKill.Location = new System.Drawing.Point(74, 21);
            this.btn_ExplorerKill.Name = "btn_ExplorerKill";
            this.btn_ExplorerKill.Size = new System.Drawing.Size(104, 31);
            this.btn_ExplorerKill.TabIndex = 0;
            this.btn_ExplorerKill.Text = "Kill explorer";
            this.btn_ExplorerKill.UseVisualStyleBackColor = true;
            this.btn_ExplorerKill.Click += new System.EventHandler(this.btn_ExplorerKill_Click);
            // 
            // btn_IdleDisable
            // 
            this.btn_IdleDisable.Location = new System.Drawing.Point(74, 76);
            this.btn_IdleDisable.Name = "btn_IdleDisable";
            this.btn_IdleDisable.Size = new System.Drawing.Size(104, 31);
            this.btn_IdleDisable.TabIndex = 1;
            this.btn_IdleDisable.Text = "Disable Idle";
            this.btn_IdleDisable.UseVisualStyleBackColor = true;
            this.btn_IdleDisable.Click += new System.EventHandler(this.btnIdleDisable_Click);
            // 
            // btn_ExplorerEnable
            // 
            this.btn_ExplorerEnable.Location = new System.Drawing.Point(74, 131);
            this.btn_ExplorerEnable.Name = "btn_ExplorerEnable";
            this.btn_ExplorerEnable.Size = new System.Drawing.Size(104, 31);
            this.btn_ExplorerEnable.TabIndex = 2;
            this.btn_ExplorerEnable.Text = "Open TaskMngr";
            this.btn_ExplorerEnable.UseVisualStyleBackColor = true;
            this.btn_ExplorerEnable.Click += new System.EventHandler(this.btnExplorerEnable_Click);
            // 
            // btn_IdleEnable
            // 
            this.btn_IdleEnable.Location = new System.Drawing.Point(74, 186);
            this.btn_IdleEnable.Name = "btn_IdleEnable";
            this.btn_IdleEnable.Size = new System.Drawing.Size(104, 31);
            this.btn_IdleEnable.TabIndex = 3;
            this.btn_IdleEnable.Text = "Enable Idle";
            this.btn_IdleEnable.UseVisualStyleBackColor = true;
            this.btn_IdleEnable.Click += new System.EventHandler(this.btnIdleEnable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 242);
            this.Controls.Add(this.btn_IdleEnable);
            this.Controls.Add(this.btn_ExplorerEnable);
            this.Controls.Add(this.btn_IdleDisable);
            this.Controls.Add(this.btn_ExplorerKill);
            this.Name = "Form1";
            this.Text = "Game Mode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ExplorerKill;
        private System.Windows.Forms.Button btn_IdleDisable;
        private System.Windows.Forms.Button btn_ExplorerEnable;
        private System.Windows.Forms.Button btn_IdleEnable;
    }
}

