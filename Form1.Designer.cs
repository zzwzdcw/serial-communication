namespace 串口通讯
{
    partial class Form1
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
            this.PortsName_ComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRate_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Open_Close_Button = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Write_TextBox = new System.Windows.Forms.RichTextBox();
            this.Write_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Reception_ListBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PortsName_ComboBox
            // 
            this.PortsName_ComboBox.FormattingEnabled = true;
            this.PortsName_ComboBox.Location = new System.Drawing.Point(60, 10);
            this.PortsName_ComboBox.Name = "PortsName_ComboBox";
            this.PortsName_ComboBox.Size = new System.Drawing.Size(96, 20);
            this.PortsName_ComboBox.TabIndex = 0;
            // 
            // BaudRate_ComboBox
            // 
            this.BaudRate_ComboBox.FormattingEnabled = true;
            this.BaudRate_ComboBox.Location = new System.Drawing.Point(218, 10);
            this.BaudRate_ComboBox.Name = "BaudRate_ComboBox";
            this.BaudRate_ComboBox.Size = new System.Drawing.Size(96, 20);
            this.BaudRate_ComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // Open_Close_Button
            // 
            this.Open_Close_Button.Location = new System.Drawing.Point(334, 6);
            this.Open_Close_Button.Name = "Open_Close_Button";
            this.Open_Close_Button.Size = new System.Drawing.Size(90, 27);
            this.Open_Close_Button.TabIndex = 4;
            this.Open_Close_Button.Text = "打开串口";
            this.Open_Close_Button.UseVisualStyleBackColor = true;
            this.Open_Close_Button.Click += new System.EventHandler(this.Open_Close_Button_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Write_TextBox
            // 
            this.Write_TextBox.Location = new System.Drawing.Point(12, 404);
            this.Write_TextBox.Name = "Write_TextBox";
            this.Write_TextBox.Size = new System.Drawing.Size(409, 30);
            this.Write_TextBox.TabIndex = 5;
            this.Write_TextBox.Text = "";
            this.Write_TextBox.TextChanged += new System.EventHandler(this.Write_TextBox_TextChanged);
            // 
            // Write_Button
            // 
            this.Write_Button.Location = new System.Drawing.Point(442, 411);
            this.Write_Button.Name = "Write_Button";
            this.Write_Button.Size = new System.Drawing.Size(94, 23);
            this.Write_Button.TabIndex = 6;
            this.Write_Button.Text = "发送数据";
            this.Write_Button.UseVisualStyleBackColor = true;
            this.Write_Button.Click += new System.EventHandler(this.Write_Button_Click);
            this.Write_Button.Enter += new System.EventHandler(this.Write_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "发送测试数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reception_ListBox2
            // 
            this.Reception_ListBox2.FormattingEnabled = true;
            this.Reception_ListBox2.ItemHeight = 12;
            this.Reception_ListBox2.Location = new System.Drawing.Point(12, 46);
            this.Reception_ListBox2.Name = "Reception_ListBox2";
            this.Reception_ListBox2.Size = new System.Drawing.Size(409, 328);
            this.Reception_ListBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reception_ListBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Write_Button);
            this.Controls.Add(this.Write_TextBox);
            this.Controls.Add(this.Open_Close_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaudRate_ComboBox);
            this.Controls.Add(this.PortsName_ComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortsName_ComboBox;
        private System.Windows.Forms.ComboBox BaudRate_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Open_Close_Button;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox Write_TextBox;
        private System.Windows.Forms.Button Write_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Reception_ListBox2;
    }
}

