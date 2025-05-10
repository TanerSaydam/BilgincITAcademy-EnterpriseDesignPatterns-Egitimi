namespace CleanArchitecture.WebAPI;

public class MailBackgroundService : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        //Scoped lu bir service provider oluşturuyorsunuz

        await Task.CompletedTask;

        //using (var scoped = ServiceTool.ServiceProvider.CreateScope())
        //{
        //    //var productRepository = scoped.ServiceProvider.GetRequiredService<IProductRepository>();
        //}

        //HttpContextAccessor httpContextAccessor = new();
        //var httpContext = httpContextAccessor.HttpContext;
        //httpContext.RequestServices.CreateScope();

        while (!stoppingToken.IsCancellationRequested)
        {
            //using (var scoped = ServiceTool.ServiceProvider.CreateScope())
            //{
            //    //var productRepository = scoped.ServiceProvider.GetRequiredService<IProductRepository>();
            //}

            Console.WriteLine("I am working...");

            await Task.Delay(500);
        }

    }
}
