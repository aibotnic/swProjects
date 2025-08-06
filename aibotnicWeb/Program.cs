// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", async context =>
// {
//     context.Response.ContentType = "text/html";
//     await context.Response.WriteAsync(@"
//         <html>
//             <head>
//                 <style>
//                     body {
//                         color: red;
//                     }
//                     input, button {
//                         color: red;
//                         border: 2px solid red;
//                         background-color: #ffe6e6;
//                     }
//                 </style>
//             </head>
//             <body>
//                 <form method='post' action='/submit'>
//                     <label for='name'>Enter your name here:</label>
//                     <input type='text' id='name' name='name' />
//                     <button type='submit'>Submit</button>
//                 </form>
//             </body>
//         </html>
//     ");
// });

// app.MapPost("/submit", async context =>
// {
//     var form = await context.Request.ReadFormAsync();
//     var name = form["name"];

//     context.Response.ContentType = "text/html";
//     await context.Response.WriteAsync($@"
//         <html>
//             <head>
//                 <style>
//                     body {{
//                         color: red;
//                     }}
//                     a {{
//                         color: red;
//                     }}
//                 </style>
//             </head>
//             <body>
//                 <p>Hello, {name}!</p>
//                 <a href='/'>Go back</a>
//             </body>
//         </html>
//     ");
// });

// app.Run();




// var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddDistributedMemoryCache();
// builder.Services.AddSession();

// var app = builder.Build();

// app.UseStaticFiles();
// app.UseSession();

// // Register routes from other files
// IndexHandler.MapIndexRoutes(app);
// AboutHandler.MapAboutRoutes(app);


// app.MapGet("/", context =>
// {
//     context.Response.Redirect("/index.html");
//     return Task.CompletedTask;
// });


// app.Run();




// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// // Serve static files from wwwroot
// app.UseStaticFiles();

// // Optional: redirect root to index.html
// app.MapGet("/", context =>
// {
//     context.Response.Redirect("/index.html");
//     return Task.CompletedTask;
// });

// // Handle form submission
// app.MapPost("/submit", async context =>
// {
//     var form = await context.Request.ReadFormAsync();
//     var name = form["name"];

//     context.Response.ContentType = "text/html";
//     await context.Response.WriteAsync($@"
//         <html>
//             <head>
//                 <style>
//                     body {{
//                         color: red;
//                     }}
//                     a {{
//                         color: red;
//                     }}
//                 </style>
//             </head>
//             <body>
//                 <p>Hello, {name}!</p>
//                 <a href='/index.html'>Go back</a>
//             </body>
//         </html>
//     ");
// });

// app.Run();





// var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddDistributedMemoryCache();
// builder.Services.AddSession();

// var app = builder.Build();

// app.UseStaticFiles();
// app.UseSession();

// // Register routes from other files
// IndexHandler.MapIndexRoutes(app);
// //AboutHandler.MapAboutRoutes(app);

// app.Run();


//AibotnicWeb.Handlers; // Adjust based on your namespace



using aibotnicWeb.Handlers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

var app = builder.Build();

app.UseStaticFiles(); // Serves files from wwwroot
app.UseSession();

// Redirect root ("/") to index.html
app.MapGet("/", context =>
{
<<<<<<< HEAD
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(@"
        <html>
            <head>
                <style>
                    body {
                        color: red;
                    }
                    input, button {
                        color: red;
                        border: 2px solid red;
                        background-color: #ffe6e6;
                    }
                </style>
            </head>
            <body>
                <form method='post' action='/submit'>
                    <label for='name'>my new form</label></br>
                    <label for='name'>Enter your name here:</label>
                    <input type='text' id='name' name='name' />
                    <button type='submit'>Submit</button>
                </form>
            </body>
        </html>
    ");
=======
    context.Response.Redirect("/index.html");
    return Task.CompletedTask;
>>>>>>> f2d8a984425a5c4f614379874e356d444bcbaa2b
});

// Register routes from IndexHandler.cs
IndexHandler.MapIndexRoutes(app);

app.Run();
