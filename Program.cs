//Task3

int[] nums = new int[] { 1, 2, 3, 4, 5, -3, -4, -10 };
int summ = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 0)
    {
        summ += nums[i];
    }
}
Console.WriteLine(summ);