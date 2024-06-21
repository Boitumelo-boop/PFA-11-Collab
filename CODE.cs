public class Converter
{
    public double ConvertKilometersToMiles(double kilometers)
    {
        double conversionFactor = 0.621371;
        double miles = kilometers * conversionFactor;
        return miles;
    }
}
public class VATCalculator
{
    public double CalculateTotalAmountWithVAT(double amount)
    {
        double vatRate = 0.15;
        double vatAmount = amount * vatRate;
        double totalAmountWithVAT = amount + vatAmount;
        return totalAmountWithVAT;
    }
}


