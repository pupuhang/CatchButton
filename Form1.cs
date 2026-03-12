namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 시작 시 리스타트 버튼 숨기기
            RestartButton.Visible = false;

            //버튼의 초기 크기/위치 저장
            frButtonSize = CatchButten.Size;
            frButtonLocation = CatchButten.Location;
        }
        //게임 기본 점수
        int score = 1000;

        //게임 목숨
        int HP = 20;

        // 초기 버튼 사이즈와 위치 저장
        private Size frButtonSize;
        private Point frButtonLocation;

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

            //놓쳤을 때 목숨감소
            HP -= 1;

            //목숨이 0이 되면 게임 오버 메세지 출력
            if (HP < 1)
            {
                MessageBox.Show("게임 오버");

                //게임 오버 시 버튼 비활성화   
                CatchButten.Enabled = false;

                // 리스타트 버튼 표시
                RestartButton.Visible = true;
            }
            //점수 표시 및 목숨 표시
            this.Text = "점수 : " + score + "남은 목숨:" + HP;
        }

        private void CatchButten_Click(object sender, EventArgs e)
        {
            // 잡았을 때 효과음 재생
            System.Media.SystemSounds.Exclamation.Play();

            //잡았을 때 축하메시지 출력
            MessageBox.Show("축하합니다~!");

            //잡았을 때 점수 증가
            score += 100;

            //점수 표시 및 목숨 표시
            this.Text = "점수 : " + score + "남은 목숨:" + HP;

            //클릭후 버튼 크기 감소
            CatchButten.Width = (int)(CatchButten.Width * 0.9);
            CatchButten.Height = (int)(CatchButten.Height * 0.9);
        }

        //게임 상태 초기화
        private void RestartButton_Click_1(object sender, EventArgs e)
        {
            // 초기값 복원
            score = 1000;
            HP = 20;

            // 버튼 활성화 및 크기/위치 초기화
            CatchButten.Enabled = true;
            CatchButten.Size = frButtonSize;
            CatchButten.Location = frButtonLocation;

            // 리스타트 버튼 숨기기
            RestartButton.Visible = false;

            // 점수 및 목숨 표시 갱신
            this.Text = "점수 : " + score + " 남은 목숨:" + HP;
        }
    }
}
