public class Class1
{
	public void SelectionSort()
	{
        for (i = 0; i < len - 1; i++)
        {
            min = i;
            for (j = i + 1; j < len; j++)
                if (err[j] < err[min])
                    min = j;
            swap = err[i];
            err[i] = err[min];
            err[min] = swap;
        }
    }
}
