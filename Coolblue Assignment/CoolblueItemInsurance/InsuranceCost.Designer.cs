
namespace CoolblueItemInsurance
{
    partial class InsuranceCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsuranceCost));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchProductInfoButton = new System.Windows.Forms.Button();
            this.SearchProductTypeButton = new System.Windows.Forms.Button();
            this.SearchProductButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.productType = new CoolblueItemInsurance.ProductType();
            this.productInformation = new CoolblueItemInsurance.ProductInformation();
            this.productID = new CoolblueItemInsurance.ProductID();
            this.productType1 = new CoolblueItemInsurance.ProductType();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchProductInfoButton);
            this.panel1.Controls.Add(this.SearchProductTypeButton);
            this.panel1.Controls.Add(this.SearchProductButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 894);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoolblueItemInsurance.Properties.Resources.Logo_coolblue_500x500;
            this.pictureBox1.InitialImage = global::CoolblueItemInsurance.Properties.Resources.Logo_coolblue_500x500;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by:";
            // 
            // SearchProductInfoButton
            // 
            this.SearchProductInfoButton.BackColor = System.Drawing.Color.DarkOrange;
            this.SearchProductInfoButton.Location = new System.Drawing.Point(45, 270);
            this.SearchProductInfoButton.Name = "SearchProductInfoButton";
            this.SearchProductInfoButton.Size = new System.Drawing.Size(126, 71);
            this.SearchProductInfoButton.TabIndex = 2;
            this.SearchProductInfoButton.Text = "ID";
            this.SearchProductInfoButton.UseVisualStyleBackColor = false;
            this.SearchProductInfoButton.Click += new System.EventHandler(this.SearchProductInfoButton_Click);
            // 
            // SearchProductTypeButton
            // 
            this.SearchProductTypeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.SearchProductTypeButton.Location = new System.Drawing.Point(45, 358);
            this.SearchProductTypeButton.Name = "SearchProductTypeButton";
            this.SearchProductTypeButton.Size = new System.Drawing.Size(126, 71);
            this.SearchProductTypeButton.TabIndex = 1;
            this.SearchProductTypeButton.Text = "Type";
            this.SearchProductTypeButton.UseVisualStyleBackColor = false;
            this.SearchProductTypeButton.Click += new System.EventHandler(this.SearchProductTypeButton_Click);
            // 
            // SearchProductButton
            // 
            this.SearchProductButton.BackColor = System.Drawing.Color.DarkOrange;
            this.SearchProductButton.Location = new System.Drawing.Point(45, 446);
            this.SearchProductButton.Name = "SearchProductButton";
            this.SearchProductButton.Size = new System.Drawing.Size(126, 71);
            this.SearchProductButton.TabIndex = 0;
            this.SearchProductButton.Text = "All Info";
            this.SearchProductButton.UseVisualStyleBackColor = false;
            this.SearchProductButton.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.productType);
            this.panel2.Controls.Add(this.productInformation);
            this.panel2.Controls.Add(this.productID);
            this.panel2.Controls.Add(this.productType1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 894);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "<--- Select Search Method";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // productType
            // 
            this.productType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.productType.Location = new System.Drawing.Point(0, 0);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(926, 894);
            this.productType.TabIndex = 5;
            this.productType.Load += new System.EventHandler(this.productType_Load);
            // 
            // productInformation
            // 
            this.productInformation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.productInformation.Location = new System.Drawing.Point(0, 0);
            this.productInformation.Name = "productInformation";
            this.productInformation.Size = new System.Drawing.Size(926, 894);
            this.productInformation.TabIndex = 4;
            // 
            // productID
            // 
            this.productID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.productID.Location = new System.Drawing.Point(0, 0);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(926, 894);
            this.productID.TabIndex = 3;
            // 
            // productType1
            // 
            this.productType1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.productType1.Location = new System.Drawing.Point(225, 409);
            this.productType1.Name = "productType1";
            this.productType1.Size = new System.Drawing.Size(8, 8);
            this.productType1.TabIndex = 2;
            // 
            // InsuranceCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1151, 894);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsuranceCost";
            this.Text = "Coolblue Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchProductInfoButton;
        private System.Windows.Forms.Button SearchProductTypeButton;
        private System.Windows.Forms.Button SearchProductButton;
        private ProductType productType1;
        private System.Windows.Forms.Label label1;
        private ProductInformation productInformation;
        private ProductID productID;
        private ProductType productType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

