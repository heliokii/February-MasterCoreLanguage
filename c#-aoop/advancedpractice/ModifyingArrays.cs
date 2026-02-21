using System;

public class Program {
    public static string[] ChangeElement(string[] arr, int index, string newElement) {
        // Write code here
        if (index >= 0 && index < arr.Length){
            string[] result = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++){
                result[i] = arr[i];
            }
            result[index] = newElement;
            return result;
        }
        return arr;

    }

    public static void Main(string[] args) {
        string textArray = Console.ReadLine();
        int index = int.Parse(Console.ReadLine());
        string newElement = Console.ReadLine();
        string[] arr = textArray.Split(',');
        string[] modifiedArr = ChangeElement(arr, index, newElement);
        for (int i = 0; i < modifiedArr.Length; i++) {
            Console.Write(modifiedArr[i] + " ");
        }
    }
}