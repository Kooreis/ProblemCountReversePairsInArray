# Question: How do you count the number of reverse pairs in an array? JavaScript Summary

The provided JavaScript code is a solution to count the number of reverse pairs in an array. It uses a modified version of the merge sort algorithm to solve the problem. The function `countReversePairs` is the main function that calls the `mergeSort` function if the array is not empty. The `mergeSort` function is a recursive function that divides the array into two halves until it reaches a single element. It then counts the number of reverse pairs while merging the two halves. A reverse pair is counted when a number in the second half of the array is less than a number in the first half. This count is stored in the variable `count`. The function also uses a cache array to temporarily store the sorted array before copying it back to the original array. The process continues until the entire array is sorted and all reverse pairs are counted. The final count of reverse pairs is then returned by the `countReversePairs` function.

---

# TypeScript Differences

The TypeScript solution uses a class-based approach to encapsulate the logic for counting reverse pairs in an array. This is different from the JavaScript solution which uses a procedural approach with standalone functions. 

In the TypeScript version, the count of reverse pairs is stored as a private property of the `ReversePairs` class, and is updated within the `merge` method. This is different from the JavaScript version where the count is returned by the `mergeSort` function and added up in the `countReversePairs` function.

The TypeScript version also uses type annotations to ensure that the input to the `countPairs`, `mergeSort`, and `merge` methods are arrays of numbers, and that the `mergeSort` and `merge` methods return arrays of numbers. This adds a level of type safety that is not present in the JavaScript version.

The TypeScript version uses the `Math.floor` function to calculate the middle index of the array, while the JavaScript version uses the bitwise right shift operator (`>>`) to achieve the same result.

The `merge` method in the TypeScript version returns a new array that is the result of merging the two input arrays. In the JavaScript version, the original array is modified in-place.

In terms of functionality, both versions solve the problem in a similar way by using a modified merge sort algorithm to count the number of reverse pairs in the array.

---

# C++ Differences

The C++ version of the solution uses a similar approach to the JavaScript version, using a modified merge sort to count the number of reverse pairs in the array. However, there are some differences due to the language features and syntax of C++.

1. Type Declaration: In C++, we need to declare the type of variables and arrays (vectors in this case), while in JavaScript, we don't need to specify the type.

2. Array Initialization: In JavaScript, we can create an array using the `new Array()` syntax. In C++, we use the `vector<int>` syntax to create an array (vector). The `vector<int> temp(n, 0);` line in C++ creates a vector of size `n` and initializes all elements to `0`.

3. Bitwise Shift: Both versions use the bitwise shift operator (`>>`) to calculate the middle index of the array. This operator works the same way in both languages.

4. Function Parameters: In C++, the `merge` and `mergeSort` functions take the `nums` and `temp` vectors as references (`&`), which means that any changes made to these vectors inside the functions will affect the original vectors. In JavaScript, arrays are passed by reference by default, so there's no need for a special syntax.

5. Long Long Integers: In the C++ version, the number `2` is represented as `2LL` in the comparison `nums[i] > 2LL * nums[k]`. This is to ensure that the multiplication does not overflow the range of a 32-bit integer. JavaScript does not have this issue because all numbers in JavaScript are 64-bit floating point numbers.

6. Output: In JavaScript, we use `console.log()` to print the result, while in C++, we use `cout`.

7. Main Function: In C++, the code must be wrapped in a `main()` function, which is the entry point of the program. JavaScript does not require a main function.

---
