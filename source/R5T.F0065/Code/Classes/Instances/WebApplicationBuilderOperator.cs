using System;


namespace R5T.F0065
{
	public class WebApplicationBuilderOperator : IWebApplicationBuilderOperator
	{
		#region Infrastructure

	    public static IWebApplicationBuilderOperator Instance { get; } = new WebApplicationBuilderOperator();

	    private WebApplicationBuilderOperator()
	    {
        }

	    #endregion
	}
}