namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //게임 기본 점수
        int score = 1000;

        private void CatchButten_MouseEnter(object sender, EventArgs e)
        {
            // 난수생성기준비
            Random rd = new Random();

            // 가용영역계산 (버튼 사이즈까지 고려해 테두리에 걸리지않게 함)
            int maxX = this.ClientSize.Width - CatchButten.Width;
            int maxY = this.ClientSize.Height - CatchButten.Height;

            // 랜덤좌표추출 (0 ~ 가용영역)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            // 랜덤 위치할당 (새로운 Point 객체생성)
            CatchButten.Location = new Point(nextX, nextY);

            // 시각적 피드백(폼 제목표시줄에 좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }

        private void CatchButten_MouseLeave(object sender, EventArgs e)
        {
            //놓쳤을 때 효과음 재생
            System.Media.SystemSounds.Hand.Play();

            //놓쳤을 때 점수감소
            score -= 10;

            //점수 표시
            this.Text = "점수 : " + score;
        }

        private void CatchButten_Click(object sender, EventArgs e)
        {
            // 잡았을 때 효과음 재생
            System.Media.SystemSounds.Exclamation.Play();

            //잡았을 때 축하메시지 출력
            MessageBox.Show("축하합니다~!");

            //잡았을 때 점수 증가
            score += 100;

            //점수 표시
            this.Text = "점수 : " + score;

        }
    }
}
