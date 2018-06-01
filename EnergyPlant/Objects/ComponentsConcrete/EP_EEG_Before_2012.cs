using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyPlant.Objects.Components;

namespace EnergyPlant.Objects.ComponentsConcrete
{
    public class EnergyPlantEEG2012 : EnergyPlantAbstract
    {
        public EnergyPlantEEG2012()
        {
            FeeDescription = "EEG 2012";
        }

        public override decimal GetFee()
        {
            decimal fee =  0.0893m;
            return fee;
        }

        public override string GetFeeDescription()
        {
            return FeeDescription;
        }
    }

    public class EnergyPlantEEG2013 : EnergyPlantAbstract
    {
        public EnergyPlantEEG2013()
        {
            FeeDescription = "EEG 2013";
        }

        public override decimal GetFee()
        {
            decimal fee = 0.088m; 
            return fee;
        }

        public override string GetFeeDescription()
        {
            return FeeDescription;
        }
    }

    public class EnergyPlantEEG2014 : EnergyPlantAbstract
    {
        public EnergyPlantEEG2014()
        {
            FeeDescription = "EEG 2014";
        }

        public override decimal GetFee()
        {
            decimal fee = 0.0866m;
            return fee;
        }

        public override string GetFeeDescription()
        {
            return FeeDescription;
        }
    }

    public class EnergyPlantBeforeEEG2012 : EnergyPlantAbstract
    {
        public EnergyPlantBeforeEEG2012()
        {
            FeeDescription = "EEG before 2012";
        }

        public override decimal GetFee()
        {
            decimal fee = 0.091m;
            return fee;
        }

        public override string GetFeeDescription()
        {
            return FeeDescription;
        }
    }
}
