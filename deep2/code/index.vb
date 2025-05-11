<!DOCTYPE html>
<html lang="ko">
<head>
  <meta charset="UTF-8">
  <title>앱 이름</title>
  <style>
    * {
      margin: 0;
      padding: 0;
      box-sizing: border-box;
    }

    body, html {
      height: 100%;
      font-family: sans-serif;
      display: flex;
      flex-direction: column;
    }

    header {
      display: flex;
      justify-content: space-between;
      align-items: center;
      padding: 10px 20px;
      border-bottom: 1px solid #ccc;
    }

    .login-btn {
      padding: 5px 10px;
    }

    main {
      flex: 1;
      display: flex;
      justify-content: center;
      align-items: center;
      padding: 40px 20px;
    }

    .left-panel, .right-panel {
      display: flex;
      flex-direction: column;
      gap: 15px;
    }

    .left-panel {
      margin-right: 100px;  /* 왼쪽 패널 좌우 간격*/
    }

    .right-panel {
      margin-left: 100px;  /* 오른쪽 패널 좌우 간격*/    
      justify-content: flex-start;
    }

    .left-panel button, .right-panel button {
      padding: 15px;
      border-radius: 12px;
      border: 1px solid #aaa;
      width: 160px;
      background-color: white;
      font-size: 14px;
      cursor: pointer;
    }

    .left-panel button .step {
      font-weight: bold;
      font-size: 18px;
      margin-bottom: 5px;
      display: block;
    }

    .camera {
      width: 240px;
      height: 340px;
      background: black;
    }

    .center-panel {
      display: flex;
      flex-direction: column;
      align-items: center;
      margin-top: 65px;
      gap: 10px;
    }

    .capture-btn {
      width: 60px;
      height: 60px;
      border-radius: 50%;
      background: #333;
      color: white;
      font-size: 24px;
      border: none;
      cursor: pointer;
    }

    footer {
      display: flex;
      justify-content: space-between;
      align-items: flex-end;
      padding: 10px 20px;
      border-top: 1px solid #ccc;
      font-size: 14px;
      background: #fff;
      position: fixed;
      bottom: 0;
      left: 0;
      width: 100%;
    }

    footer .right {
      text-align: right;
    }

    /*딜리트 위치 조정용 */
    .spacer {
      height: 222px; 
    }
  </style>
</head>
<body>

  <header>
    <div><strong>앱 이름</strong></div>
    <button class="login-btn">login</button>
  </header>

  <main>
    <div class="left-panel">
      <button>
        <span class="step">Step 1</span>
        로그인 후 화면에<br> 얼굴을 인식</br>
      </button>
      <button>
        <span class="step">Step 2</span>
        이모지 선택
      </button>
      <button>
        <span class="step">Step 3</span>
        촬영
      </button>
      <button>Gallery</button>
    </div>

    <div class="center-panel">
      <div class="camera"></div>
      <button class="capture-btn">★</button>
    </div>

    <div class="right-panel">
      <button style="margin-top: 0;">emoji</button>
      <div class="spacer"></div>
      <button>delete</button>
    </div>
  </main>

  <footer>
    <div>Baekseok University</div>
    <div class="right">
      made 곽재원<br>
      경채현
    </div>
  </footer>

</body>
</html>
