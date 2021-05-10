namespace XMLTransformUI
{
    partial class FormTransform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxI = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxO = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.buttonBrowseI = new System.Windows.Forms.Button();
            this.buttonDirI = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBrowseT = new System.Windows.Forms.Button();
            this.buttonBrowseO = new System.Windows.Forms.Button();
            this.buttonBrowseL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.buttonDirT = new System.Windows.Forms.Button();
            this.buttonDirO = new System.Windows.Forms.Button();
            this.buttonDirL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input XML File:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input XLST File:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output Result File:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output Log File:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxI
            // 
            this.textBoxI.Location = new System.Drawing.Point(116, 27);
            this.textBoxI.Name = "textBoxI";
            this.textBoxI.Size = new System.Drawing.Size(527, 20);
            this.textBoxI.TabIndex = 0;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(116, 56);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(527, 20);
            this.textBoxT.TabIndex = 1;
            // 
            // textBoxO
            // 
            this.textBoxO.Location = new System.Drawing.Point(116, 85);
            this.textBoxO.Name = "textBoxO";
            this.textBoxO.Size = new System.Drawing.Size(527, 20);
            this.textBoxO.TabIndex = 2;
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(116, 117);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(527, 20);
            this.textBoxL.TabIndex = 3;
            // 
            // buttonBrowseI
            // 
            this.buttonBrowseI.Location = new System.Drawing.Point(652, 25);
            this.buttonBrowseI.Name = "buttonBrowseI";
            this.buttonBrowseI.Size = new System.Drawing.Size(26, 22);
            this.buttonBrowseI.TabIndex = 10;
            this.buttonBrowseI.Text = "...";
            this.buttonBrowseI.UseVisualStyleBackColor = true;
            this.buttonBrowseI.Click += new System.EventHandler(this.buttonBrowseI_Click);
            // 
            // buttonDirI
            // 
            this.buttonDirI.Location = new System.Drawing.Point(684, 25);
            this.buttonDirI.Name = "buttonDirI";
            this.buttonDirI.Size = new System.Drawing.Size(26, 22);
            this.buttonDirI.TabIndex = 20;
            this.buttonDirI.Text = "F";
            this.buttonDirI.UseVisualStyleBackColor = true;
            this.buttonDirI.Click += new System.EventHandler(this.buttonDirI_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(582, 150);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(61, 26);
            this.buttonExecute.TabIndex = 50;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(649, 150);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 26);
            this.buttonClose.TabIndex = 51;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonBrowseT
            // 
            this.buttonBrowseT.Location = new System.Drawing.Point(652, 54);
            this.buttonBrowseT.Name = "buttonBrowseT";
            this.buttonBrowseT.Size = new System.Drawing.Size(26, 22);
            this.buttonBrowseT.TabIndex = 11;
            this.buttonBrowseT.Text = "...";
            this.buttonBrowseT.UseVisualStyleBackColor = true;
            this.buttonBrowseT.Click += new System.EventHandler(this.buttonBrowseT_Click);
            // 
            // buttonBrowseO
            // 
            this.buttonBrowseO.Location = new System.Drawing.Point(652, 83);
            this.buttonBrowseO.Name = "buttonBrowseO";
            this.buttonBrowseO.Size = new System.Drawing.Size(26, 22);
            this.buttonBrowseO.TabIndex = 12;
            this.buttonBrowseO.Text = "...";
            this.buttonBrowseO.UseVisualStyleBackColor = true;
            this.buttonBrowseO.Click += new System.EventHandler(this.buttonBrowseO_Click);
            // 
            // buttonBrowseL
            // 
            this.buttonBrowseL.Location = new System.Drawing.Point(652, 115);
            this.buttonBrowseL.Name = "buttonBrowseL";
            this.buttonBrowseL.Size = new System.Drawing.Size(26, 22);
            this.buttonBrowseL.TabIndex = 13;
            this.buttonBrowseL.Text = "...";
            this.buttonBrowseL.UseVisualStyleBackColor = true;
            this.buttonBrowseL.Click += new System.EventHandler(this.buttonBrowseL_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Result Msg:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMsg
            // 
            this.labelMsg.Location = new System.Drawing.Point(116, 150);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(460, 20);
            this.labelMsg.TabIndex = 19;
            this.labelMsg.Text = "Ok";
            this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDirT
            // 
            this.buttonDirT.Location = new System.Drawing.Point(684, 54);
            this.buttonDirT.Name = "buttonDirT";
            this.buttonDirT.Size = new System.Drawing.Size(26, 22);
            this.buttonDirT.TabIndex = 21;
            this.buttonDirT.Text = "F";
            this.buttonDirT.UseVisualStyleBackColor = true;
            this.buttonDirT.Click += new System.EventHandler(this.buttonDirT_Click);
            // 
            // buttonDirO
            // 
            this.buttonDirO.Location = new System.Drawing.Point(684, 83);
            this.buttonDirO.Name = "buttonDirO";
            this.buttonDirO.Size = new System.Drawing.Size(26, 22);
            this.buttonDirO.TabIndex = 22;
            this.buttonDirO.Text = "F";
            this.buttonDirO.UseVisualStyleBackColor = true;
            this.buttonDirO.Click += new System.EventHandler(this.buttonDirO_Click);
            // 
            // buttonDirL
            // 
            this.buttonDirL.Location = new System.Drawing.Point(684, 115);
            this.buttonDirL.Name = "buttonDirL";
            this.buttonDirL.Size = new System.Drawing.Size(26, 22);
            this.buttonDirL.TabIndex = 23;
            this.buttonDirL.Text = "F";
            this.buttonDirL.UseVisualStyleBackColor = true;
            this.buttonDirL.Click += new System.EventHandler(this.buttonDirL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 189);
            this.Controls.Add(this.buttonDirL);
            this.Controls.Add(this.buttonDirO);
            this.Controls.Add(this.buttonDirT);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBrowseL);
            this.Controls.Add(this.buttonBrowseO);
            this.Controls.Add(this.buttonBrowseT);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonDirI);
            this.Controls.Add(this.buttonBrowseI);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.textBoxO);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML transform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxI;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxO;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Button buttonBrowseI;
        private System.Windows.Forms.Button buttonDirI;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonBrowseT;
        private System.Windows.Forms.Button buttonBrowseO;
        private System.Windows.Forms.Button buttonBrowseL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Button buttonDirT;
        private System.Windows.Forms.Button buttonDirO;
        private System.Windows.Forms.Button buttonDirL;
    }
}

