using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ExpenseTracker.WebUI.Models;

public class Transaction
{
    [Key]
    public int TransactionId { get; set; }

    public int CategoryId { get; set; }

    [ForeignKey(nameof(CategoryId))]
    [ValidateNever]
    public Category Category { get; set; }

    public decimal Amount { get; set; }

    public string? Note { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
