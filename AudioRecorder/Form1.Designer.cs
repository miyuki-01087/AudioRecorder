
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
            this.btn_start = new System.Windows.Forms.Button();
            this.box_filename = new System.Windows.Forms.TextBox();
            this.btn_select_folder = new System.Windows.Forms.Button();
            this.label_folder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_silence = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.btn_start.Location = new System.Drawing.Point(331, 259);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(156, 73);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start Recording";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // box_filename
            // 
            this.box_filename.Location = new System.Drawing.Point(350, 157);
            this.box_filename.Name = "box_filename";
            this.box_filename.Size = new System.Drawing.Size(100, 22);
            this.box_filename.TabIndex = 1;
            this.box_filename.Text = "Recorded";
            // 
            // btn_select_folder
            // 
            this.btn_select_folder.Location = new System.Drawing.Point(460, 187);
            this.btn_select_folder.Name = "btn_select_folder";
            this.btn_select_folder.Size = new System.Drawing.Size(30, 30);
            this.btn_select_folder.TabIndex = 2;
            this.btn_select_folder.Text = " ... ";
            this.btn_select_folder.UseVisualStyleBackColor = true;
            this.btn_select_folder.Click += new System.EventHandler(this.btn_select_folder_Click);
            // 
            // label_folder
            // 
            this.label_folder.AutoSize = true;
            this.label_folder.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label_folder.Location = new System.Drawing.Point(496, 191);
            this.label_folder.Name = "label_folder";
            this.label_folder.Size = new System.Drawing.Size(47, 20);
            this.label_folder.TabIndex = 3;
            this.label_folder.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(254, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "FileName:";
            // 
            // chk_silence
            // 
            this.chk_silence.AutoSize = true;
            this.chk_silence.Checked = true;
            this.chk_silence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_silence.Location = new System.Drawing.Point(577, 241);
            this.chk_silence.Name = "chk_silence";
            this.chk_silence.Size = new System.Drawing.Size(121, 19);
            this.chk_silence.TabIndex = 5;
            this.chk_silence.Text = "RecordSilence";
            this.chk_silence.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_silence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_folder);
            this.Controls.Add(this.btn_select_folder);
            this.Controls.Add(this.box_filename);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox box_filename;
        private System.Windows.Forms.Button btn_select_folder;
        private System.Windows.Forms.Label label_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_silence;
    }
}