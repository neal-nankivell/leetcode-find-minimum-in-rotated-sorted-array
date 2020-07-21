using System.Linq;

namespace Solution
{
    public interface ISolution
    {
        int Add(params int[] input);
    }

    public class NaiveSolution : ISolution
    {
        // A simple solution using a foreach loop
        public int Add(params int[] input)
        {
            int sum = 0;

            foreach (int value in input)
            {
                sum += value;
            }

            return sum;
        }
    }

    public class ImprovedSolution : ISolution
    {
        // A slightly cleaner solution using linq
        // note: no notable performance change in this example
        public int Add(params int[] input) => input.Sum();
    }
}
