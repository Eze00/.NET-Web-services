
namespace Eze_s_Web_Browser
{
    partial class ezeSecurity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enInput = new System.Windows.Forms.TextBox();
            this.enOutput = new System.Windows.Forms.Label();
            this.encryption = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.deInput = new System.Windows.Forms.TextBox();
            this.deOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enInput
            // 
            this.enInput.Location = new System.Drawing.Point(3, 6);
            this.enInput.Name = "enInput";
            this.enInput.Size = new System.Drawing.Size(100, 22);
            this.enInput.TabIndex = 0;
            // 
            // enOutput
            // 
            this.enOutput.AutoSize = true;
            this.enOutput.Location = new System.Drawing.Point(190, 8);
            this.enOutput.Name = "enOutput";
            this.enOutput.Size = new System.Drawing.Size(51, 17);
            this.enOutput.TabIndex = 1;
            this.enOutput.Text = "Output";
            // 
            // encryption
            // 
            this.encryption.Location = new System.Drawing.Point(109, 3);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(75, 29);
            this.encryption.TabIndex = 2;
            this.encryption.Text = "Encrypt";
            this.encryption.UseVisualStyleBackColor = true;
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(109, 38);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 30);
            this.decrypt.TabIndex = 3;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // deInput
            // 
            this.deInput.Location = new System.Drawing.Point(3, 42);
            this.deInput.Name = "deInput";
            this.deInput.Size = new System.Drawing.Size(100, 22);
            this.deInput.TabIndex = 4;
            // 
            // deOutput
            // 
            this.deOutput.AutoSize = true;
            this.deOutput.Location = new System.Drawing.Point(190, 38);
            this.deOutput.Name = "deOutput";
            this.deOutput.Size = new System.Drawing.Size(51, 17);
            this.deOutput.TabIndex = 5;
            this.deOutput.Text = "Output";
            // 
            // ezeSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deOutput);
            this.Controls.Add(this.deInput);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encryption);
            this.Controls.Add(this.enOutput);
            this.Controls.Add(this.enInput);
            this.Name = "ezeSecurity";
            this.Size = new System.Drawing.Size(313, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enInput;
        private System.Windows.Forms.Label enOutput;
        private System.Windows.Forms.Button encryption;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox deInput;
        private System.Windows.Forms.Label deOutput;
    }
}
