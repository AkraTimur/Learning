using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachines
{/// <summary>
/// VendingMachine — базовый класс для всех торговых автоматов. Он содержит код продажи товаров, но сами товары не определяются. 
/// Метод для проверки того, внес ли покупатель правильную сумму, всегда возвращает false. Почему? Потому, что он будет реализован в субклассе.
/// </summary>
    internal class VendingMachine // базовый класс
    {
        public virtual string Item { get; }
        protected virtual bool CheckAmount (decimal money)
        {
            return false;
        }
        public string Dispense(decimal money)
        {
            if (CheckAmount(money))
            {
                return Item;
            }
            else
            {
                return "Please enter the right amount";
            }
        }
    }
}
