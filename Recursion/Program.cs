
/*
    - Recursive function is a function which calls itself.
    - Base case terminates recursive calls chain
*/

// Calculate factorial by Recursion

int GetFactorial(int num)
{ 
    if(num == 0) return 1;
    return num * GetFactorial(num-1);
}
 
System.Console.WriteLine(GetFactorial(5));
