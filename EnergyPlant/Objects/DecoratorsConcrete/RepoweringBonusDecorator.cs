using EnergyPlant.Objects.Components;
using EnergyPlant.Objects.Decorators;

namespace EnergyPlant.Objects.DecoratorsConcrete
{
    public class RepoweringBonusDecorator : EnergyPlantDecorator
    {
        public RepoweringBonusDecorator(EnergyPlantAbstract energyPlant) : base(energyPlant)
        {
            FeeDescription = "Repowering Bonus";
        }

        public override decimal GetFee()
        {
            return _energyPlant.GetFee() + 0.00115m;
        }

        public override string GetFeeDescription()
        {
            return $"{_energyPlant.GetFeeDescription()} + {FeeDescription}";
        }
    }
}