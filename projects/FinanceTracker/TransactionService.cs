//transactionService
using System.Text.Json;
using System.IO;
using System.Runtime.InteropServices;

namespace FinanceTracker
{
    class TransactionService
    {
        private List<Transaction> _transactions;
        private readonly string _filepath = "data.json";
        private void SaveToFile()
        {
            string json = JsonSerializer.Serialize(_transactions, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filepath, json);
        }
        private void LoadFromFile()
        {
            if(File.Exists(_filepath)){
                string json = File.ReadAllText(_filepath);
                var loaded = JsonSerializer.Deserialize<List<Transaction>>(json);
                if(loaded != null)
                {
                    _transactions = loaded;
                }
            }
        }
        public TransactionService()
        {
            _transactions = new List<Transaction>();
            this.LoadFromFile();
        }
        public void Add(Transaction transaction)
        {
            _transactions.Add(transaction);
            this.SaveToFile();
        }
        public decimal GetBalance()
        {
            decimal balance = 0;
            foreach (Transaction transaction in _transactions)
            {
                if (transaction.type == "income")
                {
                    balance += transaction.amount;
                }
                else
                {
                    balance -= transaction.amount;
                }
            }
            return balance;
        }
        public List<Transaction> GetAll()
        {
            return _transactions;
        }

    }
}