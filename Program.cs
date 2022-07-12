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
    //Inserimento utenti
    Customer customer1 = new Customer();
    customer1.Name = "Giuseppe";
    customer1.Surname = "Mirizzi";
    customer1.Email = "giuseppe.m1995@gmail.com";
    Customer customer2 = new Customer();
    customer2.Name = "Yuto";
    customer2.Surname = "Nagatomo";
    customer2.Email = "a.yuto@gmail.com";
    db.Add(customer1);
    db.Add(customer2);
    //Inserimento ordini
    ////ordine 1
    Order order1 = new Order();
    order1.Customer = customer1;
    order1.CustomerId = customer1.CustomerId;
    order1.Status = "Effettuato";
    db.Add(order1);
    db.SaveChanges();
    OrderProduct orderProduct1 = new OrderProduct();
    orderProduct1.OrderId = order1.OrderId;
    orderProduct1.ProductId = product1.ProductId;
    db.Add(orderProduct1);
    order1.OrderProducts.Add(orderProduct1);
    product1.OrderProducts.Add(orderProduct1);
    ////ordine 2
    Order order2 = new Order();
    order2.Customer = customer1;
    order2.CustomerId = customer1.CustomerId;
    order2.Status = "Effettuato";
    db.Add(order2);
    db.SaveChanges();
    OrderProduct orderProduct2 = new OrderProduct();
    orderProduct2.OrderId = order2.OrderId;
    orderProduct2.ProductId = product3.ProductId;
    db.Add(orderProduct2);
    order2.OrderProducts.Add(orderProduct2);
    product3.OrderProducts.Add(orderProduct2);
    ////ordine 3
    Order order3 = new Order();
    order3.Customer = customer1;
    order3.CustomerId = customer1.CustomerId;
    order3.Status = "Effettuato";
    db.Add(order3);
    db.SaveChanges();
    OrderProduct orderProduct3 = new OrderProduct();
    orderProduct3.OrderId = order3.OrderId;
    orderProduct3.ProductId = product2.ProductId;
    db.Add(orderProduct3);
    order3.OrderProducts.Add(orderProduct3);
    product2.OrderProducts.Add(orderProduct3);
    ////ordine 4
    Order order4 = new Order();
    order4.Customer = customer2;
    order4.CustomerId = customer2.CustomerId;
    order4.Status = "Effettuato";
    db.Add(order4);
    db.SaveChanges();
    OrderProduct orderProduct4 = new OrderProduct();
    orderProduct4.OrderId = order4.OrderId;
    orderProduct4.ProductId = product1.ProductId;
    db.Add(orderProduct4);
    order4.OrderProducts.Add(orderProduct4);
    product1.OrderProducts.Add(orderProduct4);
    ////ordine 5
    Order order5 = new Order();
    order5.Customer = customer2;
    order5.CustomerId = customer2.CustomerId;
    order5.Status = "Effettuato";
    db.Add(order5);
    db.SaveChanges();
    OrderProduct orderProduct5 = new OrderProduct();
    orderProduct5.OrderId = order5.OrderId;
    orderProduct5.ProductId = product3.ProductId;
    db.Add(orderProduct5);
    order5.OrderProducts.Add(orderProduct5);
    product3.OrderProducts.Add(orderProduct5);
    db.SaveChanges();
}