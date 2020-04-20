using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.DataBase.Config
{
    class OrderConfig
    {
        private EntityTypeBuilder<Order> entityTypeBuilder;

        public OrderConfig(EntityTypeBuilder<Order> entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }
    }
}
