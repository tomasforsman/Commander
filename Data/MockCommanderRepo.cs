using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id =0, HowTo="Boil an egg", Line="Boil water", Platform="Pan"},
                new Command{Id =1, HowTo="Boil an apple", Line="Boil apple", Platform="Pan"},
                new Command{Id =2, HowTo="Freeze an egg", Line="Freeze water", Platform="Fridge"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id =0, HowTo="Boil an egg", Line="Boil water", Platform="Pan"};
        }
    }
}