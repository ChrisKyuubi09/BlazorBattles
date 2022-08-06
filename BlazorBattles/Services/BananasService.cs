namespace BlazorBattles.Services
{
    public class BananasService : IBananaService
    {
        public event Action OnChanged;

        public int Bananas { get; set; } = 1000;

        public void EatBananas(int amount)
        {
            Bananas -= amount;
            BananasChanged();
        }

        void BananasChanged() => OnChanged.Invoke();

		public void AddBananas(int amount)
		{
			Bananas += amount;
            BananasChanged();
		}
	}
}
