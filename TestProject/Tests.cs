class TestProgram {
    public static void Main() {
        
        int[] arr = [1, 2, 3];

        foreach(int val in arr)
        {
            Console.WriteLine(val);
        }

        /**/

        int num1 = 300;
        int num2 = 200;
        var result = Math.Max(num1, num2);

        Console.WriteLine(result);
    
        /**/
        string[] identificators = ["B123", "C234", "A345", "C15","B177", "G3003", "C235", "B179"];
 
        foreach(string id in identificators)
        {
            if (id.StartsWith('B'))
            {
                Console.WriteLine($"The {id} starts with 'B'!");
            }
        }
        /**/
    }
} 