// See https://aka.ms/new-console-template for more information
using DSA_Questions;

Console.WriteLine("Hello, World!");
/*  
// 1 Move zeros to right most 31/08/2025
int[] arr = { 1, 2, 0, 3, -1, 0};
InPlaceMove0ToRightEnd.MoveZeroRight(arr);
foreach(int var in arr)
{
    Console.WriteLine(var);
}
*/

/*
//2 Print the elements in spiral order 
int[,] arr =
{
    {1,2,3,4 },
    {5,6,7,8 },
    {9,10,11,12}
};
List<int> list = _2DSpiralMove.SpiralMove_2DMatrix(arr);
foreach(int var in list)
{
    Console.Write(var + " ");
}
*/

/*
 // 3 
 * 198. House Robber, https://leetcode.com/problems/house-robber/description/
 */

/*
// 4 Binary search
int[] arr = { 1, 2, 5, 6, 8, 9 };
int n = 6;
int index = BinarySearch.SearchElement(arr, n);
Console.WriteLine(index);
*/

/*
// 5 Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to the target.
int[] nums = { 2, 8, 7, 4, 5 };
int target = 10;
_2SUM_Problem.Two_Sum(nums, target);
*/

/*
// 6 https://leetcode.com/problems/longest-substring-without-repeating-characters/
string str = "abcdghabefh";//sting str2 = abcabcbb
Console.WriteLine(LongestSubStringWithoutRepeatingCharatcters.LengthOfLongestSubStringWithoutRepeatingCHaracters(str));
*/

/*
// 7 Get sum of 2D array elements, excluding diagonal elements
int[][] arr =
{
    new int[]{1, 2, 3 },
    new int[]{4, 5, 6 },
    new int[]{7, 8, 9}
};
int sum = Sum2DElementsExcludingDiagonal.GetSum(arr);
Console.WriteLine(sum);
*/

/*
//8 Print duplicate characters in the string 
string s = "Sftrgsrraakkz";
PrintDuplicateElements.printDuplicateElements(s);
*/


/*
//9 Allocate the subject for each semester based on the dependency

Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

dict.Add("s1", new List<string> { "s3", "s5"});
dict.Add("s2", new List<string> { "s3", "s4", "s5" });
dict.Add("s3", new List<string> { "s4" });
dict.Add("s4", new List<string> { "s5" });
dict.Add("s5", new List<string> { });

AssignSubjectForSem.assignSubjectForSem(dict); */

