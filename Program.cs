using (ECommerceContext db = new ECommerceContext())
{
    //Inserimento prodotti
    Product product1 = new Product { Name = "Amaca"};
    Product product2 = new Product { Name = "Martello"};
    Product product3 = new Product { Name = "Mouse"};
    product1.Description = "Lorem ipsum";
    product2.Description = "Lorem ipsum";
    product3.Description = "Lorem ipsum";
    db.Add(product1);
    db.Add(product2);
    db.Add(product3);
    db.SaveChanges();
}