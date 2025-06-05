namespace TrafficLight_FSM.StatePattern
{
    public interface ITrafficLightState
    {
        void EnterState(TrafficLight context);
        void UpdateState(TrafficLight context);
    }
}