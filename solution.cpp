```cpp
#include <iostream>
#include <vector>

using namespace std;

int merge(vector<int>& nums, vector<int>& temp, int left, int mid, int right) {
    int i = left, j = mid, k = mid, t = mid, count = 0;
    while (i < mid) {
        while (k < right && nums[i] > 2LL * nums[k]) k++;
        while (j < right && nums[i] > nums[j]) temp[t++] = nums[j++];
        temp[t++] = nums[i++];
        count += k - mid;
    }
    while (j < right) temp[t++] = nums[j++];
    for (int i = left; i < right; i++) nums[i] = temp[i];
    return count;
}

int mergeSort(vector<int>& nums, vector<int>& temp, int left, int right) {
    if (right - left <= 1) return 0;
    int mid = left + ((right - left) >> 1);
    int count = mergeSort(nums, temp, left, mid) + mergeSort(nums, temp, mid, right);
    count += merge(nums, temp, left, mid, right);
    return count;
}

int reversePairs(vector<int>& nums) {
    int n = nums.size();
    vector<int> temp(n, 0);
    return mergeSort(nums, temp, 0, n);
}

int main() {
    vector<int> nums = {1, 3, 2, 3, 1};
    cout << "Number of reverse pairs: " << reversePairs(nums) << endl;
    return 0;
}
```