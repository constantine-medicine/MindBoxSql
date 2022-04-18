using MindBoxSql;

using (ApplicationContext db = new ApplicationContext())
{
    // создание и добавление моделей
    Category poethic = new Category { Name = "poethic" };
    Category guide = new Category { Name = "guide" };
    Category programming = new Category { Name = "programming" };
    db.Categories.AddRange(poethic, guide, programming);

    Product product1 = new Product { Name = "c# clrvia" };
    Product product2 = new Product { Name = "puskin" };
    Product product3 = new Product { Name = "pencil" };
    db.Products.AddRange(product1, product2, product3);



    // добавляем к студентам курсы
    product2.Categories.Add(poethic);
    product1.Categories.Add(guide);
    product1.Categories.Add(programming);
    db.SaveChanges();

    // Запрос
    //SELECT* FROM Products
    //INNER JOIN Categories
}