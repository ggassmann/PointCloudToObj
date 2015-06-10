using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointCloudToObj {
    public partial class PointCloudToObj : Form {
        public PointCloudToObj() {
            InitializeComponent();
        }

        private void browseForMeshlabServerButton_Click(object sender, EventArgs e) {
            openPointCloudDialog.ShowDialog();
            meshlabServerTextBox.Text = openPointCloudDialog.FileName;
        }

        private void buttonBrowseOutputFolder_Click(object sender, EventArgs e) {
            setOutputPathDialog.ShowDialog();
            textboxOutputPath.Text = setOutputPathDialog.SelectedPath;
        }

        private void buttonAddInput_Click(object sender, EventArgs e) {
            addInputDialog.ShowDialog();
            for(int i = 0; i < addInputDialog.FileNames.Length; i++) {
                outputInputsListBox.Items.Add(addInputDialog.FileNames[i]);
            }
        }

        private void outputButton_Click(object sender, EventArgs e) {
            for(int i = 0; i < outputInputsListBox.Items.Count; i++) {
                var path = (string)outputInputsListBox.Items[i];
                var parameters = "-s \"Point Cloud Script.mlx\" -i \"" + outputInputsListBox.Items[i] + "\" -o \"" + textboxOutputPath.Text + "\\" + Path.GetFileNameWithoutExtension(path) + ".obj\"";
                Console.WriteLine(meshlabServerTextBox.Text + " " + parameters);
                var pi = new ProcessStartInfo(meshlabServerTextBox.Text, parameters);
                pi.RedirectStandardOutput = true;
                pi.UseShellExecute = false;
                var proc = new Process();
                proc.StartInfo = pi;

                proc.Start();
                while (!proc.HasExited) {
                    Console.WriteLine(proc.StandardOutput.ReadLine());
                }
            }
            Console.WriteLine("Fin");
        }

        private void PointCloudToObj_Load(object sender, EventArgs e) {
            if(File.Exists("C:\\Program Files\\VCG\\MeshLab\\meshlabserver.exe")) {
                meshlabServerTextBox.Text = "C:\\Program Files\\VCG\\MeshLab\\meshlabserver.exe";
            }
        }
    }
}
