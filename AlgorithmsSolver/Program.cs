// See https://aka.ms/new-console-template for more information
using AlgorithmsSolver;
using AlgorithmsSolver.Queue;

//Console.WriteLine("Hello, World!");
//var ts = new TwoSums();
//var ts1 = ts.TwoSum([2, 7, 11, 15], 9);
//Console.WriteLine("{0} {1}", ts1[0], ts1[1]);

//var ts2 = ts.TwoSum([3, 2, 4], 6);
//Console.WriteLine("{0} {1}", ts2[0], ts2[1]);

//var ts3 = ts.TwoSum([3, 3], 6);
//Console.WriteLine("{0} {1}", ts3[0], ts3[1]);


//var rds = new RemoveDuplicatesSolver();
//var nums = new[] { 1, 1, 2 };
//var rds1 = rds.RemoveDuplicates(nums);
//Console.WriteLine(rds1);
//Console.WriteLine(string.Join(" ", nums));


//nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
//var rds2 = rds.RemoveDuplicates(nums);
//Console.WriteLine(rds2);
//Console.WriteLine(string.Join(" ", nums));

//var lengthOfLastWordSolver = new LengthOfLastWordSolver();

//var llw1 = lengthOfLastWordSolver.LengthOfLastWord("Hello World");
//Console.WriteLine(llw1);

//var llw2 = lengthOfLastWordSolver.LengthOfLastWord("   fly me   to   the moon  ");
//Console.WriteLine(llw2);

//var llw3 = lengthOfLastWordSolver.LengthOfLastWord("luffy is still joyboy");
//Console.WriteLine(llw3);

//var llw4 = lengthOfLastWordSolver.LengthOfLastWord("l     ");
//Console.WriteLine(llw4);

//var llw5 = lengthOfLastWordSolver.LengthOfLastWord("l");
//Console.WriteLine(llw5);


//var recentCounter = new RecentCounter();
//List<int> res = new List<int>();
//res.Add(recentCounter.Ping(1));
//res.Add(recentCounter.Ping(2));
//res.Add(recentCounter.Ping(3001));
//res.Add(recentCounter.Ping(3002));
//Console.WriteLine(string.Join(", ", res));


var countStudentsSolver = new CountStudentsSolver();

var res1 = countStudentsSolver.CountStudents([1, 1, 0, 0], [0, 1, 0, 1]);
Console.WriteLine(res1);

var res2 = countStudentsSolver.CountStudents([1, 1, 1, 0, 0, 1], [1, 0, 0, 0, 1, 1]);
Console.WriteLine(res2);