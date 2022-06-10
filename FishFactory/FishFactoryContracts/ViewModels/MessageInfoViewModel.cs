﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.Attributes;

namespace FishFactoryContracts.ViewModels
{
    public class MessageInfoViewModel
    {
        public string MessageId { get; set; }

        [Column(title: "Отправитель", width: 200)]
        public string SenderName { get; set; }

        [Column(title: "Дата письма", width: 110)]
        public DateTime DateDelivery { get; set; }

        [Column(title: "Заголовок", width: 150)]
        public string Subject { get; set; }

        [Column(title: "Текст", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string Body { get; set; }
    }
}