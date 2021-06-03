
namespace AudioRecorder
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.box_filename = new System.Windows.Forms.TextBox();
            this.btn_select_folder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_silence = new System.Windows.Forms.CheckBox();
            this.box_folder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.btn_start.Location = new System.Drawing.Point(40, 159);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(156, 73);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start Recording";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // box_filename
            // 
            this.box_filename.Location = new System.Drawing.Point(116, 36);
            this.box_filename.Name = "box_filename";
            this.box_filename.Size = new System.Drawing.Size(100, 22);
            this.box_filename.TabIndex = 1;
            this.box_filename.Text = "Recorded";
            // 
            // btn_select_folder
            // 
            this.btn_select_folder.Location = new System.Drawing.Point(28, 69);
            this.btn_select_folder.Name = "btn_select_folder";
            this.btn_select_folder.Size = new System.Drawing.Size(30, 30);
            this.btn_select_folder.TabIndex = 2;
            this.btn_select_folder.Text = " ... ";
            this.btn_select_folder.UseVisualStyleBackColor = true;
            this.btn_select_folder.Click += new System.EventHandler(this.btn_select_folder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "FileName:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chk_silence
            // 
            this.chk_silence.AutoSize = true;
            this.chk_silence.Checked = true;
            this.chk_silence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_silence.Location = new System.Drawing.Point(28, 118);
            this.chk_silence.Name = "chk_silence";
            this.chk_silence.Size = new System.Drawing.Size(121, 19);
            this.chk_silence.TabIndex = 5;
            this.chk_silence.Text = "RecordSilence";
            this.chk_silence.UseVisualStyleBackColor = true;
            // 
            // box_folder
            // 
            this.box_folder.Location = new System.Drawing.Point(64, 74);
            this.box_folder.Name = "box_folder";
            this.box_folder.Size = new System.Drawing.Size(150, 22);
            this.box_folder.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 253);
            this.Controls.Add(this.box_folder);
            this.Controls.Add(this.chk_silence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_select_folder);
            this.Controls.Add(this.box_filename);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "AudioRecorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox box_filename;
        private System.Windows.Forms.Button btn_select_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_silence;
        private System.Windows.Forms.TextBox box_folder;
    }
}