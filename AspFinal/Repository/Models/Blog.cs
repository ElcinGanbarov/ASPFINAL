﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Blog : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(100)]
        public string Experience { get; set; }
        [Required]
        [MaxLength(100)]
        public string ActionText { get; set; }
        public IEnumerable<BlogText> BlogTexts { get; set; }

    }
}
