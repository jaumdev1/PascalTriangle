public class Solution {
    
 public IList<IList<int>> Generate(int numRows)
{
    List<IList<int>> pTriangle = new List<IList<int>>();

    int i = 0;

    while (i < numRows)
    {
        List<int> row = new List<int>();
        int j = 0;

        while (j <= i)
        {
            if (j == 0 || j == i)
            {
                row.Add(1);
            }
            else
            {
               
             int value = pTriangle[i - 1][j - 1] + pTriangle[i - 1][j];
                row.Add(value);
            }

            j++;
        }

        pTriangle.Add(row);
        i++;
    }

    return pTriangle;
}

}