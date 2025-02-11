﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject
{
    public class RoomType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomTypeID { get; set; }
        [Required]
        [MaxLength(50)]
        public string RoomTypeName { get; set; }
        [Required]
        [MaxLength(500)]
        public string TypeDescription { get; set; }
        [Required]
        [MaxLength(100)]
        public string TypeNote { get; set; }

    }
}
