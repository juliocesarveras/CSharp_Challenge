# CSharp_Challenge

Scenario: C# Solution for Test Results Analysis

 

Challenge Description: Assume that you are given a JSON file containing the results of an executed test case. Your task is to create a C# program that processes this JSON data, converts it into a CSV file format, exports it, and generates various metrics based on the test results.

Requirements:

**Script Requirements:** The presented solution must work successfully without requiring any edits to the script. Candidates must provide clear instructions on how to execute the script and specify any requirements it has.

JSON Format Assumption: Candidates can assume any JSON format/structure for their solution, but they need to explicitly mention what the assumed JSON format content is in their code documentation or comments.

CSV Export: Create a CSV file from the parsed data that includes details such as test case names, pass/fail status, execution times, and timestamps.

Export Functionality: Implement a mechanism to export the generated CSV file to a specified location on the filesystem.

Metrics Calculation: Calculate and display the following metrics based on the test results:
Total number of test cases executed.
Number of test cases passed.
Number of test cases failed.
Average execution time for all test cases.
Minimum execution time among all test cases.
Maximum execution time among all test cases.

Code Quality: Ensure that the code is well-formatted, follows coding conventions, and is easy to read and understand.
Modularity and SOLID Principles: Design the code in a modular way,

<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
       Challenge completed 
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

Instructions for executing the script:

Create a C# project in your development environment.

Add the Newtonsoft.Json and CsvHelper NuGet packages to your project to handle JSON and CSV processing. You can install these packages using NuGet Package Manager.

Replace the file paths jsonFilePath and csvFilePath in the Main method with the paths to your JSON input file and the desired CSV output file (I provided two files as examples). 

Build and run the project.

The format of the JSON file created is a plain JSON object array. This is a common and standard format for representing a list of objects in JSON. Each object in the array represents a test case result with properties such as TestName, Status, ExecutionTime, and Timestamp. This JSON format is a structured way to store data with each object having key-value pairs.

 The script is designed with modularity and adheres to SOLID principles for maintainability and extensibility.
