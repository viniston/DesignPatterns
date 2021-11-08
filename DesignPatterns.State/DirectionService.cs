namespace DesignPatterns.State
{
    public class DirectionService
    {
        private ITravelMode _travelMode;

        public DirectionService(ITravelMode travelMode)
        {
            _travelMode = travelMode;
        }

        public void SetTravelMode(ITravelMode travelMode)
        {
            _travelMode = travelMode;
        }

        public ITravelMode GetTravelMode()
        {
            return _travelMode;
        }

        public void GetEta()
        {
            _travelMode.GetEta();
        }

        public void GetDirection()
        {
            _travelMode.GetDirection();
        }
    }
}
