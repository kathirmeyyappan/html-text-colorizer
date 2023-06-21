namespace TextColorizer
{
    partial class ColorizerGUI
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.colorBox1 = new System.Windows.Forms.CheckBox();
            this.colorBox2 = new System.Windows.Forms.CheckBox();
            this.colorBox3 = new System.Windows.Forms.CheckBox();
            this.colorBox4 = new System.Windows.Forms.CheckBox();
            this.colorBox5 = new System.Windows.Forms.CheckBox();
            this.colorBox6 = new System.Windows.Forms.CheckBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.colorDialog5 = new System.Windows.Forms.ColorDialog();
            this.colorDialog6 = new System.Windows.Forms.ColorDialog();
            this.colorDialog7 = new System.Windows.Forms.ColorDialog();
            this.colorDialog8 = new System.Windows.Forms.ColorDialog();
            this.htmlPreview = new System.Windows.Forms.WebBrowser();
            this.inputBoxTitle = new System.Windows.Forms.Label();
            this.outputBoxTitle = new System.Windows.Forms.Label();
            this.previewBoxTitle = new System.Windows.Forms.Label();
            this.colorDialog9 = new System.Windows.Forms.ColorDialog();
            this.boldBox = new System.Windows.Forms.CheckBox();
            this.italicsBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(50, 44);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Input.Size = new System.Drawing.Size(225, 82);
            this.Input.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(200, 139);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 1;
            this.Button.Text = "GET HTML";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "functionBox";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rainbow Shift",
            "Rainbow Alternating",
            "Custom Alternating",
            "Custom Shift"});
            this.comboBox1.Location = new System.Drawing.Point(50, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(50, 291);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(228, 82);
            this.Output.TabIndex = 3;
            // 
            // colorBox1
            // 
            this.colorBox1.AccessibleName = "";
            this.colorBox1.AutoSize = true;
            this.colorBox1.Location = new System.Drawing.Point(19, 175);
            this.colorBox1.Margin = new System.Windows.Forms.Padding(1);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(90, 17);
            this.colorBox1.TabIndex = 4;
            this.colorBox1.Text = "Unused Color";
            this.colorBox1.UseVisualStyleBackColor = true;
            this.colorBox1.Visible = false;
            this.colorBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // colorBox2
            // 
            this.colorBox2.AccessibleName = "";
            this.colorBox2.AutoSize = true;
            this.colorBox2.Location = new System.Drawing.Point(121, 175);
            this.colorBox2.Margin = new System.Windows.Forms.Padding(1);
            this.colorBox2.Name = "colorBox2";
            this.colorBox2.Size = new System.Drawing.Size(90, 17);
            this.colorBox2.TabIndex = 5;
            this.colorBox2.Text = "Unused Color";
            this.colorBox2.UseVisualStyleBackColor = true;
            this.colorBox2.Visible = false;
            this.colorBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // colorBox3
            // 
            this.colorBox3.AccessibleName = "";
            this.colorBox3.AutoSize = true;
            this.colorBox3.Location = new System.Drawing.Point(221, 175);
            this.colorBox3.Margin = new System.Windows.Forms.Padding(1);
            this.colorBox3.Name = "colorBox3";
            this.colorBox3.Size = new System.Drawing.Size(90, 17);
            this.colorBox3.TabIndex = 6;
            this.colorBox3.Text = "Unused Color";
            this.colorBox3.UseVisualStyleBackColor = true;
            this.colorBox3.Visible = false;
            this.colorBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // colorBox4
            // 
            this.colorBox4.AccessibleName = "";
            this.colorBox4.AutoSize = true;
            this.colorBox4.Location = new System.Drawing.Point(19, 205);
            this.colorBox4.Margin = new System.Windows.Forms.Padding(1);
            this.colorBox4.Name = "colorBox4";
            this.colorBox4.Size = new System.Drawing.Size(90, 17);
            this.colorBox4.TabIndex = 7;
            this.colorBox4.Text = "Unused Color";
            this.colorBox4.UseVisualStyleBackColor = true;
            this.colorBox4.Visible = false;
            this.colorBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // colorBox5
            // 
            this.colorBox5.AccessibleName = "";
            this.colorBox5.AutoSize = true;
            this.colorBox5.Location = new System.Drawing.Point(121, 205);
            this.colorBox5.Margin = new System.Windows.Forms.Padding(1);
            this.colorBox5.Name = "colorBox5";
            this.colorBox5.Size = new System.Drawing.Size(90, 17);
            this.colorBox5.TabIndex = 8;
            this.colorBox5.Text = "Unused Color";
            this.colorBox5.UseVisualStyleBackColor = true;
            this.colorBox5.Visible = false;
            this.colorBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // colorBox6
            // 
            this.colorBox6.AccessibleName = "";
            this.colorBox6.AutoSize = true;
            this.colorBox6.Location = new System.Drawing.Point(221, 205);
            this.colorBox6.Margin = new System.Windows.Forms.Padding(1);
            this.colorBox6.Name = "colorBox6";
            this.colorBox6.Size = new System.Drawing.Size(90, 17);
            this.colorBox6.TabIndex = 9;
            this.colorBox6.Text = "Unused Color";
            this.colorBox6.UseVisualStyleBackColor = true;
            this.colorBox6.Visible = false;
            this.colorBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // htmlPreview
            // 
            this.htmlPreview.Location = new System.Drawing.Point(50, 420);
            this.htmlPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.htmlPreview.Name = "htmlPreview";
            this.htmlPreview.Size = new System.Drawing.Size(225, 79);
            this.htmlPreview.TabIndex = 12;
            // 
            // inputBoxTitle
            // 
            this.inputBoxTitle.AutoSize = true;
            this.inputBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.inputBoxTitle.Location = new System.Drawing.Point(130, 19);
            this.inputBoxTitle.Name = "inputBoxTitle";
            this.inputBoxTitle.Size = new System.Drawing.Size(64, 22);
            this.inputBoxTitle.TabIndex = 13;
            this.inputBoxTitle.Text = "INPUT";
            // 
            // outputBoxTitle
            // 
            this.outputBoxTitle.AutoSize = true;
            this.outputBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.outputBoxTitle.Location = new System.Drawing.Point(102, 266);
            this.outputBoxTitle.Name = "outputBoxTitle";
            this.outputBoxTitle.Size = new System.Drawing.Size(140, 22);
            this.outputBoxTitle.TabIndex = 14;
            this.outputBoxTitle.Text = "HTML OUTPUT";
            // 
            // previewBoxTitle
            // 
            this.previewBoxTitle.AutoSize = true;
            this.previewBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.previewBoxTitle.Location = new System.Drawing.Point(117, 395);
            this.previewBoxTitle.Name = "previewBoxTitle";
            this.previewBoxTitle.Size = new System.Drawing.Size(92, 22);
            this.previewBoxTitle.TabIndex = 15;
            this.previewBoxTitle.Text = "PREVIEW";
            // 
            // boldBox
            // 
            this.boldBox.AutoSize = true;
            this.boldBox.Location = new System.Drawing.Point(84, 236);
            this.boldBox.Name = "boldBox";
            this.boldBox.Size = new System.Drawing.Size(47, 17);
            this.boldBox.TabIndex = 16;
            this.boldBox.Text = "Bold";
            this.boldBox.UseVisualStyleBackColor = true;
            // 
            // italicsBox
            // 
            this.italicsBox.AutoSize = true;
            this.italicsBox.Location = new System.Drawing.Point(190, 236);
            this.italicsBox.Name = "italicsBox";
            this.italicsBox.Size = new System.Drawing.Size(61, 17);
            this.italicsBox.TabIndex = 17;
            this.italicsBox.Text = "Italicize";
            this.italicsBox.UseVisualStyleBackColor = true;
            // 
            // Colorizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 522);
            this.Controls.Add(this.italicsBox);
            this.Controls.Add(this.boldBox);
            this.Controls.Add(this.previewBoxTitle);
            this.Controls.Add(this.outputBoxTitle);
            this.Controls.Add(this.inputBoxTitle);
            this.Controls.Add(this.htmlPreview);
            this.Controls.Add(this.colorBox6);
            this.Controls.Add(this.colorBox5);
            this.Controls.Add(this.colorBox4);
            this.Controls.Add(this.colorBox3);
            this.Controls.Add(this.colorBox2);
            this.Controls.Add(this.colorBox1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Input);
            this.Name = "Colorizer";
            this.Text = "HTML Text Colorizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.CheckBox colorBox1;
        private System.Windows.Forms.CheckBox colorBox2;
        private System.Windows.Forms.CheckBox colorBox3;
        private System.Windows.Forms.CheckBox colorBox4;
        private System.Windows.Forms.CheckBox colorBox5;
        private System.Windows.Forms.CheckBox colorBox6;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
        private System.Windows.Forms.ColorDialog colorDialog5;
        private System.Windows.Forms.ColorDialog colorDialog6;
        private System.Windows.Forms.ColorDialog colorDialog7;
        private System.Windows.Forms.ColorDialog colorDialog8;
        private System.Windows.Forms.WebBrowser htmlPreview;
        private System.Windows.Forms.Label inputBoxTitle;
        private System.Windows.Forms.Label outputBoxTitle;
        private System.Windows.Forms.Label previewBoxTitle;
        private System.Windows.Forms.ColorDialog colorDialog9;
        private System.Windows.Forms.CheckBox boldBox;
        private System.Windows.Forms.CheckBox italicsBox;
    }
}

