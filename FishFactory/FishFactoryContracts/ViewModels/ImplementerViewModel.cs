﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.Attributes;

namespace FishFactoryContracts.ViewModels
{
    public class ImplementerViewModel
    {
        [Column(title: "Номер", width: 50)]
        public int Id { get; set; }

        [Column(title: "Исполнитель", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ImplementerFIO { get; set; }

        [Column(title: "Время работы", width: 110)]
        public int WorkingTime { get; set; }

        [Column(title: "Время отдыха", width: 110)]
        public int PauseTime { get; set; }
    }
}