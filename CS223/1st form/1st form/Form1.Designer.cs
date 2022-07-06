namespace _1st_form
{
    partial class Form1
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblclick = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtinventory = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblcount = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.btncancle = new System.Windows.Forms.Button();
            this.lblobject = new System.Windows.Forms.Label();
            this.txtobject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(71, 89);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(209, 22);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblclick
            // 
            this.lblclick.Location = new System.Drawing.Point(143, 334);
            this.lblclick.Name = "lblclick";
            this.lblclick.Size = new System.Drawing.Size(75, 23);
            this.lblclick.TabIndex = 1;
            this.lblclick.Text = "add";
            this.lblclick.UseVisualStyleBackColor = true;
            this.lblclick.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(68, 56);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 17);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "name";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(385, 40);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(36, 17);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "inventory no";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(384, 89);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 22);
            this.txtdate.TabIndex = 7;
            // 
            // txtinventory
            // 
            this.txtinventory.Location = new System.Drawing.Point(707, 91);
            this.txtinventory.Name = "txtinventory";
            this.txtinventory.Size = new System.Drawing.Size(100, 22);
            this.txtinventory.TabIndex = 8;
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(100, 264);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(100, 22);
            this.txtcount.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(445, 263);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 22);
            this.txtprice.TabIndex = 10;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(93, 224);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(43, 17);
            this.lblcount.TabIndex = 11;
            this.lblcount.Text = "count";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(445, 224);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(39, 17);
            this.lblprice.TabIndex = 12;
            this.lblprice.Text = "price";
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(445, 334);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(75, 23);
            this.btncancle.TabIndex = 13;
            this.btncancle.Text = "cancle";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // lblobject
            // 
            this.lblobject.AutoSize = true;
            this.lblobject.Location = new System.Drawing.Point(71, 148);
            this.lblobject.Name = "lblobject";
            this.lblobject.Size = new System.Drawing.Size(46, 17);
            this.lblobject.TabIndex = 14;
            this.lblobject.Text = "object";
            // 
            // txtobject
            // 
            this.txtobject.Location = new System.Drawing.Point(74, 179);
            this.txtobject.Name = "txtobject";
            this.txtobject.Size = new System.Drawing.Size(733, 22);
            this.txtobject.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 507);
            this.Controls.Add(this.txtobject);
            this.Controls.Add(this.lblobject);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtinventory);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lblclick);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button lblclick;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtinventory;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Label lblobject;
        private System.Windows.Forms.TextBox txtobject;
    }
}

