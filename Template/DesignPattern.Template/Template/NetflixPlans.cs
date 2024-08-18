namespace DesignPattern.Template.Template
{
    public abstract class NetflixPlans
    {
        public void CreatePlan()
        {
            PlanType(string.Empty);
            CountPerson(0);
            Price(0);
            Resolution(string.Empty);
            Content(string.Empty);
        }
        public abstract string PlanType(string planType);
        public abstract int CountPerson(int countPerson);
        public abstract decimal Price(decimal price);
        public abstract string Resolution(string resolution);
        public abstract string Content(string content);
    }
}
