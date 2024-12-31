function countReversePairs(nums) {
    if (nums.length === 0) return 0;
    return mergeSort(nums, 0, nums.length - 1);
}