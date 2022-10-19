using System;


namespace R5T.F0065
{
    public static class Instances
    {
        public static IWebApplicationBuilderOperator WebApplicationBuilderOperator { get; } = F0065.WebApplicationBuilderOperator.Instance;
        public static IWebApplicationOperator WebApplicationOperator { get; } = F0065.WebApplicationOperator.Instance;

        public static IWebApplicationOperator WebApplication => Instances.WebApplicationOperator;
    }
}