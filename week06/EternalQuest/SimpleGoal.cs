namespace Goals
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points)
            : base(name, description, points) { }

        public override void RecordEvent()
        {
            if (!_isCompleted)
            {
                _isCompleted = true;
                Console.WriteLine($"Congratulations! You completed '{_name}' and earned {_points} points!");
            }
            else
            {
                Console.WriteLine($"'{_name}' is already complete.");
            }
        }

        public override bool IsCompleted() => _isCompleted;

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal|{_name}|{_description}|{_points}|{_isCompleted}";
        }
    }
}
