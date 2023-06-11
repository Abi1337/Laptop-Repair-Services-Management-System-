namespace FINAL_ASSIGNMENT_IOOP
{
    partial class TECH_MAIN_PAGE
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
            this.lblTechPage = new System.Windows.Forms.Label();
            this.lblNewRequest = new System.Windows.Forms.Label();
            this.lblInProg = new System.Windows.Forms.Label();
            this.lblMenuTech = new System.Windows.Forms.Label();
            this.btnViewNewReq = new System.Windows.Forms.Button();
            this.btnViewInProg = new System.Windows.Forms.Button();
            this.btnBack1T = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTechPage
            // 
            this.lblTechPage.AutoSize = true;
            this.lblTechPage.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechPage.Location = new System.Drawing.Point(18, 20);
            this.lblTechPage.Name = "lblTechPage";
            this.lblTechPage.Size = new System.Drawing.Size(256, 31);
            this.lblTechPage.TabIndex = 0;
            this.lblTechPage.Text = "TECHNICIAN PAGE";
            // 
            // lblNewRequest
            // 
            this.lblNewRequest.AutoSize = true;
            this.lblNewRequest.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRequest.Location = new System.Drawing.Point(129, 207);
            this.lblNewRequest.Name = "lblNewRequest";
            this.lblNewRequest.Size = new System.Drawing.Size(130, 23);
            this.lblNewRequest.TabIndex = 1;
            this.lblNewRequest.Text = "New Requests:";
            // 
            // lblInProg
            // 
            this.lblInProg.AutoSize = true;
            this.lblInProg.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProg.Location = new System.Drawing.Point(529, 207);
            this.lblInProg.Name = "lblInProg";
            this.lblInProg.Size = new System.Drawing.Size(175, 23);
            this.lblInProg.TabIndex = 2;
            this.lblInProg.Text = "Request in Progress:";
            // 
            // lblMenuTech
            // 
            this.lblMenuTech.AutoSize = true;
            this.lblMenuTech.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTech.Location = new System.Drawing.Point(361, 116);
            this.lblMenuTech.Name = "lblMenuTech";
            this.lblMenuTech.Size = new System.Drawing.Size(91, 31);
            this.lblMenuTech.TabIndex = 3;
            this.lblMenuTech.Text = "MENU";
            // 
            // btnViewNewReq
            // 
            this.btnViewNewReq.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNewReq.Location = new System.Drawing.Point(129, 277);
            this.btnViewNewReq.Name = "btnViewNewReq";
            this.btnViewNewReq.Size = new System.Drawing.Size(130, 40);
            this.btnViewNewReq.TabIndex = 4;
            this.btnViewNewReq.Text = "View";
            this.btnViewNewReq.UseVisualStyleBackColor = true;
            // 
            // btnViewInProg
            // 
            this.btnViewInProg.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInProg.Location = new System.Drawing.Point(554, 277);
            this.btnViewInProg.Name = "btnViewInProg";
            this.btnViewInProg.Size = new System.Drawing.Size(126, 40);
            this.btnViewInProg.TabIndex = 5;
            this.btnViewInProg.Text = "View";
            this.btnViewInProg.UseVisualStyleBackColor = true;
            // 
            // btnBack1T
            // 
            this.btnBack1T.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1T.Location = new System.Drawing.Point(352, 385);
            this.btnBack1T.Name = "btnBack1T";
            this.btnBack1T.Size = new System.Drawing.Size(116, 42);
            this.btnBack1T.TabIndex = 6;
            this.btnBack1T.Text = "Back";
            this.btnBack1T.UseVisualStyleBackColor = true;
            // 
            // TECH_MAIN_PAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack1T);
            this.Controls.Add(this.btnViewInProg);
            this.Controls.Add(this.btnViewNewReq);
            this.Controls.Add(this.lblMenuTech);
            this.Controls.Add(this.lblInProg);
            this.Controls.Add(this.lblNewRequest);
            this.Controls.Add(this.lblTechPage);
            this.Name = "TECH_MAIN_PAGE";
            this.Text = "Nodir Laptop Repair Service KL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTechPage;
        private System.Windows.Forms.Label lblNewRequest;
        private System.Windows.Forms.Label lblInProg;
        private System.Windows.Forms.Label lblMenuTech;
        private System.Windows.Forms.Button btnViewNewReq;
        private System.Windows.Forms.Button btnViewInProg;
        private System.Windows.Forms.Button btnBack1T;
    }
}

