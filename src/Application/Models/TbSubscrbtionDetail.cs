using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbSubscrbtionDetail
    {
        public int Id { get; set; }
        public int SubscrbtionId { get; set; }
        public int CustomerId { get; set; }
        public int DeliveryAdress { get; set; }
        public int DriverId { get; set; }
        public int BranchId { get; set; }
        public int MealId { get; set; }
        public int MealTypeId { get; set; }
        public int DayId { get; set; }
        public string DayName { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int DayNumberCount { get; set; }
        public int PaymentsDetailsId { get; set; }
        public int LineState { get; set; }
        public int RelatedLineChange { get; set; }
        public string Sticker { get; set; }
        public int DeliveryStatus { get; set; }
        public string Notes { get; set; }
        public string DeliveryNotes { get; set; }
        public bool AutoDislikeMeal { get; set; }

        public virtual TbCustomerAdress DeliveryAdressNavigation { get; set; }
        public virtual TbDriver Driver { get; set; }
        public virtual TbMeal Meal { get; set; }
        public virtual TbMealsType MealType { get; set; }
        public virtual TbInvoicePaymentsHdr PaymentsDetails { get; set; }
        public virtual TbSubscrbtionHeader Subscrbtion { get; set; }
    }
}
