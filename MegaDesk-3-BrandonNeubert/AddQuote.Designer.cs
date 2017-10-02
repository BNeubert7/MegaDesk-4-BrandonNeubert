namespace MegaDesk_3_BrandonNeubert
{
    partial class AddQuote
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
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DrawerCtLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.SurfaceMatLabel = new System.Windows.Forms.Label();
            this.ShipMethLabel = new System.Windows.Forms.Label();
            this.variableDrawerCount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.variableSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.CustNameLabel = new System.Windows.Forms.Label();
            this.nameFirstForm = new System.Windows.Forms.TextBox();
            this.nameLastForm = new System.Windows.Forms.TextBox();
            this.variableShippingMethod = new System.Windows.Forms.ComboBox();
            this.variableWidth = new System.Windows.Forms.TextBox();
            this.variableDepth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.variableDrawerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(12, 43);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Padding = new System.Windows.Forms.Padding(5);
            this.WidthLabel.Size = new System.Drawing.Size(68, 34);
            this.WidthLabel.TabIndex = 50;
            this.WidthLabel.Text = "Width";
            // 
            // DrawerCtLabel
            // 
            this.DrawerCtLabel.AutoSize = true;
            this.DrawerCtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerCtLabel.Location = new System.Drawing.Point(12, 111);
            this.DrawerCtLabel.Name = "DrawerCtLabel";
            this.DrawerCtLabel.Padding = new System.Windows.Forms.Padding(5);
            this.DrawerCtLabel.Size = new System.Drawing.Size(135, 34);
            this.DrawerCtLabel.TabIndex = 50;
            this.DrawerCtLabel.Text = "Drawer Count";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthLabel.Location = new System.Drawing.Point(12, 77);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Padding = new System.Windows.Forms.Padding(5);
            this.DepthLabel.Size = new System.Drawing.Size(70, 34);
            this.DepthLabel.TabIndex = 50;
            this.DepthLabel.Text = "Depth";
            // 
            // SurfaceMatLabel
            // 
            this.SurfaceMatLabel.AutoSize = true;
            this.SurfaceMatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMatLabel.Location = new System.Drawing.Point(12, 145);
            this.SurfaceMatLabel.Name = "SurfaceMatLabel";
            this.SurfaceMatLabel.Padding = new System.Windows.Forms.Padding(5);
            this.SurfaceMatLabel.Size = new System.Drawing.Size(154, 34);
            this.SurfaceMatLabel.TabIndex = 50;
            this.SurfaceMatLabel.Text = "Surface Material";
            // 
            // ShipMethLabel
            // 
            this.ShipMethLabel.AutoSize = true;
            this.ShipMethLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipMethLabel.Location = new System.Drawing.Point(12, 179);
            this.ShipMethLabel.Name = "ShipMethLabel";
            this.ShipMethLabel.Padding = new System.Windows.Forms.Padding(5);
            this.ShipMethLabel.Size = new System.Drawing.Size(141, 34);
            this.ShipMethLabel.TabIndex = 50;
            this.ShipMethLabel.Text = "Shipping Days";
            // 
            // variableDrawerCount
            // 
            this.variableDrawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableDrawerCount.Location = new System.Drawing.Point(182, 118);
            this.variableDrawerCount.Name = "variableDrawerCount";
            this.variableDrawerCount.Size = new System.Drawing.Size(120, 29);
            this.variableDrawerCount.TabIndex = 5;
            this.variableDrawerCount.ValueChanged += new System.EventHandler(this.variableDrawerCount_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // variableSurfaceMaterial
            // 
            this.variableSurfaceMaterial.DisplayMember = "SurfaceMaterials";
            this.variableSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableSurfaceMaterial.FormattingEnabled = true;
            this.variableSurfaceMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.variableSurfaceMaterial.Location = new System.Drawing.Point(181, 153);
            this.variableSurfaceMaterial.Name = "variableSurfaceMaterial";
            this.variableSurfaceMaterial.Size = new System.Drawing.Size(121, 28);
            this.variableSurfaceMaterial.TabIndex = 7;
            this.variableSurfaceMaterial.ValueMember = "ToString()";
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameLabel.Location = new System.Drawing.Point(12, 9);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.CustNameLabel.Size = new System.Drawing.Size(157, 34);
            this.CustNameLabel.TabIndex = 50;
            this.CustNameLabel.Text = "Customer Name";
            // 
            // nameFirstForm
            // 
            this.nameFirstForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFirstForm.Location = new System.Drawing.Point(181, 14);
            this.nameFirstForm.Name = "nameFirstForm";
            this.nameFirstForm.Size = new System.Drawing.Size(121, 29);
            this.nameFirstForm.TabIndex = 1;
            this.nameFirstForm.Text = "First";
            // 
            // nameLastForm
            // 
            this.nameLastForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLastForm.Location = new System.Drawing.Point(308, 14);
            this.nameLastForm.Name = "nameLastForm";
            this.nameLastForm.Size = new System.Drawing.Size(121, 29);
            this.nameLastForm.TabIndex = 2;
            this.nameLastForm.Text = "Last";
            // 
            // variableShippingMethod
            // 
            this.variableShippingMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableShippingMethod.FormattingEnabled = true;
            this.variableShippingMethod.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.variableShippingMethod.Location = new System.Drawing.Point(181, 187);
            this.variableShippingMethod.Name = "variableShippingMethod";
            this.variableShippingMethod.Size = new System.Drawing.Size(121, 28);
            this.variableShippingMethod.TabIndex = 8;
            // 
            // variableWidth
            // 
            this.variableWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableWidth.Location = new System.Drawing.Point(181, 48);
            this.variableWidth.Name = "variableWidth";
            this.variableWidth.Size = new System.Drawing.Size(121, 29);
            this.variableWidth.TabIndex = 3;
            this.variableWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variableWidth_KeyPress);
            this.variableWidth.Validating += new System.ComponentModel.CancelEventHandler(this.variableWidth_Validating);
            // 
            // variableDepth
            // 
            this.variableDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableDepth.Location = new System.Drawing.Point(181, 83);
            this.variableDepth.Name = "variableDepth";
            this.variableDepth.Size = new System.Drawing.Size(121, 29);
            this.variableDepth.TabIndex = 4;
            this.variableDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variableDepth_KeyPress);
            this.variableDepth.Validating += new System.ComponentModel.CancelEventHandler(this.variableDepth_Validating);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 302);
            this.Controls.Add(this.variableDepth);
            this.Controls.Add(this.variableWidth);
            this.Controls.Add(this.nameLastForm);
            this.Controls.Add(this.nameFirstForm);
            this.Controls.Add(this.CustNameLabel);
            this.Controls.Add(this.variableShippingMethod);
            this.Controls.Add(this.variableSurfaceMaterial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.variableDrawerCount);
            this.Controls.Add(this.ShipMethLabel);
            this.Controls.Add(this.SurfaceMatLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.DrawerCtLabel);
            this.Controls.Add(this.WidthLabel);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.variableDrawerCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label DrawerCtLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label SurfaceMatLabel;
        private System.Windows.Forms.Label ShipMethLabel;
        private System.Windows.Forms.NumericUpDown variableDrawerCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox variableSurfaceMaterial;
        private System.Windows.Forms.Label CustNameLabel;
        private System.Windows.Forms.TextBox nameFirstForm;
        private System.Windows.Forms.TextBox nameLastForm;
        private System.Windows.Forms.ComboBox variableShippingMethod;
        private System.Windows.Forms.TextBox variableWidth;
        private System.Windows.Forms.TextBox variableDepth;
    }
}