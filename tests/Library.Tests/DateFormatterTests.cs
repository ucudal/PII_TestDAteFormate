using TestDateFormat;
using NUnit.Framework;

namespace Library.Tests;

public class DateFormatTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ChangeDateOkay()
    {
        //Configuración
        const string initialDate= "10/11/1997";
        const string expectedDate= "1997-11-10";

        //Ejecución
        string testDate= DateFormatter.ChangeFormat(initialDate);

        //Comprobación
        Assert.AreEqual(expectedDate, testDate);
    }

    [Test]
    public void ChangeDateWrong()
    {
        //Configuración
        const string initialWrongDate= "1/11/1997";
        const string expectedWrongDate= null;

        //Ejecución
        DateFormatter testDate= new DateFormatter(initialWrongDate);

        //Comprobación
        Assert.AreEqual(expectedWrongDate, testDate.TestDate);
    }

    [Test]
    public void EmptyDate()
    {
        //Configuración
        const string initialEmptyDate= " ";
        const string expectedEmptyDate= null;

        //Ejecución
        DateFormatter testEmptyDate= new DateFormatter(initialEmptyDate);

        //Comprobación
        Assert.AreEqual(expectedEmptyDate, testEmptyDate.TestDate);
    }
}