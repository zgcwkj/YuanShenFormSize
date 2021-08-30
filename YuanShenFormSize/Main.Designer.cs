
namespace YuanShenFormSize
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Btn_fullScreen = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_Show1080P = new System.Windows.Forms.Button();
            this.Btn_Show720P = new System.Windows.Forms.Button();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Text_Width = new System.Windows.Forms.TextBox();
            this.Txt_ShowType = new System.Windows.Forms.Label();
            this.Rb_ShowForm = new System.Windows.Forms.RadioButton();
            this.Rb_FullScreen = new System.Windows.Forms.RadioButton();
            this.Txt_Width = new System.Windows.Forms.Label();
            this.Txt_Height = new System.Windows.Forms.Label();
            this.Text_Height = new System.Windows.Forms.TextBox();
            this.Txt_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_fullScreen
            // 
            this.Btn_fullScreen.Font = new System.Drawing.Font("宋体", 12F);
            this.Btn_fullScreen.Location = new System.Drawing.Point(292, 19);
            this.Btn_fullScreen.Name = "Btn_fullScreen";
            this.Btn_fullScreen.Size = new System.Drawing.Size(156, 48);
            this.Btn_fullScreen.TabIndex = 3;
            this.Btn_fullScreen.Text = "全屏显示";
            this.toolTip.SetToolTip(this.Btn_fullScreen, "全屏显示，像素最大化");
            this.Btn_fullScreen.UseVisualStyleBackColor = true;
            this.Btn_fullScreen.Click += new System.EventHandler(this.Btn_fullScreen_Click);
            // 
            // Btn_Show1080P
            // 
            this.Btn_Show1080P.Font = new System.Drawing.Font("宋体", 12F);
            this.Btn_Show1080P.Location = new System.Drawing.Point(292, 87);
            this.Btn_Show1080P.Name = "Btn_Show1080P";
            this.Btn_Show1080P.Size = new System.Drawing.Size(83, 48);
            this.Btn_Show1080P.TabIndex = 8;
            this.Btn_Show1080P.Text = "1080P";
            this.Btn_Show1080P.UseVisualStyleBackColor = true;
            this.Btn_Show1080P.Click += new System.EventHandler(this.Btn_Show1080P_Click);
            // 
            // Btn_Show720P
            // 
            this.Btn_Show720P.Font = new System.Drawing.Font("宋体", 12F);
            this.Btn_Show720P.Location = new System.Drawing.Point(381, 87);
            this.Btn_Show720P.Name = "Btn_Show720P";
            this.Btn_Show720P.Size = new System.Drawing.Size(69, 48);
            this.Btn_Show720P.TabIndex = 9;
            this.Btn_Show720P.Text = "720P";
            this.Btn_Show720P.UseVisualStyleBackColor = true;
            this.Btn_Show720P.Click += new System.EventHandler(this.Btn_Show720P_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Font = new System.Drawing.Font("宋体", 12F);
            this.Btn_Ok.Location = new System.Drawing.Point(12, 142);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(142, 49);
            this.Btn_Ok.TabIndex = 10;
            this.Btn_Ok.Text = "确定修改";
            this.toolTip.SetToolTip(this.Btn_Ok, "by zgcwkj");
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Text_Width
            // 
            this.Text_Width.Location = new System.Drawing.Point(87, 59);
            this.Text_Width.Name = "Text_Width";
            this.Text_Width.Size = new System.Drawing.Size(195, 25);
            this.Text_Width.TabIndex = 5;
            // 
            // Txt_ShowType
            // 
            this.Txt_ShowType.AutoSize = true;
            this.Txt_ShowType.Font = new System.Drawing.Font("宋体", 12F);
            this.Txt_ShowType.Location = new System.Drawing.Point(12, 21);
            this.Txt_ShowType.Name = "Txt_ShowType";
            this.Txt_ShowType.Size = new System.Drawing.Size(109, 20);
            this.Txt_ShowType.TabIndex = 0;
            this.Txt_ShowType.Text = "显示类型：";
            // 
            // Rb_ShowForm
            // 
            this.Rb_ShowForm.AutoSize = true;
            this.Rb_ShowForm.Font = new System.Drawing.Font("宋体", 12F);
            this.Rb_ShowForm.Location = new System.Drawing.Point(127, 19);
            this.Rb_ShowForm.Name = "Rb_ShowForm";
            this.Rb_ShowForm.Size = new System.Drawing.Size(70, 24);
            this.Rb_ShowForm.TabIndex = 1;
            this.Rb_ShowForm.Text = "窗体";
            this.Rb_ShowForm.UseVisualStyleBackColor = true;
            // 
            // Rb_FullScreen
            // 
            this.Rb_FullScreen.AutoSize = true;
            this.Rb_FullScreen.Checked = true;
            this.Rb_FullScreen.Font = new System.Drawing.Font("宋体", 12F);
            this.Rb_FullScreen.Location = new System.Drawing.Point(212, 19);
            this.Rb_FullScreen.Name = "Rb_FullScreen";
            this.Rb_FullScreen.Size = new System.Drawing.Size(70, 24);
            this.Rb_FullScreen.TabIndex = 2;
            this.Rb_FullScreen.TabStop = true;
            this.Rb_FullScreen.Text = "全屏";
            this.Rb_FullScreen.UseVisualStyleBackColor = true;
            // 
            // Txt_Width
            // 
            this.Txt_Width.AutoSize = true;
            this.Txt_Width.Font = new System.Drawing.Font("宋体", 12F);
            this.Txt_Width.Location = new System.Drawing.Point(12, 61);
            this.Txt_Width.Name = "Txt_Width";
            this.Txt_Width.Size = new System.Drawing.Size(69, 20);
            this.Txt_Width.TabIndex = 4;
            this.Txt_Width.Text = "宽度：";
            // 
            // Txt_Height
            // 
            this.Txt_Height.AutoSize = true;
            this.Txt_Height.Font = new System.Drawing.Font("宋体", 12F);
            this.Txt_Height.Location = new System.Drawing.Point(12, 104);
            this.Txt_Height.Name = "Txt_Height";
            this.Txt_Height.Size = new System.Drawing.Size(69, 20);
            this.Txt_Height.TabIndex = 6;
            this.Txt_Height.Text = "高度：";
            // 
            // Text_Height
            // 
            this.Text_Height.Location = new System.Drawing.Point(88, 102);
            this.Text_Height.Name = "Text_Height";
            this.Text_Height.Size = new System.Drawing.Size(194, 25);
            this.Text_Height.TabIndex = 7;
            // 
            // Txt_Info
            // 
            this.Txt_Info.AutoSize = true;
            this.Txt_Info.ForeColor = System.Drawing.Color.Red;
            this.Txt_Info.Location = new System.Drawing.Point(186, 176);
            this.Txt_Info.Name = "Txt_Info";
            this.Txt_Info.Size = new System.Drawing.Size(262, 15);
            this.Txt_Info.TabIndex = 11;
            this.Txt_Info.Text = "如果无法修改，请以管理员身份运行！";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 194);
            this.Controls.Add(this.Txt_Info);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Btn_Show720P);
            this.Controls.Add(this.Btn_Show1080P);
            this.Controls.Add(this.Text_Height);
            this.Controls.Add(this.Txt_Height);
            this.Controls.Add(this.Txt_Width);
            this.Controls.Add(this.Rb_FullScreen);
            this.Controls.Add(this.Rb_ShowForm);
            this.Controls.Add(this.Txt_ShowType);
            this.Controls.Add(this.Text_Width);
            this.Controls.Add(this.Btn_fullScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(486, 241);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(486, 241);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "原神窗体大小";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_fullScreen;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox Text_Width;
        private System.Windows.Forms.Label Txt_ShowType;
        private System.Windows.Forms.RadioButton Rb_ShowForm;
        private System.Windows.Forms.RadioButton Rb_FullScreen;
        private System.Windows.Forms.Label Txt_Width;
        private System.Windows.Forms.Label Txt_Height;
        private System.Windows.Forms.TextBox Text_Height;
        private System.Windows.Forms.Button Btn_Show1080P;
        private System.Windows.Forms.Button Btn_Show720P;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Label Txt_Info;
    }
}

