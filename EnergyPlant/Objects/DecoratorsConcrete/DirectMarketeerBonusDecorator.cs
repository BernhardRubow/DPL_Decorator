using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyPlant.Objects.Components;
using EnergyPlant.Objects.Decorators;

namespace EnergyPlant.Objects.DecoratorsConcrete
{
    public class DirectMarketeerBonusDecorator : EnergyPlantDecorator
    {
        public DirectMarketeerBonusDecorator(EnergyPlantAbstract energyPlant) : base(energyPlant)
        {
            FeeDescription = "Direct Marketeer Bonus";
        }

        public override decimal GetFee()
        {
            return _energyPlant.GetFee() + 0.00095m;
        }

        public override string GetFeeDescription()
        {
            return $"{_energyPlant.GetFeeDescription()} + {FeeDescription}";
        }
    }
}
