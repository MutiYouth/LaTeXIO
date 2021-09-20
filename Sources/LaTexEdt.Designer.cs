namespace LaTeXIO
{
    partial class LaTexEdt
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
            this.btn_gen = new System.Windows.Forms.Button();
            this.logsBox = new System.Windows.Forms.RichTextBox();
            this.cb_AutoClose = new System.Windows.Forms.CheckBox();
            this.texCodeBox = new ICSharpCode.TextEditor.TextEditorControl();
            this.btn_prvTex = new System.Windows.Forms.Button();
            this.btn_nxtTeX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gen
            // 
            this.btn_gen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_gen.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btn_gen.FlatAppearance.BorderSize = 0;
            this.btn_gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_gen.Location = new System.Drawing.Point(344, 347);
            this.btn_gen.Margin = new System.Windows.Forms.Padding(0);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(292, 32);
            this.btn_gen.TabIndex = 6;
            this.btn_gen.Text = "Generation";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // logsBox
            // 
            this.logsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logsBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logsBox.DetectUrls = false;
            this.logsBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.logsBox.Location = new System.Drawing.Point(13, 207);
            this.logsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logsBox.Name = "logsBox";
            this.logsBox.ReadOnly = true;
            this.logsBox.Size = new System.Drawing.Size(617, 136);
            this.logsBox.TabIndex = 2;
            this.logsBox.TabStop = false;
            this.logsBox.Text = "";
            this.logsBox.WordWrap = false;
            // 
            // cb_AutoClose
            // 
            this.cb_AutoClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_AutoClose.AutoSize = true;
            this.cb_AutoClose.BackColor = System.Drawing.Color.Transparent;
            this.cb_AutoClose.Checked = true;
            this.cb_AutoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AutoClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AutoClose.Location = new System.Drawing.Point(19, 346);
            this.cb_AutoClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_AutoClose.Name = "cb_AutoClose";
            this.cb_AutoClose.Size = new System.Drawing.Size(249, 24);
            this.cb_AutoClose.TabIndex = 3;
            this.cb_AutoClose.Text = "Close after compiling success.";
            this.cb_AutoClose.UseVisualStyleBackColor = false;
            // 
            // texCodeBox
            // 
            this.texCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texCodeBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.texCodeBox.Highlighting = "TeX";
            this.texCodeBox.Location = new System.Drawing.Point(13, 6);
            this.texCodeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texCodeBox.Name = "texCodeBox";
            this.texCodeBox.ShowTabs = true;
            this.texCodeBox.ShowVRuler = false;
            this.texCodeBox.Size = new System.Drawing.Size(617, 177);
            this.texCodeBox.TabIndent = 1;
            this.texCodeBox.TabIndex = 1;
            // 
            // btn_prvTex
            // 
            this.btn_prvTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prvTex.BackColor = System.Drawing.Color.Transparent;
            this.btn_prvTex.Enabled = false;
            this.btn_prvTex.FlatAppearance.BorderSize = 0;
            this.btn_prvTex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prvTex.Location = new System.Drawing.Point(545, 312);
            this.btn_prvTex.Margin = new System.Windows.Forms.Padding(0);
            this.btn_prvTex.Name = "btn_prvTex";
            this.btn_prvTex.Size = new System.Drawing.Size(31, 29);
            this.btn_prvTex.TabIndex = 4;
            this.btn_prvTex.Text = "<";
            this.btn_prvTex.UseVisualStyleBackColor = false;
            this.btn_prvTex.Click += new System.EventHandler(this.btn_prvTex_Click);
            // 
            // btn_nxtTeX
            // 
            this.btn_nxtTeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nxtTeX.BackColor = System.Drawing.Color.Transparent;
            this.btn_nxtTeX.Enabled = false;
            this.btn_nxtTeX.FlatAppearance.BorderSize = 0;
            this.btn_nxtTeX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nxtTeX.Location = new System.Drawing.Point(584, 312);
            this.btn_nxtTeX.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nxtTeX.Name = "btn_nxtTeX";
            this.btn_nxtTeX.Size = new System.Drawing.Size(32, 29);
            this.btn_nxtTeX.TabIndex = 5;
            this.btn_nxtTeX.Text = ">";
            this.btn_nxtTeX.UseVisualStyleBackColor = false;
            this.btn_nxtTeX.Click += new System.EventHandler(this.btn_nxtTeX_Click);
            // 
            // LaTexEdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 379);
            this.Controls.Add(this.btn_nxtTeX);
            this.Controls.Add(this.btn_prvTex);
            this.Controls.Add(this.cb_AutoClose);
            this.Controls.Add(this.logsBox);
            this.Controls.Add(this.texCodeBox);
            this.Controls.Add(this.btn_gen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 426);
            this.Name = "LaTexEdt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TeX Code Editor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LaTexEdt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gen;
        private ICSharpCode.TextEditor.TextEditorControl texCodeBox;
        private System.Windows.Forms.RichTextBox logsBox;
        private System.Windows.Forms.CheckBox cb_AutoClose;
        private System.Windows.Forms.Button btn_prvTex;
        private System.Windows.Forms.Button btn_nxtTeX;
    }
}