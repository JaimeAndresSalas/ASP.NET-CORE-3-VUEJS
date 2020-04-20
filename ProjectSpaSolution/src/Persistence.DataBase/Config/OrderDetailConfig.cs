using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Config
{
    class OrderDetailConfig
    {
        private EntityTypeBuilder<OrderDetail> entityTypeBuilder;

        public OrderDetailConfig(EntityTypeBuilder<OrderDetail> entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }
    }
}
