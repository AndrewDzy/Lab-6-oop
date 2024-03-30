
namespace Lab_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.coeffATextBox = new System.Windows.Forms.TextBox();
            this.coeffBTextBox = new System.Windows.Forms.TextBox();
            this.coeffCTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rootsTextBox = new System.Windows.Forms.TextBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.solveButton);
            this.tabPage1.Controls.Add(this.rootsTextBox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.coeffCTextBox);
            this.tabPage1.Controls.Add(this.coeffBTextBox);
            this.tabPage1.Controls.Add(this.coeffATextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // coeffATextBox
            // 
            this.coeffATextBox.Location = new System.Drawing.Point(136, 84);
            this.coeffATextBox.Name = "coeffATextBox";
            this.coeffATextBox.Size = new System.Drawing.Size(100, 20);
            this.coeffATextBox.TabIndex = 0;
            this.coeffATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffATextBox_KeyPress);
            // 
            // coeffBTextBox
            // 
            this.coeffBTextBox.Location = new System.Drawing.Point(136, 123);
            this.coeffBTextBox.Name = "coeffBTextBox";
            this.coeffBTextBox.Size = new System.Drawing.Size(100, 20);
            this.coeffBTextBox.TabIndex = 1;
            this.coeffBTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffBTextBox_KeyPress);
            // 
            // coeffCTextBox
            // 
            this.coeffCTextBox.Location = new System.Drawing.Point(136, 164);
            this.coeffCTextBox.Name = "coeffCTextBox";
            this.coeffCTextBox.Size = new System.Drawing.Size(100, 20);
            this.coeffCTextBox.TabIndex = 2;
            this.coeffCTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coeffCTextBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 33);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rootsTextBox
            // 
            this.rootsTextBox.Location = new System.Drawing.Point(268, 123);
            this.rootsTextBox.Name = "rootsTextBox";
            this.rootsTextBox.Size = new System.Drawing.Size(299, 20);
            this.rootsTextBox.TabIndex = 4;
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(268, 164);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 5;
            this.solveButton.Text = "button1";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.TextBox rootsTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox coeffCTextBox;
        private System.Windows.Forms.TextBox coeffBTextBox;
        private System.Windows.Forms.TextBox coeffATextBox;
    }
}

