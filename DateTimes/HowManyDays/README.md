
# Calculate the number of days between today and a given date

You're given a date as a string.

<strong>Your task:</strong> Parse the date string into a DateTime object and calculate how many days either remain from today until the given date (if it hasn`t passed yet), or how many days have gone by since the date (if it has already passed). If the date string is invalid, return int.MaxValue.

Return posiive numbers for dates in the past, negative numbers for dates in the future, and zero for today.

### Parameters

```date_str```: A string representing a date

### Results

```int```: The number of day until or since the given date, or int.MaxValue if the date string is invalid.
-   If the date is in the future, return a negative number
-   If the date is in the past, return a positive number
-   If the date is today, return 0

### Exemple 1:

Assume today is April 1, 2030.

Input: ```"April 5, 2030"```
Result: ```-4```

### Exemple 2:

Assume today is April 1, 2030.

Input: ```"March 15, 2030"```
Result: ```17```

### Exemple 3:

Assume today is April 1, 2030.

Input: ```"Not a date"```
Result: ```2147483647```
