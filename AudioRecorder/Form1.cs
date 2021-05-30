using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace AudioRecorder
{
    public partial class Form1 : Form
    {
        private bool is_recording = false;
        private Record reco;
        public Form1()
        {
            this.Text = "Recorder";
            InitializeComponent();
            reco = new Record();
            label_folder.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (is_recording)
            {
                btn_start.Text = "Start Recording";
                is_recording = false;
                reco.QuitRecording();
                chk_silence.Enabled = true;
            }
            else
            {
                string filename = box_filename.Text;
                btn_start.Text = "Stop Recording";
                reco.setup(label_folder.Text, filename, chk_silence.Checked);
                is_recording = true;
                chk_silence.Enabled = false;
            }
        }

        private void btn_select_folder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();


            commonOpenFileDialog.Title = "フォルダを選択してください。";
            commonOpenFileDialog.InitialDirectory = @"C:";
            commonOpenFileDialog.IsFolderPicker = true;


            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                label_folder.Text = commonOpenFileDialog.FileName;
            }
            else
            {
                label_folder.Text = "キャンセルされました。";
            }
        }
    
    }
}
