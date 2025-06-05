namespace TrafficLight_FSM.StatePattern
{
    public class YellowState : ITrafficLightState
    {
        public void EnterState(TrafficLight trafficLight)
        {
            trafficLight.stopwatch.Restart();
            trafficLight.uIController.ShowYellowLight();
        }

        public void UpdateState(TrafficLight trafficLight)
        {
            if (trafficLight.stopwatch.Elapsed.TotalSeconds >= trafficLight.yellowDuration)
                trafficLight.SetState(ES1.Active, new RedState());
        }
    }
}