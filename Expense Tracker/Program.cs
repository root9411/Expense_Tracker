using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"));
});

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVFpHaVZdX2NLfUNwT2FZdV5xZCQ7a15RRnVfQF1kSXhXckBqWX1cdg==;Mgo+DSMBPh8sVXJ0S0J+XE9AflRBQmpWfFN0RnNfdVxwflVHcC0sT3RfQF5jS35UdkNnXXpXcHBXQA==;ORg4AjUWIQA/Gnt2VVhkQlFacldJXnxAYVF2R2BJeVRydF9GYUwgOX1dQl9gSXxTcUVlXXtbeXRQT2Y=;MTA3OTU4NEAzMjMwMmUzNDJlMzBJRUhFMmNKd0FnNzRpcG8yWEMzZ3R5Qzd5L2g1TndMMjYwRkhLcVR3bTNJPQ==;MTA3OTU4NUAzMjMwMmUzNDJlMzBlZmxTTFczWE9wUENPdFo2Vmx2Nk5Od1pKay81aVpJVGtEbXZQVUVCVGZRPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmBWd0x0RWFab1h6dlVMYF1BNQtUQF1hSn5RdkJjX3tadX1URWNa;MTA3OTU4N0AzMjMwMmUzNDJlMzBVNW55UXJJcmxVZGRYWTJuTlRuK1Z6QUNjSisvMG9QdC9aaGFGVzdSbEpnPQ==;MTA3OTU4OEAzMjMwMmUzNDJlMzBWY3VadStSWHhrMTlkSUgyK09nV3pIWW4yczJoOUhtQU5oaXB0cHdMeDV3PQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJXnxAYVF2R2BJeVRydF9GYUwgOX1dQl9gSXxTcUVlXXtbeXZQQ2Y=;MTA3OTU5MEAzMjMwMmUzNDJlMzBocENnRlprZ0Z5cVFteDBveTZCYXhUajkrSVp3bTRzUHRGaWhob1NDakNzPQ==;MTA3OTU5MUAzMjMwMmUzNDJlMzBqV21tRDdEaU0rOVlKOU9peU0zYUY2Y0p5ajV6OGZDS043VHo5azNqdGZzPQ==;MTA3OTU5MkAzMjMwMmUzNDJlMzBVNW55UXJJcmxVZGRYWTJuTlRuK1Z6QUNjSisvMG9QdC9aaGFGVzdSbEpnPQ==");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
