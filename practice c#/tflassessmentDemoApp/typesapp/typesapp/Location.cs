namespace com.Transflower.Types
{
    

    //value types : struct and enum, int, double, bool, char
    
    public struct Location
    {
        public double longitude;
        public double latitude;
        public Location(double lg, double lt)
        {
            longitude = lg;
            latitude = lt  ;
        }
    }
}