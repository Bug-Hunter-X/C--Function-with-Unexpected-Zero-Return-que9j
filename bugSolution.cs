public class ExampleClass{
    public int Calculate(int a, int b) {
        if (a == 0 && b == 0) {
            throw new ArgumentException("Both a and b cannot be 0."); // Handle both being 0
        } else if (a == 0 || b == 0) {
            return 0; // Handle either being 0
        }
        return a / b;
    }
}