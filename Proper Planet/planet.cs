namespace Proper_Planet
{
    public class Planet 
    {
        public int PlaID { get; set; }

        public string PlaName { get; set; }

        public double PlaMass { get; set; }

        public int PlaDiameter { get; set; }

        public int PlaDensity { get; set; }

        public double PlaGravity { get; set; }

        public double PlaRotation { get; set; }

        public double PlaLenghtOfDay { get; set; }

        public double PlaToSunDistance { get; set; }

        public double PlaOrbitTime { get; set; }

        public double PlaVelocity { get; set; }

        public int PlaTemperature { get; set; }

        public int PlaMoonCount { get; set; }

        public string PlaRings { get; set; }

         public override string ToString()
        {
            return "ID: " + PlaID +
                "\nName:" + PlaName +
                "\nMass: " + PlaMass +
                "\nDiameter in km: " + PlaDiameter +
                "\nDensity(kg/m3): " + PlaDensity +
                "\nGravity (m/s2): " + PlaGravity +
                "\nRotation Period (hours): " + PlaRotation +
                "\nLenght of Day (hours): " + PlaLenghtOfDay + 
                "\nDistance From Sun 106 KM: " + PlaToSunDistance + 
                "\nOrbital Period (days): " + PlaOrbitTime + 
                "\nOrbital Velocity (km/s): " + PlaVelocity + 
                "\nMean Temperature (Celcius): " + PlaTemperature + 
                "\nNumber of Moons: " + PlaMoonCount +
                "\nRing System: " + PlaRings + "\n";  

        }
    }
}
