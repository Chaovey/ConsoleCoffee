using CoffeeShop2.Models.Customers;
using CoffeeShop2.Models.Items;
using CoffeeShop2.Models.Menus;
using CoffeeShop2.Models.OrderItems;
using CoffeeShop2.Models.Orders;
using CoffeeShop2.Models.Payments;
using ConsoleCoffee.Results;
using RestClientLib;

namespace ConsoleCoffee.Funtions
{
    public class Funtion
    {
        //Menu
        public static async void createMenu(string BASE_URL)
        {
            Console.Write("Input MenuID:");
            var code = Console.ReadLine();
            Console.Write("Input Name:");
            var name = Console.ReadLine();
            Console.Write("Input Description:");
            var description = Console.ReadLine();
            Console.Write("Input Price:");
            var Price = Console.ReadLine();
            var result = new MenuCreateReq()
            {
                menuKey = code,
                Name = name,
                Description = description,
                Price = Convert.ToDouble(Price),
            };
            var enpoit = "api/menu";
            RestClient<MenuCreateReq> restClient = new(BASE_URL);
            var response = await restClient.PostAsync<MenuCreateReq, Result<string?>>(enpoit, result);
            var id = response!.Data;
            if (!string.IsNullOrEmpty(id))
                Console.WriteLine($"Successfully created a new menu with id, {id}");
            else
                Console.WriteLine($"Failed to create a new menu with id, {id}");
        }
        public static async void getMenu(string BASE_URL)
        {
            RestClient<MenuResponse> restClient = new RestClient<MenuResponse>(BASE_URL);
            var enpoit = "api/menu";
            var result = await restClient.GetAsync<Result<List<MenuResponse>>>(enpoit) ?? new();
            var all = result!.Data ?? new();
            var count = all.Count;
            Console.WriteLine($"Menu is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("Menu is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID : {item.Id}\n" +
                    $"MenuID : {item.menuCode}\n" +
                    $"Name : {item.Name}\n" +
                    $"Description : {item.Description}\n" +
                    $"Price : {item.Price}");
                Console.WriteLine();
            }
        }
        public static async void updateMenu(string BASE_URL)
        {
            Console.Write("Product Id/Code(required): ");
            var key = Console.ReadLine() ?? "";
            Console.Write("Input new MenuID:");
            var code = Console.ReadLine();
            Console.Write("Input new Name:");
            var name = Console.ReadLine();
            Console.Write("Input new Description:");
            var description = Console.ReadLine();
            Console.Write("Input new Price:");
            var price = Console.ReadLine();
            var result = new MenuUpdateReq()
            {
                Id = key,
                menuKey = code,
                Name = name,
                Description = description,
                Price = Convert.ToDouble(price),
            };
            var endpoint = "api/menu";
            RestClient<MenuUpdateReq> restClient = new RestClient<MenuUpdateReq>(BASE_URL);
            var response = await restClient.PutAsync<MenuUpdateReq, Result<string?>>(endpoint, result);
            if (response!.Data != null)
            {
                Console.WriteLine($"Successfully update the menu with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to update the menu with id/code, {key}");
            }
        }
        public static async void deleteMenu(string BASE_URL)
        {
            Console.Write("Menu Id: ");
            var key = Console.ReadLine() ?? "";
            var endpoint = $"api/menu/{key}";
            RestClient<MenuResponse> restClient = new(BASE_URL);
            var result = await restClient.DeleteAsync<Result<string>>(endpoint);
            if (result!.Data != null)
            {
                Console.WriteLine($"Successfully delete the menu with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to delete a menu with id/code, {key}");
            }
        }
        public static async void getSreachMenu(string BASE_URL)
        {
            Console.Write("Input Sreach:");
            var id = Console.ReadLine() ?? "";
            RestClient<MenuResponse> restClient = new RestClient<MenuResponse>(BASE_URL);
            var enpoit = "api/menu";
            var result = await restClient.GetAsync<Result<List<MenuResponse>>>(enpoit) ?? new();
            var all = result!.Data!.Where(p => p.menuCode.ToLower() == id.ToLower()).ToList() ?? new();
            var count = all.Count;
            Console.WriteLine($"Menu is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("Menu is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID : {item.Id}\n" +
                                    $"MenuID : {item.menuCode}\n" +
                                    $"Name : {item.Name}\n" +
                                    $"Description : {item.Description}\n" +
                                    $"Price : {item.Price}");
                Console.WriteLine();
            }
        }

        //Customer
        public static async void createCustomer(string BASE_URL)
        {
            Console.Write("Input CustomerID:");
            var code = Console.ReadLine();
            Console.Write("Input Name:");
            var name = Console.ReadLine();
            Console.Write("Input Phone:");
            var phone = Console.ReadLine();
            Console.Write("Input OrderHistory:");
            var orderH = Console.ReadLine();
            var result = new CustomerCreateReq()
            {
                customerKey = code,
                Name = name,
                Phone = phone,
                Order_history = Convert.ToInt32(orderH)
            };
            var enpoit = "api/customer";
            RestClient<CustomerCreateReq> restClient = new(BASE_URL);
            var response = await restClient.PostAsync<CustomerCreateReq, Result<string?>>(enpoit, result);
            var id = response!.Data;
            if (!string.IsNullOrEmpty(id))
                Console.WriteLine($"Successfully created a new customer with id, {id}");
            else
                Console.WriteLine($"Failed to create a new customer with id, {id}");
        }
        public static async void getCustomer(string BASE_URL)
        {
            RestClient<CustomerResponse> restClient = new RestClient<CustomerResponse>(BASE_URL);
            var enpoit = "api/customer";
            var result = await restClient.GetAsync<Result<List<CustomerResponse>>>(enpoit) ?? new();
            var all = result!.Data ?? new();
            var count = all.Count;
            Console.WriteLine($"customer is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("Customer is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID: {item.Id}\n" +
                  $"CustomerID: {item.customerCode}\n" +
                  $"Name: {item.Name}\n" +
                  $"Phone: {item.Phone}\n" +
                  $"OrderHistory :{item.Order_history}");
                Console.WriteLine();
            }
        }
        public static async void updateCustomer(string BASE_URL)
        {
            Console.Write("Product Id/Code(required): ");
            var key = Console.ReadLine() ?? "";
            Console.Write("Input new CustomerID:");
            var code = Console.ReadLine();
            Console.Write("Input new Name:");
            var name = Console.ReadLine();
            Console.Write("Input new Phone:");
            var phone = Console.ReadLine();
            Console.Write("Input new OrderHistory:");
            var orderH = Console.ReadLine();
            var result = new CustomerUpdateReq()
            {
                Id = key,
                customerKey=code,
                Name = name,
                Phone = phone,
                Order_history = Convert.ToInt32(orderH)
            };
            var endpoint = "api/customer";
            RestClient<CustomerUpdateReq> restClient = new RestClient<CustomerUpdateReq>(BASE_URL);
            var response = await restClient.PutAsync<CustomerUpdateReq, Result<string?>>(endpoint, result);
            if (response!.Data != null)
            {
                Console.WriteLine($"Successfully update the customer with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to update the customer with id/code, {key}");
            }
        }
        public static async void deleteCustomer(string BASE_URL)
        {
            Console.Write("Customer Id: ");
            var key = Console.ReadLine() ?? "";
            var endpoint = $"api/customer/{key}";
            RestClient<MenuResponse> restClient = new(BASE_URL);
            var result = await restClient.DeleteAsync<Result<string>>(endpoint);
            if (result!.Data != null)
            {
                Console.WriteLine($"Successfully delete the customer with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to delete a customer with id/code, {key}");
            }
        }
        public static async void getSreachCustomer(string BASE_URL)
        {
            Console.Write("Input Sreach:");
            var id = Console.ReadLine() ?? "";
            RestClient<CustomerResponse> restClient = new RestClient<CustomerResponse>(BASE_URL);
            var enpoit = "api/customer";
            var result = await restClient.GetAsync<Result<List<CustomerResponse>>>(enpoit) ?? new();
            var all = result!.Data!.Where(p => p.customerCode.ToLower() == id.ToLower()).ToList() ?? new();
            var count = all.Count;
            Console.WriteLine($"customer is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("Customer is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID: {item.Id}\n" +
                                  $"CustomerID: {item.customerCode}\n" +
                                  $"Name: {item.Name}\n" +
                                  $"Phone: {item.Phone}\n" +
                                  $"OrderHistory :{item.Order_history}");
                Console.WriteLine();
            }
        }

        //Order
        public static async void createOrder(string BASE_URL)
        {
            Console.Write("Input OrderID:");
            var code = Console.ReadLine();
            Console.Write("Input OrderStatus:");
            var orderstatus = Console.ReadLine();
            Console.Write("Input Price:");
            var price = Console.ReadLine();
            Console.Write("Input MenuID:");
            var menuid = Console.ReadLine();
            Console.Write("Input CustomerID:");
            var customerid = Console.ReadLine();
            var result = new OrderCreateReq()
            {
                orderKey=code,
                orderStatus=orderstatus,
                Price=Convert.ToDouble(price),
                MenuId=menuid,
                CustomerId=customerid,
            };
            var enpoit = "api/order";
            RestClient<OrderCreateReq> restClient = new(BASE_URL);
            var response = await restClient.PostAsync<OrderCreateReq, Result<string?>>(enpoit, result);
            var id = response!.Data;
            if (!string.IsNullOrEmpty(id))
                Console.WriteLine($"Successfully created a new order with id, {id}");
            else
                Console.WriteLine($"Failed to create a new order with id, {id}");
        }
        public static async void getOrder(string BASE_URL)
        {
            RestClient<OrderResponse> restClient = new RestClient<OrderResponse>(BASE_URL);
            var enpoit = "api/order";
            var result = await restClient.GetAsync<Result<List<OrderResponse>>>(enpoit) ?? new();
            var all = result!.Data ?? new();
            var count = all.Count;
            Console.WriteLine($"order is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("order is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID: {item.Id}\n" +
                                $"orderCode: {item.orderCode}\n" +
                                $"orderStatus: {item.orderStatus}\n" +
                                $"Price: {item.Price}\n" +
                                $"MenuId: {item.MenuId}\n" +
                                $"CustmerId: {item.CustomerId}");
                Console.WriteLine();
            }
        }
        public static async void updateOrder(string BASE_URL)
        {
            Console.Write("Input new ID:");
            var key = Console.ReadLine();
            Console.Write("Input new OrderID:");
            var code = Console.ReadLine();
            Console.Write("Input new OrderStatus:");
            var orderstatus = Console.ReadLine();
            Console.Write("Input new Price:");
            var price = Console.ReadLine();
            Console.Write("Input new MenuID:");
            var menuid = Console.ReadLine();
            Console.Write("Input new CustomerID:");
            var customerid = Console.ReadLine();
            var result = new OrderUpdateReq()
            {
                Id=key,
                orderKey= code,
                ordderStatus=orderstatus,
                Price=Convert.ToDouble(price),
                MenuId=menuid,
                CustomerId=customerid
            };
            var endpoint = "api/order";
            RestClient<OrderUpdateReq> restClient = new RestClient<OrderUpdateReq>(BASE_URL);
            var response = await restClient.PutAsync<OrderUpdateReq, Result<string?>>(endpoint, result);
            if (response!.Data != null)
            {
                Console.WriteLine($"Successfully update the order with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to update the order with id/code, {key}");
            }
        }
        public static async void deleteOrder(string BASE_URL)
        {
            Console.Write("Order Id: ");
            var key = Console.ReadLine() ?? "";
            var endpoint = $"api/order/{key}";
            RestClient<OrderResponse> restClient = new(BASE_URL);
            var result = await restClient.DeleteAsync<Result<string>>(endpoint);
            if (result!.Data != null)
            {
                Console.WriteLine($"Successfully delete the order with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to delete a order with id/code, {key}");
            }
        }
        public static async void getSreachOrder(string BASE_URL)
        {
            Console.Write("Input Sreach:");
            var id = Console.ReadLine() ?? "";
            RestClient<OrderResponse> restClient = new RestClient<OrderResponse>(BASE_URL);
            var enpoit = "api/order";
            var result = await restClient.GetAsync<Result<List<OrderResponse>>>(enpoit) ?? new();
            var all = result!.Data!.Where(p => p.orderCode.ToLower() == id.ToLower()).ToList() ?? new();
            var count = all.Count;
            Console.WriteLine($"Order is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("Customer is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID: {item.Id}\n" +
                                $"orderCode: {item.orderCode}\n" +
                                $"orderStatus: {item.orderStatus}\n" +
                                $"Price: {item.Price}\n" +
                                $"MenuId: {item.MenuId}\n" +
                                $"CustmerId: {item.CustomerId}");
                Console.WriteLine();
            }
        }

        //Item
        public static async void createItem(string BASE_URL)
        {
            Console.Write("Input ItemID:");
            var code = Console.ReadLine();
            Console.Write("Input Name:");
            var name = Console.ReadLine();
            Console.Write("Input Description:");
            var des = Console.ReadLine();
            Console.Write("Input Size:");
            var size = Console.ReadLine();
            var result = new ItemCreateReq()
            {
               itemKey=code,
               Name=name,
               Description=des,
               size=size
            };
            var enpoit = "api/item";
            RestClient<ItemCreateReq> restClient = new(BASE_URL);
            var response = await restClient.PostAsync<ItemCreateReq, Result<string?>>(enpoit, result);
            var id = response!.Data;
            if (!string.IsNullOrEmpty(id))
                Console.WriteLine($"Successfully created a new item with id, {id}");
            else
                Console.WriteLine($"Failed to create a new item with id, {id}");
        }
        public static async void getItem(string BASE_URL)
        {
            RestClient<ItemResponse> restClient = new RestClient<ItemResponse>(BASE_URL);
            var enpoit = "api/item";
            var result = await restClient.GetAsync<Result<List<ItemResponse>>>(enpoit) ?? new();
            var all = result!.Data ?? new();
            var count = all.Count;
            Console.WriteLine($"item is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("item is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID : {item.Id}\n" +
                    $"ItemCode : {item.itemCode}\n" +
                    $"Name : {item.Name}\n" +
                    $"Description : {item.Description}\n" +
                    $"Size : {item.size}");
                Console.WriteLine();
            }
        }
        public static async void updateItem(string BASE_URL)
        {
            Console.Write("Input new ID:");
            var key = Console.ReadLine();
            Console.Write("Input new ItemID:");
            var code = Console.ReadLine();
            Console.Write("Input new Name:");
            var name = Console.ReadLine();
            Console.Write("Input new Description:");
            var des = Console.ReadLine();
            Console.Write("Input new Size:");
            var size = Console.ReadLine();
            var result = new ItemUpdateReq()
            {
                Id = key,
                itemKey=code,
                Name = name,
                Description = des,
                size = size
            };
            var endpoint = "api/item";
            RestClient<ItemUpdateReq> restClient = new RestClient<ItemUpdateReq>(BASE_URL);
            var response = await restClient.PutAsync<ItemUpdateReq, Result<string?>>(endpoint, result);
            if (response!.Data != null)
            {
                Console.WriteLine($"Successfully update the item with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to update the item with id/code, {key}");
            }
        }
        public static async void deleteItem(string BASE_URL)
        {
            Console.Write("Item Id: ");
            var key = Console.ReadLine() ?? "";
            var endpoint = $"api/item/{key}";
            RestClient<OrderResponse> restClient = new(BASE_URL);
            var result = await restClient.DeleteAsync<Result<string>>(endpoint);
            if (result!.Data != null)
            {
                Console.WriteLine($"Successfully delete the item with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to delete a item with id/code, {key}");
            }
        }
        public static async void getSreachItem(string BASE_URL)
        {
            Console.Write("Input Sreach:");
            var id = Console.ReadLine() ?? "";
            RestClient<ItemResponse> restClient = new RestClient<ItemResponse>(BASE_URL);
            var enpoit = "api/item";
            var result = await restClient.GetAsync<Result<List<ItemResponse>>>(enpoit) ?? new();
            var all = result!.Data!.Where(p => p.itemCode.ToLower() == id.ToLower()).ToList() ?? new();
            var count = all.Count;
            Console.WriteLine($"Item is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("Customer is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID : {item.Id}\n" +
                    $"ItemCode : {item.itemCode}\n" +
                    $"Name : {item.Name}\n" +
                    $"Description : {item.Description}\n" +
                    $"Size : {item.size}");
                Console.WriteLine();
            }
        }


        //OrderItem
        public static async void createOrderItem(string BASE_URL)
        {
            Console.Write("Input OrderItemID:");
            var code = Console.ReadLine();
            Console.Write("Input Quantity:");
            var quan= Console.ReadLine();
            Console.Write("Input OrderID:");
            var order = Console.ReadLine();
            Console.Write("Input ItemID:");
            var item = Console.ReadLine();
            var result = new OrderItemCreateReq()
            {
                orderItemKey=code,
                quantity = Convert.ToInt32(quan),
                orderId=order,
                itemId =item,
            };
            var enpoit = "api/orderitem";
            RestClient<OrderItemCreateReq> restClient = new(BASE_URL);
            var response = await restClient.PostAsync<OrderItemCreateReq, Result<string?>>(enpoit, result);
            var id = response!.Data;
            if (!string.IsNullOrEmpty(id))
                Console.WriteLine($"Successfully created a new orderitem with id, {id}");
            else
                Console.WriteLine($"Failed to create a new orderitem with id, {id}");
        }
        public static async void getOrderItem(string BASE_URL)
        {
            RestClient<OrderItemResponse> restClient = new RestClient<OrderItemResponse>(BASE_URL);
            var enpoit = "api/orderitem";
            var result = await restClient.GetAsync<Result<List<OrderItemResponse>>>(enpoit) ?? new();
            var all = result!.Data ?? new();
            var count = all.Count;
            Console.WriteLine($"orderitem is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("orderitem is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID : {item.Id}\n" +
                    $"orderItemCode : {item.orderItemCode}\n" +
                    $"Quantity : {item.quantity}\n" +
                    $"OrderId : {item.orderId}\n" +
                    $"ItemId : {item.itemId}");
                Console.WriteLine();
            }
        }
        public static async void updateOrderItem(string BASE_URL)
        {
            Console.Write("Input new ID:");
            var key = Console.ReadLine();
            Console.Write("Input new OrderItemID:");
            var code = Console.ReadLine();
            Console.Write("Input new Quantity:");
            var quan = Console.ReadLine();
            Console.Write("Input new OrderID:");
            var order = Console.ReadLine();
            Console.Write("Input new ItemID:");
            var item = Console.ReadLine();
            var result = new OrderItemUpdateReq()
            {
                Id = key,
                orderItemKey=code,
                quantity=Convert.ToInt32(quan),
                orderId=order,
                itemId=item,
            };
            var endpoint = "api/orderitem";
            RestClient<OrderItemUpdateReq> restClient = new RestClient<OrderItemUpdateReq>(BASE_URL);
            var response = await restClient.PutAsync<OrderItemUpdateReq, Result<string?>>(endpoint, result);
            if (response!.Data != null)
            {
                Console.WriteLine($"Successfully update the orderitem with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to update the orderitem with id/code, {key}");
            }
        }
        public static async void deleteOrderItem(string BASE_URL)
        {
            Console.Write("Item Id: ");
            var key = Console.ReadLine() ?? "";
            var endpoint = $"api/orderitem/{key}";
            RestClient<OrderItemResponse> restClient = new(BASE_URL);
            var result = await restClient.DeleteAsync<Result<string>>(endpoint);
            if (result!.Data != null)
            {
                Console.WriteLine($"Successfully delete the item with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to delete a item with id/code, {key}");
            }
        }
        public static async void getSreachOrderItem(string BASE_URL)
        {
            Console.Write("Input Sreach:");
            var id = Console.ReadLine() ?? "";
            RestClient<OrderItemResponse> restClient = new RestClient<OrderItemResponse>(BASE_URL);
            var enpoit = "api/orderitem";
            var result = await restClient.GetAsync<Result<List<OrderItemResponse>>>(enpoit) ?? new();
            var all = result!.Data!.Where(p => p.orderItemCode.ToLower() == id.ToLower()).ToList() ?? new();
            var count = all.Count;
            Console.WriteLine($"orderitem is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("Customer is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID : {item.Id}\n" +
                    $"orderItemCode : {item.orderItemCode}\n" +
                    $"Quantity : {item.quantity}\n" +
                    $"OrderId : {item.orderId}\n" +
                    $"ItemId : {item.itemId}");
                Console.WriteLine();
            }
        }

        //Payment
        public static async void createPayment(string BASE_URL)
        {
            Console.Write("Input PyamentID:");
            var code = Console.ReadLine();
            Console.Write("Input PaymentAmount:");
            var Amount = Console.ReadLine();
            Console.Write("Input PaymentDate:"+DateTime.Now);
            var date = Console.ReadLine();
            Console.Write("Input CustomerID:");
            var customer = Console.ReadLine();
            Console.Write("Input OrderID:");
            var order = Console.ReadLine();
            var result = new PaymentCreateReq()
            {
                paymentKey=code,
                paymentAmount=Convert.ToDouble(Amount),
                paymentDate=Convert.ToDateTime(date),
                CustomerId= customer,
                orderId= order
            };
            var enpoit = "api/payment";
            RestClient<PaymentCreateReq> restClient = new(BASE_URL);
            var response = await restClient.PostAsync<PaymentCreateReq, Result<string?>>(enpoit, result);
            var id = response!.Data;
            if (!string.IsNullOrEmpty(id))
                Console.WriteLine($"Successfully created a new payment with id, {id}");
            else
                Console.WriteLine($"Failed to create a new payment with id, {id}");
        }
        public static async void getPayment(string BASE_URL)
        {
            RestClient<PaymentResponse> restClient = new RestClient<PaymentResponse>(BASE_URL);
            var enpoit = "api/payment";
            var result = await restClient.GetAsync<Result<List<PaymentResponse>>>(enpoit) ?? new();
            var all = result!.Data ?? new();
            var count = all.Count;
            Console.WriteLine($"payment is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("payment is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID : {item.Id}\n" +
                    $"paymentID : {item.paymentCode}\n" +
                    $"paymentAmount : {item.paymentAmount}\n" +
                    $"paymentDate : {item.paymentDate}\n" +
                    $"CustomerId : {item.CustomerId}\n" +
                    $"OrderId : {item.orderId}");
                Console.WriteLine();
            }
        }
        public static async void updatePayment(string BASE_URL)
        {
            Console.Write("Input new ID:");
            var key = Console.ReadLine();
            Console.Write("Input PyamentID:");
            var code = Console.ReadLine();
            Console.Write("Input PaymentAmount:");
            var Amount = Console.ReadLine();
            Console.Write("Input PaymentDate:" + DateTime.Now);
            var date = Console.ReadLine();
            Console.Write("Input CustomerID:");
            var customer = Console.ReadLine();
            Console.Write("Input OrderID:");
            var order = Console.ReadLine();
            var result = new PaymentUpdateReq()
            {
                Id = key,
                paymentKey=code,
                paymentAmount=Convert.ToDouble(Amount),
                paymentDate=Convert.ToDateTime(date),
                CustomerId=customer,
                orderId=order
            };
            var endpoint = "api/payment";
            RestClient<PaymentUpdateReq> restClient = new RestClient<PaymentUpdateReq>(BASE_URL);
            var response = await restClient.PutAsync<PaymentUpdateReq, Result<string?>>(endpoint, result);
            if (response!.Data != null)
            {
                Console.WriteLine($"Successfully update the payment with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to update the payment with id/code, {key}");
            }
        }
        public static async void deletePayment(string BASE_URL)
        {
            Console.Write("Payment Id: ");
            var key = Console.ReadLine() ?? "";
            var endpoint = $"api/payment/{key}";
            RestClient<PaymentResponse> restClient = new(BASE_URL);
            var result = await restClient.DeleteAsync<Result<string>>(endpoint);
            if (result!.Data != null)
            {
                Console.WriteLine($"Successfully delete the payment with id/code, {key}");
            }
            else
            {
                Console.WriteLine($"Failed to delete a payment with id/code, {key}");
            }
        }
        public static async void getSreachPayment(string BASE_URL)
        {
            Console.Write("Input Sreach:");
            var id = Console.ReadLine() ?? "";
            RestClient<PaymentResponse> restClient = new RestClient<PaymentResponse>(BASE_URL);
            var enpoit = "api/payment";
            var result = await restClient.GetAsync<Result<List<PaymentResponse>>>(enpoit) ?? new();
            var all = result!.Data!.Where(p => p.paymentCode.ToLower() == id.ToLower()).ToList() ?? new();
            var count = all.Count;
            Console.WriteLine($"payment is : {count}");
            Console.WriteLine();
            if (count == 0) Console.WriteLine("Customer is not Found");
            foreach (var item in all)
            {
                Console.WriteLine($"ID : {item.Id}\n" +
                    $"paymentID : {item.paymentCode}\n" +
                    $"paymentAmount : {item.paymentAmount}\n" +
                    $"paymentDate : {item.paymentDate}\n" +
                    $"CustomerId : {item.CustomerId}\n" +
                    $"OrderId : {item.orderId}");
                Console.WriteLine();
            }
        }
    }
}
