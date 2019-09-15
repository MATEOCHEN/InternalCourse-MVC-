using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Windows.Markup;
using MoneyTemplate.Models.ViewModel;
using Type = System.Type;

namespace MoneyTemplate.Models
{
    public class BookKeeping
    {
        private readonly List<Account> _accountCollection;

        public BookKeeping(List<Account> accountCollectionCollection)
        {
            _accountCollection = accountCollectionCollection;
            Init();
        }

        public void Add(Account account)
        {
            _accountCollection.Add(account);
        }

        public List<Account> GetBookList()
        {
            return _accountCollection;
        }

        private void Init()
        {
            var random = new Random();
            for (int i = 0; i < 50; i++)
            {
                _accountCollection.Add(new Account
                {
                    Type = (ViewModel.Type)random.Next(1, 3),
                    Amount = random.Next(1000, 5000),
                    Date = new DateTime(2018, 8, 14).AddDays(random.Next(100)),
                    Remark = "Fake Data"
                });
            }
        }
    }
}