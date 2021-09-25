
namespace Eze_s_Web_Browser
{
    partial class ezeCalculator
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
            this.components = new System.ComponentModel.Container();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(13, 3);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 22);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(13, 31);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 22);
            this.input2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(143, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(143, 32);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 4;
            this.multiply.Text = "Multiply";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(224, 3);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(75, 23);
            this.subtract.TabIndex = 5;
            this.subtract.Text = "Subtract";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(224, 32);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 6;
            this.divide.Text = "Divide";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(318, 19);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(51, 17);
            this.output.TabIndex = 7;
            this.output.Text = "Output";
            // 
            // ezeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.output);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.add);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "ezeCalculator";
            this.Size = new System.Drawing.Size(382, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label output;
    }
}
