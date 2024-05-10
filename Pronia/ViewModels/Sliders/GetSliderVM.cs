using System.ComponentModel.DataAnnotations;

namespace Pronia.ViewModels.Slider
{
    public class GetSliderVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Subtitle { get; internal set; }
        public int Discount { get; set; }
        public string ImageUrl { get; set; }
    }
}
