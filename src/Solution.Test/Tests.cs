using AutoFixture;
using NUnit.Framework;

namespace Solution.Test
{
    public class NaiveSolutionTests : GenericSolutionTests<NaiveSolution> { }
    public class LinqSolutionTests : GenericSolutionTests<LinqSolution> { }
    public class SlidingWindowTests : GenericSolutionTests<SlidingWindowSolution> { }

    /// <summary>
    /// As we expect to iterate on solutions to the same kata/problem,
    /// We should only need to write the unit tests once, then run the same tests for each solution
    /// </summary>
    /// <typeparam name="T">The implmentation type</ref></typeparam>
    public abstract class GenericSolutionTests<T> where T : ISolution
    {
        private ISolution _sut = new Fixture().Create<T>();

        [TestCase(4, 5, 6, 7, 0, 1, 2, ExpectedResult = 0)]
        [TestCase(2, 3, 4, 5, 1, ExpectedResult = 1)]
        [TestCase(5, 1, 2, 3, 4, ExpectedResult = 1)]
        public int FindMin(params int[] input) => _sut.FindMin(input);
    }
}