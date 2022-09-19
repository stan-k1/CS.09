﻿Console.WriteLine("Hello, World!");
var task = Task.Run(() =>
        {
            Console.WriteLine("Heavy Task Running");
            Task.Delay(1000);
            Console.WriteLine("Heavy Task Complete");
            return new string("Heavy Task Result");
        }
    );
Console.WriteLine("Execution resuming in main thread");
var resultingObj = await task;
Console.WriteLine(resultingObj);

