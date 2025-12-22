def binary_search(nums, n):
    low = 0
    high = len(nums)
    steps = 0

    while low < high:
        steps += 1  
        mid = int((low + high)/2)

        if nums[mid] == n:
            print('steps =', steps)
            return mid
        elif nums[mid] < n:
            low = mid + 1
        else:
            high = mid

    return - 1

a = [1, 2, 3, 4, 5, 6]
b = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
c = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]
d = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20]

binary_search(c, 3)