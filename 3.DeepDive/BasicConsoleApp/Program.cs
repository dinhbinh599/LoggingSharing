using System.Text.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .SetMinimumLevel(LogLevel.Debug)
        .AddJsonConsole(options =>
        {
            options.TimestampFormat = "HH:mm:ss";
            options.JsonWriterOptions = new JsonWriterOptions()
            {
                Indented = true
            };
        });
});

var logger = loggerFactory.CreateLogger<Program>();

var name = "Tuan";
var age = 24;

try
{
    throw new Exception("Something went wrong");
}
catch (Exception ex)
{
    logger.LogError(ex, "Failure during birthday of {Name} who is {Age}", name, age);
}
