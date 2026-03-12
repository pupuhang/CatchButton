# 버튼잡기게임(C# 코딩)
## 개요- C# 프로그래밍 학습
- 핵심기능: 마우스가 버튼 위로 올라갔을시 랜덤 좌표로 이동, 버튼 좌표 상단에 표시,버튼 클릭시 축하메세지 출력, 목숨 및 점수 구현, 재시작 구현
- 화면구성: "나를 잡아봐"버튼, 술래잡기 타이틀
## 실행화면
- 1단계 코드의 실행 스크린샷
- <img width="1709" height="913" alt="image" src="https://github.com/user-attachments/assets/aa1b99d1-d66a-45a0-809c-80371cf5aad0" />
커서가 "나를 잡아봐" 버튼에 올라가면 버튼이 화면 밖으로 나가지 않는 선에서 랜덤 좌표로 버튼이 이동함

- 2단계 코드의 실행 스크린샷
- <img width="1715" height="921" alt="image" src="https://github.com/user-attachments/assets/504ab25b-35ff-458e-bbd0-06b743c8b84c" />
버튼을 잡았을 떄 와 놓쳤을 때 사운드 추가 했으나 실습실 환경에선 사운드 출력할 수단이 없어 작동여부는 확인 불가했음 추후 확인 예정, 잡았을 때 축하 메세지를 출력함

- 3단계 코드의 실행 스크린샷
<img width="1712" height="921" alt="image" src="https://github.com/user-attachments/assets/9563cd8e-59bc-4335-aa9a-1cc09a72d159" />
<img width="1703" height="914" alt="image" src="https://github.com/user-attachments/assets/f74d43eb-71c0-4fa0-86e9-5999a7326499" />
기본 점수 1000점, 잡았을시 +100, 놓쳤을시-10으로 점수 구현, 한 번 잡으면 버튼 크기가 10%가 줄어들게 구현, 구현 확인을 편하게 하기 위해 임시로 랜덤 좌표를 (0,0)으로 고정 함

- 4단계 코드의 실행 스크린샷
<img width="1704" height="916" alt="image" src="https://github.com/user-attachments/assets/6a19fd1f-0004-403d-9431-224b73e23e14" />
시작시 재시작 버튼 숨김
<img width="1709" height="913" alt="image" src="https://github.com/user-attachments/assets/419316e9-5c8d-4b72-a7be-e129d46cd61d" />
목숨이 다 되어 게임 오버시 "나를 잡아봐" 버튼 비활성화 및 재시작 버튼 활성화

- ## 구현시 어려웠던 점
- 재시작 버튼을 비활성화 했다가 게임 오버시 나타는 기능을 구현하는 법을 몰라 힘들었다.(RestartButton.Visible = ;)로 구현
- 재시작시 초기값을 하드코딩으로 하지 않고 저장 시켰다가 재시작시 불러오는 기능를 구현하는데 어려움이 있었다.(frButtonSize = CatchButten.Size;)를 사용해 초기 값을 frButtonSize에 저장하고 불러올 때 frButtonSize의 값을 불러옴
