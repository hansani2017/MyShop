﻿namespace MyShopCore.Web.Api.Models
{
    public class Audit
    {
        public DateTimeOffset Creadte { get; set; }
        public DateTimeOffset Updated { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
