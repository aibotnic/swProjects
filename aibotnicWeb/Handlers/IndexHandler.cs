// namespace aibotnicWeb.Handlers
// {
//     public static class IndexHandler
//     {
//         public static void MapIndexRoutes(WebApplication app)
//         {
//             app.MapPost("/submit", async context =>
//             {
//                 var form = await context.Request.ReadFormAsync();
//                 var name = form["name"];

//                 context.Response.ContentType = "text/html";
//                 await context.Response.WriteAsync($@"
//                     <html>
//                         <body style='color:red;'>
//                             <p>Hello, {name}!</p>
//                             <a href='/index.html'>Go back</a>
//                         </body>
//                     </html>
//                 ");
//             });
//         }
        
//     }
    
// }



namespace aibotnicWeb.Handlers
{
    public static class IndexHandler
    {
        public static void MapIndexRoutes(WebApplication app)
        {
            // Handle form submission
            app.MapPost("/submit", async context =>
            {
                var form = await context.Request.ReadFormAsync();
                var name = form["name"];

                context.Response.ContentType = "text/html";
                await context.Response.WriteAsync($@"
                    <html>
                        <body style='color:red;'>
                            <p>Hello, {name}!</p>
                            <a href='/index.html'>Go back</a>
                        </body>
                    </html>
                ");
            });

            // SSE endpoint for counting
            app.MapGet("/count-stream", async context =>
            {
                //context.Response.Headers.Add("Content-Type", "text/event-stream");

                context.Response.Headers["Content-Type"] = "text/event-stream";

                for (int i = 1; i <= 10; i++)
                {
                    await context.Response.WriteAsync($"data: {i}\n\n");
                    await context.Response.Body.FlushAsync();
                    await Task.Delay(2000); // 2 seconds
                }
            });
        }
    }
}
