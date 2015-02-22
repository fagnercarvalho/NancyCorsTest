namespace NancyCorsTest
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Post["/test"] = parameters =>
                {
                    this.EnableCors();

                    return this.Response.AsText("Testing CORS!");
                };
        }
    }
}