using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Convert2WebpGUI
{
    public partial class Main : Form
    {
        private bool bIsBusy = false;
        private string current_result = "";
        private int current_percent = 0;
        private int current_row = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = dgvFileList.Rows.Count;
            if (selectFiles.ShowDialog() == DialogResult.OK)
            {
                foreach (string st in selectFiles.FileNames)
                {
                    count = dgvFileList.Rows.Add();
                    dgvFileList.Rows[count].Cells["colOrder"].Value = count + 1;
                    dgvFileList.Rows[count].Cells["colFile"].Value = st;
                    dgvFileList.Rows[count].Cells["colResult"].Value = string.Empty;
                }
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            dgvFileList.Rows.Clear();
        }

        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectFolder.Enabled = radOther.Checked;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (saveFolder.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = saveFolder.SelectedPath;
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (bIsBusy)
            {
                string stFile = "";
                current_result = "";
                for (int i = 0; i < dgvFileList.Rows.Count; i++)
                {
                    stFile = dgvFileList.Rows[i].Cells["colFile"].Value.ToString();
                    current_result = Convert2Webp(stFile, txtOutputFolder.Text, radOther.Checked);
                    current_row = i;
                    current_percent = ((i + 1) / dgvFileList.Rows.Count) * 100;
                    backgroundWorker1.ReportProgress(current_percent);
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            dgvFileList.Rows[current_row].Cells["colResult"].Value = current_result;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            bIsBusy = false;
            Set_Control(!bIsBusy);
            MessageBox.Show("Đã xong!", "Thông báo");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Check output
            if (radOther.Checked && txtOutputFolder.Text.Length <= 0)
            {
                MessageBox.Show("Please select output folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bIsBusy = true;
            Set_Control(!bIsBusy);
            //Do work
            backgroundWorker1.RunWorkerAsync();
        }

        private void Set_Control(bool Active)
        {
            btnAdd.Enabled = Active;
            btnConvert.Enabled = Active;
            btnExit.Enabled = Active;
            btnClear.Enabled = Active;
            btnSelectFolder.Enabled = (Active && radOther.Checked);
            if (Active)
            {
                this.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
            }
        }

        private string Convert2Webp(string stFile, string OutputFolder, bool bIsOtherFolder)
        {
            if (!File.Exists(stFile))
            {
                return "File does not exists";
            }
            //Generate new file's name
            bool IsFilenameSpecial = false;
            string stFileName = Path.GetFileNameWithoutExtension(stFile);
            string stFileExt = Path.GetExtension(stFile);
            string stNewFile = "";
            if (bIsOtherFolder)
            {
                stNewFile = OutputFolder + "\\" + stFileName + ".webp";
            }
            else
            {
                stNewFile = stFile.Replace(stFileExt, ".webp");
            }
            if (File.Exists(stNewFile))
            {
                File.Delete(stNewFile);
            }
            IsFilenameSpecial = stFileName.Contains("-");
            //Generate command
            string stCommand = "";

            //Add Input file
            stCommand = " \"" + stFile + "\" ";

            //Add lossess
            if (radLossless.Checked)
            {
                stCommand += "-lossless ";
            }

            //Add quanlity
            stCommand += " -q " + Properties.Settings.Default.quality.ToString();

            //Add preset
            stCommand += " -preset " + Properties.Settings.Default.preset;

            //Add compression method
            stCommand += " -m " + Properties.Settings.Default.compress_method.ToString();

            //Add deblocking filter
            stCommand += " -f " + Properties.Settings.Default.deblocking.ToString();

            //Add sharpness
            stCommand += " -sharpness " + Properties.Settings.Default.sharpness.ToString();

            //Add Output file
            stCommand += " -o \"" + stNewFile + "\" ";

            //Explicitly specify the input file
            if (IsFilenameSpecial)
            {
                stCommand += " --";
            }
            Process process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "cwebp.exe";
            process.StartInfo.Arguments = stCommand;
            process.Start();
            process.WaitForExit();
            if (!File.Exists(stNewFile))
            {
                return "Error while encoding file!";
            }
            return "OK";
        }

        private void SaveOption()
        {
            Properties.Settings.Default.quality = Decimal.ToInt16(nmQuantity.Value);
            Properties.Settings.Default.lossless = radLossless.Checked;
            Properties.Settings.Default.preset = cbPreset.SelectedItem.ToString();
            Properties.Settings.Default.sharpness = Decimal.ToInt16(nmSharpness.Value);
            Properties.Settings.Default.compress_method = Decimal.ToInt16(nmMethod.Value);
            Properties.Settings.Default.deblocking = Decimal.ToInt16(nmDeFilter.Value);
            Properties.Settings.Default.Save();
        }

        private void LoadOption()
        {
            barQuanlity.Value = Properties.Settings.Default.quality;
            barMethod.Value = Properties.Settings.Default.compress_method;
            barSharpness.Value = Properties.Settings.Default.sharpness;
            barDeFilter.Value = Properties.Settings.Default.deblocking;
            cbPreset.SelectedItem = Properties.Settings.Default.preset;

            radLossless.Checked = Properties.Settings.Default.lossless;
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupMain.Visible = false;
            groupOption.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupMain.Visible = true;
            groupOption.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOption();
            groupMain.Visible = true;
            groupOption.Visible = false;
        }

        private void barQuanlity_ValueChanged(object sender, EventArgs e)
        {
            nmQuantity.Value = barQuanlity.Value;
        }

        private void barSharpness_ValueChanged(object sender, EventArgs e)
        {
            nmSharpness.Value = barSharpness.Value;
        }

        private void barMethod_ValueChanged(object sender, EventArgs e)
        {
            nmMethod.Value = barMethod.Value;
        }

        private void barDeFilter_ValueChanged(object sender, EventArgs e)
        {
            nmDeFilter.Value = barDeFilter.Value;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadOption();
        }
    }
}