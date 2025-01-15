
# Transpose a date string using regular expression

You're given a string that represents a date in "mm/dd/yyyy" format.

<strong>Your task:</strong> Using a regular expression, return a string in the format of "yyyy-mm-dd".

The format and day values in the string can be 1 or 2 digits, and the year can be 2 or 4 digits. You do not need to expand the values to fill the full 2 or 4 digits.

### Parameters

```date-str```: A string representing the date to cenvert.

### Results

```string```: The given string rearranged into "yyyy-mm-dd" format (or "yy-m-d" as the case may be).

If the given date is invalid, return an empty string.

### Exemple 1:

Input: ```11/12/2020```
Result: ```2020-11-12```

### Exemple 2:

Input: ```1/1/99```
Result: ```99-1-1```
