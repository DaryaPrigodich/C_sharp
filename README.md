# TASK:

**Симулятор магазина.**

Создать коллекцию Users (покупателей), у которых есть возможность добавлять в корзину определенные товары.

Каждому покупателю присваиваем *passport id, name, age.*

Каждый товар имеет *name, category, barcode или id, price.*

Например:
id = 482,
name = “cheese”,
category = “milk products”,
price = 5$

Основные правила и ограничения:

 * Сгенерировать с помощью ***Bogus*** 5 пользователей с уже заполненными корзинами.
 * Вывести меню с возможностью:
   * Просмотреть всех покупателей.
   * Просмотреть товары определенного покупателя, с итоговой суммой всех товаров в корзине
   * Добавление нового покупателя с консоли:
       * При добавлении одного и того же человека (проверка на равенство по номеру паспорта, необходимо переопределить метод Equals и/или операторы равенства для сравнения объектов по номеру паспорта) элемент не добавляется, выдается сообщение.
   * Добавление/удаление товаров из корзины:
       * При добавлении в корзину пользователем age<18 лет алкоголя - информационное сообщение на консоли красным цветом.


Используйте ***LINQ***
