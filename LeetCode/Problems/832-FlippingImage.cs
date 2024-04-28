namespace LeetCode.Problems;
public class _832_FlippingImage
{
    //Problem: https://leetcode.com/problems/flipping-an-image/

    //Solution: https://leetcode.com/problems/flipping-an-image/submissions/1061414034/
    public int[][] FlipAndInvertImage(int[][] image)
    {
        foreach (var img in image)
        {
            for (int i = 0, j = img.Length - 1; i < j; i++, j--)
            {
                img[i] = img[i] + img[j];
                img[j] = img[i] - img[j];
                img[i] = img[i] - img[j];
            }
            for (int i = 0; i < img.Length; i++)
            {
                img[i] = img[i] == 0 ? 1 : 0;
            }
        }
        return image;
    }

    //Solution: https://leetcode.com/problems/flipping-an-image/submissions/1061430187/
    public int[][] FlipAndInvertImage_1(int[][] image)
    {
        foreach (var img in image)
        {
            for (int i = 0, j = img.Length - 1; i <= j; i++, j--)
            {
                int temp = img[i];
                img[i] = 1 - img[j];
                img[j] = 1 - temp;
            }
        }
        return image;
    }
}
