using System;
using System.Collections.Generic;

#nullable disable

namespace ErpDashboard.Application.Models
{
    public partial class TbSubscribtionOpertaion
    {
        public int Id { get; set; }
        public int SubscrbtionId { get; set; }
        public int CustomerId { get; set; }
        public int DayId { get; set; }
        public int DayNumber { get; set; }
        public int DeliveryAdress { get; set; }
        public string DriverName { get; set; }
        public int DriverId { get; set; }
        public int DeliverBranchId { get; set; }
        public string DeliverBranchName { get; set; }
        public int CustomerBranchId { get; set; }
        public string CustomerBranchName { get; set; }
        public string DayName { get; set; }
        public int DayState { get; set; }
        public string DayNotes { get; set; }
        public string CustomerNote { get; set; }
        public string DeliveryNote { get; set; }
        public int ComId { get; set; }
        public string CustomerName { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime PrintDate { get; set; }
        public string PlanExpression { get; set; }
        public int? MealId { get; set; }

        public virtual TbMeal Meal { get; set; }
        public virtual TbSubscrbtionHeader Subscrbtion { get; set; }
    }
}
