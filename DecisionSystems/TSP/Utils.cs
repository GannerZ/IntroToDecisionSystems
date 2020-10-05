using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionSystems.TSP
{
    public static class Utils
    {
        public static double GetDistance(IReadOnlyCollection<int> solution, IReadOnlyList<Location> cities)
        {
            //var distance = 0.0;
            //var previousCityIndex = solution.Last();
            //foreach (var cityIndex in solution)
            //{
            //    var previousCity = cities[previousCityIndex - 1];
            //    var city = cities[cityIndex - 1];
            //    distance += GetDistance(previousCity, city);
            //    previousCityIndex = cityIndex;             
            //}
            //return distance;

            int solutionIndex = 1;
            var location = cities[solutionIndex - 1];

            Location getLocation(int solutionIndex)
            {
                return cities[solutionIndex - 1];
            }
            return solution
                .Append(solution.First())
                .Select(getLocation)
                .Pairwise(GetDistance)
                .Sum();                 
        }
        public static IEnumerable<TOut> Pairwise<TIn, TOut> (this IEnumerable<TIn> items,Func<TIn, TIn, TOut> merge)
        {
            if (items is null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            return items.Zip(items.Skip(1),merge);
        }
        public static double GetDistance(Location a, Location b)
        {
            var dx = a.X - b.X;
            var dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}