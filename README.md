# csharp-kata-template

Template repository for working on code katas in C#

# Building / Running Tests

## Using docker-compose

run `docker-compose up`, This will build and run the tests

## Using dotnet

from the `src` directory run `dotnet test` or `dotnet build`

# Code Structure

In `src/Solution/Solution.cs` you will find an example/template, this contains:

1. An interface `ISolution` with a single method defined
2. Two implmentations of this `NaiveSolution` and `ImprovedSolution`
   The idea here is to keep a few iterations of a solution so they are easy to compare

The unit tests located at `src/Solution.Test/Tests.cs` are then general to all implmentations of `ISolution`.
So when we add new tests we can easily compare validate all iterations of the solution.
