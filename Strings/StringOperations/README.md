
# String Operations

This challenge involves string formating and manipulation.

<strong>Your task:</strong> Write two functions to use strings operations to return a result string.

The first function will accept a DateTime object and format it in a particular way.

The second function will accept an array of strings, conert them to upper case, and join them into a single string, converted to uppercase, with each word separated by a period.

You should solve the challenges using strings interpolation and the other techniques that were covered in this chapter.

### Parameters

For the first function ("FormatDateTime"):

```the_date```: A DateTime object

For the second function ("FormatJoinStrings"):

```str_array```: An array of strings.

### Results

Your function named "FormatDateTime" will take the DateTime argument and return a string in the format: ```YYYY--MM--DD ```

Your function named "FormatJoinStrings" will return an uppercase string with periods between the joined strings.

### Exemple 1:

Input: ```DateTime(2030,4,1)```
Result: ```2030--4--1```

### Exemple 2:

Input: ```["Join", "these", "strings", "together"]```
Result: ```JOIN.THESE.STRING.TOGETHER```
