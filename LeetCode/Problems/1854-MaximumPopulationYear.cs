namespace LeetCode.Problems;
public class _1854_MaximumPopulationYear
{
    //Problem: https://leetcode.com/problems/maximum-population-year/
    //Solution: https://leetcode.com/problems/maximum-population-year/submissions/1061638544/
    public int MaximumPopulationYear_2(int[][] logs)
    {
        int maxYear = 2051;
        int maxPopulationYear = 0;
        int currentPopulation = 0;
        int maxPopulation = 0;

        int[] birthCountYearWise = new int[maxYear];
        int[] deathCountYearWise = new int[maxYear];

        foreach (var log in logs)
        {
            birthCountYearWise[log[0]]++;
            deathCountYearWise[log[1]]++;
        }

        for (int i = 1950; i < maxYear; i++)
        {
            currentPopulation += birthCountYearWise[i] - deathCountYearWise[i];

            if (currentPopulation > maxPopulation)
            {
                maxPopulation = currentPopulation;
                maxPopulationYear = i;
            }
        }
        return maxPopulationYear;
    }

    //Solution: https://leetcode.com/problems/maximum-population-year/submissions/1061649682/
    public int MaximumPopulationYear(int[][] logs)
    {
        int[] population = new int[101];
        int maxPopulation = 0;
        int maxPopulationYear = 0;
        int currentPopulation = 0;

        foreach (var log in logs)
        {
            population[log[0] - 1950]++;
            population[log[1] - 1950]--;
        }

        for (int year = 0; year < 101; year++)
        {
            currentPopulation += population[year];
            if (currentPopulation > maxPopulation)
            {
                maxPopulation = currentPopulation;
                maxPopulationYear = year;
            }
        }
        return maxPopulationYear + 1950;
    }

}

