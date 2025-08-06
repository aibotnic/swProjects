var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
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
});

app.MapPost("/submit", async context =>
{
    var form = await context.Request.ReadFormAsync();
    var name = form["name"];

    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync($@"
        <html>
            <head>
                <style>
                    body {{
                        color: red;
                    }}
                    a {{
                        color: red;
                    }}
                </style>
            </head>
            <body>
                <p>Hello, {name}!</p>
                <a href='/'>Go back</a>
            </body>
        </html>
    ");
});

app.Run();

