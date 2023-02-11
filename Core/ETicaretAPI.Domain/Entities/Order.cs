﻿using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order: BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; } //Orderın içinde bir den fazla product olabilir. many to many dir o yüzden Product entityde ICollection olarak tanımlanmıştır.

        public Customer Customer { get; set; } //Orderın sadece bir customerı olabilir
    }
}
