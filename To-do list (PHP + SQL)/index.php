<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Project1</title>
    <link href="./css/style.css" rel="stylesheet" type="text/css">
</head>
<body>
    <main class="main">
        <form method="post" class="form">
            <h1>
                Login
            </h1>
            <br>  
            <input name="login" type="text" placeholder="Username">
            <br>
            <br>
            <input name="password" type="password" placeholder="Password">
            <br>
            <br>
            <!-- <a href="reg.php"> -->
            <input name="signIn" type="submit" class="btnlogin" value="Login">
            <!-- </a> -->
            <input name="btn" type="submit" class="btnsignup" value="SignUp">
        </form>
        <?php
            if(isset($_POST["signIn"]))
            {
                require "config.php";
                
                $login=$_POST["login"];
                $pwd=$_POST["password"];
                //запрос на получние данных из бд
                $request = "SELECT * FROM users WHERE login = ? AND password = ?";

                $result = $pdo->prepare($request);
                $result->execute([$login,$pwd]);
                //вывод полученных данных из бд
                if($row = $result->fetch()) echo "<h1>".$row["login"]."</h1>";
                else echo "error";
            }
            ?>
        </h2>
    </main>
</body>
</html>