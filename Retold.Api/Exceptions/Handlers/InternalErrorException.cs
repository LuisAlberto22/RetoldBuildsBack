
/*
using Microsoft.AspNetCore.Diagnostics;

namespace GimnasioApi.Exceptions.Handlers
{
	public class InternalErrorException : IExceptionHandler
	{
		private readonly ApiBodyResponseBuilder responseBuilder;

		public InternalErrorException(ApiBodyResponseBuilder responseBuilder)
		{
			this.responseBuilder = responseBuilder;
		}

		public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
		{
			if (exception is Exception)
			{
				httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
				httpContext.Response.ContentType = "application/json";
				ApiResponseBodyBuilderDirector.BuildInternalErrorResponse(responseBuilder);
				await httpContext.Response.WriteAsJsonAsync(responseBuilder.Build(), cancellationToken);
				return true;
			}
			return false;
		}
	}
}
*/