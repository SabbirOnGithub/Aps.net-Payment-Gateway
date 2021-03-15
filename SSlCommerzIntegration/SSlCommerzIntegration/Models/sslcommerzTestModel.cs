namespace SSlCommerzIntegration.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class sslcommerzTestModel : DbContext
    {
        public sslcommerzTestModel()
            : base("name=sslcommerzTestModel")
        {
        }

        public virtual DbSet<PaymentLog> PaymentLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
