// IsPalindrome For example, 121 is a palindrome while 123 is not.

int x = 23;
int rem, sum = 0, temp;
temp = x;
while (x > 0)
{
    rem = x % 10;
    // Console.WriteLine(rem);
    x = x / 10;
   // Console.WriteLine(x);
    sum = sum * 10 + rem;
   //  Console.WriteLine(sum);

}
if (temp == sum)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}