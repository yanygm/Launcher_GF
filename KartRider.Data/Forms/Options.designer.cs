
namespace KartRider
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.DataPack_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DataPack_CheckBox
            // 
            this.DataPack_CheckBox.AutoSize = true;
            this.DataPack_CheckBox.Location = new System.Drawing.Point(18, 12);
            this.DataPack_CheckBox.Name = "DataPack_CheckBox";
            this.DataPack_CheckBox.Size = new System.Drawing.Size(72, 16);
            this.DataPack_CheckBox.TabIndex = 4;
            this.DataPack_CheckBox.Text = "DataPack";
            this.DataPack_CheckBox.UseVisualStyleBackColor = true;
            this.DataPack_CheckBox.CheckedChanged += new System.EventHandler(this.DataPack_CheckBox_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 130);
            this.Controls.Add(this.DataPack_CheckBox);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox DataPack_CheckBox;
    }
}