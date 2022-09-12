namespace TestDateFormat;

/// <summary>
/// El programa principal.
/// </summary>
public static class Program
{
    /// <summary>
    /// Punto de entrada al programa principal.
    /// </summary>
    public static void Main()
    {
        string testDate1 = "10/11/1997";
        string dateFormat1 = DateFormatter.ChangeFormat(testDate1);
        DateFormatter formatDate1 = new DateFormatter(dateFormat1);
        Console.WriteLine($"{testDate1} se convierte a {formatDate1.TestDate}");
        string testDate2 = "10/11/199";
        string dateFormat2 = DateFormatter.ChangeFormat(testDate2);
        DateFormatter formatDate2 = new DateFormatter(dateFormat2);
    }
}