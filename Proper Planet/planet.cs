namespace Proper_Planet
{
    public class Planet
    {
        #region Private Props
        private int plaID;
        private string plaName ;
        private double plaMass ;
        private int plaDiameter;
        private int plaDensity;
        private double plaGravity ;
        private double plaRotation;
        private double plaLenghtOfDay;
        private double plaToSunDistance;
        private double plaOrbitTime;
        private double plaVelocity;
        private int plaTemperature;
        private int plaMoonCount;
        private string plaRings;
        #endregion
        #region Get/Set
        public int PlaID { get { return plaID; } set { plaID = value; } }

        public string PlaName { get { return plaName; } set { plaName = value; } }

        public double PlaMass { get { return plaMass; } set { plaMass = value; } }

        public int PlaDiameter { get { return plaDiameter; } set { plaDiameter = value; } }

        public int PlaDensity { get { return plaDensity; } set { plaDensity = value; } }

        public double PlaGravity { get { return plaGravity; } set { plaGravity = value; } }

        public double PlaRotation { get { return plaRotation; } set { plaRotation = value; } }

        public double PlaLenghtOfDay { get { return plaLenghtOfDay; } set { plaLenghtOfDay = value; } }

        public double PlaToSunDistance { get { return plaToSunDistance; } set { plaToSunDistance = value; } }

        public double PlaOrbitTime { get { return plaOrbitTime; } set { plaOrbitTime = value; } }

        public double PlaVelocity { get { return plaVelocity; } set { plaVelocity = value; } }

        public int PlaTemperature { get { return plaTemperature; } set { plaTemperature = value; } }

        public int PlaMoonCount { get { return plaMoonCount; } set { plaMoonCount = value; } }

        public string PlaRings { get { return plaRings; } set { plaRings = value; } }
        #endregion

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
