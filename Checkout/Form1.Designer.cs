namespace Checkout
{
    partial class checkoutForm
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
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label taxLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label tenderedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkoutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.costButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.bowInput = new System.Windows.Forms.TextBox();
            this.swordInput = new System.Windows.Forms.TextBox();
            this.shieldInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.subtotalOutput = new System.Windows.Forms.RichTextBox();
            this.changeOutput = new System.Windows.Forms.RichTextBox();
            this.taxOutput = new System.Windows.Forms.RichTextBox();
            this.totalOutput = new System.Windows.Forms.RichTextBox();
            this.tenderedInput = new System.Windows.Forms.RichTextBox();
            this.receiptLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            taxLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            tenderedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            subtotalLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subtotalLabel.ForeColor = System.Drawing.Color.White;
            subtotalLabel.Location = new System.Drawing.Point(230, 154);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(107, 34);
            subtotalLabel.TabIndex = 18;
            subtotalLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.BackColor = System.Drawing.Color.Transparent;
            taxLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            taxLabel.ForeColor = System.Drawing.Color.White;
            taxLabel.Location = new System.Drawing.Point(232, 188);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new System.Drawing.Size(58, 34);
            taxLabel.TabIndex = 19;
            taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.BackColor = System.Drawing.Color.Transparent;
            totalLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.ForeColor = System.Drawing.Color.White;
            totalLabel.Location = new System.Drawing.Point(231, 219);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(70, 34);
            totalLabel.TabIndex = 20;
            totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            tenderedLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenderedLabel.ForeColor = System.Drawing.Color.White;
            tenderedLabel.Location = new System.Drawing.Point(228, 246);
            tenderedLabel.Name = "tenderedLabel";
            tenderedLabel.Size = new System.Drawing.Size(121, 34);
            tenderedLabel.TabIndex = 21;
            tenderedLabel.Text = "Tendered";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weapon Checkout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Black;
            this.changeButton.BackgroundImage = global::Checkout.Properties.Resources.wood;
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Image = global::Checkout.Properties.Resources.wood;
            this.changeButton.Location = new System.Drawing.Point(233, 280);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(189, 36);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Black;
            this.newButton.BackgroundImage = global::Checkout.Properties.Resources.wood;
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Image = global::Checkout.Properties.Resources.wood;
            this.newButton.Location = new System.Drawing.Point(549, 353);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(182, 33);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // costButton
            // 
            this.costButton.BackColor = System.Drawing.Color.Black;
            this.costButton.BackgroundImage = global::Checkout.Properties.Resources.wood;
            this.costButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.costButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costButton.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costButton.ForeColor = System.Drawing.Color.White;
            this.costButton.Image = global::Checkout.Properties.Resources.wood;
            this.costButton.Location = new System.Drawing.Point(233, 115);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(189, 39);
            this.costButton.TabIndex = 3;
            this.costButton.Text = "Calculate";
            this.costButton.UseVisualStyleBackColor = false;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Black;
            this.printButton.BackgroundImage = global::Checkout.Properties.Resources.wood;
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Image = global::Checkout.Properties.Resources.wood;
            this.printButton.Location = new System.Drawing.Point(233, 351);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(189, 35);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // bowInput
            // 
            this.bowInput.Location = new System.Drawing.Point(168, 353);
            this.bowInput.Name = "bowInput";
            this.bowInput.Size = new System.Drawing.Size(31, 20);
            this.bowInput.TabIndex = 5;
            this.bowInput.Text = "0";
            this.bowInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // swordInput
            // 
            this.swordInput.Location = new System.Drawing.Point(168, 139);
            this.swordInput.Name = "swordInput";
            this.swordInput.Size = new System.Drawing.Size(31, 20);
            this.swordInput.TabIndex = 6;
            this.swordInput.Text = "0";
            this.swordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shieldInput
            // 
            this.shieldInput.Location = new System.Drawing.Point(168, 248);
            this.shieldInput.Name = "shieldInput";
            this.shieldInput.Size = new System.Drawing.Size(31, 20);
            this.shieldInput.TabIndex = 7;
            this.shieldInput.Text = "0";
            this.shieldInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.Location = new System.Drawing.Point(341, 159);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.ReadOnly = true;
            this.subtotalOutput.Size = new System.Drawing.Size(81, 24);
            this.subtotalOutput.TabIndex = 13;
            this.subtotalOutput.Text = "";
            // 
            // changeOutput
            // 
            this.changeOutput.Location = new System.Drawing.Point(233, 321);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.ReadOnly = true;
            this.changeOutput.Size = new System.Drawing.Size(189, 24);
            this.changeOutput.TabIndex = 14;
            this.changeOutput.Text = "";
            // 
            // taxOutput
            // 
            this.taxOutput.Location = new System.Drawing.Point(341, 189);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.ReadOnly = true;
            this.taxOutput.Size = new System.Drawing.Size(81, 24);
            this.taxOutput.TabIndex = 15;
            this.taxOutput.Text = "";
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(341, 219);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.ReadOnly = true;
            this.totalOutput.Size = new System.Drawing.Size(81, 24);
            this.totalOutput.TabIndex = 16;
            this.totalOutput.Text = "";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(341, 249);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(81, 24);
            this.tenderedInput.TabIndex = 17;
            this.tenderedInput.Text = "";
            // 
            // receiptLabel
            // 
            this.receiptLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(481, 116);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(300, 270);
            this.receiptLabel.TabIndex = 22;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 390);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(tenderedLabel);
            this.Controls.Add(totalLabel);
            this.Controls.Add(taxLabel);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shieldInput);
            this.Controls.Add(this.swordInput);
            this.Controls.Add(this.bowInput);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "checkoutForm";
            this.Text = "Blacksmith Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox bowInput;
        private System.Windows.Forms.TextBox swordInput;
        private System.Windows.Forms.TextBox shieldInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox subtotalOutput;
        private System.Windows.Forms.RichTextBox changeOutput;
        private System.Windows.Forms.RichTextBox taxOutput;
        private System.Windows.Forms.RichTextBox totalOutput;
        private System.Windows.Forms.RichTextBox tenderedInput;
        private System.Windows.Forms.Label receiptLabel;
    }
}

