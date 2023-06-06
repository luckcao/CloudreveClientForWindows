
namespace ComponentControls.Controls
{
    partial class HintTextBox
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxValue.Location = new System.Drawing.Point(0, 0);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(279, 29);
            this.textBoxValue.TabIndex = 0;
            this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.BackColor = System.Drawing.Color.White;
            this.labelHint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelHint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHint.ForeColor = System.Drawing.Color.DarkGray;
            this.labelHint.Location = new System.Drawing.Point(10, 4);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(59, 22);
            this.labelHint.TabIndex = 1;
            this.labelHint.Text = "label1";
            this.labelHint.Click += new System.EventHandler(this.labelHint_Click);
            // 
            // HintTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.textBoxValue);
            this.Name = "HintTextBox";
            this.Size = new System.Drawing.Size(279, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label labelHint;
    }
}
