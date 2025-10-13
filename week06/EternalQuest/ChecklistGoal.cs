namespace Goals
{
    public class ChecklistGoal : Goal
    {
        private int _targetCount;
        private int _currentCount;
        private int _bonusPoints;

        public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _currentCount = 0;
            _bonusPoints = bonusPoints;
        }

        public override void RecordEvent()
        {
            if (!_isCompleted)
            {
                _currentCount++;
                Console.WriteLine($"You have made progress on '{_name}': {_currentCount}/{_targetCount}");

                if (_currentCount >= _targetCount)
                {
                    _isCompleted = true;
                    Console.WriteLine($"Congratulations! You completed '{_name}' and earned {_points + _bonusPoints} points!");
                }
                else
                {
                    Console.WriteLine($"You earned {_points} points for your progress.");
                }
            }
            else
            {
                Console.WriteLine($"'{_name}' is already complete.");
            }
        }

        public override bool IsCompleted() => _isCompleted;

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal|{_name}|{_description}|{_points}|{_isCompleted}|{_targetCount}|{_currentCount}|{_bonusPoints}";
        }

        public override string GetDetailsString()
        {
            string status = _isCompleted ? "[X]" : "[ ]";
            return $"{status} {_name} ({_description}) -- Progress: {_currentCount}/{_targetCount}";
        }
    }
}
   