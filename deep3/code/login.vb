<!DOCTYPE html>
<html lang="ko">
<head>
  <meta charset="UTF-8">
  <title>login</title>
  <style>
    * {
      box-sizing: border-box;
      margin: 0;
      padding: 0;
    }

    body {
      font-family: Arial, sans-serif;
      background-color: #fff;
      display: flex;
      flex-direction: column;
      min-height: 100vh;
    }

    header {
      display: flex;
      justify-content: space-between;
      align-items: center;
      padding: 10px 20px;
      border-bottom: 1px solid #ccc;
    }

    main {
      flex: 1;
      display: flex;
      justify-content: center;
      align-items: center;
      padding: 40px 20px;
    }

    .login-box {
      width: 400px;
      padding: 40px;
      border: 1px solid #ddd;
      border-radius: 8px;
      box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
      text-align: center;
    }

    .login-box h2 {
      font-weight: normal;
      margin-bottom: 50px;
    }

    .login-box input[type="email"],
    .login-box input[type="password"] {
      width: 93.5%;
      padding: 12px;
      font-size: 16px;
      border: 1px solid #ccc;
      border-radius: 4px;
      margin-bottom: 8px;
    }

    .login-box a {
      display: block;
      text-align: left;
      font-size: 13px;
      margin-bottom: 25px;
      color: #1a73e8;
      text-decoration: none;
    }

    .login-box button {
      width: 100%;
      padding: 10px;
      font-size: 16px;
      background-color: #1a73e8;
      color: white;
      border: none;
      border-radius: 4px;
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
    }

    footer .right {
      text-align: right;
    }
  </style>
</head>
<body>

 
  <header>
    <div><strong>앱 이름</strong></div>
    <div></div> 
  </header>

  <main>
    <div class="login-box">
      <h2>login</h2>
      <input type="email" placeholder="아이디">
      <input type="password" placeholder="비밀번호">
      <button onclick="location.href='index.html'">다음</button>
      <a href="#">계정 만들기</a>
    </div>
  </main>

  <footer>
    <div>Baekseok University</div>
    <div class="right">
      made 곽재원<br>
      경채현
    </div>
  </footer>

  <script>
    function completeLogin() {
      if (window.opener && !window.opener.closed) {
        localStorage.setItem("loggedIn", "true");
        window.opener.location.reload();
      }
      window.close();
    }
  </script>

</body>
</html>
