Generic Collections (System.Collections.Generic) : Generic collections are strongly typed, providing type safety and eliminating the need for boxing/unboxing.

1. List<T> : A strongly typed dynamic array.

Example:

List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
int firstNumber = numbers[0]; // No casting required
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2. Dictionary<TKey, TValue>: A collection of key-value pairs where both key and value are strongly typed.

Example:
Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "One");
dict.Add(2, "Two");
string value = dict[1]; // No casting required
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
3. Stack<T>: A strongly typed last-in, first-out (LIFO) collection.

Example:
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
int top = stack.Pop(); // No casting required
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
4. Queue<T>: A strongly typed first-in, first-out (FIFO) collection.

Example:

Queue<string> queue = new Queue<string>();
queue.Enqueue("First");
queue.Enqueue("Second");
string first = queue.Dequeue(); // No casting required
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
5. HashSet<T>
A collection of unique elements, similar to a mathematical set.
Example:

HashSet<int> set = new HashSet<int>();
set.Add(1);
set.Add(2);
bool added = set.Add(2); // Will return false as 2 is already in the set
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
6. LinkedList<T>
A doubly linked list where each node points to the next and previous node.
Example:
csharp
Copy code
LinkedList<int> linkedList = new LinkedList<int>();
linkedList.AddFirst(1);
linkedList.AddLast(2);
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
7. SortedList<TKey, TValue>
A collection of key-value pairs sorted by key, similar to a dictionary but sorted.
Example:

SortedList<int, string> sortedList = new SortedList<int, string>();
sortedList.Add(2, "Two");
sortedList.Add(1, "One");
string value = sortedList[1]; // Sorted by key
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
8. SortedDictionary<TKey, TValue>
Similar to SortedList<TKey, TValue>, but with better performance for large collections.
Example:

SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();
sortedDict.Add(2, "Two");
sortedDict.Add(1, "One");
string value = sortedDict[1];
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
9. ObservableCollection<T>
A dynamic collection that notifies subscribers when items are added or removed. Often used in data-binding scenarios (e.g., with WPF).
Example:

ObservableCollection<string> collection = new ObservableCollection<string>();
collection.Add("Item 1");
collection.CollectionChanged += (sender, e) =>
{
    Console.WriteLine("Collection changed!");
};
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
10. Concurrent Collections (System.Collections.Concurrent):

ConcurrentDictionary<TKey, TValue>: A thread-safe dictionary for use in multi-threaded environments.
ConcurrentQueue<T>, ConcurrentStack<T>, and BlockingCollection<T> also provide thread-safe versions of their respective non-thread-safe counterparts.
Example:

ConcurrentDictionary<int, string> concurrentDict = new ConcurrentDictionary<int, string>();
concurrentDict.TryAdd(1, "One");
