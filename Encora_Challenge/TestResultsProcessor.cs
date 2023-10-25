using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using CsvHelper;
using System.Globalization;

public class TestResultsProcessor
{
    public static void ProcessTestResults(string jsonFilePath, string csvFilePath)
    {
        var json = File.ReadAllText(jsonFilePath);
        var testResults = JsonConvert.DeserializeObject<List<TestCaseResult>>(json);

        // Calculate metrics
        var metrics = new TestMetrics
        {
            TotalTestCases = testResults.Count,
            PassedTestCases = testResults.Count(r => r.Status == "Pass"),
            FailedTestCases = testResults.Count(r => r.Status == "Fail"),
            AverageExecutionTime = testResults.Average(r => r.ExecutionTime),
            MinExecutionTime = testResults.Min(r => r.ExecutionTime),
            MaxExecutionTime = testResults.Max(r => r.ExecutionTime)
        };

        // Export to CSV
        using (var writer = new StreamWriter(csvFilePath))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            // Write the metrics table
            csv.WriteRecords(new List<TestMetrics> { metrics });

            // Write a separator
            csv.NextRecord();

            // Write the test results table
            csv.WriteRecord(new { TestName = "Test Case Name", Status = "Status", ExecutionTime = "Execution Time", Timestamp = "Time Stamp" });
            csv.NextRecord();

            csv.WriteRecords(testResults);
        }

        Console.WriteLine("Metrics:");
        Console.WriteLine($"Total Test Cases: {metrics.TotalTestCases}");
        Console.WriteLine($"Passed Test Cases: {metrics.PassedTestCases}");
        Console.WriteLine($"Failed Test Cases: {metrics.FailedTestCases}");
        Console.WriteLine($"Average Execution Time: {metrics.AverageExecutionTime} seconds");
        Console.WriteLine($"Min Execution Time: {metrics.MinExecutionTime} seconds");
        Console.WriteLine($"Max Execution Time: {metrics.MaxExecutionTime} seconds");
        Console.Write(Environment.NewLine);
        Console.WriteLine(" << CSV File Generated Succesfully! >>");
        Console.Write(Environment.NewLine);

    }
}
