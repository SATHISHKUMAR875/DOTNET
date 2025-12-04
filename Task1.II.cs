using System;

namespace DeviceMonitor
{
    class TemperatureModule
    {
        // This is now the STARTUP method
        public static void Main(string[] args)
        {
            Console.WriteLine("Temperature Module Started...");
            Console.WriteLine("Reading temperature sensor values...");

            // Calling the helper method from VibrationModule
            VibrationModule.RunVibrationCheck();

            Console.WriteLine("Temperature Module Execution Completed.");
            Console.ReadLine();
        }
    }

    class VibrationModule
    {
        // Converted the Main() method into a normal helper method
        public static void RunVibrationCheck()
        {
            Console.WriteLine("Vibration Module Executing...");
            Console.WriteLine("Checking vibration levels...");
            Console.WriteLine("Vibration Module Task Completed.");
        }
    }
}
}