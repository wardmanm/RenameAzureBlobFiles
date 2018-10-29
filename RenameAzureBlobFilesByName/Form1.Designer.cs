namespace RenameAzureBlobFilesByName
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.storageAccountNameLbl = new System.Windows.Forms.Label();
			this.storageAccountNameTextBox = new System.Windows.Forms.TextBox();
			this.storageAccountKeyLbl = new System.Windows.Forms.Label();
			this.storageAccountKeyTextBox = new System.Windows.Forms.TextBox();
			this.findNameLbl = new System.Windows.Forms.Label();
			this.findNameTextBox = new System.Windows.Forms.TextBox();
			this.resultsBoxLbl = new System.Windows.Forms.Label();
			this.findBtn = new System.Windows.Forms.Button();
			this.containerLbl = new System.Windows.Forms.Label();
			this.containerTextBox = new System.Windows.Forms.TextBox();
			this.resultsBox = new System.Windows.Forms.ListBox();
			this.replaceBtn = new System.Windows.Forms.Button();
			this.replaceTextBox = new System.Windows.Forms.TextBox();
			this.replaceLbl = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// storageAccountNameLbl
			// 
			this.storageAccountNameLbl.AutoSize = true;
			this.storageAccountNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.storageAccountNameLbl.Location = new System.Drawing.Point(0, 37);
			this.storageAccountNameLbl.Name = "storageAccountNameLbl";
			this.storageAccountNameLbl.Size = new System.Drawing.Size(235, 25);
			this.storageAccountNameLbl.TabIndex = 0;
			this.storageAccountNameLbl.Text = "Storage Account Name";
			this.storageAccountNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// storageAccountNameTextBox
			// 
			this.storageAccountNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.storageAccountNameTextBox.Location = new System.Drawing.Point(5, 65);
			this.storageAccountNameTextBox.Name = "storageAccountNameTextBox";
			this.storageAccountNameTextBox.Size = new System.Drawing.Size(500, 30);
			this.storageAccountNameTextBox.TabIndex = 1;
			// 
			// storageAccountKeyLbl
			// 
			this.storageAccountKeyLbl.AutoSize = true;
			this.storageAccountKeyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.storageAccountKeyLbl.Location = new System.Drawing.Point(506, 37);
			this.storageAccountKeyLbl.Name = "storageAccountKeyLbl";
			this.storageAccountKeyLbl.Size = new System.Drawing.Size(217, 25);
			this.storageAccountKeyLbl.TabIndex = 2;
			this.storageAccountKeyLbl.Text = "Storage Account Key";
			// 
			// storageAccountKeyTextBox
			// 
			this.storageAccountKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.storageAccountKeyTextBox.Location = new System.Drawing.Point(511, 65);
			this.storageAccountKeyTextBox.Name = "storageAccountKeyTextBox";
			this.storageAccountKeyTextBox.Size = new System.Drawing.Size(698, 30);
			this.storageAccountKeyTextBox.TabIndex = 3;
			// 
			// findNameLbl
			// 
			this.findNameLbl.AutoSize = true;
			this.findNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.findNameLbl.Location = new System.Drawing.Point(0, 186);
			this.findNameLbl.Name = "findNameLbl";
			this.findNameLbl.Size = new System.Drawing.Size(54, 25);
			this.findNameLbl.TabIndex = 4;
			this.findNameLbl.Text = "Find";
			// 
			// findNameTextBox
			// 
			this.findNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.findNameTextBox.Location = new System.Drawing.Point(5, 214);
			this.findNameTextBox.Name = "findNameTextBox";
			this.findNameTextBox.Size = new System.Drawing.Size(500, 30);
			this.findNameTextBox.TabIndex = 5;
			// 
			// resultsBoxLbl
			// 
			this.resultsBoxLbl.AutoSize = true;
			this.resultsBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultsBoxLbl.Location = new System.Drawing.Point(0, 324);
			this.resultsBoxLbl.Name = "resultsBoxLbl";
			this.resultsBoxLbl.Size = new System.Drawing.Size(83, 25);
			this.resultsBoxLbl.TabIndex = 7;
			this.resultsBoxLbl.Text = "Results";
			this.resultsBoxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// findBtn
			// 
			this.findBtn.Enabled = false;
			this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.findBtn.Location = new System.Drawing.Point(511, 214);
			this.findBtn.Name = "findBtn";
			this.findBtn.Size = new System.Drawing.Size(103, 30);
			this.findBtn.TabIndex = 8;
			this.findBtn.Text = "Find";
			this.findBtn.UseVisualStyleBackColor = true;
			this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
			// 
			// containerLbl
			// 
			this.containerLbl.AutoSize = true;
			this.containerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.containerLbl.Location = new System.Drawing.Point(0, 98);
			this.containerLbl.Name = "containerLbl";
			this.containerLbl.Size = new System.Drawing.Size(168, 25);
			this.containerLbl.TabIndex = 9;
			this.containerLbl.Text = "Container Name";
			this.containerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// containerTextBox
			// 
			this.containerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.containerTextBox.Location = new System.Drawing.Point(5, 126);
			this.containerTextBox.Name = "containerTextBox";
			this.containerTextBox.Size = new System.Drawing.Size(500, 30);
			this.containerTextBox.TabIndex = 10;
			// 
			// resultsBox
			// 
			this.resultsBox.FormattingEnabled = true;
			this.resultsBox.ItemHeight = 16;
			this.resultsBox.Location = new System.Drawing.Point(5, 353);
			this.resultsBox.Name = "resultsBox";
			this.resultsBox.ScrollAlwaysVisible = true;
			this.resultsBox.Size = new System.Drawing.Size(1202, 292);
			this.resultsBox.TabIndex = 6;
			// 
			// replaceBtn
			// 
			this.replaceBtn.Enabled = false;
			this.replaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.replaceBtn.Location = new System.Drawing.Point(511, 275);
			this.replaceBtn.Name = "replaceBtn";
			this.replaceBtn.Size = new System.Drawing.Size(103, 30);
			this.replaceBtn.TabIndex = 13;
			this.replaceBtn.Text = "Replace";
			this.replaceBtn.UseVisualStyleBackColor = true;
			this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
			// 
			// replaceTextBox
			// 
			this.replaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.replaceTextBox.Location = new System.Drawing.Point(5, 275);
			this.replaceTextBox.Name = "replaceTextBox";
			this.replaceTextBox.Size = new System.Drawing.Size(500, 30);
			this.replaceTextBox.TabIndex = 12;
			// 
			// replaceLbl
			// 
			this.replaceLbl.AutoSize = true;
			this.replaceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.replaceLbl.Location = new System.Drawing.Point(0, 247);
			this.replaceLbl.Name = "replaceLbl";
			this.replaceLbl.Size = new System.Drawing.Size(140, 25);
			this.replaceLbl.TabIndex = 11;
			this.replaceLbl.Text = "Replace With";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1221, 27);
			this.toolStrip1.TabIndex = 14;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
			this.openToolStripButton.Text = "&Open Configuration";
			this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(5, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1204, 2);
			this.label1.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1221, 657);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.replaceBtn);
			this.Controls.Add(this.replaceTextBox);
			this.Controls.Add(this.replaceLbl);
			this.Controls.Add(this.containerTextBox);
			this.Controls.Add(this.containerLbl);
			this.Controls.Add(this.findBtn);
			this.Controls.Add(this.resultsBoxLbl);
			this.Controls.Add(this.resultsBox);
			this.Controls.Add(this.findNameTextBox);
			this.Controls.Add(this.findNameLbl);
			this.Controls.Add(this.storageAccountKeyTextBox);
			this.Controls.Add(this.storageAccountKeyLbl);
			this.Controls.Add(this.storageAccountNameTextBox);
			this.Controls.Add(this.storageAccountNameLbl);
			this.Name = "MainForm";
			this.Text = "Find and Replace Azure Blob Files";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label storageAccountNameLbl;
		private System.Windows.Forms.TextBox storageAccountNameTextBox;
		private System.Windows.Forms.Label storageAccountKeyLbl;
		private System.Windows.Forms.TextBox storageAccountKeyTextBox;
		private System.Windows.Forms.Label findNameLbl;
		private System.Windows.Forms.TextBox findNameTextBox;
		private System.Windows.Forms.Label resultsBoxLbl;
		private System.Windows.Forms.Button findBtn;
		private System.Windows.Forms.Label containerLbl;
		private System.Windows.Forms.TextBox containerTextBox;
		private System.Windows.Forms.ListBox resultsBox;
		private System.Windows.Forms.Button replaceBtn;
		private System.Windows.Forms.TextBox replaceTextBox;
		private System.Windows.Forms.Label replaceLbl;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.Label label1;
	}
}

