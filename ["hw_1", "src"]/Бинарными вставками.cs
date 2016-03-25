public class Class1
{
	public void InsertionSort()
	{
        for (i = 1; i < counter; i++)
            if (err[i - 1] > err[i])
            {
                x = err[i];
                left = 0;
                right = i;
                do
                {
                    middle = (left + right) / 2;
                    if (err[middle] < x)
                        left = middle + 1;
                    else
                        right = middle - 1;
                } while (left <= right);
                for (j = i - 1; j >= left; j--)
                    err[j + 1] = err[j];
                err[left] = x;
            }
    }
}
