using System;

namespace GmcRestServicesClient.Models
{
    public class ChildImage
    {
        public string EntityKey { get; set; }

        public string EntityType { get; set; }

        public string ImageType { get; set; }

        public bool HasImage { get; set; }

        public ChildImageData Image { get; set; }

        public int LeftCoordinate { get; set; }

        public int TopCoordinate { get; set; }

        public int WidthCoordinate { get; set; }

        public int HeightCoordinate { get; set; }
	}

    public class ChildImageData
    {
        public int Dpi { get; set; }

		public int Quality { get; set; }

		public string ImageFormat { get; set; }

		public int Width { get; set; }

		public int Height { get; set; }

        public string ImageData { get; set; }

        public byte[] ImageDataBytes { get { return Convert.FromBase64String(ImageData); } }
    }
}