using System.Collections;
using System.Diagnostics;
using System.Numerics;

namespace AdventOfCode2023
{
	static class Day06
	{
		internal static void Solve()
		{
			Console.WriteLine("Day 06");
			Console.WriteLine("------");

			var document = @"Time:        47     84     74     67
Distance:   207   1394   1209   1014";

			var documentLines = document.Split(Environment.NewLine);
			Debug.Assert(documentLines.Length == 2);
			var times = documentLines[0].Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
			var distances = documentLines[1].Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
			Debug.Assert(times.Length == distances.Length);
			var solution = 1;
			for (int i = 1; i < times.Length; i++)
			{
				var time = Convert.ToInt64(times[i]);
				var distance = Convert.ToInt64(distances[i]);
				var wins = 0;

				for(int j = 0; j <= time; j++)
				{
					var result = j * (time - j);
					if(result > distance)
					{
						wins++;
					}
				}

				Console.WriteLine($"Race time {time} distance {distance} has {wins} possible wins");
				solution *= wins;
			}

			Console.WriteLine($"Solution: {solution}");
		}
	}
}