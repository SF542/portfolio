<?php
    //задаем параметры для подключения к бд 
    $serverName = "localhost";
    $dbName = "project1";
    $userName = "root";
    $password = "";

    // Создаем соединение с бд
    $pdo = new PDO("mysql:host=$serverName;dbname=$dbName", $userName, $password);
?>