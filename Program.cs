using ConsoleCoffee.Funtions;
char op,ch;
string BASE_URL = "http://peterlyheng-001-site1.btempurl.com/";
do
{
    back:
    Console.WriteLine();
    Console.WriteLine("1.Menu");
    Console.WriteLine("2.Customer");
    Console.WriteLine("3.Order");
    Console.WriteLine("4.Item");
    Console.WriteLine("5.OrderItem");
    Console.WriteLine("6.Payment");
    Console.WriteLine("7.Exit");
    op = Console.ReadKey(true).KeyChar;
    switch (op)
    {
        case '1':
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Input  Menu");
                    Console.WriteLine("2.Ouput  Menu");
                    Console.WriteLine("3.Update Menu");
                    Console.WriteLine("4.Search Menu");
                    Console.WriteLine("5.Delete Menu");
                    Console.WriteLine("6.Back");
                    ch = Console.ReadKey(true).KeyChar;
                    switch (ch)
                    {
                        case '1':
                            {
                                Funtion.createMenu(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '2':
                            {
                                Funtion.getMenu(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '3':
                            {
                                Funtion.updateMenu(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '4':
                            {
                                Funtion.getSreachOrder(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '5':
                            {
                                Funtion.deleteMenu(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '6':
                            {
                                Console.WriteLine("-------------------[Order]------------------");
                                goto back;
                                break;
                            }
                        default:
                            Console.WriteLine("No Case in System");
                            break;
                    }
                }
                break;
            }
        case '2':
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Input  Customer");
                    Console.WriteLine("2.Ouput  Customer");
                    Console.WriteLine("3.Update Customer");
                    Console.WriteLine("4.Search Customer");
                    Console.WriteLine("5.Delete Customer");
                    Console.WriteLine("6.Back");
                    ch = Console.ReadKey(true).KeyChar;
                    switch (ch)
                    {
                        case '1':
                            {
                                Funtion.createCustomer(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '2':
                            {
                                Funtion.getCustomer(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '3':
                            {
                                Funtion.updateCustomer(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '4':
                            {
                                Funtion.getSreachCustomer(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '5':
                            {
                                Funtion.deleteCustomer(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '6':
                            {
                                Console.WriteLine("------------------[Customer]--------------------");
                                goto back;
                                break;
                            }
                        default:
                            Console.WriteLine("No Case in System");
                            break;
                    }
                }
                break;
            }
        case '3':
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Input  Order");
                    Console.WriteLine("2.Ouput  Order");
                    Console.WriteLine("3.Update Order");
                    Console.WriteLine("4.Search Order");
                    Console.WriteLine("5.Delete Order");
                    Console.WriteLine("6.Back");
                    ch = Console.ReadKey(true).KeyChar;
                    switch (ch)
                    {
                        case '1':
                            {
                                Funtion.createOrder(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '2':
                            {
                                Funtion.getOrder(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '3':
                            {
                                Funtion.updateOrder(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '4':
                            {
                                Funtion.getSreachOrder(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '5':
                            {
                                Funtion.deleteOrder(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '6':
                            {
                                Console.WriteLine("---------------------[Order]----------------------");
                                goto back;
                                break;
                            }
                        default:
                            Console.WriteLine("No Case in System");
                            break;
                    }
                }
                break;
            }
        case '4':
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Input  Item");
                    Console.WriteLine("2.Ouput  Item");
                    Console.WriteLine("3.Update Item");
                    Console.WriteLine("4.Search Item");
                    Console.WriteLine("5.Delete Item");
                    Console.WriteLine("6.Back");
                    ch = Console.ReadKey(true).KeyChar;
                    switch (ch)
                    {
                        case '1':
                            {
                                Funtion.createItem(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '2':
                            {
                                Funtion.getItem(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '3':
                            {
                                Funtion.updateItem(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '4':
                            {
                                Funtion.getSreachItem(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '5':
                            {
                                Funtion.deleteItem(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '6':
                            {
                                Console.WriteLine("---------------------[Item]-----------------------");
                                goto back;
                                break;
                            }
                        default:
                            Console.WriteLine("No Case in System");
                            break;
                    }
                }
                break;
            }
        case '5':
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Input  OrderItem");
                    Console.WriteLine("2.Ouput  OrderItem");
                    Console.WriteLine("3.Update OrderItem");
                    Console.WriteLine("4.Search OrderItem");
                    Console.WriteLine("5.Delete OrderItem");
                    Console.WriteLine("6.Back");
                    ch = Console.ReadKey(true).KeyChar;
                    switch (ch)
                    {
                        case '1':
                            {
                                Funtion.createOrderItem(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '2':
                            {
                                Funtion.getOrderItem(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '3':
                            {
                                Funtion.updateItem(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '4':
                            {
                                Funtion.getSreachOrderItem(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '5':
                            {
                                Funtion.deleteOrderItem(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '6':
                            {
                                Console.WriteLine("-----------------[OrderItem]-------------------");
                                goto back;
                                break;
                            }
                        default:
                            Console.WriteLine("No Case in System");
                            break;
                    }
                }
                break;
            }
        case '6':
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Input  Payment");
                    Console.WriteLine("2.Ouput  Payment");
                    Console.WriteLine("3.Update Payment");
                    Console.WriteLine("4.Search Payment");
                    Console.WriteLine("5.Delete Payment");
                    Console.WriteLine("6.Back");
                    ch = Console.ReadKey(true).KeyChar;
                    switch (ch)
                    {
                        case '1':
                            {
                                Funtion.createPayment(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '2':
                            {
                                Funtion.getPayment(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '3':
                            {
                                Funtion.updatePayment(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '4':
                            {
                                Funtion.getSreachPayment(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '5':
                            {
                                Funtion.deletePayment(BASE_URL);
                                Thread.Sleep(1000);
                                break;
                            }
                        case '6':
                            {
                                Console.WriteLine("-----------------[OrderItem]-------------------");
                                goto back;
                                break;
                            }
                        default:
                            Console.WriteLine("No Case in System");
                            break;
                    }
                }
                break;
            }
        case '7':
            System.Environment.Exit(0);
            break;
    }
} while (true);
