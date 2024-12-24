# MiniProject_windows_calculator
프로젝트 계획서
오하준, 강현준, 김예린, 김나연

목표 : 윈도우 표준 계산기
기능
  1. 사칙연산
    1) 덧셈
    2) 뺄셈
    3) 곱셈
    4) 나눗셈 : 0으로 나눌 경우 예외 처리 ("0으로 나눌 수 없습니다.")
     
  2. 단항 연산자
    1) 제곱
    2) 제곱근
    3) 음수 처리
     
  4. 숫자 버튼
    1) 0~9 버튼
    2) . 버튼 (소수점 표시)
     
  5. 지우기 기능
    1) C : 전체 지우기
    2) CE : 최근 항목 삭제
    3) Backspace : 마지막 숫자 제거
     
WinForms GUI 설계
  1. 텍스트 박스
    - 숫자 입력 및 결과 표시, 최근 항목 표시
  2. 버튼
    - 숫자 버튼 및 연산자, 지우기 버튼

파일 구조
Project/
  ├── Program.cs // 메인 실행 파일
  ├── MainForm.cs // WinForms GUI 설계 및 메인 로직
  ├── ArithmeticOperations.cs // 사칙연산 로직
  ├── UnaryOperations.cs // 단항 연산 로직 (제곱, 제곱근, 음수 처리 등)
  ├── NumberButtons.cs // 숫자 버튼 로직
  ├── ClearFunction.cs // 지우기 기능 로직
  
역할 분담:
- UI, 사칙연산 : 하준
- 숫자 버튼 0~9 : 현준
- 지우기(C, CE, 숫자 하나만 지움) : 나연
- %, 분수, 제곱, 루트, 음수, 소숫점 : 예린
