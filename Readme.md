# AИС "Бибилиотека"

👉 Среда разработки "Visual Studio 2010" СУБД "MSSQL manager 2008"

# ⛓ Описание физической модели
[Описание модель](https://github.com/zloisupport/Library_solution_for_D.N.B_/tree/master/sql)

## FAQ

❔︎Где дамп базы данных ?

✅Дамп БД находиться в папке sql/DumbDb(sql/dumbdb/*.*mdf)

❔Как подкл БД к проекту?

В файле  проекта app.config в строке  :

`connectionString="Data Source=Указать имя вашего сервера MSSQL;Initial Catalog=Библиотека;Integrated Security=True"`

К примеру :

 `connectionString="Data Source=USER-638D5FB763\MS_SQL_SERVER;Initial Catalog=Библиотека;Integrated Security=True"`
 
 