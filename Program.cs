/* Follow the below steps to the Define a method that help you create a random string:

Step 1: Define Method Parameters
The method should take the following parameters

- length (int): specifies the length of the random string
- includeAlphabets (bool): Whether to include alphabets.
- includeNumbers (bool): Whether to include numbers.
- includeSpecialCharacters (bool): Whether to include special characters

Step 2: Set Character Pools
In the method create pools (string) for alphabets, numbers and special characters:

- Alphabets: "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
- Numbers: "0123456789"
- Special Characters: "!@#$%^&*()-_=+[]{};:'\",.<>?/|\\~"`

Step 3: Combine Character Pools
Based on the parameters, dynamically build a combined pool of characters.

Step 4: Randomly Select Characters
Use the Random class to pick characters from the combine pool until the desired length is reached.

Step 5: Return the Generated String
Convert the selected characters into a string and return it.

NB: Think of why the three Boolean parameters are passed in the method definition. Ensure it takes care of when the user want alphabets only or alphanumeric or mixed with special characters

Come up with a solution and best solution wins a prize. Your time starts NOW. */

using System.ComponentModel;


