namespace RestAPISimulator
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
            this.btnPost = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtCustomerData = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerResponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(31, 27);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(206, 50);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "Post Customer Data";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(31, 152);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(206, 50);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get Customer Data";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtCustomerData
            // 
            this.txtCustomerData.Location = new System.Drawing.Point(31, 282);
            this.txtCustomerData.Name = "txtCustomerData";
            this.txtCustomerData.Size = new System.Drawing.Size(636, 189);
            this.txtCustomerData.TabIndex = 2;
            this.txtCustomerData.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Response to show success or faliure";
            // 
            // txtServerResponse
            // 
            this.txtServerResponse.Location = new System.Drawing.Point(290, 57);
            this.txtServerResponse.Name = "txtServerResponse";
            this.txtServerResponse.Size = new System.Drawing.Size(413, 75);
            this.txtServerResponse.TabIndex = 5;
            this.txtServerResponse.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 539);
            this.Controls.Add(this.txtServerResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerData);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnPost);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Rest API Simulators";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox txtCustomerData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtServerResponse;
    }
}

