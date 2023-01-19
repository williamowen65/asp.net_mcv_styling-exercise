namespace ModelBindingStyling_Lab.Models
{
    /// <summary>
    /// Represents an individual 3D printer
    /// </summary>
    public class ThreeDPrinters
    {
        /// <summary>
        /// Stock Keeping Unit identifier
        /// </summary>
        public string SKU { get; set; } = null!;

        /// <summary>
        /// Title of the printer product
        /// </summary>
        public string Title { get; set; } = null!;

        /// <summary>
        /// Sale price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Build volume that can be printed
        /// ex. 180 x 180 x 180 mm
        /// </summary>
        public string BuildVolume { get; set; } = null!;

        /// <summary>
        /// Product image of the printer
        /// </summary>
        public string PrinterImage { get; set; } = "https://via.placeholder.com/300";
    }
}
