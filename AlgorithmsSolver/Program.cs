// See https://aka.ms/new-console-template for more information
using AlgorithmsSolver;

//Console.WriteLine("Hello, World!");
//var ts = new TwoSums();
//var ts1 = ts.TwoSum([2, 7, 11, 15], 9);
//Console.WriteLine("{0} {1}", ts1[0], ts1[1]);

//var ts2 = ts.TwoSum([3, 2, 4], 6);
//Console.WriteLine("{0} {1}", ts2[0], ts2[1]);

//var ts3 = ts.TwoSum([3, 3], 6);
//Console.WriteLine("{0} {1}", ts3[0], ts3[1]);


var rds = new RemoveDuplicatesSolver();
var nums = new[] { 1, 1, 2 };
var rds1 = rds.RemoveDuplicates(nums);
Console.WriteLine(rds1);
Console.WriteLine(string.Join(" ", nums));


nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
var rds2 = rds.RemoveDuplicates(nums);
Console.WriteLine(rds2);
Console.WriteLine(string.Join(" ", nums));