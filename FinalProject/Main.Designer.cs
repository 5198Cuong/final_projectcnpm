namespace FinalProject
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtRPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cNPMFinalDataSet = new FinalProject.CNPMFinalDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new FinalProject.CNPMFinalDataSetTableAdapters.ProductTableAdapter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewReceive = new System.Windows.Forms.DataGridView();
            this.btnUpdateRecevie = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerorder = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnViewDeliveryNote = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnChooseMonth = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.dataGridViewDelivery = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDPrice);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtQuantity);
            this.tabPage1.Controls.Add(this.txtRPrice);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ware House";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDPrice
            // 
            this.txtDPrice.Location = new System.Drawing.Point(492, 467);
            this.txtDPrice.Name = "txtDPrice";
            this.txtDPrice.Size = new System.Drawing.Size(247, 26);
            this.txtDPrice.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Delivery Price";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(833, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 31);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(782, 495);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 31);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(782, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 31);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(492, 509);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(248, 26);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtRPrice
            // 
            this.txtRPrice.Location = new System.Drawing.Point(492, 425);
            this.txtRPrice.Name = "txtRPrice";
            this.txtRPrice.Size = new System.Drawing.Size(248, 26);
            this.txtRPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Receive Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 470);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(107, 428);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(248, 26);
            this.txtID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(894, 348);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(398, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ware House";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnViewDeliveryNote);
            this.tabPage2.Controls.Add(this.btnCreate);
            this.tabPage2.Controls.Add(this.dateTimePickerorder);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridViewOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delivery";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewDelivery);
            this.tabPage3.Controls.Add(this.txtMonth);
            this.tabPage3.Controls.Add(this.btnChooseMonth);
            this.tabPage3.Controls.Add(this.txtRevenue);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtDelivery);
            this.tabPage3.Controls.Add(this.txtReceive);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 611);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Stock/Revenue";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cNPMFinalDataSet
            // 
            this.cNPMFinalDataSet.DataSetName = "CNPMFinalDataSet";
            this.cNPMFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.cNPMFinalDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnUpdateRecevie);
            this.tabPage4.Controls.Add(this.dataGridViewReceive);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(992, 611);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Receive";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Receive Notes List";
            // 
            // dataGridViewReceive
            // 
            this.dataGridViewReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceive.Location = new System.Drawing.Point(9, 51);
            this.dataGridViewReceive.Name = "dataGridViewReceive";
            this.dataGridViewReceive.RowHeadersWidth = 62;
            this.dataGridViewReceive.RowTemplate.Height = 28;
            this.dataGridViewReceive.Size = new System.Drawing.Size(966, 445);
            this.dataGridViewReceive.TabIndex = 1;
            // 
            // btnUpdateRecevie
            // 
            this.btnUpdateRecevie.Location = new System.Drawing.Point(411, 530);
            this.btnUpdateRecevie.Name = "btnUpdateRecevie";
            this.btnUpdateRecevie.Size = new System.Drawing.Size(164, 41);
            this.btnUpdateRecevie.TabIndex = 2;
            this.btnUpdateRecevie.Text = "Update";
            this.btnUpdateRecevie.UseVisualStyleBackColor = true;
            this.btnUpdateRecevie.Click += new System.EventHandler(this.btnUpdateRecevie_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(9, 53);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 62;
            this.dataGridViewOrder.RowTemplate.Height = 28;
            this.dataGridViewOrder.Size = new System.Drawing.Size(966, 262);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(424, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Order Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Date";
            // 
            // dateTimePickerorder
            // 
            this.dateTimePickerorder.Location = new System.Drawing.Point(93, 361);
            this.dateTimePickerorder.Name = "dateTimePickerorder";
            this.dateTimePickerorder.Size = new System.Drawing.Size(302, 26);
            this.dateTimePickerorder.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(135, 414);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(193, 31);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Delivery Note";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnViewDeliveryNote
            // 
            this.btnViewDeliveryNote.Location = new System.Drawing.Point(734, 334);
            this.btnViewDeliveryNote.Name = "btnViewDeliveryNote";
            this.btnViewDeliveryNote.Size = new System.Drawing.Size(218, 53);
            this.btnViewDeliveryNote.TabIndex = 5;
            this.btnViewDeliveryNote.Text = "View Delivery Notes";
            this.btnViewDeliveryNote.UseVisualStyleBackColor = true;
            this.btnViewDeliveryNote.Click += new System.EventHandler(this.btnViewDeliveryNote_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Choose Month";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(445, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Receive: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(449, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Delivery:";
            // 
            // txtReceive
            // 
            this.txtReceive.Enabled = false;
            this.txtReceive.Location = new System.Drawing.Point(535, 133);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(176, 26);
            this.txtReceive.TabIndex = 4;
            // 
            // txtDelivery
            // 
            this.txtDelivery.Enabled = false;
            this.txtDelivery.Location = new System.Drawing.Point(535, 184);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(176, 26);
            this.txtDelivery.TabIndex = 5;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Enabled = false;
            this.txtRevenue.Location = new System.Drawing.Point(535, 239);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(176, 26);
            this.txtRevenue.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(445, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Revenue:";
            // 
            // btnChooseMonth
            // 
            this.btnChooseMonth.Location = new System.Drawing.Point(265, 66);
            this.btnChooseMonth.Name = "btnChooseMonth";
            this.btnChooseMonth.Size = new System.Drawing.Size(89, 31);
            this.btnChooseMonth.TabIndex = 8;
            this.btnChooseMonth.Text = "Choose";
            this.btnChooseMonth.UseVisualStyleBackColor = true;
            this.btnChooseMonth.Click += new System.EventHandler(this.btnChooseMonth_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(42, 106);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(312, 26);
            this.txtMonth.TabIndex = 9;
            // 
            // dataGridViewDelivery
            // 
            this.dataGridViewDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelivery.Location = new System.Drawing.Point(42, 309);
            this.dataGridViewDelivery.Name = "dataGridViewDelivery";
            this.dataGridViewDelivery.RowHeadersWidth = 62;
            this.dataGridViewDelivery.RowTemplate.Height = 28;
            this.dataGridViewDelivery.Size = new System.Drawing.Size(912, 169);
            this.dataGridViewDelivery.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 638);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private CNPMFinalDataSet cNPMFinalDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private CNPMFinalDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtRPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewReceive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateRecevie;
        private System.Windows.Forms.DateTimePicker dateTimePickerorder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button btnViewDeliveryNote;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChooseMonth;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.DataGridView dataGridViewDelivery;
    }
}

