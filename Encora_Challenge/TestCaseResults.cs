using CsvHelper.Configuration.Attributes;

public class TestCaseResult
{
 [  Name("Test Case Name")]
    public string TestName { get; set; }

    [Name("Status")]
    public string Status { get; set; }

    [Name("Execution Time")]
    public double ExecutionTime { get; set; }

    [Name("Time Stamp")]
    public DateTime Timestamp { get; set; }

}
