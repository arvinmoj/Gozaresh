using System;
using System.ComponentModel.DataAnnotations;

namespace My_Application.Models
{
    public class DataGet
    {
        public DataGet()
        {
        }

        [Key]
        public Guid Id { get; set; }


        [Display(Name = "کد")]
        public string Code { get; set; }


        [Display(Name = "نام")]
        public string Name { get; set; }


        [Display(Name = "تاریخ")]
        public string DateTime { get; set; }

        [Display(Name = "سال فصل")]
        public string YearSeason { get; set; }

        [Display(Name = "شماره قرار داد")]
        public string ContractNumber { get; set; }

        [Display(Name = "تعداد قرار داد")]
        public string ContractCount { get; set; }

        [Display(Name = "تعداد بدون قرار داد")]
        public string NoContractCount { get; set; }

        [Display(Name = "شماره فاکتور")]
        public string InvoiceNumber { get; set; }

        [Display(Name = "عداد")]
        public string Count { get; set; }

        [Display(Name = "فی فروش")]
        public string PerSale { get; set; }

        [Display(Name = "خالص فروش")]
        public string NetSales { get; set; }

        [Display(Name = "تخفیف")]
        public string Discount { get; set; }

        [Display(Name = "فروش باارزش افزوده")]
        public string SalesTax { get; set; }

        [Display(Name = "تعداد برگشتی")]
        public string ReturnedCount { get; set; }

        [Display(Name = "مبلغ برگشتی")]
        public string RefundAmount { get; set; }

        [Display(Name = "مبلغ دریافتی")]
        public string ReceivedMoney { get; set; }

    }
} 