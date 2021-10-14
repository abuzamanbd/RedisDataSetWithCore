
namespace RegisDataManagerForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientId = new System.Windows.Forms.TextBox();
            this.DepositAmt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientIdForDataView = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.getData = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DId
            // 
            this.DId.Location = new System.Drawing.Point(234, 36);
            this.DId.Name = "DId";
            this.DId.Size = new System.Drawing.Size(260, 27);
            this.DId.TabIndex = 0;
            this.DId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ClientId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Deposit Amount";
            // 
            // ClientId
            // 
            this.ClientId.Location = new System.Drawing.Point(234, 100);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(260, 27);
            this.ClientId.TabIndex = 4;
            this.ClientId.TextChanged += new System.EventHandler(this.ClientId_TextChanged);
            // 
            // DepositAmt
            // 
            this.DepositAmt.Location = new System.Drawing.Point(234, 168);
            this.DepositAmt.Name = "DepositAmt";
            this.DepositAmt.Size = new System.Drawing.Size(260, 27);
            this.DepositAmt.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(234, 232);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(94, 29);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(455, 159);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClientIdForDataView
            // 
            this.ClientIdForDataView.AutoSize = true;
            this.ClientIdForDataView.Location = new System.Drawing.Point(71, 314);
            this.ClientIdForDataView.Name = "ClientIdForDataView";
            this.ClientIdForDataView.Size = new System.Drawing.Size(102, 20);
            this.ClientIdForDataView.TabIndex = 8;
            this.ClientIdForDataView.Text = "Enter Client Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(367, 313);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(94, 29);
            this.getData.TabIndex = 10;
            this.getData.Text = "Get data";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(485, 314);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 589);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClientIdForDataView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.DepositAmt);
            this.Controls.Add(this.ClientId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxDepositAmt;
        private System.Windows.Forms.TextBox ClientId;
        private System.Windows.Forms.TextBox DepositAmt;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ClientIdForDataView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

