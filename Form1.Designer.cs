
namespace Eze_s_Web_Browser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.ezeCalculator1 = new Eze_s_Web_Browser.ezeCalculator();
            this.ezeSecurity1 = new Eze_s_Web_Browser.ezeSecurity();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(800, 331);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(93, 12);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(75, 23);
            this.forward.TabIndex = 2;
            this.forward.Text = "Forward";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(174, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Location = new System.Drawing.Point(699, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Location = new System.Drawing.Point(255, 12);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(438, 22);
            this.input.TabIndex = 5;
            // 
            // ezeCalculator1
            // 
            this.ezeCalculator1.Location = new System.Drawing.Point(406, 380);
            this.ezeCalculator1.Name = "ezeCalculator1";
            this.ezeCalculator1.Size = new System.Drawing.Size(382, 68);
            this.ezeCalculator1.TabIndex = 6;
            // 
            // ezeSecurity1
            // 
            this.ezeSecurity1.Location = new System.Drawing.Point(0, 378);
            this.ezeSecurity1.Name = "ezeSecurity1";
            this.ezeSecurity1.Size = new System.Drawing.Size(313, 71);
            this.ezeSecurity1.TabIndex = 7;
            this.ezeSecurity1.Load += new System.EventHandler(this.ezeSecurity1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ezeSecurity1);
            this.Controls.Add(this.ezeCalculator1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.search);
            this.Controls.Add(this.home);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Eze\'s Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox input;
        private ezeCalculator ezeCalculator1;
        private ezeSecurity ezeSecurity1;
    }
}

