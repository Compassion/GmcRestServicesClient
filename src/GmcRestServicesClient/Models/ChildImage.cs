using System;

namespace GmcRestServicesClient.Models
{
    public class ChildImage
    {
        /// <summary>
        /// Same value that was in the Childkey in the request.
        /// </summary>
        public string EntityKey { get; set; }

        public string EntityType { get; set; }

        /// <summary>
        /// Image Type chosen by the customer or the default (headshot) if Image Type was not included in the input.
        /// </summary>
        public string ImageType { get; set; }

        public bool HasImage { get; set; }

        /// <summary>
        /// Image information and data.
        /// </summary>
        public ChildImageData Image { get; set; }

        /// <summary>
        /// Identifying the number of pixels from left side of the image to the top left corner of the child's headshot. Returned only if ImageType == Raw.
        /// </summary>
        public int LeftCoordinate { get; set; }

        /// <summary>
        /// Identifying the number of pixels from top of the image to the top left corner of the child's headshot. Returned only if ImageType == Raw.
        /// </summary>
        public int TopCoordinate { get; set; }

        /// <summary>
        /// The width of the child's headshot. Returned only if ImageType == Raw.
        /// </summary>
        public int WidthCoordinate { get; set; }

        /// <summary>
        /// The height of the child's headshot. Returned only if ImageType == Raw.
        /// </summary>
        public int HeightCoordinate { get; set; }

        /// <summary>
        /// The date the image was stored in GMCCompass database.
        /// </summary>
        public DateTime ImageDate { get; set; }
	}

    public class ChildImageData
    {
        /// <summary>
        /// DPI chosen by the customer. This field is not included if the DPI was not included in the input.
        /// </summary>
        public int Dpi { get; set; }

        /// <summary>
        /// Quality chosen by the customer.
        /// </summary>
		public int Quality { get; set; }

        /// <summary>
        /// Image format chosen by the customer or the default (jpeg) if the Image Format was not included in the input.
        /// </summary>
		public string ImageFormat { get; set; }

        /// <summary>
        /// Width chosen by the customer. This field is not included if the width was not included in the input.
        /// </summary>
		public int Width { get; set; }

        /// <summary>
        /// Height chosen by the customer. This field is not included if  the height was not included in the input.
        /// </summary>
		public int Height { get; set; }

        /// <summary>
        /// Child image data encoded in Base64.
        /// </summary>
        public string ImageData { get; set; }

        /// <summary>
        /// Decoded ImageData as a byte array, suitable for writing out to a file, etc. 
        /// </summary>
        public byte[] ImageDataBytes { get { return Convert.FromBase64String(ImageData); } }
    }
}