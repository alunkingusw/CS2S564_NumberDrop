namespace NumberDrop
{
    partial class frmDragDropCalculator
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
            lblNumOne = new Label();
            lblSubTarget = new Label();
            lblTotal = new Label();
            lblAddTarget = new Label();
            SuspendLayout();
            // 
            // lblNumOne
            // 
            lblNumOne.AutoSize = true;
            lblNumOne.FlatStyle = FlatStyle.Flat;
            lblNumOne.Font = new Font("Segoe UI", 16F);
            lblNumOne.Location = new Point(58, 90);
            lblNumOne.Name = "lblNumOne";
            lblNumOne.Size = new Size(25, 30);
            lblNumOne.TabIndex = 0;
            lblNumOne.Tag = "1";
            lblNumOne.Text = "1";
            lblNumOne.MouseDown += lblNumOne_MouseDown;
            // 
            // lblSubTarget
            // 
            lblSubTarget.AllowDrop = true;
            lblSubTarget.AutoSize = true;
            lblSubTarget.Font = new Font("Segoe UI", 16F);
            lblSubTarget.Location = new Point(344, 90);
            lblSubTarget.Name = "lblSubTarget";
            lblSubTarget.Size = new Size(93, 30);
            lblSubTarget.TabIndex = 1;
            lblSubTarget.Text = "Subtract";
            lblSubTarget.DragDrop += lblSubTarget_DragDrop;
            lblSubTarget.DragEnter += lblSubTarget_DragEnter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16F);
            lblTotal.Location = new Point(683, 90);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(25, 30);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "0";
            // 
            // lblAddTarget
            // 
            lblAddTarget.AllowDrop = true;
            lblAddTarget.AutoSize = true;
            lblAddTarget.Font = new Font("Segoe UI", 16F);
            lblAddTarget.Location = new Point(362, 147);
            lblAddTarget.Name = "lblAddTarget";
            lblAddTarget.Size = new Size(53, 30);
            lblAddTarget.TabIndex = 3;
            lblAddTarget.Text = "Add";
            lblAddTarget.DragDrop += lblAddTarget_DragDrop;
            lblAddTarget.DragEnter += lblAddTarget_DragEnter;
            // 
            // frmDragDropCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAddTarget);
            Controls.Add(lblTotal);
            Controls.Add(lblSubTarget);
            Controls.Add(lblNumOne);
            Name = "frmDragDropCalculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumOne;
        private Label lblSubTarget;
        private Label lblTotal;
        private Label lblAddTarget;
    }
}
