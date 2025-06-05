using TrafficLight_FSM.StatePattern;
using TrafficLight_StatePattern;

namespace TrafficLight_FSM_Project.Scopes
{

    public partial class Scope
    {

        public static Mainform mainForm = null;

        public void Init_MainForm()
        {
            mainForm = new Mainform(new MainformPack());
        }

    }

    class MainformPack : ITrafficLight
    {
        public void Exit()
        {
            Scope.trafficLight.Exit();
        }

        public void Pause()
        {
            Scope.trafficLight.Pause();
        }

        public void SetDurations(int red, int green, int yellow)
        {
            Scope.trafficLight.SetDurations(red, green, yellow);
        }

        public void Start()
        {
            Scope.trafficLight.Start();
        }

        public void Stop()
        {
            Scope.trafficLight.Stop();
        }
    }
}
