namespace PrototypePattern
{
    public class Transformer
    {
        public string WindingLowVoltage { get; set; }

        public string WindingHighVoltage { get; set; }

        public string WindingTapVoltage { get; set; }

        public Tank Tank { get; set; }

        public Transformer ShallowCopy()
        {
            return (Transformer)MemberwiseClone();
        }

        public Transformer DeepCopy()
        {
            var other = (Transformer)MemberwiseClone();
            other.Tank = new Tank(Tank.Weight);
            other.WindingLowVoltage = WindingLowVoltage;
            other.WindingHighVoltage = WindingHighVoltage;
            other.WindingTapVoltage = WindingTapVoltage;
            return other;
        }
    }
}
