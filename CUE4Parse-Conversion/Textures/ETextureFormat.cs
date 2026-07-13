using System.ComponentModel;

namespace CUE4Parse_Conversion.Textures
{
    public enum ETextureFormat
    {
        [Description("PNG")]
        Png,
        [Description("JPEG")]
        Jpeg,
        [Description("TGA")]
        Tga,
        [Description("TGA RLE-Compressed")]
        Tgac,
        [Description("DDS (Not Implemented)")]
        Dds
    }
}
