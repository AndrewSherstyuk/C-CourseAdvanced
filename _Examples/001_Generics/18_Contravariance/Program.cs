using System;

/// <summary>
///  Контравариантность обобщений.
///  Контравариантность: позволяет использовать более универсальный тип, чем заданный изначально.
///  Для создания контравариантного интерфейса надо использовать ключевое слово in.
/// </summary>
namespace _18_Contravariance
{
    /// <summary>
    /// Класс Account - обычного счета
    /// </summary>
    class Account
    {
        /// <summary>
        /// Совершить перевод
        /// </summary>
        public virtual void DoTransfer(int sum)
        {
            Console.WriteLine(@"Клиент положил на счет {0} долларов", sum);
        }
    }

    /// <summary>
    /// Класс DepositAccountунаследован от обычного счета - Account
    /// </summary>
    class DepositAccount : Account
    {
        /// <summary>
        /// Переопределенный метод 
        /// </summary>
        public override void DoTransfer(int sum)
        {
            Console.WriteLine(@"Клиент положил на депозитный счет {0} долларов", sum);
        }
    }

    /// <summary>
    /// ITransaction - представляет условную банковскую операцию
    /// Ключевое слово in в определении интерфейса указывает, 
    /// что этот интерфейс - контравариантный
    /// </summary>
    interface ITransaction<in T>
    {
        /// <summary>
        /// Произвести операцию
        /// </summary>
        void DoOperation(T account, int sum);
    }

    /// <summary>
    /// Класс Transaction реализует этот интерфейс и реализует его метод DoOperation.
    /// </summary>
    class Transaction<T> : ITransaction<T> where T : Account
    {
        public void DoOperation(T account, int sum)
        {
            account.DoTransfer(sum);
        }
    }

    class Program
    {
        static void Main()
        {
            ITransaction<Account> accTransaction = new Transaction<Account>();
            accTransaction.DoOperation(new Account(), 400);

            // интерфейс ITransaction использует универсальный параметр с ключевым словом in, 
            // он является контравариантным, поэтому в коде мы можем объект Transaction<Account> 
            // привести к типу ITransaction<DepositAccount>:
            // Account -  более универсальный тип, чем указан изначально - DepositAccount

            ITransaction<DepositAccount> depAccTransaction = new Transaction<Account>();
            depAccTransaction.DoOperation(new DepositAccount(), 450);

            // Задержка
            Console.ReadKey();
        }
    }
}
