//Transaction.cs
namespace FinanceTracker
{
    public record Transaction // record - специальный тип для неизменяемых данных, со встроенным коснструктором и методами
    (
        string category,
        decimal amount,
        DateTime date,
        string type
    );
}