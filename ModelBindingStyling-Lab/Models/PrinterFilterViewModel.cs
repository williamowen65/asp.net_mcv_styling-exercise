using System.ComponentModel.DataAnnotations;

namespace ModelBindingStyling_Lab.Models
{
    public class PrinterFilterViewModel
    {
        public string SKU { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }

        [Display(Name ="Build Volume")]
        public string BuildVolume { get; set; }

        [Display(Name ="Print Image")]
        public string PrinterImage { get; set; }

       
    }
}
