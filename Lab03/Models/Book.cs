namespace Lab03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [Required(ErrorMessage ="ID không được để trống")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required(ErrorMessage ="Tiêu đề không được để trống")]
        [StringLength(100, ErrorMessage ="Tiêu đề không quá 100 kí tự" )]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nội dung không được để trống")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(30, ErrorMessage = "Tác giả không quá 30 kí tự")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Hình ảnh không được để trống")]
        [StringLength(255)]
        public string Images { get; set; }

        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(1000, 1000000, ErrorMessage = "Giá sách từ 1000 đến 1000000")]
        public int Price { get; set; }
    }
}
