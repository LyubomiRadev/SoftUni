using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double granica = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double newPrice = double.Parse(Console.ReadLine());
            double div = Proc(lastPrice, newPrice);

            //изчислява процентната разлика
            bool isSignificantDifference = imaliDif(div, granica);



            string message = Get(newPrice, lastPrice, div, isSignificantDifference);
            Console.WriteLine(message);

            lastPrice = newPrice;
        }
    }

    private static string Get(double newPrice, double oldPrice, double razlika, bool etherTrueOrFalse)
    {
        string outputText = "";
        if (razlika == 0)
        {
            outputText = string.Format("NO CHANGE: {0}", newPrice);
        }
        else if (!etherTrueOrFalse)
        {
            outputText = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", oldPrice, newPrice, razlika);
        }
        else if (etherTrueOrFalse && (razlika > 0))
        {
            outputText = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", oldPrice, newPrice, razlika);
        }
        else if (etherTrueOrFalse && (razlika < 0))
        {
            outputText = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", oldPrice, newPrice, razlika);
        }
        return outputText;
    }

    private static bool imaliDif(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double lastPrice, double newPrice)
    {
        double result = (newPrice - lastPrice) / lastPrice;
        return result;
    }
}
