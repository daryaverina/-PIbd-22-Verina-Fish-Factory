using System;
using System.Collections.Generic;
using System.Text;
using FishFactoryContracts.Attributes;


namespace FishFactoryContracts.ViewModels
{
    /// Компонент, требуемый для изготовления изделия
    public class ComponentViewModel
    {
        public int Id { get; set; }
        [Column(title: "Название компонента", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ComponentName { get; set; }
    }
}
