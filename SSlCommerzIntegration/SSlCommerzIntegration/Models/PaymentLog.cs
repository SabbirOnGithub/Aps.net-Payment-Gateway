namespace SSlCommerzIntegration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentLog")]
    public partial class PaymentLog
    {
        public int PaymentLogID { get; set; }

        [StringLength(250)]
        public string tran_id { get; set; }

        public DateTime? tran_date { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        [StringLength(50)]
        public string val_id { get; set; }

        public decimal? amount { get; set; }

        public decimal? store_amount { get; set; }

        [StringLength(50)]
        public string currency { get; set; }

        [StringLength(50)]
        public string bank_tran_id { get; set; }

        [StringLength(50)]
        public string card_type { get; set; }

        [StringLength(50)]
        public string card_no { get; set; }

        [StringLength(50)]
        public string card_issuer { get; set; }

        [StringLength(50)]
        public string card_brand { get; set; }

        [StringLength(50)]
        public string card_issuer_country { get; set; }

        [StringLength(50)]
        public string card_issuer_country_code { get; set; }

        [StringLength(50)]
        public string currency_type { get; set; }

        public decimal? currency_amount { get; set; }

        public decimal? currency_rate { get; set; }

        public decimal? base_fair { get; set; }

        [StringLength(50)]
        public string value_a { get; set; }

        [StringLength(50)]
        public string value_b { get; set; }

        [StringLength(50)]
        public string value_c { get; set; }

        [StringLength(50)]
        public string risk_title { get; set; }

        public int? risk_level { get; set; }

        [StringLength(50)]
        public string APIConnect { get; set; }

        [StringLength(50)]
        public string validated_on { get; set; }

        [StringLength(50)]
        public string gw_version { get; set; }
    }
}
