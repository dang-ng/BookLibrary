using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.WebMVC.Models;

public class Book
{
    public int Id { get; set; }
    [Required, DisplayName("Tiêu Đề")]
    public string Name { get; set; }
    [Required, DisplayName("Tác Giả")]
    public string Authors { get; set; }
    [Required, DisplayName("Nhà Xuất Bản")]
    public string Publisher { get; set; }
    [Required, Range(1990,int.MaxValue),DisplayName("Năm Xuất Bản")]
    public int Year { get; set; }
    [DisplayName("Tóm Tắt")]
    public string Description { get; set; }
    [DisplayName("File")]
    public string DataFile { get; set; }
}