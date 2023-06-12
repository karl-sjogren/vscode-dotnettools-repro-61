namespace AnalyzerProblems;

public static class Program {
    public static void Main() {
        Console.WriteLine("Hello World!");
    }

    public static async Task WaitABit() {
        await Task.Delay(1000);
    }
}
