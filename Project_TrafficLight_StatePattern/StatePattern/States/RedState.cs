namespace TrafficLight_FSM.StatePattern
{
    public class RedState : ITrafficLightState
    {
        public void EnterState(TrafficLight trafficLight)
        {
            trafficLight.stopwatch.Restart();
            trafficLight.uIController.ShowRedLight();
        }

        public void UpdateState(TrafficLight trafficLight)
        {
            if (trafficLight.stopwatch.Elapsed.TotalSeconds >= trafficLight.redDuration)
                trafficLight.SetState(ES1.Active, new GreenState());
        }
    }
}