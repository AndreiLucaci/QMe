namespace QMe.Templating
{
	partial class TemplateManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateManager));
			this.addNewTemplateBtn = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// addNewTemplateBtn
			// 
			this.addNewTemplateBtn.Location = new System.Drawing.Point(12, 12);
			this.addNewTemplateBtn.Name = "addNewTemplateBtn";
			this.addNewTemplateBtn.Size = new System.Drawing.Size(120, 39);
			this.addNewTemplateBtn.TabIndex = 0;
			this.addNewTemplateBtn.Text = "Add new template";
			this.addNewTemplateBtn.UseVisualStyleBackColor = true;
			this.addNewTemplateBtn.Click += new System.EventHandler(this.addNewTemplateBtn_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Description});
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(894, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(540, 593);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// TemplateManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1446, 608);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.addNewTemplateBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TemplateManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Templating Manager";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addNewTemplateBtn;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader Title;
		private System.Windows.Forms.ColumnHeader Description;
	}
}

