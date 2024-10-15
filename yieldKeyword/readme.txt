Yield Keyword ---> 

In C#, the yield keyword is used to simplify the implementation of iterators, which allow you to return a sequence of values one at a time instead of returning them all at once.
This is particularly useful when working with large datasets or streams of data, as it allows you to generate and process data lazily (on demand), which can save memory and improve performance.

When you use the yield keyword, the method doesn't need to create and return a collection all at once. Instead, it maintains the state of the iteration internally and returns each element when needed.
The method that uses yield return returns an IEnumerable<T> that can be enumerated using foreach or other iteration methods.

Benefits of yield:
Lazy Evaluation: Values are generated only when they are needed, not all at once.
Memory Efficiency: Especially useful for large collections, since the entire collection doesn't need to be stored in memory at once.
Cleaner Code: It allows simpler and more readable iterator methods without the need to manually manage the state of the iteration.
