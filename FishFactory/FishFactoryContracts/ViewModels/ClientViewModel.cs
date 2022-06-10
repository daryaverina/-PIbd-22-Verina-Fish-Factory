using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.Attributes;

namespace FishFactoryContracts.ViewModels
{
    public class ClientViewModel
    {
        [Column(title: "Номер", width: 50)]
        public int Id { get; set; }

        [Column(title: "Клиент", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ClientFIO { get; set; }

        [Column(title: "Логин", width: 150)]
        public string Login { get; set; }

        [Column(title: "Пароль", width: 100)]
        public string Password { get; set; }
    }
}