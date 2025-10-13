using System;
using System.Collections.Generic;
using System.IO;

namespace Goals
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public void Start()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nWelcome to Eternal Quest!");
                Console.WriteLine($"You have {_score} points.");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoals();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        private void CreateGoal()
        {
            Console.WriteLine("\nThe types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string type = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();

            Console.Write("Enter points for this goal: ");
            int points = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Enter number of times needed to complete this goal: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points upon completion: ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
                    break;
            }
        }

        private void ListGoals()
        {
            Console.WriteLine("\nYour Goals:");
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet.");
            }
            else
            {
                int i = 1;
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{i}. {goal.GetDetailsString()}");
                    i++;
                }
            }
        }

        private void RecordEvent()
        {
            ListGoals();
            Console.Write("Which goal did you accomplish? ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                Goal goal = _goals[index];
                goal.RecordEvent();
                _score += goal.GetPoints();
            }
        }

        private void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved!");
        }

        private void LoadGoals()
        {
            if (File.Exists("goals.txt"))
            {
                _goals.Clear();
                string[] lines = File.ReadAllLines("goals.txt");
                _score = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    string type = parts[0];

                    if (type == "SimpleGoal")
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));

                    else if (type == "EternalGoal")
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));

                    else if (type == "ChecklistGoal")
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                            int.Parse(parts[5]), int.Parse(parts[4]))); // points, bonus, targetCount
                }

                Console.WriteLine("Goals loaded!");
            }
            else
            {
                Console.WriteLine("No save file found.");
            }
        }
    }
}
