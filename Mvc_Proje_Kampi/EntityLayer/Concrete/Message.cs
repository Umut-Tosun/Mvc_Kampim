﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace EntityLayer.Concrete
{
   public class Message
    {
        [Key]
        public int MessageID { get; set; }
        [StringLength(50)]
        public string SenderMail { get; set; }
        [StringLength(50)]
        public string RecevierMail { get; set; }
        [StringLength(50)]
        public string subject { get; set; }
        [StringLength(250)]
        [AllowHtml]
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
        public bool IsRead { get; set; }
    }
}
