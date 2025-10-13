namespace Goals
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points) { }

        public override void RecordEvent()
        {
            Console.WriteLine($"You have earned {_points} points for completing the eternal goal: {_name}");
        }

        public override bool IsCompleted() => false;

        public override string GetStringRepresentation()
        {
            return $"EternalGoal|{_name}|{_description}|{_points}";
        }
    }
}
