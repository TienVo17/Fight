using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduEcommerce.Attributes;

namespace TeduEcommerce.Configurations.ProductAttributes
{
    internal class ProductAtrributeConfiguration : IEntityTypeConfiguration<ProductAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            builder.ToTable(TeduEcommerceConsts.DbTablePrefix + "ProductAttribute");
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Code).HasMaxLength(50).IsUnicode(false).IsRequired();
            builder.Property(x=>x.Label).HasMaxLength(50).IsRequired();
        }
    }
}
