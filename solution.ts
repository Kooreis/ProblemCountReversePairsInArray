Here is a TypeScript solution for counting the number of reverse pairs in an array:

```typescript
class ReversePairs {
    private count: number;

    constructor() {
        this.count = 0;
    }

    public countPairs(nums: number[]): number {
        this.mergeSort(nums, 0, nums.length - 1);
        return this.count;
    }

    private mergeSort(nums: number[], start: number, end: number): number[] {
        if (start >= end) return [nums[start]];
        let mid = start + Math.floor((end - start) / 2);
        let left = this.mergeSort(nums, start, mid);
        let right = this.mergeSort(nums, mid + 1, end);
        return this.merge(nums, left, right);
    }

    private merge(nums: number[], left: number[], right: number[]): number[] {
        let i = 0, j = 0, k = 0, merge = [];
        while (i < left.length && j < right.length) {
            if (left[i] <= 2 * right[j]) {
                merge[k++] = left[i++];
            } else {
                this.count += left.length - i;
                merge[k++] = right[j++];
            }
        }
        while (i < left.length) merge[k++] = left[i++];
        while (j < right.length) merge[k++] = right[j++];
        return merge;
    }
}

let rp = new ReversePairs();
let nums = [1, 3, 2, 3, 1];
console.log(rp.countPairs(nums));
```

This TypeScript solution uses a class `ReversePairs` to encapsulate the logic for counting reverse pairs. The `countPairs` method is the public interface for counting the pairs, which internally uses a merge sort algorithm to sort the array while counting the reverse pairs. The `mergeSort` method recursively sorts the array and the `merge` method merges two sorted arrays while counting the reverse pairs. The count of reverse pairs is stored in the `count` property of the `ReversePairs` class.