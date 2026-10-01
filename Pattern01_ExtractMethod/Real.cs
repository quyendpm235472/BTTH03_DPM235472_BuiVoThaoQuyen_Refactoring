using System;
using System.Collections.Generic;

namespace Pattern01_ExtractMethod
{
    public class Real
    {
        public class OrderItem
        {
            public string ProductName { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public OrderItem(string name, double price, int quantity)
            {
                ProductName = name;
                Price = price;
                Quantity = quantity;
            }
        }

        public class InvoiceService
        {
            public void ExportInvoice(string customerName, List<OrderItem> items, double discountRate)
            {
                PrintHeader();
                PrintCustomerInfo(customerName);

                double totalAmount = CalculateTotalAmount(items, discountRate);

                PrintInvoiceDetails(items);
                PrintFooter(totalAmount);
            }

            private void PrintHeader()
            {
                Console.WriteLine("========================================");
                Console.WriteLine("       SIÊU THỊ WINMART - HÓA ĐƠN       ");
                Console.WriteLine("========================================");
            }

            private void PrintCustomerInfo(string customerName)
            {
                Console.WriteLine($"Khách hàng: {customerName}");
                Console.WriteLine($"Ngày lập: {DateTime.Now:dd/MM/yyyy HH:mm}");
                Console.WriteLine("----------------------------------------");
            }

            private double CalculateTotalAmount(List<OrderItem> items, double discountRate)
            {
                double subTotal = 0;
                foreach (var item in items)
                {
                    subTotal += item.Price * item.Quantity;
                }
                return subTotal * (1 - discountRate);
            }

            private void PrintInvoiceDetails(List<OrderItem> items)
            {
                Console.WriteLine("Danh sách sản phẩm:");
                foreach (var item in items)
                {
                    double itemTotal = item.Price * item.Quantity;
                    Console.WriteLine($"- {item.ProductName} (x{item.Quantity}): {itemTotal:N0} VNĐ");
                }
                Console.WriteLine("----------------------------------------");
            }

            private void PrintFooter(double finalTotal)
            {
                Console.WriteLine($"TỔNG TIỀN THANH TOÁN: {finalTotal:N0} VNĐ");
                Console.WriteLine("========================================");
                Console.WriteLine("  CẢM ƠN QUÝ KHÁCH & HẸN GẶP LẠI!  ");
                Console.WriteLine("========================================");
            }
        }
    }
}