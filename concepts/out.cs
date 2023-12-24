namespace Tfl;
public class Out{
   public void MathOut(int number1, int number2, out int Addition, out int Subtraction)
        {
            Addition = number1 + number2; //This will Update the Addition variable inside the Main method
            Subtraction = number1 - number2; //This will Update the Subtraction variable inside the Main method
        }
}