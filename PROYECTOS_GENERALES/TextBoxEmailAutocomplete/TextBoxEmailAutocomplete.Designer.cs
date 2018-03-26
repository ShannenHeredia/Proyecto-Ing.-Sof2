namespace CustomControls
{
    partial class TextBoxEmailAutocomplete
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbSuggestions = new CustomControls.TextBoxEmailAutocomplete.CustomListBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.tbInput.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(2, 2);
            this.tbInput.MinimumSize = new System.Drawing.Size(100, 45);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(557, 184);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "LINE1\r\nLINE2\r\nLINE3";
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            this.tbInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyUp);
            // 
            // lbSuggestions
            // 
            this.lbSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSuggestions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuggestions.FormattingEnabled = true;
            this.lbSuggestions.HighlightColor = System.Drawing.SystemColors.ControlLight;
            this.lbSuggestions.HighlightWord = "";
            this.lbSuggestions.ItemHeight = 16;
            this.lbSuggestions.Items.AddRange(new object[] {
            "line1",
            "line2",
            "line3",
            "line4",
            "line5",
            "line6",
            "line7",
            "line8",
            "line9",
            "line10",
            "line11",
            "line12",
            "line13",
            "line14",
            "line15",
            "line16",
            "line17",
            "line18",
            "line19",
            "line20",
            "line21",
            "line22",
            "line23",
            "line24",
            "line25",
            "line26",
            "line27",
            "line28",
            "line29",
            "line30"});
            this.lbSuggestions.Location = new System.Drawing.Point(3, 187);
            this.lbSuggestions.Name = "lbSuggestions";
            this.lbSuggestions.Size = new System.Drawing.Size(556, 116);
            this.lbSuggestions.TabIndex = 1;
            this.lbSuggestions.VisibleChanged += new System.EventHandler(this.lbSuggestions_VisibleChanged);
            this.lbSuggestions.SelectedIndexChanged += new System.EventHandler(this.lbSuggestions_SelectedIndexChanged);
            this.lbSuggestions.SizeChanged += new System.EventHandler(this.lbSuggestions_SizeChanged);
            this.lbSuggestions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbSuggestions_MouseMove);
            this.lbSuggestions.Click += new System.EventHandler(this.lbSuggestions_Click);
            // 
            // TextBoxEmailAutocomplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.lbSuggestions);
            this.Controls.Add(this.tbInput);
            this.MinimumSize = new System.Drawing.Size(103, 246);
            this.Name = "TextBoxEmailAutocomplete";
            this.Size = new System.Drawing.Size(562, 304);
            this.Leave += new System.EventHandler(this.TextBoxEmailAutocomplete_Leave);
            this.Resize += new System.EventHandler(this.TextBoxEmailAutocomplete_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private CustomControls.TextBoxEmailAutocomplete.CustomListBox lbSuggestions;
    }
}