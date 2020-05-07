using Microsoft.AspNetCore.Mvc.Filters;

namespace AdminService.Extensions
{
    interface IExceptionFilter: IFilterMetadata
    {
        void OnException(ExceptionContext context);
    }
}
