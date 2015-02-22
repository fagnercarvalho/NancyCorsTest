namespace NancyCorsTest
{
    using Nancy;
    using Nancy.Bootstrapper;
    using Nancy.TinyIoc;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            pipelines.AfterRequest.AddItemToEndOfPipeline((ctx) => 
                ctx.Response.WithHeader("Access-Control-Allow-Origin", "*"));
        }
    }
}