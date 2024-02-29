var stopWatch = new Stopwatch();

stopWatch.Start();

await Task.Delay(1000);

stopWatch.Stop();

stopWatch.Start();

await Task.Delay(1000);

stopWatch.Stop();

Console.WriteLine($"Duration : {stopWatch.Duration}");

//stopWatch.Start();

//stopWatch.Start(); //Will throw an InvalidOperationException here