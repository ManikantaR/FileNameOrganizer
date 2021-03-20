
namespace FileNameOrganizer
{
    partial class FileOrganizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.prepend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.postpend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Rename = new System.Windows.Forms.Button();
            this.RevertDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderName
            // 
            this.folderName.AllowDrop = true;
            this.folderName.Location = new System.Drawing.Point(318, 41);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(1059, 55);
            this.folderName.TabIndex = 0;
            this.folderName.DragDrop += new System.Windows.Forms.DragEventHandler(this.folderName_DragDrop);
            this.folderName.DragEnter += new System.Windows.Forms.DragEventHandler(this.folderName_DragEnter);
            this.folderName.MouseLeave += new System.EventHandler(this.folderName_MouseLeave);
            this.folderName.MouseHover += new System.EventHandler(this.folderName_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder Name";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(73, 320);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1372, 487);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // prepend
            // 
            this.prepend.Location = new System.Drawing.Point(318, 117);
            this.prepend.Name = "prepend";
            this.prepend.Size = new System.Drawing.Size(810, 55);
            this.prepend.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Append Text";
            // 
            // postpend
            // 
            this.postpend.Location = new System.Drawing.Point(318, 193);
            this.postpend.Name = "postpend";
            this.postpend.Size = new System.Drawing.Size(810, 55);
            this.postpend.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prepend Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1410, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rename
            // 
            this.Rename.Location = new System.Drawing.Point(1184, 124);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(225, 69);
            this.Rename.TabIndex = 3;
            this.Rename.Text = "Rename";
            this.Rename.UseVisualStyleBackColor = true;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // RevertDate
            // 
            this.RevertDate.Location = new System.Drawing.Point(1184, 199);
            this.RevertDate.Name = "RevertDate";
            this.RevertDate.Size = new System.Drawing.Size(225, 69);
            this.RevertDate.TabIndex = 3;
            this.RevertDate.Text = "ReverDate";
            this.RevertDate.UseVisualStyleBackColor = true;
            this.RevertDate.Click += new System.EventHandler(this.RevertDate_Click);
            // 
            // FileOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 918);
            this.Controls.Add(this.RevertDate);
            this.Controls.Add(this.Rename);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.postpend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prepend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderName);
            this.Name = "FileOrganizer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox prepend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox postpend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Rename;
        private System.Windows.Forms.Button RevertDate;
    }
}

