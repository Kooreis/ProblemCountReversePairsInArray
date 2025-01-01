function mergeSort(nums, low, high) {
    if (low >= high) return 0;
    let mid = (low + high) >> 1;
    let count = mergeSort(nums, low, mid) + mergeSort(nums, mid + 1, high);
    let cache = new Array(high - low + 1);
}