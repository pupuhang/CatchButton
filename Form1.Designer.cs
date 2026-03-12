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
            SuspendLayout();
            // 
            // CatchButten
            // 
            CatchButten.Cursor = Cursors.Hand;
            CatchButten.Font = new Font("메이플스토리", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            CatchButten.ForeColor = Color.Blue;
            CatchButten.Location = new Point(340, 153);
            CatchButten.Name = "CatchButten";
            CatchButten.Size = new Size(131, 51);
            CatchButten.TabIndex = 0;
            CatchButten.Text = "나를 잡아봐";
            CatchButten.UseVisualStyleBackColor = true;
            CatchButten.MouseEnter += CatchButten_MouseEnter;
            CatchButten.MouseLeave += CatchButten_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CatchButten);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CatchButten;
    }
}
