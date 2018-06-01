using EnergyPlant.Objects.Components;
using EnergyPlant.Objects.Decorators;

namespace EnergyPlant.Objects.DecoratorsConcrete
{
    public class RemoteControlBonusDecorator : EnergyPlantDecorator
    {
        public RemoteControlBonusDecorator(EnergyPlantAbstract energyPlant) : base(energyPlant)
        {
            FeeDescription = "Remote Control Bonus";
        }

        public override decimal GetFee()
        {
            return _energyPlant.GetFee() + 0.001m;
        }

        public override string GetFeeDescription()
        {
            return $"{_energyPlant.GetFeeDescription()} + {FeeDescription}";
        }
    }
}