using System;
using System.Text;
using System.Collections.Generic;
using FishFactoryContracts.Attributes;


namespace FishFactoryContracts.ViewModels
{
    /// Изделие, изготавливаемое в магазине
    public class CannedViewModel
    {
        [Column(title: "Номер", width: 50)]
        public int Id { get; set; }
        [Column(title: "Название консервы", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string CannedName { get; set; }
        [Column(title: "Цена", gridViewAutoSize: GridViewAutoSize.Fill)]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> CannedComponents { get; set; }
    }
}
