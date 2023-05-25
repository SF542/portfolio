<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Project1</title>
    <link href="./css/regstyle.css" rel="stylesheet" type="text/css">
</head>
<body>
    <main class="main">
    <form method="post" class="form">
            <h1>
                Sign Up
            </h1>
            <br>  
            <input name="login" type="text" placeholder="Username">
            <br>
            <br>
            <input name="pwd" type="password" placeholder="Password">
            <br>
            <br>
            <input name="text" type="password" placeholder="Confirm Password">
            <br>
            <br>
            <input name="register" type="submit" class="btnsubmit" value="Submit">
            <input name="btn" type="submit" class="btnreset" value="Reset">
        </form>
    </main>
</body>
</html>

<?php   
    //нажатие на кнопку Регистрация
    if(isset($_POST["register"])){
        require "config.php";
        //Получение данных с полей input
        $login = $_POST["login"];
        $pwd = $_POST["pwd"];
        $pwd=md5($pwd);
        $request = "INSERT INTO users(login, password) VALUES (?,?)";

        $result=$pdo->prepare($request);
        $result->execute([$login, $pwd]);

        if($result) echo "<h1>Success</h1>";
        else echo "Error";
    }
?>