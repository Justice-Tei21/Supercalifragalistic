namespace Supercalifragalistic
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
            this.components = new System.ComponentModel.Container();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWeight = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.heightbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(6, 40);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(95, 25);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "weight(kg)";
            // 
            // weightbox
            // 
            this.weightbox.BackColor = System.Drawing.SystemColors.Window;
            this.weightbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.weightbox.Location = new System.Drawing.Point(0, 70);
            this.weightbox.Name = "weightbox";
            this.weightbox.Size = new System.Drawing.Size(130, 31);
            this.weightbox.TabIndex = 1;
            this.weightbox.Text = "yes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weightLabel);
            this.groupBox1.Controls.Add(this.weightbox);
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnWeight
            // 
            this.btnWeight.Location = new System.Drawing.Point(204, 117);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(65, 34);
            this.btnWeight.TabIndex = 2;
            this.btnWeight.Text = "calc";
            this.btnWeight.UseVisualStyleBackColor = true;
            this.btnWeight.Click += new System.EventHandler(this.button1_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 40);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(126, 25);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "height(meters)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWeight);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(32, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 378);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.heightbox);
            this.groupBox2.Controls.Add(this.heightLabel);
            this.groupBox2.Location = new System.Drawing.Point(23, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // heightbox
            // 
            this.heightbox.Location = new System.Drawing.Point(0, 70);
            this.heightbox.Name = "heightbox";
            this.heightbox.Size = new System.Drawing.Size(130, 31);
            this.heightbox.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.outputlabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(686, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 197);
            this.panel2.TabIndex = 5;
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.Location = new System.Drawing.Point(56, 108);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(59, 25);
            this.outputlabel.TabIndex = 1;
            this.outputlabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "BMI Calcula";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label weightLabel;
        private TextBox weightbox;
        private GroupBox groupBox1;
        private Label heightLabel;
        private Panel panel1;
        private GroupBox groupBox2;
        private TextBox heightbox;
        private Button btnWeight;
        private Panel panel2;
        private Label label1;
        private Label outputlabel;
        private ErrorProvider errorProvider1;
    }
}