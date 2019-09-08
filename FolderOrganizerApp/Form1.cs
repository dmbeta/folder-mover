using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FolderOrganizerApp
{
    public partial class Form1 : Form
    {

        private string path;
        private string name;
        private string[] files;
        private List<List<string>> organized;

        private List<typeF> Dtypes;


        public Form1()
        {
            InitializeComponent();
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            DialogResult r = folderBrowserDialog1.ShowDialog();
            if (r.Equals(DialogResult.OK))
            {
                path = folderBrowserDialog1.SelectedPath;
                if (Directory.Exists(path))
                {
                    fileOrganizer();
                }
            }
        }

        private void fileOrganizer()
        {
            files = Directory.GetFiles(path);
            int max = Dtypes.Count;
            foreach(string f in files)
            {
                for(int k = 0; k < max; k++)
                {
                    typeF tF = Dtypes[k];
                    string[] ar = tF.list;
                    foreach(string ex in ar)
                    {
                        if(f.Contains(ex))
                        {
                            try
                            {
                                Directory.CreateDirectory(path + "\\" + tF.name);
                                File.Move(f, path + "\\" + tF.name + "\\" + f.Substring(path.Length + 1));
                                Console.WriteLine(path + "\\" + tF.name + "\\" + f.Substring(path.Length + 1));
                            }
                            catch(IOException)
                            {
                                Console.WriteLine("File exists elsewhere :" + path + "\\" + tF.name + "\\" + f.Substring(path.Length + 1));
                            }
                        }
                    }
                }
            }
        }

        private void extButton_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r.Equals(DialogResult.OK))
            {
                name = openFileDialog1.FileName;
                if (File.Exists(name))
                {
                    Dtypes = new List<typeF>();
                    organizeButton.Enabled = folderButton.Enabled = true;
                    loadTypes();

                }
            }
        }

        private void loadTypes()
        {
            StreamReader types = new StreamReader(name);
            while(types.Peek() > 0)
            {
                string line = types.ReadLine();
                if(line != null)
                {
                    string[] spl = line.Split(' ');
                    string key = spl[0];
                    string[] ext = new string[spl.Count() - 1];
                    Array.Copy(spl, 1, ext, 0, spl.Count() - 1);
                    typeF k = new typeF(key, ext);
                    Dtypes.Add(k);
                    Console.WriteLine(key);
                }
                else
                {
                    Console.WriteLine("null exception");
                }
            }
        }
    }
}
