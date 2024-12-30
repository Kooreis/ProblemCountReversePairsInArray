Here is a JavaScript solution for the problem:

```javascript
function countReversePairs(nums) {
    if (nums.length === 0) return 0;
    return mergeSort(nums, 0, nums.length - 1);
}

function mergeSort(nums, low, high) {
    if (low >= high) return 0;
    let mid = (low + high) >> 1;
    let count = mergeSort(nums, low, mid) + mergeSort(nums, mid + 1, high);
    let cache = new Array(high - low + 1);
    let i = low, t = low, r = 0;
    for (let j = mid + 1; j <= high; j++, r++) {
        while (i <= mid && nums[i] <= 2 * nums[j]) i++;
        while (t <= mid && nums[t] < nums[j]) cache[r++] = nums[t++];
        cache[r] = nums[j];
        count += mid - i + 1;
    }
    while (t <= mid) cache[r++] = nums[t++];
    for (let i = 0; i < high - low + 1; i++) nums[low + i] = cache[i];
    return count;
}

let nums = [1, 3, 2, 3, 1];
console.log(countReversePairs(nums));
```

This solution uses a modified merge sort to count the number of reverse pairs in the array. The merge sort function is modified to count the number of reverse pairs while sorting the array. The count is incremented whenever a number in the second half of the array is found to be less than a number in the first half. The sorted array is then copied back to the original array. The process is repeated recursively for the two halves of the array until the entire array is sorted and all reverse pairs are counted.