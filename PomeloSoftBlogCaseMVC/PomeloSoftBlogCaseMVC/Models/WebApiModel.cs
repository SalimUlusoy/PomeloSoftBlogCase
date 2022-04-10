using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PomeloSoftBlogCaseMVC.Models
{
    public class WebApiModel
    {
        public WebApiModel()
        {

        }
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public int? GirisSayisi { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
