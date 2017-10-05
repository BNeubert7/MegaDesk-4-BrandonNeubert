namespace MegaDesk_3_BrandonNeubert
{
    partial class SearchQuotes
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
            this.SurfaceSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewSQuotes = new System.Windows.Forms.RichTextBox();
            this.SearchAllQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SurfaceSearch
            // 
            this.SurfaceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceSearch.FormattingEnabled = true;
            this.SurfaceSearch.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.SurfaceSearch.Location = new System.Drawing.Point(162, 20);
            this.SurfaceSearch.Name = "SurfaceSearch";
            this.SurfaceSearch.Size = new System.Drawing.Size(212, 32);
            this.SurfaceSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surface Material";
            // 
            // viewSQuotes
            // 
            this.viewSQuotes.Location = new System.Drawing.Point(12, 58);
            this.viewSQuotes.Name = "viewSQuotes";
            this.viewSQuotes.ReadOnly = true;
            this.viewSQuotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.viewSQuotes.Size = new System.Drawing.Size(465, 491);
            this.viewSQuotes.TabIndex = 2;
            this.viewSQuotes.Text = "";
            // 
            // SearchAllQuotes
            // 
            this.SearchAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAllQuotes.Location = new System.Drawing.Point(380, 20);
            this.SearchAllQuotes.Name = "SearchAllQuotes";
            this.SearchAllQuotes.Size = new System.Drawing.Size(92, 32);
            this.SearchAllQuotes.TabIndex = 3;
            this.SearchAllQuotes.Text = "Search";
            this.SearchAllQuotes.UseVisualStyleBackColor = true;
            this.SearchAllQuotes.Click += new System.EventHandler(this.SearchAllQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.SearchAllQuotes);
            this.Controls.Add(this.viewSQuotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SurfaceSearch);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SurfaceSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox viewSQuotes;
        private System.Windows.Forms.Button SearchAllQuotes;
    }
}