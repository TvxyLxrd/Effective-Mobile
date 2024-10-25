# Сервис доставки

## Описание
Приложение "Delivery Service" предназначено для фильтрации заказов на основе района и времени доставки. Оно загружает данные из файла CSV и записывает результаты в указанный файл.

## Требования
- .NET SDK (версия 8.0 или выше)
- Текстовый редактор или IDE (например, Visual Studio или Visual Studio Code)

## Настройка и конфигурация

1. **Клонирование репозитория**
   Сделайте клон репозитория на ваш локальный компьютер командой:
                    # git clone <URL_репозитория>
   
2. **Установка зависимостей**
Перейдите в директорию проекта и выполните команду для восстановления зависимостей командой:
                        # dotnet restore


3. **Подготовка файлов**
Убедитесь, что файл `orders.csv` находится в корневой директории проекта. Пример содержимого:

         1,11,Moscow,2024-10-23 13:33:00

        2,1,Moscow,2024-10-23 13:44:00

        1,5,Positano,2024-10-23 13:55:00

        3,6,SaintP,2024-10-23 14:00:00


4. **Запуск приложения**
Приложение запускается с помощью командной строки. Используйте следующий синтаксис:

         dotnet run <District> <FirstDeliveryTime> <LogFilePath> <ResultFilePath>
Пример:

        dotnet run Moscow "2024-10-23 13:30:00" log.txt result.txt

5. **Файлы логов и результатов**
- `LogFilePath` указывает файл, в который будут записываться логи приложения.
- `ResultFilePath` указывает файл, в который будут записаны отфильтрованные заказы.

## Примечания
- Убедитесь, что время доставки указано в формате `yyyy-MM-dd HH:mm:ss`.
- Если возникли ошибки, проверьте формат входных данных и наличие необходимых файлов.

## made by TvxyLxrd
