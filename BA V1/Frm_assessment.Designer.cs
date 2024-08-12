
namespace BA_V1
{
    partial class Frm_assessment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            lbl_Text = new Label();
            lbl_symptom = new Label();
            trckbr_VAS = new TrackBar();
            lbl_disagree = new Label();
            lbl_agree = new Label();
            btn_back = new Button();
            btn_next = new Button();
            ((System.ComponentModel.ISupportInitialize)trckbr_VAS).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.Location = new Point(205, 288);
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Maximum = 34;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(410, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 0;
            // 
            // lbl_Text
            // 
            lbl_Text.Anchor = AnchorStyles.None;
            lbl_Text.AutoSize = true;
            lbl_Text.Location = new Point(205, 90);
            lbl_Text.Name = "lbl_Text";
            lbl_Text.Size = new Size(38, 15);
            lbl_Text.TabIndex = 1;
            lbl_Text.Text = "label1";
            // 
            // lbl_symptom
            // 
            lbl_symptom.Anchor = AnchorStyles.None;
            lbl_symptom.AutoSize = true;
            lbl_symptom.Location = new Point(205, 143);
            lbl_symptom.Name = "lbl_symptom";
            lbl_symptom.Size = new Size(38, 15);
            lbl_symptom.TabIndex = 2;
            lbl_symptom.Text = "label2";
            // 
            // trckbr_VAS
            // 
            trckbr_VAS.Anchor = AnchorStyles.None;
            trckbr_VAS.LargeChange = 100;
            trckbr_VAS.Location = new Point(205, 180);
            trckbr_VAS.Maximum = 500;
            trckbr_VAS.Name = "trckbr_VAS";
            trckbr_VAS.Size = new Size(410, 45);
            trckbr_VAS.SmallChange = 5;
            trckbr_VAS.TabIndex = 3;
            trckbr_VAS.TickFrequency = 0;
            // 
            // lbl_disagree
            // 
            lbl_disagree.Anchor = AnchorStyles.None;
            lbl_disagree.AutoSize = true;
            lbl_disagree.Location = new Point(205, 210);
            lbl_disagree.Name = "lbl_disagree";
            lbl_disagree.Size = new Size(38, 15);
            lbl_disagree.TabIndex = 4;
            lbl_disagree.Text = "label3";
            // 
            // lbl_agree
            // 
            lbl_agree.Anchor = AnchorStyles.None;
            lbl_agree.AutoSize = true;
            lbl_agree.Location = new Point(577, 210);
            lbl_agree.Name = "lbl_agree";
            lbl_agree.Size = new Size(38, 15);
            lbl_agree.TabIndex = 5;
            lbl_agree.Text = "label4";
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.None;
            btn_back.Location = new Point(459, 245);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 6;
            btn_back.Text = "button1";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_next
            // 
            btn_next.Anchor = AnchorStyles.None;
            btn_next.Location = new Point(540, 245);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(75, 23);
            btn_next.TabIndex = 7;
            btn_next.Text = "button2";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += bnt_next_Click;
            // 
            // Frm_assessment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(859, 451);
            Controls.Add(btn_next);
            Controls.Add(btn_back);
            Controls.Add(lbl_agree);
            Controls.Add(lbl_disagree);
            Controls.Add(trckbr_VAS);
            Controls.Add(lbl_symptom);
            Controls.Add(lbl_Text);
            Controls.Add(progressBar1);
            MaximumSize = new Size(875, 490);
            MinimumSize = new Size(875, 490);
            Name = "Frm_assessment";
            Text = "Testung";
            FormClosing += Frm_assessment_FormClosing;
            Load += Frm_assessment_Load;
            ((System.ComponentModel.ISupportInitialize)trckbr_VAS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lbl_Text;
        private Label lbl_symptom;
        private TrackBar trckbr_VAS;
        private Label lbl_disagree;
        private Label lbl_agree;
        private Button btn_back;
        private Button btn_next;
    }
}