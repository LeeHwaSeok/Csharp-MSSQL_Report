namespace FirstDB
{
    partial class FillOrCancel
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnFindByOrderID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문 ID :";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(171, 41);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(124, 28);
            this.txtOrderID.TabIndex = 1;
            // 
            // btnFindByOrderID
            // 
            this.btnFindByOrderID.Location = new System.Drawing.Point(385, 40);
            this.btnFindByOrderID.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindByOrderID.Name = "btnFindByOrderID";
            this.btnFindByOrderID.Size = new System.Drawing.Size(128, 28);
            this.btnFindByOrderID.TabIndex = 2;
            this.btnFindByOrderID.Text = "주문 찾기";
            this.btnFindByOrderID.UseVisualStyleBackColor = true;
            this.btnFindByOrderID.Click += new System.EventHandler(this.btnFindByOrderID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "주문 입력시 날짜 :";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(56, 480);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(128, 28);
            this.btnCancelOrder.TabIndex = 4;
            this.btnCancelOrder.Text = "주문 취소";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.Location = new System.Drawing.Point(290, 480);
            this.btnFillOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Size = new System.Drawing.Size(128, 28);
            this.btnFillOrder.TabIndex = 5;
            this.btnFillOrder.Text = "주문 입력";
            this.btnFillOrder.UseVisualStyleBackColor = true;
            this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.Location = new System.Drawing.Point(730, 480);
            this.btnFinishUpdates.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Size = new System.Drawing.Size(128, 28);
            this.btnFinishUpdates.TabIndex = 6;
            this.btnFinishUpdates.Text = "Exit";
            this.btnFinishUpdates.UseVisualStyleBackColor = true;
            this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(225, 200);
            this.dtpFillDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(249, 28);
            this.dtpFillDate.TabIndex = 7;
            // 
            // dgvCustomerOrders
            // 
            this.dgvCustomerOrders.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrders.Location = new System.Drawing.Point(56, 260);
            this.dgvCustomerOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomerOrders.Name = "dgvCustomerOrders";
            this.dgvCustomerOrders.ReadOnly = true;
            this.dgvCustomerOrders.RowHeadersVisible = false;
            this.dgvCustomerOrders.RowHeadersWidth = 51;
            this.dgvCustomerOrders.RowTemplate.Height = 27;
            this.dgvCustomerOrders.Size = new System.Drawing.Size(835, 180);
            this.dgvCustomerOrders.TabIndex = 8;
            this.dgvCustomerOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerOrders_CellContentClick);
            // 
            // FillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.dgvCustomerOrders);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.btnFinishUpdates);
            this.Controls.Add(this.btnFillOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindByOrderID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FillOrCancel";
            this.Text = "FillOrCancel";
            this.Load += new System.EventHandler(this.FillOrCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnFindByOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFillOrder;
        private System.Windows.Forms.Button btnFinishUpdates;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.DataGridView dgvCustomerOrders;
    }
}