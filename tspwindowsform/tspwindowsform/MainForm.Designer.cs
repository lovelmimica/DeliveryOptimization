namespace traveling_salesman_problem
{
    partial class MainForm
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
            this.tbOriginAddress = new System.Windows.Forms.TextBox();
            this.tbVehicleCount = new System.Windows.Forms.TextBox();
            this.lblOriginAddress = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblVehicleCount = new System.Windows.Forms.Label();
            this.routeResultLabel = new System.Windows.Forms.Label();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOriginAddress
            // 
            this.tbOriginAddress.Location = new System.Drawing.Point(15, 25);
            this.tbOriginAddress.Name = "tbOriginAddress";
            this.tbOriginAddress.Size = new System.Drawing.Size(242, 20);
            this.tbOriginAddress.TabIndex = 0;
            // 
            // tbVehicleCount
            // 
            this.tbVehicleCount.Location = new System.Drawing.Point(15, 64);
            this.tbVehicleCount.Name = "tbVehicleCount";
            this.tbVehicleCount.Size = new System.Drawing.Size(100, 20);
            this.tbVehicleCount.TabIndex = 1;
            // 
            // lblOriginAddress
            // 
            this.lblOriginAddress.AutoSize = true;
            this.lblOriginAddress.Location = new System.Drawing.Point(12, 9);
            this.lblOriginAddress.Name = "lblOriginAddress";
            this.lblOriginAddress.Size = new System.Drawing.Size(90, 13);
            this.lblOriginAddress.TabIndex = 2;
            this.lblOriginAddress.Text = "Polazišna adresa:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(81, 90);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_onClick);
            // 
            // lblVehicleCount
            // 
            this.lblVehicleCount.AutoSize = true;
            this.lblVehicleCount.Location = new System.Drawing.Point(12, 48);
            this.lblVehicleCount.Name = "lblVehicleCount";
            this.lblVehicleCount.Size = new System.Drawing.Size(58, 13);
            this.lblVehicleCount.TabIndex = 3;
            this.lblVehicleCount.Text = "Broj vozila:";
            // 
            // routeResultLabel
            // 
            this.routeResultLabel.AutoSize = true;
            this.routeResultLabel.Location = new System.Drawing.Point(15, 122);
            this.routeResultLabel.Name = "routeResultLabel";
            this.routeResultLabel.Size = new System.Drawing.Size(13, 13);
            this.routeResultLabel.TabIndex = 5;
            this.routeResultLabel.Text = "  ";
            // 
            // pbMap
            // 
            this.pbMap.Location = new System.Drawing.Point(292, 9);
            this.pbMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(700, 700);
            this.pbMap.TabIndex = 6;
            this.pbMap.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(81, 119);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 19);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_onClick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 455);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.routeResultLabel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblVehicleCount);
            this.Controls.Add(this.lblOriginAddress);
            this.Controls.Add(this.tbVehicleCount);
            this.Controls.Add(this.tbOriginAddress);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traveling salesman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOriginAddress;
        private System.Windows.Forms.TextBox tbVehicleCount;
        private System.Windows.Forms.Label lblOriginAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblVehicleCount;
        private System.Windows.Forms.Label routeResultLabel;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Button btnNext;
    }
}

