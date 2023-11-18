namespace Server
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
            btnSend = new Button();
            label1 = new Label();
            txb_Key = new TextBox();
            txb_Message = new TextBox();
            lsv_Message = new ListView();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(598, 367);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(190, 62);
            btnSend.TabIndex = 19;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(598, 326);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 18;
            label1.Text = "Key :";
            // 
            // txb_Key
            // 
            txb_Key.Location = new Point(663, 324);
            txb_Key.Name = "txb_Key";
            txb_Key.Size = new Size(125, 27);
            txb_Key.TabIndex = 17;
            // 
            // txb_Message
            // 
            txb_Message.Location = new Point(12, 338);
            txb_Message.Multiline = true;
            txb_Message.Name = "txb_Message";
            txb_Message.Size = new Size(551, 91);
            txb_Message.TabIndex = 16;
            // 
            // lsv_Message
            // 
            lsv_Message.Location = new Point(12, 12);
            lsv_Message.Name = "lsv_Message";
            lsv_Message.Size = new Size(776, 306);
            lsv_Message.TabIndex = 15;
            lsv_Message.UseCompatibleStateImageBehavior = false;
            lsv_Message.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 438);
            Controls.Add(btnSend);
            Controls.Add(label1);
            Controls.Add(txb_Key);
            Controls.Add(txb_Message);
            Controls.Add(lsv_Message);
            Name = "Form1";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label label1;
        private TextBox txb_Key;
        private TextBox txb_Message;
        private ListView lsv_Message;
    }
}