namespace task8Library
{
    public interface EmergencyService
    {
        void Start();
        bool IsWaiting();
        void GoTo(Coordinates coordinates);
        void NeedToBeFixed(TrolleyBuss tb);
        void FixBuss(TrolleyBuss trolleyBuss);
        
        Coordinates TargetCoordinates { get; set; }
        Coordinates BaseCoordinates { get; set; }
    }
}