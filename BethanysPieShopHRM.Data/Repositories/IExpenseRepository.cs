using BethanysPieShopHRM.Shared;
using System.Collections.Generic;

namespace BethanysPieShopHRM.Api.Models
{
    public interface IExpenseRepository
    {
        public IEnumerable<Expense> GetAllExpenses();
        public Expense GetExpenseById(int id);
        Expense UpdateExpense(Expense expense);
        Expense AddExpense(Expense expense);
    }
}
