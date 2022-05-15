using System;
using System.ComponentModel;

namespace FishFactoryContracts.ViewModels
{
    /// Заказ
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int CannedId { get; set; }
        public int ClientId { get; set; }
        public int? ImplementerId { get; set; }

        [DisplayName("ФИО клиента")]
        public string ClientFIO { get; set; }
        [DisplayName("ФИО исполнителя")]
        public string ImplementerFIO { get; set; }
        [DisplayName("Изделие")]
        public string CannedName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
        [DisplayName("Дата выполнения")]
        public DateTime? DateImplement { get; set; }
    }
}
