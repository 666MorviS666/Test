namespace UP_02._01
{
    partial class Resoults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resoults));
            this.registrationEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathonDataSet = new UP_02._01.MarathonDataSet();
            this.registrationEventTableAdapter = new UP_02._01.MarathonDataSetTableAdapters.RegistrationEventTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resoultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathonDataSet1 = new UP_02._01.MarathonDataSet1();
            this.resoultsTableAdapter = new UP_02._01.MarathonDataSet1TableAdapters.ResoultsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.marathonDataSet2 = new UP_02._01.MarathonDataSet2();
            this.resoultsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resoultsTableAdapter1 = new UP_02._01.MarathonDataSet2TableAdapters.ResoultsTableAdapter();
            this.tableAdapterManager = new UP_02._01.MarathonDataSet2TableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registrationEventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resoultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resoultsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationEventBindingSource
            // 
            this.registrationEventBindingSource.DataMember = "RegistrationEvent";
            this.registrationEventBindingSource.DataSource = this.marathonDataSet;
            // 
            // marathonDataSet
            // 
            this.marathonDataSet.DataSetName = "MarathonDataSet";
            this.marathonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationEventTableAdapter
            // 
            this.registrationEventTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.raceTimeDataGridViewTextBoxColumn,
            this.FirstName,
            this.LastName,
            this.CountryCode});
            this.dataGridView1.DataSource = this.resoultsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Place";
            this.Place.HeaderText = "Place";
            this.Place.MinimumWidth = 6;
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // raceTimeDataGridViewTextBoxColumn
            // 
            this.raceTimeDataGridViewTextBoxColumn.DataPropertyName = "RaceTime";
            this.raceTimeDataGridViewTextBoxColumn.HeaderText = "RaceTime";
            this.raceTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.raceTimeDataGridViewTextBoxColumn.Name = "raceTimeDataGridViewTextBoxColumn";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // CountryCode
            // 
            this.CountryCode.DataPropertyName = "CountryCode";
            this.CountryCode.HeaderText = "CountryCode";
            this.CountryCode.MinimumWidth = 6;
            this.CountryCode.Name = "CountryCode";
            // 
            // resoultsBindingSource
            // 
            this.resoultsBindingSource.DataMember = "Resoults";
            this.resoultsBindingSource.DataSource = this.marathonDataSet1;
            // 
            // marathonDataSet1
            // 
            this.marathonDataSet1.DataSetName = "MarathonDataSet1";
            this.marathonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resoultsTableAdapter
            // 
            this.resoultsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.xuiButton3);
            this.panel1.Location = new System.Drawing.Point(-86, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 123);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(290, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 81);
            this.label2.TabIndex = 0;
            this.label2.Text = "MARATHON SKILLS 2016";
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton3.ButtonImage")));
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton3.ButtonText = "Назад";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(98, 35);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(137, 50);
            this.xuiButton3.TabIndex = 6;
            this.xuiButton3.TextColor = System.Drawing.Color.Black;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.Click += new System.EventHandler(this.xuiButton3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(-86, 782);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 74);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(217, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результаты предыдущих гонок";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Place ",
            "RaceTime",
            "FirstName",
            "LastName",
            "CountryCode"});
            this.comboBox1.Location = new System.Drawing.Point(504, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(519, 37);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // marathonDataSet2
            // 
            this.marathonDataSet2.DataSetName = "MarathonDataSet2";
            this.marathonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resoultsBindingSource1
            // 
            this.resoultsBindingSource1.DataMember = "Resoults";
            this.resoultsBindingSource1.DataSource = this.marathonDataSet2;
            // 
            // resoultsTableAdapter1
            // 
            this.resoultsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CharityTableAdapter = null;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.EventTypeTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.MarathonTableAdapter = null;
            this.tableAdapterManager.RaceKitOptionTableAdapter = null;
            this.tableAdapterManager.RegistrationEventTableAdapter = null;
            this.tableAdapterManager.RegistrationStatusTableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = null;
            this.tableAdapterManager.ResoultsTableAdapter = this.resoultsTableAdapter1;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.RunnersTableAdapter = null;
            this.tableAdapterManager.RunnerTableAdapter = null;
            this.tableAdapterManager.SponsorshipTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UP_02._01.MarathonDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VolunteerTableAdapter = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(330, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сортировать:";
            // 
            // Resoults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 852);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Resoults";
            this.Text = "Resoults";
            this.Load += new System.EventHandler(this.Resoults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationEventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resoultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resoultsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MarathonDataSet marathonDataSet;
        private System.Windows.Forms.BindingSource registrationEventBindingSource;
        private MarathonDataSetTableAdapters.RegistrationEventTableAdapter registrationEventTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MarathonDataSet1 marathonDataSet1;
        private System.Windows.Forms.BindingSource resoultsBindingSource;
        private MarathonDataSet1TableAdapters.ResoultsTableAdapter resoultsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton xuiButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MarathonDataSet2 marathonDataSet2;
        private System.Windows.Forms.BindingSource resoultsBindingSource1;
        private MarathonDataSet2TableAdapters.ResoultsTableAdapter resoultsTableAdapter1;
        private MarathonDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
    }
}