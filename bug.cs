public class ExampleClass{
    public int Calculate(int a, int b) {
        if (a == 0 || b == 0) {
            return 0; //This will cause an error if a and b are both 0
        }
        return a / b;
    }
}