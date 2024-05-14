// See https://aka.ms/new-console-template for more information


var singleService = new SingleIntegrationService();

var tasks = new[]
{
            singleService.ProcessItemAsync("content1"),
            singleService.ProcessItemAsync("content2"),
            singleService.ProcessItemAsync("content1"), // Yinelenen içerik
            singleService.ProcessItemAsync("content3"),
            singleService.ProcessItemAsync("content2")  // Yinelenen içerik
        };

var results = await Task.WhenAll(tasks);

foreach (var result in results)
{
    Console.WriteLine(result);
}



var distributedService = new DistributedItemIntegrationService();

var tasks1= new[]
{
            distributedService.ProcessItemAsync("content1"),
            distributedService.ProcessItemAsync("content2"),
            distributedService.ProcessItemAsync("content1"), // Yinelenen içerik
            distributedService.ProcessItemAsync("content3"),
            distributedService.ProcessItemAsync("content2")  // Yinelenen içerik
        };

var results1 = await Task.WhenAll(tasks1);

foreach (var result in results1)
{
    Console.WriteLine(result);
}





