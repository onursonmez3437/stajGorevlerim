using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.siniflar
{
	public class Nedir
	{
		[Key]
		public int ID { get; set; }
		public string konu { get; set; }
		public string aciklama { get; set; }
        public string ekAciklama { get; set; }
        public int deger { get; set; }

    }
}