# SupermarketMS
Supermarket Manager System

Supermarket Management System - это веб-приложение для управления супермаркетом, разработанное с использованием технологий ASP.NET Core Blazor, Entity Framework, SQL Server и Identity. Приложение предоставляет возможность взаимодействия между администратором и кассиром, позволяя администратору создавать категории продуктов, добавлять определенные продукты в каждую категорию, указывать цены и доступное количество продуктов, а также генерировать отчеты о продажах за определенный период времени. Кассир же имеет возможность продавать товары с указанием количества.


Основные роли: Администратор и кассир.

ДОСТУП К АДМИНИСТРАТОРУ И КАССИРУ:

АДМИНИСТРАТОР :

логин: admin@mail.com

пароль: 113355ndE#


КАССИР: 

логин: Iamcashier@mail.com

пароль: 224466ndE#


Основные функции

Аутентификация и авторизация: Приложение предоставляет механизм аутентификации и авторизации с помощью ASP.NET Core Identity. Администратор и кассир могут создавать учетные записи и входить в систему с разными уровнями доступа.

Управление категориями продуктов: Администратор может создавать, редактировать и удалять категории продуктов. Каждая категория содержит определенные продукты.

Управление продуктами: В рамках каждой категории продуктов администратор может добавлять, редактировать и удалять конкретные продукты. При добавлении продукта необходимо указать цену и количество.

Продажи и отчеты: Кассир имеет возможность продавать продукты, выбирая категорию и указывая количество продуктов для продажи. Администратор может генерировать отчеты о продажах за определенный период времени, включающие информацию о продуктах, проданных количествах и общей стоимости.

Требования
Для успешного запуска приложения необходимо наличие следующих компонентов:

1. .NET Core SDK (версия 3.1 или выше)
2. SQL Server (или другая поддерживаемая база данных)
3. Веб-браузер (Google Chrome, Mozilla Firefox и т.д.)


Установка и настройка

1.Склонируйте репозиторий проекта на вашу локальную машину или скачайте его в виде ZIP-архива.

2.Откройте проект в вашей среде разработки (например, Visual Studio или Visual Studio Code).

3.Установите строку подключения к базе данных в файле appsettings.json. Убедитесь, что она указывает на вашу установку SQL Server или другую базу данных.

4.Откройте консоль пакетного менеджера (Package Manager Console) и выполните следующую команду, чтобы применить миграции Entity Framework и создать необходимые таблицы базы данных:
dotnet ef database update.

5.Запустите приложение , после откроется веб-браузер.
6.Логинитесь через админа или кассира по вышеуказанным данным.
