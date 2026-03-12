namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CatchButten_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수생성기준비
            Random rd = new Random();

            // 2. 가용영역계산 (버튼이폼테두리에걸리지않게보호)
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;

            // 3. 랜덤좌표추출 (0 ~ 최대가용치사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            // 4. 랜덤 위치할당 (새로운Point 객체생성)
            CatchButten.Location = new Point(nextX, nextY);

            // 5. 시각적 피드백(폼 제목표시줄에 좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }
    }
}
