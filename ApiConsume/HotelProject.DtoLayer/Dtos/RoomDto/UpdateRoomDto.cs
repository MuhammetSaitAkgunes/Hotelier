using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarasını yazınız.")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görseli ekleyiniz.")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığını belirtiniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen oda yatak sayısını giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen oda banyo sayısını giriniz.")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen oda açıklaması yazınız.")]
        public string Description { get; set; }
    }
}
