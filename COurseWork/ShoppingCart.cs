using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COurseWork
{
    public class CartItem
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public static class ShoppingCart
    {
        public static List<CartItem> Items { get; private set; } = new List<CartItem>();

        // Додавання книги до кошика
        public static void AddProduct(int bookId, string title, decimal price)
        {
            // Перевірка, чи така книга вже є в кошику
            var existingItem = Items.Find(i => i.BookId == bookId);
            if (existingItem != null)
            {
                existingItem.Quantity++; // Якщо є - збільшуємо кількість
            }
            else
            {
                // Якщо немає - додаю як новий рядок
                Items.Add(new CartItem { BookId = bookId, Title = title, Price = price, Quantity = 1 });
            }
        }
        public static decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }

        // Очищення кошика після оформлення замовлення
        public static void Clear()
        {
            Items.Clear();
        }

    }

}
