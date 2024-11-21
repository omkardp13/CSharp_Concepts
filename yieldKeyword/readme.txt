Yield Keyword ---> 

1.In C#, the yield keyword is used to simplify the implementation of iterators, which allow you to return a sequence of values one at a time instead of returning them all at once.

2.This is particularly useful when working with large datasets or streams of data, as it allows you to generate and process data lazily (on demand), which can save memory and improve performance.

3.When you use the yield keyword, the method doesn't need to create and return a collection all at once. Instead, it maintains the state of the iteration internally and returns each element when needed.

4.The method that uses yield return returns an IEnumerable<T> that can be enumerated using foreach or other iteration methods.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Benefits of yield:

1.Lazy Evaluation: Values are generated only when they are needed, not all at once.

2.Memory Efficiency: Especially useful for large collections, since the entire collection doesn't need to be stored in memory at once.

3.Cleaner Code: It allows simpler and more readable iterator methods without the need to manually manage the state of the iteration.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Example in your code:

In your example, the yield return statement in GetNumbers(int upto) method allows numbers from 0 to upto - 1 to be generated and returned one at a time:


public static IEnumerable<int> GetNumbers(int upto)
{
    for(int i = 0; i < upto; i++)
    {
        yield return i;  // Return one number at a time
        Console.WriteLine("print");
    }
}

When the foreach loop in the Main method iterates over numbers, it fetches the next number on each iteration. The method continues from where it left off after the last yield return call until the loop completes.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------
Without yield:
Without yield, you would need to store all the numbers in a collection like a List<int>, return the entire list, and then iterate over it, which can consume more memory:

public static IEnumerable<int> GetNumbers(int upto)
{
    List<int> numbers = new List<int>();
    for (int i = 0; i < upto; i++)
    {
        numbers.Add(i);
    }
    return numbers;
}
Using yield makes this process more efficient and cleaner, especially for large or infinite sequences.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------
