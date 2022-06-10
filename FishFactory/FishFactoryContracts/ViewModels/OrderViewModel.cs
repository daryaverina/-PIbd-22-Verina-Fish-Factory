using System;
using FishFactoryContracts.Attributes;

namespace FishFactoryContracts.ViewModels
{
    /// Заказ
    public class OrderViewModel
    {
        [Column(title: "Номер", width: 50)]
        public int Id { get; set; }
        public int CannedId { get; set; }
        public int ClientId { get; set; }
        public int? ImplementerId { get; set; }

        [Column(title: "Клиент", width: 200)]
        public string ClientFIO { get; set; }
        [Column(title: "Исполнитель", width: 100)]
        public string ImplementerFIO { get; set; }
        [Column(title: "Изделие", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string CannedName { get; set; }
        [Column(title: "Количество", width: 80)]
        public int Count { get; set; }
        [Column(title: "Сумма", width: 70)]
        public decimal Sum { get; set; }
        [Column(title: "Статус", width: 110)]
        public string Status { get; set; }
        [Column(title: "Дата создания", width: 110)]
        public DateTime DateCreate { get; set; }
        [Column(title: "Дата выполнения", width: 110)]
        public DateTime? DateImplement { get; set; }
    }
}
