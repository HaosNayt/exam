namespace salonKrasoti
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.salonKrasotiDataSet = new salonKrasoti.salonKrasotiDataSet();
            this.salonKrasotiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиTableAdapter = new salonKrasoti.salonKrasotiDataSetTableAdapters.УслугиTableAdapter();
            this.servicesGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salonKrasotiDataSet
            // 
            this.salonKrasotiDataSet.DataSetName = "salonKrasotiDataSet";
            this.salonKrasotiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonKrasotiDataSetBindingSource
            // 
            this.salonKrasotiDataSetBindingSource.DataSource = this.salonKrasotiDataSet;
            this.salonKrasotiDataSetBindingSource.Position = 0;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.salonKrasotiDataSetBindingSource;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // servicesGridView
            // 
            this.servicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesGridView.Location = new System.Drawing.Point(12, 65);
            this.servicesGridView.Name = "servicesGridView";
            this.servicesGridView.Size = new System.Drawing.Size(597, 301);
            this.servicesGridView.TabIndex = 0;
            this.servicesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicesGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Показать услуги";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Показать клиентов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 378);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.servicesGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonKrasotiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource salonKrasotiDataSetBindingSource;
        private salonKrasotiDataSet salonKrasotiDataSet;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private salonKrasotiDataSetTableAdapters.УслугиTableAdapter услугиTableAdapter;
        private System.Windows.Forms.DataGridView servicesGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}