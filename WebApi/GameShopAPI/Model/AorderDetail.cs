using System;
using System.Collections.Generic;

#nullable disable

namespace Model
{
    public partial class AorderDetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ItemId { get; set; }
        public int? ItemAmount { get; set; }
        public decimal? Total { get; set; }

        public virtual AnItem Item { get; set; }
        public virtual Aorder Order { get; set; }
    }
}
