<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Дом на CSS</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="house">
        <div class="roof"></div>
        <div class="chimney"></div>
        <div class="base">
            <div class="window"></div>
            <div class="door"></div>
        </div>
    </div>
</body>
</html>

body {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    background-color: #87CEEB; /* Небесно-голубой фон */
    margin: 0;
}

.house {
    position: relative;
    width: 200px; /* Ширина дома */
}

.roof {
    width: 0;
    height: 0;
    border-left: 100px solid transparent; /* Левый треугольник */
    border-right: 100px solid transparent; /* Правый треугольник */
    border-bottom: 60px solid #8B4513; /* Цвет крыши */
}

.base {
    width: 200px;
    height: 120px; /* Высота дома */
    background-color: #FFD700; /* Цвет основания дома */
    position: relative;
}

.window {
    width: 50px;
    height: 50px;
    background-color: #87CEFA; /* Цвет окна */
    border-radius: 50%; /* Круглая форма окна */
    position: absolute;
    top: 30px; /* Расположение окна */
    left: 75px; /* Центрирование окна */
}

.door {
    width: 60px;
    height: 80px;
    background-color: #654321; /* Цвет двери */
    position: absolute;
    bottom: 0; /* Крепление к основанию */
    left: 70px; /* Центрирование двери */
}

.chimney {
    width: 30px;
    height: 70px;
    background-color: #8B4513; /* Цвет дымохода */
    position: absolute;
    top: -10px; /* Положение относительно крыши */
    right: 20px; /* Положение дымохода */
}
