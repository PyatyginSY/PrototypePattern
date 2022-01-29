using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PrototypePattern\n");

            var transformer = new Transformer();
            transformer.WindingLowVoltage = "Power WindingLowVoltage";
            transformer.WindingHighVoltage = "Power WindingHighVoltage";
            transformer.WindingTapVoltage = "Power WindingTapVoltage";
            transformer.Tank = new Tank(126.1);

            var transformerShallowCopyClone = transformer.ShallowCopy();

            var transformerDeepCopyClone = transformer.DeepCopy();

            Console.WriteLine("Original values.");
            Console.WriteLine("transformer:");
            Console.WriteLine($"WindingLowVoltage: {transformer.WindingLowVoltage}, WindingHighVoltage: {transformer.WindingHighVoltage}, WindingTapVoltage: {transformer.WindingTapVoltage}, Tank: {transformer.Tank.Weight}");
            Console.WriteLine("transformerShallowCopyClone:");
            Console.WriteLine($"WindingLowVoltage: {transformerShallowCopyClone.WindingLowVoltage}, WindingHighVoltage: {transformerShallowCopyClone.WindingHighVoltage}, WindingTapVoltage: {transformerShallowCopyClone.WindingTapVoltage}, Tank: {transformerShallowCopyClone.Tank.Weight}");
            Console.WriteLine("transformerDeepCopyClone:");
            Console.WriteLine($"WindingLowVoltage: {transformerDeepCopyClone.WindingLowVoltage}, WindingHighVoltage: {transformerDeepCopyClone.WindingHighVoltage}, WindingTapVoltage: {transformerDeepCopyClone.WindingTapVoltage}, Tank: {transformerDeepCopyClone.Tank.Weight}");

            transformer.WindingLowVoltage = "Distribution WindingLowVoltage";
            transformer.WindingHighVoltage = "Distribution WindingHighVoltage";
            transformer.WindingTapVoltage = "Distribution WindingTapVoltage";
            transformer.Tank.Weight = 0.5;
            Console.WriteLine("Change values.");
            Console.WriteLine("Original values.");
            Console.WriteLine("transformer:");
            Console.WriteLine($"WindingLowVoltage: {transformer.WindingLowVoltage}, WindingHighVoltage: {transformer.WindingHighVoltage}, WindingTapVoltage: {transformer.WindingTapVoltage}, Tank: {transformer.Tank.Weight}");
            Console.WriteLine("transformerShallowCopyClone:");
            Console.WriteLine($"WindingLowVoltage: {transformerShallowCopyClone.WindingLowVoltage}, WindingHighVoltage: {transformerShallowCopyClone.WindingHighVoltage}, WindingTapVoltage: {transformerShallowCopyClone.WindingTapVoltage}, Tank: {transformerShallowCopyClone.Tank.Weight}");
            Console.WriteLine("transformerDeepCopyClone:");
            Console.WriteLine($"WindingLowVoltage: {transformerDeepCopyClone.WindingLowVoltage}, WindingHighVoltage: {transformerDeepCopyClone.WindingHighVoltage}, WindingTapVoltage: {transformerDeepCopyClone.WindingTapVoltage}, Tank: {transformerDeepCopyClone.Tank.Weight}");

            Console.ReadLine();
        }
    }
}
