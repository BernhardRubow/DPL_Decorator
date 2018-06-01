namespace EnergyPlant.Objects.Components
{
    public abstract class EnergyPlantAbstract
    {
        public string Caption { get; set; }
        public int YearOfLaunch { get; set; }
        public string FeeDescription { get; set; }

        public abstract decimal GetFee();

        public abstract string GetFeeDescription();
    }
}
