using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static List<List<int>> combinationSum (int[] candidates, int target) 
    {
        Array.Sort(candidates); // Сначала сортируем массив кандидатов
        List<List<int>> result = new List<List<int>>();
        List<int> currentList = new List<int>();
        
        combinationSumHelper(candidates, target, 0, currentList, result);
        return result;
    }

    static void combinationSumHelper(int[] candidates, int target, int index, List<int> currentList, List<List<int>> result)
    {
        if(target == 0)
        {
            result.Add(new List<int>(currentList));
            return;
        }

        for(int i = index; i < candidates.Length; i++)
        {
            if(candidates[i] > target) break; // Если текущий кандидат больше цели, прекращаем поиск
            if(i > index && candidates[i] == candidates[i - 1]) continue; // Избегаем повторений
            
            currentList.Add(candidates[i]);
            
            combinationSumHelper(candidates, target - candidates[i], i + 1, currentList, result);
            
            currentList.RemoveAt(currentList.Count - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива candidates через пробел:");
        int[] candidates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        Console.WriteLine("Введите значение target:");
        int target = int.Parse(Console.ReadLine());

        List<List<int>> result = combinationSum(candidates, target);

        foreach(var combination in result)
        {
            Console.WriteLine($"[{string.Join(", ", combination)}]");
        }
    }
}