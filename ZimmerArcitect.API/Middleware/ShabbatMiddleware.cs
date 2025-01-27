namespace ZimmerArcitect.API.Middleware
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;
        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public static bool IsTodaySaturday()
        {
            DateTime today = DateTime.Now;
            // בדיקה אם היום הוא שבת
            return today.DayOfWeek == DayOfWeek.Saturday;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Middleware begin");
            if (IsTodaySaturday() )
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
            await _next(context);
            Console.WriteLine("Middleware end");

        }
    }
}
