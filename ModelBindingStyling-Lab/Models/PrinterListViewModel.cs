namespace ModelBindingStyling_Lab.Models
{
    public class PrinterListViewModel
    {
        public required IEnumerable<ThreeDPrinters> Printers { get; set; }
        public required PrinterFilterViewModel Filter { get; set; }

        public int Count { get; set; }
    }
}