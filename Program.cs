var builder = WebApplication.CreateBuilder(args);

// Configure for Railway deployment
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

// Add diagnostic endpoints
app.MapGet("/health", () => "PlanKrypto is running!");
app.MapGet("/api/status", () => new { status = "OK", timestamp = DateTime.UtcNow });
app.MapGet("/test", () => "Test endpoint working!");
app.MapGet("/", () => "Root endpoint - Razor Pages should handle this");

app.Run();
