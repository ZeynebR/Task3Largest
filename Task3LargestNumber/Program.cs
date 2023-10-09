int[] Numbers = { 2005,3, 8, 23,106, 1, 55 ,677};
int LargestNumber = Numbers[0];
for (int i = 1; i < Numbers.Length; i++)
{
    
    if (LargestNumber < Numbers[i])
	{
        LargestNumber = Numbers[i];
	}
    
        
}
Console.WriteLine( "largest number is " +LargestNumber);
