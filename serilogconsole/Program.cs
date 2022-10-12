using Serilog;

Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Verbose()   
                 .WriteTo.Console()   
                 .CreateLogger();

Log.Verbose("Log verbose");
Log.Debug("Log debug");
Log.Information("log information");
Log.Warning("log warning");
Log.Error("log error");
Log.Fatal("log fatal");
