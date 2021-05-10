
namespace assignment4
{
    partial class TripsGUI
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TripList = new System.Windows.Forms.ListBox();
            this.grbChangeQueue = new System.Windows.Forms.GroupBox();
            this.grbDest = new System.Windows.Forms.GroupBox();
            this.txtShowDest = new System.Windows.Forms.TextBox();
            this.btnDest = new System.Windows.Forms.Button();
            this.grbChangeQueue.SuspendLayout();
            this.grbDest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(149, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add trip";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(6, 22);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(76, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type of trip:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDest.Location = new System.Drawing.Point(6, 84);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(75, 13);
            this.lblDest.TabIndex = 3;
            this.lblDest.Text = "Destination:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(99, 19);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(99, 52);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 5;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(99, 81);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(100, 20);
            this.txtDest.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(29, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete trip";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TripList
            // 
            this.TripList.FormattingEnabled = true;
            this.TripList.Location = new System.Drawing.Point(29, 12);
            this.TripList.Name = "TripList";
            this.TripList.Size = new System.Drawing.Size(738, 186);
            this.TripList.TabIndex = 8;
            this.TripList.Tag = "";
            this.TripList.Visible = false;
            // 
            // grbChangeQueue
            // 
            this.grbChangeQueue.Controls.Add(this.txtType);
            this.grbChangeQueue.Controls.Add(this.lblType);
            this.grbChangeQueue.Controls.Add(this.txtDate);
            this.grbChangeQueue.Controls.Add(this.lblDate);
            this.grbChangeQueue.Controls.Add(this.lblDest);
            this.grbChangeQueue.Controls.Add(this.btnAdd);
            this.grbChangeQueue.Controls.Add(this.btnDelete);
            this.grbChangeQueue.Controls.Add(this.txtDest);
            this.grbChangeQueue.Location = new System.Drawing.Point(107, 215);
            this.grbChangeQueue.Name = "grbChangeQueue";
            this.grbChangeQueue.Size = new System.Drawing.Size(274, 165);
            this.grbChangeQueue.TabIndex = 17;
            this.grbChangeQueue.TabStop = false;
            this.grbChangeQueue.Text = "Change queue";
            // 
            // grbDest
            // 
            this.grbDest.Controls.Add(this.txtShowDest);
            this.grbDest.Controls.Add(this.btnDest);
            this.grbDest.Location = new System.Drawing.Point(464, 243);
            this.grbDest.Name = "grbDest";
            this.grbDest.Size = new System.Drawing.Size(243, 115);
            this.grbDest.TabIndex = 19;
            this.grbDest.TabStop = false;
            this.grbDest.Text = "Display trips by destination";
            // 
            // txtShowDest
            // 
            this.txtShowDest.Location = new System.Drawing.Point(28, 36);
            this.txtShowDest.Name = "txtShowDest";
            this.txtShowDest.Size = new System.Drawing.Size(165, 20);
            this.txtShowDest.TabIndex = 18;
            // 
            // btnDest
            // 
            this.btnDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDest.Location = new System.Drawing.Point(28, 72);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(166, 23);
            this.btnDest.TabIndex = 17;
            this.btnDest.Text = "Show all trips by this destination";
            this.btnDest.UseVisualStyleBackColor = false;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // TripsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 589);
            this.Controls.Add(this.grbDest);
            this.Controls.Add(this.grbChangeQueue);
            this.Controls.Add(this.TripList);
            this.Name = "TripsGUI";
            this.Text = "Trips managment system";
            this.grbChangeQueue.ResumeLayout(false);
            this.grbChangeQueue.PerformLayout();
            this.grbDest.ResumeLayout(false);
            this.grbDest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox TripList;
        private System.Windows.Forms.GroupBox grbChangeQueue;
        private System.Windows.Forms.GroupBox grbDest;
        private System.Windows.Forms.TextBox txtShowDest;
        private System.Windows.Forms.Button btnDest;
    }
}

