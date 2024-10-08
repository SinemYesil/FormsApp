﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models;
public class Product
{
    [Display(Name="Ürün Id")]
    public int ProductId { get; set; }
    [Display(Name="Ürün Adı")]
    [StringLength(100)]
    [Required]
    public string Name { get; set; } = string.Empty;
    [Display(Name="Ürün Fiyat")]
    public decimal Price { get; set; }
    [Display(Name="Ürün Resmi")]
    public string Image { get; set; }= string.Empty;
    public bool IsActive { get; set; }
    [Display(Name="Kategori")]
    public int CategoryId { get; set; }
}