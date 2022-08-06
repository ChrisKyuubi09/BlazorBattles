using BlazorBattles_Shared;

namespace BlazorBattles.Services
{
    public interface IUnitService
    {
        IList<Unit> Units { get; }

        IList<UserUnit> MyUnits { get; set; }

        void AddUnit(int unitId);

    }
}
