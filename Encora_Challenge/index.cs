using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Programa
{
    static void Main(string[] args)
    {
        string jsonFilePath = "test_results.json";  // Specify the JSON file path
        string csvFilePath = "test_results.csv";    // Specify the CSV file path

        TestResultsProcessor.ProcessTestResults(jsonFilePath, csvFilePath);
    }
}
