using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileNameOrganizer
{
    public partial class FileOrganizer : Form
    {
        public List<string> Files { get; set; }

        public FileOrganizer()
        {
            InitializeComponent();
            listView1.Columns.Add("File", 100);
            listView1.Columns.Add("Location", 100);
            prepend.Text = DateTime.Today.ToString("yyyyMMdd");

        }
        private string GetFileName(string fileName,bool removedate=false)
        {

            string prepend = FileNameHasDate(fileName) || removedate ? "" : this.prepend.Text+"_";
            string newFileName= string.Format("{0}\\{1}{2}", Path.GetDirectoryName(fileName), prepend,
                getParsedFilename(Path.GetFileName(fileName), replaceDate: removedate, replaceSpace: true), postpend.Text);

            return newFileName.StartsWith("_") ? newFileName.Substring(1) : newFileName;
        }

        private object getParsedFilename(string fileName, bool replaceDate, bool replaceSpace)
        {
            if (FileNameHasDate(fileName) && replaceDate)
                fileName = fileName.Substring(8);
            if(replaceSpace) 
            fileName = fileName.Replace(" ", "_");
            if (fileName.StartsWith("_")) 
            fileName = fileName.Substring(1);

            return fileName;
        }

        private static bool FileNameHasDate(string fileName)
        {
            return fileName.Length > 8 && long.TryParse(fileName.Substring(0, 8), out long num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                return;
            folderName.Text = folderBrowserDialog1.SelectedPath;
        }


        private void folderName_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                folderName.Text = files[0];
            }
        }

        private void folderName_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                List<string> filenames = GetFileNames(  files[0]);
                AddFileNamesToList(filenames);
                folderName.Text = files[0];
            }
        }

        private void AddFileNamesToList(List<string> files)
        {
            listView1.Items.Clear();
            foreach(var file in files)
            {
                string[] items = {  Path.GetFileName(file), Path.GetDirectoryName(file) };
                ListViewItem item =   new ListViewItem(items);
                
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private List<string> GetFileNames(string v)
        {
            if ((File.GetAttributes(v) & FileAttributes.Directory) != FileAttributes.Directory)
                return new List<string> { v};
            return Directory.GetFiles(v, "*.*", SearchOption.AllDirectories).ToList();
        }

        private void folderName_MouseHover(object sender, EventArgs e)
        {
            if(folderName.Text.Length > 0)
            {
                toolTip1.SetToolTip(folderName, folderName.Text);
                //toolTip1.Show();
            }
        }

        private void folderName_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(this);
        }

        private void Rename_Click(object sender, EventArgs e)
        {
           
            if (!(folderName.Text.Length>0 )) return;
            List<string> files = Directory.GetFiles(folderName.Text, "*.*", SearchOption.AllDirectories).ToList();

            foreach (var file in files)
            {
                string filen = GetFileName(file);
                File.Move(file, filen);
            }
            files = Directory.GetFiles(folderName.Text, "*.*", SearchOption.AllDirectories).ToList();
            AddFileNamesToList(files);
        }

        private void RevertDate_Click(object sender, EventArgs e)
        {
            List<string> files = Directory.GetFiles(folderName.Text, "*.*", SearchOption.AllDirectories).ToList();
            if (! (folderName.Text.Length > 0)) return;

            foreach (var file in files)
            {
                string filen = GetFileName(file,true);
                File.Move(file, filen);
            }
            files = Directory.GetFiles(folderName.Text, "*.*", SearchOption.AllDirectories).ToList();
            AddFileNamesToList(files);
        }
    }
}
