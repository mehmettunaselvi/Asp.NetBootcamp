var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Server tarafinda context uzerinden status code gonderme.
app.Run(async(HttpContext context) =>
{
    context.Response.StatusCode = 400;
    //Response body'e yazmak icin gerekli metot.
    await context.Response.WriteAsJsonAsync("This is a Response Message from Kestrel");


    }); 

app.Run();
