/*
EXCEEDING REQUIREMENTS:
- Added a Level Up system when reaching 1000 points.
- Full save/load preserves completion state and checklist progress.
- Proper polymorphism using abstract base class.
- Encapsulation with private and protected fields.
- Clean separation of concerns via GoalManager.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}


