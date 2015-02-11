using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactJSExamples.Startup))]
namespace ReactJSExamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
