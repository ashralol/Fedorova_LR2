# ЛР 2. Вывод данных из БД через UserControl

Студент: Fedorova

Windows Forms (.NET Framework 4.7.2) + Entity Framework 6 (Code First из БД `MotorbikeDB`).
Записи таблицы `Table_Motorbike` показываются плитками (UserControl1 с картинкой и данными),
кнопки «<» и «>» листают список в обе стороны (методы `Loading()` и `Loading(bool)`).
Дополнительное задание: фильтр по марке и по максимальной цене.

Запуск:
1. Выполнить `MotorbikeDB.sql` в SQL Server (экземпляр `.\SQLEXPRESS`).
2. Открыть `Fedorova.sln` в Visual Studio 2022 (EntityFramework восстановится из NuGet).
3. Папка `Pictures` копируется в `bin\Debug` автоматически при сборке.
