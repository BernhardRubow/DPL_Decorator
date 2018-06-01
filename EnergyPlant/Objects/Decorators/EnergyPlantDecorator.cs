using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyPlant.Objects.Components;

namespace EnergyPlant.Objects.Decorators
{
    public class EnergyPlantDecorator : EnergyPlantAbstract
    {
        protected EnergyPlantAbstract _energyPlant;

        public EnergyPlantDecorator(EnergyPlantAbstract energyPlant)
        {
            _energyPlant = energyPlant;
        }

        public override decimal GetFee()
        {
            return _energyPlant.GetFee();
        }

        public override string GetFeeDescription()
        {
            return _energyPlant.GetFeeDescription();
        }
    }
}
