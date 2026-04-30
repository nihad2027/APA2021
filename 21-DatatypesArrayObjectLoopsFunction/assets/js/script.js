function removeAndCountDuplicates(arr) {
    let uniqueArray = [];
    let duplicateCount = 0;
    let seenElements = {};

    for (let i = 0; i < arr.length; i++) {
        let currentNumber = arr[i];

        if (seenElements[currentNumber]) {

            duplicateCount++;
        } else {

            seenElements[currentNumber] = true;
            uniqueArray.push(currentNumber);
        }
    }

    return {
        netice: uniqueArray,
        tekrarSayi: duplicateCount
    };
}

console.log(removeAndCountDuplicates([1, 2, 3, 2, 4, 1, 5]));



function isPalindrome(word) {

    let str = String(word).toLowerCase();
    let leftIndex = 0;
    let rightIndex = str.length - 1;

    while (leftIndex < rightIndex) {
        if (str[leftIndex] !== str[rightIndex]) {
            return false;
        }
        leftIndex++;
        rightIndex--;
    }
    return true;
}

console.log(isPalindrome("Kelek"));
console.log(isPalindrome("Salam"));



function countGreaterElements(targetNumber, arr) {
    let count = 0;

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] > targetNumber) {
            count++;
        }
    }

    return count;
}

console.log(countGreaterElements(10, [5, 12, 8, 20, 10, 15]));



function checkAbundantOrDeficient(num) {
    if (num <= 0) return "Müsbət tam ədəd daxil edin";

    let sumOfDivisors = 0;


    for (let i = 1; i <= num / 2; i++) {
        if (num % i === 0) {
            sumOfDivisors += i;
        }
    }

    if (sumOfDivisors > num) {
        return "Abundant";
    } else {
        return "Deficient";
    }
}

console.log(checkAbundantOrDeficient(12));
console.log(checkAbundantOrDeficient(13));


function squareArrayElements(arr) {
    let squaredArray = [];

    for (let i = 0; i < arr.length; i++) {
        let squaredValue = arr[i] * arr[i];
        squaredArray.push(squaredValue);
    }

    return squaredArray;
}

console.log(squareArrayElements([2, 3, 4, 5]));