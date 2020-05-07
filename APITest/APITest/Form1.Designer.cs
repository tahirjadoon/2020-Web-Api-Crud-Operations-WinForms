namespace APITest
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
            this.btnTestApiPost = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestApiGetAll = new System.Windows.Forms.Button();
            this.btnTestApiGetId = new System.Windows.Forms.Button();
            this.btnTestApiGet = new System.Windows.Forms.Button();
            this.btnTestApiDelete = new System.Windows.Forms.Button();
            this.btnTestApiPut = new System.Windows.Forms.Button();
            this.btnTestApiPostExtraMultiLine = new System.Windows.Forms.Button();
            this.btnTestApiPostExtraOkResult = new System.Windows.Forms.Button();
            this.btnTestApiPostExtra = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApiPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestApiPost
            // 
            this.btnTestApiPost.Location = new System.Drawing.Point(6, 19);
            this.btnTestApiPost.Name = "btnTestApiPost";
            this.btnTestApiPost.Size = new System.Drawing.Size(154, 23);
            this.btnTestApiPost.TabIndex = 0;
            this.btnTestApiPost.Text = "Post - return Model";
            this.btnTestApiPost.UseVisualStyleBackColor = true;
            this.btnTestApiPost.Click += new System.EventHandler(this.btnTestApiPost_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTestApiGetAll);
            this.groupBox1.Controls.Add(this.btnTestApiGetId);
            this.groupBox1.Controls.Add(this.btnTestApiGet);
            this.groupBox1.Controls.Add(this.btnTestApiDelete);
            this.groupBox1.Controls.Add(this.btnTestApiPut);
            this.groupBox1.Controls.Add(this.btnTestApiPostExtraMultiLine);
            this.groupBox1.Controls.Add(this.btnTestApiPostExtraOkResult);
            this.groupBox1.Controls.Add(this.btnTestApiPostExtra);
            this.groupBox1.Controls.Add(this.btnTestApiPost);
            this.groupBox1.Location = new System.Drawing.Point(45, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test API";
            // 
            // btnTestApiGetAll
            // 
            this.btnTestApiGetAll.Location = new System.Drawing.Point(185, 153);
            this.btnTestApiGetAll.Name = "btnTestApiGetAll";
            this.btnTestApiGetAll.Size = new System.Drawing.Size(154, 23);
            this.btnTestApiGetAll.TabIndex = 8;
            this.btnTestApiGetAll.Text = "Get / All";
            this.btnTestApiGetAll.UseVisualStyleBackColor = true;
            this.btnTestApiGetAll.Click += new System.EventHandler(this.btnTestApiGetAll_Click);
            // 
            // btnTestApiGetId
            // 
            this.btnTestApiGetId.Location = new System.Drawing.Point(185, 124);
            this.btnTestApiGetId.Name = "btnTestApiGetId";
            this.btnTestApiGetId.Size = new System.Drawing.Size(154, 23);
            this.btnTestApiGetId.TabIndex = 7;
            this.btnTestApiGetId.Text = "Get / 12345";
            this.btnTestApiGetId.UseVisualStyleBackColor = true;
            this.btnTestApiGetId.Click += new System.EventHandler(this.btnTestApiGetId_Click);
            // 
            // btnTestApiGet
            // 
            this.btnTestApiGet.Location = new System.Drawing.Point(185, 95);
            this.btnTestApiGet.Name = "btnTestApiGet";
            this.btnTestApiGet.Size = new System.Drawing.Size(154, 23);
            this.btnTestApiGet.TabIndex = 6;
            this.btnTestApiGet.Text = "Get";
            this.btnTestApiGet.UseVisualStyleBackColor = true;
            this.btnTestApiGet.Click += new System.EventHandler(this.btnTestApiGet_Click);
            // 
            // btnTestApiDelete
            // 
            this.btnTestApiDelete.Location = new System.Drawing.Point(185, 48);
            this.btnTestApiDelete.Name = "btnTestApiDelete";
            this.btnTestApiDelete.Size = new System.Drawing.Size(154, 23);
            this.btnTestApiDelete.TabIndex = 5;
            this.btnTestApiDelete.Text = "Delete - return OK Result";
            this.btnTestApiDelete.UseVisualStyleBackColor = true;
            this.btnTestApiDelete.Click += new System.EventHandler(this.btnTestApiDelete_Click);
            // 
            // btnTestApiPut
            // 
            this.btnTestApiPut.Location = new System.Drawing.Point(185, 19);
            this.btnTestApiPut.Name = "btnTestApiPut";
            this.btnTestApiPut.Size = new System.Drawing.Size(154, 23);
            this.btnTestApiPut.TabIndex = 4;
            this.btnTestApiPut.Text = "Put - return Model";
            this.btnTestApiPut.UseVisualStyleBackColor = true;
            this.btnTestApiPut.Click += new System.EventHandler(this.btnTestApiPut_Click);
            // 
            // btnTestApiPostExtraMultiLine
            // 
            this.btnTestApiPostExtraMultiLine.Location = new System.Drawing.Point(6, 77);
            this.btnTestApiPostExtraMultiLine.Name = "btnTestApiPostExtraMultiLine";
            this.btnTestApiPostExtraMultiLine.Size = new System.Drawing.Size(154, 23);
            this.btnTestApiPostExtraMultiLine.TabIndex = 3;
            this.btnTestApiPostExtraMultiLine.Text = "Post - return Multi Line Model";
            this.btnTestApiPostExtraMultiLine.UseVisualStyleBackColor = true;
            this.btnTestApiPostExtraMultiLine.Click += new System.EventHandler(this.btnTestApiPostExtraMultiLine_Click);
            // 
            // btnTestApiPostExtraOkResult
            // 
            this.btnTestApiPostExtraOkResult.Location = new System.Drawing.Point(6, 106);
            this.btnTestApiPostExtraOkResult.Name = "btnTestApiPostExtraOkResult";
            this.btnTestApiPostExtraOkResult.Size = new System.Drawing.Size(154, 23);
            this.btnTestApiPostExtraOkResult.TabIndex = 2;
            this.btnTestApiPostExtraOkResult.Text = "Post Extra  - return OK Result";
            this.btnTestApiPostExtraOkResult.UseVisualStyleBackColor = true;
            this.btnTestApiPostExtraOkResult.Click += new System.EventHandler(this.btnTestApiPostExtraOkResult_Click);
            // 
            // btnTestApiPostExtra
            // 
            this.btnTestApiPostExtra.Location = new System.Drawing.Point(6, 48);
            this.btnTestApiPostExtra.Name = "btnTestApiPostExtra";
            this.btnTestApiPostExtra.Size = new System.Drawing.Size(154, 23);
            this.btnTestApiPostExtra.TabIndex = 1;
            this.btnTestApiPostExtra.Text = "Post Extra - return Model";
            this.btnTestApiPostExtra.UseVisualStyleBackColor = true;
            this.btnTestApiPostExtra.Click += new System.EventHandler(this.btnTestApiPostExtra_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(511, 40);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(435, 499);
            this.txtResults.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(871, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "API Path: ";
            // 
            // txtApiPath
            // 
            this.txtApiPath.Location = new System.Drawing.Point(113, 48);
            this.txtApiPath.Name = "txtApiPath";
            this.txtApiPath.Size = new System.Drawing.Size(332, 20);
            this.txtApiPath.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 551);
            this.Controls.Add(this.txtApiPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestApiPost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTestApiPostExtra;
        private System.Windows.Forms.Button btnTestApiPostExtraOkResult;
        private System.Windows.Forms.Button btnTestApiPostExtraMultiLine;
        private System.Windows.Forms.Button btnTestApiPut;
        private System.Windows.Forms.Button btnTestApiDelete;
        private System.Windows.Forms.Button btnTestApiGetAll;
        private System.Windows.Forms.Button btnTestApiGetId;
        private System.Windows.Forms.Button btnTestApiGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApiPath;
    }
}

