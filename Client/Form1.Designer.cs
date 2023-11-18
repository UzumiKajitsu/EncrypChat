namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Send = new Button();
            label1 = new Label();
            txb_Key = new TextBox();
            txb_Message = new TextBox();
            lsv_Message = new ListView();
            SuspendLayout();
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(598, 379);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(190, 59);
            btn_Send.TabIndex = 14;
            btn_Send.Text = "SEND";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(598, 335);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 13;
            label1.Text = "Key :";
            label1.Click += label1_Click;
            // 
            // txb_Key
            // 
            txb_Key.Location = new Point(663, 333);
            txb_Key.Name = "txb_Key";
            txb_Key.Size = new Size(125, 27);
            txb_Key.TabIndex = 12;
            txb_Key.TextChanged += txb_Key_TextChanged;
            // 
            // txb_Message
            // 
            txb_Message.Location = new Point(12, 333);
            txb_Message.Multiline = true;
            txb_Message.Name = "txb_Message";
            txb_Message.Size = new Size(580, 105);
            txb_Message.TabIndex = 11;
            txb_Message.TextChanged += txb_Message_TextChanged;
            // 
            // lsv_Message
            // 
            lsv_Message.Location = new Point(12, 12);
            lsv_Message.Name = "lsv_Message";
            lsv_Message.Size = new Size(776, 306);
            lsv_Message.TabIndex = 10;
            lsv_Message.UseCompatibleStateImageBehavior = false;
            lsv_Message.View = View.List;
            lsv_Message.SelectedIndexChanged += lsv_Message_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Send);
            Controls.Add(label1);
            Controls.Add(txb_Key);
            Controls.Add(txb_Message);
            Controls.Add(lsv_Message);
            Name = "Form1";
            Text = "Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Send;
        private Label label1;
        private TextBox txb_Key;
        private TextBox txb_Message;
        private ListView lsv_Message;
    }
}