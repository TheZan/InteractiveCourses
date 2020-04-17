# Interactive Courses

Interactive Courses - приложение для прохождения обучающих курсов.

# Описание
В проекте есть 2 программы. Courses - приложение для прохождения курсов пользователями. CoursesAdmin - приложение для администрирования системы курсов, есть возможность удаления/добавления/изменения курсов.
Пользователи проходят аутентификацию и получают доступ к списку курсов. После прохождения каждого курса пользователи получают достижения, которые отображаются в профиле.
Демонстрация работы программы:
![N|Solid](https://i.imgur.com/Yi0Y8kD.gif)
Демонстрация работы панели администратора:
![N|Solid](https://i.imgur.com/jUNkZwv.gif)
Скриншоты:
![N|Solid](https://i.imgur.com/JSQuJz1.png)
![N|Solid](https://i.imgur.com/NAjWiID.png)
![N|Solid](https://i.imgur.com/Ujk0Mrg.png)
![N|Solid](https://i.imgur.com/dGHjyHA.png)
![N|Solid](https://i.imgur.com/hDk9pJv.png)
![N|Solid](https://i.imgur.com/fAQOIqC.png)
### Инструкция
Используемое СУБД Microsoft SQL Server Express 2017.
Скрипт создания базы данных находится в проекте и называется Courses.sql.
Диаграмма базы данных:
![N|Solid](https://i.imgur.com/pUhkVyR.png)
Строка подключения к базе данных находится в файлах CoursesContext.cs:
Формат строки подключения:
![N|Solid](https://i.imgur.com/9ax0Q7m.png)
### Credits
* [MaterialDesignInXamlToolkit](https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit) - Material Design In XAML Toolkit
* [PBKDF2HashHelper](https://www.cyberforum.ru/post13828768.html) - Шифрование паролей