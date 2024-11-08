using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о приоритетных заказах.
    /// </summary>
    internal class PriorityOrder : Order
    {
        /// <summary>
        /// Возвращает и задает желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate { get; set; }
        /// <summary>
        /// Возвращает и задает желаемое время доставки.
        /// </summary>
        public DeliveryTimeRange DesiredDeliveryTime { get; set; }
        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>
        /// </summary>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки.</param>
        /// <param name="desiredDeliveryTime">Желаемое время доставки.</param>
        public PriorityOrder (Address address, List<Item> items, bool isId) : base (address, items, isId)
        {
            DesiredDeliveryDate = DateTime.MaxValue;
            DesiredDeliveryTime = 0;
        }
        public PriorityOrder(bool isID) : base (isID) { }

    }
}
