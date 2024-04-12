# GenSpark Training Day 1 Apr 09

## Overview

This repository is for understanding Git, and working on some logic problems.

## Tasks

1. Create a new repository and try conflicting and resolve it.
2. Work on some logic problems:
- [Two Sum](https://leetcode.com/problems/two-sum/description/)

```
var twoSum = function (nums, target) {
    const m = new Map();
    for (let i = 0; ; ++i) {
        const x = nums[i];
        const y = target - x;
        if (m.has(y)) {
            return [m.get(y), i];
        }
        m.set(x, i);
    }
};
```


- [Palindrome Number](https://leetcode.com/problems/palindrome-number/description/)
```
var isPalindrome = function (x) {
    if (x < 0 || (x > 0 && x % 10 === 0)) {
        return false;
    }
    let y = 0;
    for (; y < x; x = ~~(x / 10)) {
        y = y * 10 + (x % 10);
    }
    return x === y || x === ~~(y / 10);
};
```

## Repository

The repository for this project can be found [here](https://github.com/gayat19/FSD09Apr2024).

## RESULT

![Two Sum](https://github.com/kaxxsh/demo1/blob/main/Results/Day%201/Two%20Sum.png)

![Palindrome Number](https://github.com/kaxxsh/demo1/blob/main/Results/Day%201/palindrom.png)