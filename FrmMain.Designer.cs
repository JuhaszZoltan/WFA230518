namespace WFA230518
{
    partial class FrmMain
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
            rtbConnectionTest = new RichTextBox();
            txtNewName = new TextBox();
            dtpNewDoB = new DateTimePicker();
            label1 = new Label();
            btnInsert = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // rtbConnectionTest
            // 
            rtbConnectionTest.Location = new Point(11, 11);
            rtbConnectionTest.Name = "rtbConnectionTest";
            rtbConnectionTest.Size = new Size(803, 157);
            rtbConnectionTest.TabIndex = 0;
            rtbConnectionTest.Text = "";
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(167, 221);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(263, 29);
            txtNewName.TabIndex = 1;
            // 
            // dtpNewDoB
            // 
            dtpNewDoB.Format = DateTimePickerFormat.Short;
            dtpNewDoB.Location = new Point(167, 275);
            dtpNewDoB.Name = "dtpNewDoB";
            dtpNewDoB.Size = new Size(263, 29);
            dtpNewDoB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 224);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 3;
            label1.Text = "name:";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 335);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(418, 45);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "add new entity";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 280);
            label2.Name = "label2";
            label2.Size = new Size(150, 22);
            label2.TabIndex = 3;
            label2.Text = "date of birth:";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(825, 449);
            Controls.Add(btnInsert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpNewDoB);
            Controls.Add(txtNewName);
            Controls.Add(rtbConnectionTest);
            Font = new Font("Consolas", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmMain";
            Text = "MySQL adatbázis-kapcsolat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbConnectionTest;
        private TextBox txtNewName;
        private DateTimePicker dtpNewDoB;
        private Label label1;
        private Button btnInsert;
        private Label label2;
    }
}