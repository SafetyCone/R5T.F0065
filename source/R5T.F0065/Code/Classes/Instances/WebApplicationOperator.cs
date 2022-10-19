using System;


namespace R5T.F0065
{
	public class WebApplicationOperator : IWebApplicationOperator
	{
		#region Infrastructure

	    public static IWebApplicationOperator Instance { get; } = new WebApplicationOperator();

	    private WebApplicationOperator()
	    {
        }

	    #endregion
	}
}