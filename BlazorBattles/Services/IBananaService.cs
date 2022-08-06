namespace BlazorBattles.Services
{
    public interface IBananaService
    {
        event Action OnChanged;
        public int Bananas { get; set; }
        void EatBananas(int amount);

        void AddBananas(int amount);
    }
}
