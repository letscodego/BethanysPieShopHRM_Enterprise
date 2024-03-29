﻿using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.UI.Services
{
    public interface IExpenseDataService
    {
        public Task<IEnumerable<Expense>> GetAllExpenses();
        public Task<Expense> GetExpenseById(int id);
        public Task<IEnumerable<Currency>> GetAllCurrencies();
        public Task<Expense> AddExpense(Expense editExpense);
        public Task UpdateExpense(Expense editExpense);
    }
}
