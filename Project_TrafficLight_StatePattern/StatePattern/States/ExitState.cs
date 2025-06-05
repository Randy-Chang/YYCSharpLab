namespace TrafficLight_FSM.StatePattern
{
    public class ExitState : ITrafficLightState
    {
        public void EnterState(TrafficLight trafficLight)
        {
            trafficLight.uIController.ShowTimerState("Exit");
        }

        public void UpdateState(TrafficLight trafficLight)
        {
            // Idle 不做任何事
        }
    }
}