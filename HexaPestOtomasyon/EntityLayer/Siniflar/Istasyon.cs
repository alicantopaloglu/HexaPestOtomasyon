﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class Istasyon
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        [Required]
        public string anaBolge { get; set; }
        public ICollection<IstasyonAlt> IstasyonAlts { get; set; }
        public bool aktif { get; set; }


        public int projeID { get; set; }
        public virtual Proje proje { get; set; }
        public ICollection<KemirgenKontrol> kemirgenKontrols { get; set; }
    }
}
