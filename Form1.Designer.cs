namespace CatchButton
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
            CatchButten = new Button();
            RestartButton = new Button();
            SuspendLayout();
            // 
            // CatchButten
            // 
            CatchButten.Cursor = Cursors.Hand;
            CatchButten.Font = new Font("메이플스토리", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            CatchButten.ForeColor = Color.Blue;
            CatchButten.Location = new Point(340, 153);
            CatchButten.Name = "CatchButten";
            CatchButten.Size = new Size(199, 99);
            CatchButten.TabIndex = 0;
            CatchButten.Text = "나를 잡아봐";
            CatchButten.UseVisualStyleBackColor = true;
            CatchButten.Click += CatchButten_Click;
            CatchButten.MouseEnter += CatchButten_MouseEnter;
            CatchButten.MouseLeave += CatchButten_MouseLeave;
            // 
            // RestartButton
            // 
            RestartButton.Location = new Point(643, 303);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(94, 29);
            RestartButton.TabIndex = 1;
            RestartButton.Text = "재시도";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Click += RestartButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RestartButton);
            Controls.Add(CatchButten);
            Name = "Form1";
            Text = "술래잡기";
            ResumeLayout(false);
        }

        #endregion

        private Button CatchButten;
        private Button RestartButton;
    }
}
