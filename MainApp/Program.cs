using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyPlant.Objects.ComponentsConcrete;
using EnergyPlant.Objects.DecoratorsConcrete;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EnergyPlantEEG2013 epEeg2013 = new EnergyPlantEEG2013();
            var dmBonus = new DirectMarketeerBonusDecorator(epEeg2013);
            var repoBonus = new RepoweringBonusDecorator(dmBonus);
            var remoteBonus = new RemoteControlBonusDecorator(repoBonus);


            Console.WriteLine("Production      : 1000000");
            Console.WriteLine("Compensation    : {0:f2}", remoteBonus.GetFee()*1000000m);
            Console.WriteLine("Fee description : " + remoteBonus.GetFeeDescription());

            Console.ReadLine();
        }
    }
}
