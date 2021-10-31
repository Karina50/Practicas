namespace AlcoholApi.Domain.Interfaces
{
    public interface IDatos
    {
        void dato_1(int cantidad, string bebida);
        void dato_2(int peso);
        string ReturnTotal();
    }
}