class Program
{
    static void Main(string[] args)
    {
        int c = 45;
        int d = 50;
        int b = 60;
        int[] numbers = { 6, 7, 8 };

        CustomArrResize(ref numbers, 45, 50, 60);
        Console.WriteLine("Yenilenmis massiv :" + 45, 50 , 60);
    }
    public static void CustomArrResize(ref int[] arr, params int[] nums)
    {
        int[] newArr = new int[arr.Length + nums.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            newArr[arr.Length + i] = nums[i];
        }
        arr = newArr;
    }
}