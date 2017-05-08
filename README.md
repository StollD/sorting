# Sorting Algorithms
An interface for easily sorting arrays and lists in C#, with custom sorting algoritms

Algorithms implemented by default:
* MinimumSort
* BubbleSort
* Optimized BubbleSort
* QuickSort

Example:
```
Int32[] sorted = Sort.SortList<Int32, BubbleSort>(new [] { 89, 563, 684, 33, 55, 492, 99, 183, 7493, 525334, 0, 11 });
Console.WriteLine(String.Join(", ", sorted));
// 0, 11, 33, 55, 89, 99, 183, 492, 563, 684, 7493, 525334
```