﻿// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using LearnHubApp;

Console.WriteLine("Hello, World!");
var summary = BenchmarkRunner.Run<LoopTest>();