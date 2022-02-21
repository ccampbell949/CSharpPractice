
namespace UnitConversionGUI
{
    partial class FrmMain
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
            this.lblCaption = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.rbFtoM = new System.Windows.Forms.RadioButton();
            this.rbMitoK = new System.Windows.Forms.RadioButton();
            this.rbKToMi = new System.Windows.Forms.RadioButton();
            this.rbMtoF = new System.Windows.Forms.RadioButton();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(241, 18);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(164, 25);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Unit Converter";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.LightGray;
            this.grpInput.Controls.Add(this.rbMtoF);
            this.grpInput.Controls.Add(this.rbKToMi);
            this.grpInput.Controls.Add(this.btnConvert);
            this.grpInput.Controls.Add(this.rbMitoK);
            this.grpInput.Controls.Add(this.lblInput);
            this.grpInput.Controls.Add(this.rbFtoM);
            this.grpInput.Controls.Add(this.txtInput);
            this.grpInput.Location = new System.Drawing.Point(51, 64);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(397, 168);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.LightGray;
            this.grpOutput.Controls.Add(this.btnReset);
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Controls.Add(this.lblOutput);
            this.grpOutput.Location = new System.Drawing.Point(51, 252);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(397, 168);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(500, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 58);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.OrangeRed;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(307, 126);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(84, 36);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(307, 126);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 36);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(77, 32);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 6;
            this.lblInput.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(134, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(152, 20);
            this.txtInput.TabIndex = 7;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(77, 37);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(138, 34);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(173, 20);
            this.txtOutput.TabIndex = 9;
            // 
            // rbFtoM
            // 
            this.rbFtoM.AutoSize = true;
            this.rbFtoM.Location = new System.Drawing.Point(134, 90);
            this.rbFtoM.Name = "rbFtoM";
            this.rbFtoM.Size = new System.Drawing.Size(93, 17);
            this.rbFtoM.TabIndex = 10;
            this.rbFtoM.TabStop = true;
            this.rbFtoM.Text = "Feet to Metres";
            this.rbFtoM.UseVisualStyleBackColor = true;
            this.rbFtoM.CheckedChanged += new System.EventHandler(this.rbFtoM_CheckedChanged);
            // 
            // rbMitoK
            // 
            this.rbMitoK.AutoSize = true;
            this.rbMitoK.Location = new System.Drawing.Point(134, 113);
            this.rbMitoK.Name = "rbMitoK";
            this.rbMitoK.Size = new System.Drawing.Size(112, 17);
            this.rbMitoK.TabIndex = 11;
            this.rbMitoK.TabStop = true;
            this.rbMitoK.Text = "Miles to Kilometres";
            this.rbMitoK.UseVisualStyleBackColor = true;
            this.rbMitoK.CheckedChanged += new System.EventHandler(this.rbMitoK_CheckedChanged);
            // 
            // rbKToMi
            // 
            this.rbKToMi.AutoSize = true;
            this.rbKToMi.Location = new System.Drawing.Point(134, 136);
            this.rbKToMi.Name = "rbKToMi";
            this.rbKToMi.Size = new System.Drawing.Size(112, 17);
            this.rbKToMi.TabIndex = 12;
            this.rbKToMi.TabStop = true;
            this.rbKToMi.Text = "Kilometres to Miles";
            this.rbKToMi.UseVisualStyleBackColor = true;
            this.rbKToMi.CheckedChanged += new System.EventHandler(this.rbKToMi_CheckedChanged);
            // 
            // rbMtoF
            // 
            this.rbMtoF.AutoSize = true;
            this.rbMtoF.Location = new System.Drawing.Point(134, 67);
            this.rbMtoF.Name = "rbMtoF";
            this.rbMtoF.Size = new System.Drawing.Size(93, 17);
            this.rbMtoF.TabIndex = 13;
            this.rbMtoF.TabStop = true;
            this.rbMtoF.Text = "Metres to Feet";
            this.rbMtoF.UseVisualStyleBackColor = true;
            this.rbMtoF.CheckedChanged += new System.EventHandler(this.rbMtoF_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(627, 448);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.RadioButton rbMtoF;
        private System.Windows.Forms.RadioButton rbKToMi;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rbMitoK;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.RadioButton rbFtoM;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnExit;
    }
}

