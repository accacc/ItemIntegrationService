// See https://aka.ms/new-console-template for more information


using ItemIntegrationService;

var singleService = new SingleIntegrationService();

var tasks = new[]
{
            singleService.ProcessItemAsync(new ServiceJob("A")),
            singleService.ProcessItemAsync(new ServiceJob("B")),
            singleService.ProcessItemAsync(new ServiceJob("A")),
            singleService.ProcessItemAsync(new ServiceJob("A")),
            singleService.ProcessItemAsync(new ServiceJob("C")) 
        };

var results = await Task.WhenAll(tasks);

foreach (var result in results)
{
    Console.WriteLine(result.Message);
}



var distributedService = new DistributedItemIntegrationService();

var tasks1= new[]
{
            distributedService.ProcessItemAsync(new ServiceJob("A")),
            distributedService.ProcessItemAsync(new ServiceJob("B")),
            distributedService.ProcessItemAsync(new ServiceJob("B")),
            distributedService.ProcessItemAsync(new ServiceJob("C")),
            distributedService.ProcessItemAsync(new ServiceJob("A")),
            distributedService.ProcessItemAsync(new ServiceJob("D")),
        };

var results1 = await Task.WhenAll(tasks1);

foreach (var result in results1)
{
    Console.WriteLine(result.Message);
}





