namespace ByteVieer
{
    partial class ByteViewer
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
            this.dataTextbox = new System.Windows.Forms.RichTextBox();
            this.lineTextbox = new System.Windows.Forms.RichTextBox();
            this.asciiTextbox = new System.Windows.Forms.RichTextBox();
            this.lengthTextbox = new System.Windows.Forms.Label();
            this.columnTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTextbox
            // 
            this.dataTextbox.AutoWordSelection = true;
            this.dataTextbox.DetectUrls = false;
            this.dataTextbox.Font = new System.Drawing.Font("Hack", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTextbox.Location = new System.Drawing.Point(66, 35);
            this.dataTextbox.Name = "dataTextbox";
            this.dataTextbox.ReadOnly = true;
            this.dataTextbox.Size = new System.Drawing.Size(595, 151);
            this.dataTextbox.TabIndex = 4;
            this.dataTextbox.Text = "";
            this.dataTextbox.WordWrap = false;
            this.dataTextbox.HScroll += new System.EventHandler(this.dataTextbox_HScroll);
            this.dataTextbox.VScroll += new System.EventHandler(this.dataTextbox_VScroll);
            // 
            // lineTextbox
            // 
            this.lineTextbox.DetectUrls = false;
            this.lineTextbox.Font = new System.Drawing.Font("Hack", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineTextbox.Location = new System.Drawing.Point(3, 35);
            this.lineTextbox.Name = "lineTextbox";
            this.lineTextbox.ReadOnly = true;
            this.lineTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lineTextbox.Size = new System.Drawing.Size(57, 151);
            this.lineTextbox.TabIndex = 5;
            this.lineTextbox.Text = "";
            this.lineTextbox.WordWrap = false;
            // 
            // asciiTextbox
            // 
            this.asciiTextbox.DetectUrls = false;
            this.asciiTextbox.Font = new System.Drawing.Font("Hack", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asciiTextbox.Location = new System.Drawing.Point(667, 35);
            this.asciiTextbox.Name = "asciiTextbox";
            this.asciiTextbox.ReadOnly = true;
            this.asciiTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.asciiTextbox.Size = new System.Drawing.Size(119, 151);
            this.asciiTextbox.TabIndex = 6;
            this.asciiTextbox.Text = "";
            this.asciiTextbox.WordWrap = false;
            // 
            // lengthTextbox
            // 
            this.lengthTextbox.AutoSize = true;
            this.lengthTextbox.Location = new System.Drawing.Point(667, 189);
            this.lengthTextbox.Name = "lengthTextbox";
            this.lengthTextbox.Size = new System.Drawing.Size(51, 13);
            this.lengthTextbox.TabIndex = 7;
            this.lengthTextbox.Text = "LENGTH";
            this.lengthTextbox.Click += new System.EventHandler(this.lengthTextbox_Click);
            // 
            // columnTextBox
            // 
            this.columnTextBox.DetectUrls = false;
            this.columnTextBox.Font = new System.Drawing.Font("Hack", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnTextBox.Location = new System.Drawing.Point(66, 3);
            this.columnTextBox.Name = "columnTextBox";
            this.columnTextBox.ReadOnly = true;
            this.columnTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.columnTextBox.Size = new System.Drawing.Size(595, 26);
            this.columnTextBox.TabIndex = 8;
            this.columnTextBox.Text = "";
            this.columnTextBox.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.621993F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.37801F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.columnTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.asciiTextbox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lineTextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lengthTextbox, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 210);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ByteViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ByteViewer";
            this.Size = new System.Drawing.Size(792, 213);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox dataTextbox;
        private System.Windows.Forms.RichTextBox lineTextbox;
        private System.Windows.Forms.RichTextBox asciiTextbox;
        private System.Windows.Forms.Label lengthTextbox;
        private System.Windows.Forms.RichTextBox columnTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
