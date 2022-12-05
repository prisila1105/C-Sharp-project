namespace Doctors_Patients_portal
{
    partial class admin
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdminRequest = new System.Windows.Forms.Button();
            this.btnDoctorRequest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(201, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(884, 528);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.AllowUserToAddRowsChanged += new System.EventHandler(this.btnEdit_Click);
            this.dataGridView2.AllowUserToDeleteRowsChanged += new System.EventHandler(this.btnDelete_Click);
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.Color.Navy;
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDoctor.Location = new System.Drawing.Point(0, 170);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(200, 75);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPatient.Location = new System.Drawing.Point(0, 251);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(200, 75);
            this.btnPatient.TabIndex = 2;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Blue;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(0, 342);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 75);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdminRequest
            // 
            this.btnAdminRequest.BackColor = System.Drawing.Color.Navy;
            this.btnAdminRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminRequest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdminRequest.Location = new System.Drawing.Point(0, 9);
            this.btnAdminRequest.Name = "btnAdminRequest";
            this.btnAdminRequest.Size = new System.Drawing.Size(200, 75);
            this.btnAdminRequest.TabIndex = 1;
            this.btnAdminRequest.Text = "Admin Request";
            this.btnAdminRequest.UseVisualStyleBackColor = false;
            this.btnAdminRequest.Click += new System.EventHandler(this.btnAdminRequest_Click);
            // 
            // btnDoctorRequest
            // 
            this.btnDoctorRequest.BackColor = System.Drawing.Color.Navy;
            this.btnDoctorRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorRequest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDoctorRequest.Location = new System.Drawing.Point(0, 89);
            this.btnDoctorRequest.Name = "btnDoctorRequest";
            this.btnDoctorRequest.Size = new System.Drawing.Size(200, 75);
            this.btnDoctorRequest.TabIndex = 1;
            this.btnDoctorRequest.Text = "Doctor Request";
            this.btnDoctorRequest.UseVisualStyleBackColor = false;
            this.btnDoctorRequest.Click += new System.EventHandler(this.btnDoctorRequest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 528);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1089, 528);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.btnDoctorRequest);
            this.Controls.Add(this.btnAdminRequest);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdminRequest;
        private System.Windows.Forms.Button btnDoctorRequest;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}