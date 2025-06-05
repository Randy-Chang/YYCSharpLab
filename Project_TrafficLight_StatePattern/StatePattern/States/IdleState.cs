namespace TrafficLight_FSM.StatePattern
{
    public class IdleState : ITrafficLightState
    {
        public void EnterState(TrafficLight trafficLight)
        {
            trafficLight.uIController.ShowTimerState("Idle");
        }

        public void UpdateState(TrafficLight trafficLight)
        {
            // Idle 不做任何事
        }
    }
}