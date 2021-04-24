using System;

/// <summary>
/// Ковариантность обобщений.
/// Ковариантность: позволяет использовать более конкретный тип, чем заданный изначально.
/// Обобщенные интерфейсы могут быть ковариантными, если к универсальному параметру 
/// применяется ключевое слово out. 
/// </summary>
namespace _17_Covariance
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
    /// Обобщенный интерфейс IBank определяет метод CreateAccount 
    /// для создания счета.  на момент определения интерфейса 
    /// мы не знаем, какой тип будет представлять счет.
    /// out указывает, что данный интерфейс будет ковариантным.
    /// </summary>
    interface IBank<out T>
    {
        T CreateAccount(int sum);
    }

    /// <summary>
    /// Класс Bank - условный банк
    /// Bank реализует интерфейс IBank и возвращает из метода CreateAccount 
    /// объект, который представляет класс Account, или один из его 
    /// наследников.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Bank<T> : IBank<T> where T : Account, new()
    {
        public T CreateAccount(int sum)
        {
            T account = new T();  // создаем счет
            account.DoTransfer(sum);
            
            return account;
        }
    }
    
    class Program
    {
        static void Main()
        {
            IBank<DepositAccount> depositBank = new Bank<DepositAccount>();

            Account account1 = depositBank.CreateAccount(34);

            // Обычный банк
            // Account - более контретный тип
            // DepositAccount - более общенный тип
            IBank<Account> ordinaryBank = new Bank<DepositAccount>();

            Account account2 = ordinaryBank.CreateAccount(45);

            // Задержка
            Console.ReadKey();
        }
    }
}
