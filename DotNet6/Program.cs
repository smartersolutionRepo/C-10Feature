// See https://aka.ms/new-console-template for more information
using DotNet6;
using var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

DotNetDateOnly.Print();
DotNetLinq.Print();
await DotNetPeriodicTimer.PrintAsync();
await DotNetPriorityQueue.PrintAsync();
await ParallelForEach.PrintAsync();
await SystemTextJson.PrintAsync();
