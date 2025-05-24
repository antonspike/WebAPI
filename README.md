# Web API для PostgreSQL
REST API, созданный на ASP .NET Core, для управления клиентами и их заказами.
## Функциональность 
* Работа с PostgreSQL
* CRUD для таблиц клиентов и заказов
* Получение данных из таблиц клиентов и заказов с фильтрацией и пагинацией
* Dependency Injection
* Документация через Swagger
## Используемые технологии
* .NET 8.0
* ASP .NET Core 8.0
* Entity Framework Core 9.0.4
* Npgsql для работы с PostgreSQL
* Swagger
* Встроенный DI-контейнер ASP .NET Core
* xUnit тесты
## Запуск проекта
1. Отредактируйте строку подключения к серверу PostgreSQL в файле ```appsettings.json```:
   ```json
   "ConnectionStrings": {
    "DefaultConnection": "Host=<host>;Port=<port>;Database=<database name>;Username=<yours username>;Password=<yours password"
   }
   ```
2. Установите зависимости (если не установлены):
   ```bash
   dotnet restore
   ```
3. Установите необходимые для миграции базы данных инструменты:
   ```bash
   dotnet tool install --global dotnet-ef
   ```
4. Примените миграции:
   ```bash
   dotnet ef database update
   ```
5. Запустите проект:
   ```bash
   dotnet run --project API
   ```
## Поддерживаемые запросы
- Clients
  - ``` GET/api/Clients ``` - Вывод списка клиентов
  - ``` GET/api/Clients/{id} ``` - Вывод информации о клиенте по его ID
  - ``` GET/api/Clients/filtered ``` - Вывод списка клиентов с заданным фильтром (с пагинацией)
  - ``` POST/api/Clients ``` - Добавление нового клиента
  - ``` PUT/api/Clients/{id} ``` - Редактировние информации о клиенте по его ID
  - ``` DELETE/api/Clients/{id} ``` - Удаление клиента по его ID
- Orders
  - ``` GET/api/Orders ``` - Вывод списка заказов
  - ``` GET/api/Orders/{id} ``` - Вывод информации о заказе по его ID (с информацией о клиенте или без неё)
  - ``` GET/api/Orders/filtered ``` - Вывод списка заказов с заданным фильтром (с пагинацией)
  - ``` GET/api/Orders/total-cost-of-birthday-orders ``` - Получение списка сумм заказов со статусом «Выполнен» по каждому клиенту, произведенных в день рождения клиента
  - ``` GET/api/Orders/average-costs-by-hour ``` - Получение списка часов в порядке убывания со средним чеком заказов за каждый час
  - ``` POST/api/Orders ``` - Создание нового заказа
  - ``` PUT/api/Orders/{id} ``` - Редактирование заказа по его ID
  - ``` DELETE/api/Orders/{id} ``` - Удаление заказа по его ID
## Тесты
- Все методы контроллеров протестированы через Unit-тесты (проект Tests)
