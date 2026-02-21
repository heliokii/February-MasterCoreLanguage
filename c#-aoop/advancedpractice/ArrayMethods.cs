using System;


public class Program {
    public static string[] Merge(string[] arr1, string[] arr2) {
        // Write code here
        string[] mergedArray = new string[arr1.Length + arr2.Length];

        Array.Copy(arr1, 0, mergedArray, 0, arr1.Length);
        Array.Copy(arr2, 0, mergedArray, arr1.Length, arr2.Length);
        Array.Sort(mergedArray);
        return mergedArray;

    }

    public static void Main(string[] args) {
        string textArr1 = Console.ReadLine();
        string textArr2 = Console.ReadLine();
        string[] arr1 = textArr1.Split(",");
        string[] arr2 = textArr2.Split(",");

        string[] mergedArray = Merge(arr1, arr2);
        Console.WriteLine(string.Join(", ", mergedArray));
    }
}