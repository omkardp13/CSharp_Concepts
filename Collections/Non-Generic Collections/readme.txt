1. Non-Generic Collections (System.Collections)

Non-generic collections store elements as objects (of type object), which means they are not type-safe and require boxing/unboxing for value types.

1.ArrayList: A dynamically resizable array that holds elements of type object.

Example:
ArrayList arrayList = new ArrayList();
arrayList.Add(1);    // Adds an integer
arrayList.Add("Two"); // Adds a string
object item = arrayList[0]; // You need to cast it to the appropriate type when retrieving

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2. Hashtable: A collection of key-value pairs, where keys and values are of type object.

Example:

Hashtable hashtable = new Hashtable();
hashtable.Add(1, "One");
hashtable.Add("Two", 2); // Key as string, value as int
object value = hashtable[1]; // You need to cast it to the appropriate type when retrieving

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
3. Stack: A last-in, first-out (LIFO) non-generic collection of objects.

Example:

Stack stack = new Stack();
stack.Push(1);
stack.Push("Two");
object top = stack.Pop(); // You need to cast it to the appropriate type

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
4. Queue: A first-in, first-out (FIFO) non-generic collection of objects.

Example:

Queue queue = new Queue();
queue.Enqueue(1);
queue.Enqueue("Two");
object front = queue.Dequeue(); // You need to cast it to the appropriate type

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
5. SortedList: A collection of key-value pairs sorted by the key, where keys and values are of type object.
Example:

SortedList sortedList = new SortedList();
sortedList.Add(1, "One");
sortedList.Add(2, "Two");
object value = sortedList[1]; // You need to cast it to the appropriate type
