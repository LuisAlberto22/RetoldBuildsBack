//using GimnasioApi.Builder.Directors;
//using GimnasioApi.Builder;
//using Microsoft.AspNetCore.Diagnostics;

//namespace GimnasioApi.Exceptions.Handlers
//{
//	public class NotFoundExceptionHandler : IExceptionHandler
//	{
//		private readonly ApiBodyResponseBuilder responseBuilder;

//		public NotFoundExceptionHandler(ApiBodyResponseBuilder responseBuilder)
//		{
//			this.responseBuilder = responseBuilder;
//		}
//		public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
//		{
//			if (exception is not NotFoundException)
//			{
//				return false;
//			}
//			httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
//			httpContext.Response.ContentType = "application/json";
//			ApiResponseBodyBuilderDirector.BuildOKResponse(responseBuilder);
//			await httpContext.Response.WriteAsJsonAsync(responseBuilder.Build(), cancellationToken);
//			return true;
//		}
//	}
//}
