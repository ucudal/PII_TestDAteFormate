namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{
    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        if (date.Length.Equals(10))
        {
            string dd = date.Substring(0, 2);
            string mm = date.Substring(3, 2);
            string yyyy = date.Substring(6, 4);
            if (!dd.Contains("/") && !mm.Contains("/") && !yyyy.Contains("/"))
            {
                string testDate = yyyy + "-" + mm + "-" + dd; //se corrigen los parametros de los Substring
                return testDate;
            }
            else
            {
                return date;
            }
        }
        else
        {
            return date;
        }

    }
    public string TestDate { get; set; }
    public DateFormatter(string date)
    {
        if (!string.IsNullOrEmpty(date) && date.Length.Equals(10))
        {
            this.TestDate = date;
        }
        else
        {
            Console.WriteLine($"La fecha \"{date}\" no es valida");
        }
    }


}
