using System;

namespace MyApp{
    class BankAccount{
        private string _owner;
        private double _balance;

        public BankAccount(string owner, double balance)
        {
            _owner = owner;
            _balance = balance;
        }
        public void Show()
        {
            Console.WriteLine($"Баланс пользователя {this._owner}: {this._balance} рублей");
        }
        public void Deposit(double money)
        {
            this._balance += money;
            Console.WriteLine($"На счет внесено {money} рублей.Текущий баланс пользователя: {this._balance} рублей");
        }
        public void Withdraw(double money)
        {
            if (this._balance >= money)
            {
                this._balance -= money;
                Console.WriteLine($"Со счета снято {money} рублей.Текущий баланс пользователя: {this._balance} рублей");
            }
            else
            {
            Console.WriteLine($"Не удалось снять {money} рублей.Текущий баланс пользователя: {this._balance} рублей");
            }
        }
        
    }
    class program{
        static void Main(string[] args){
            var acc = new BankAccount("Василий", 500);
            acc.Deposit(500);
            acc.Show();
            acc.Withdraw(800);
        }
    }
}