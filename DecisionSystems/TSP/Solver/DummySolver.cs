using System.Collections.Generic;

namespace DecisionSystems.TSP.Solver
{
    public class DummySolver : ITSPSolver
    {
        public List<int> Solve(IReadOnlyList<Location> cities)
        {
            List<int> cityIndexes = new List<int>();

            for (int i = 1; i < cities.Count+1; i++)
            {
                cityIndexes.Add(i);
            }
            return cityIndexes;
        }
    }
}