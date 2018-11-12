using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoRepair.ModelsDTO;
namespace AutoRepair.Filters
{
    public class ModelsCarResultFilterAttribute : ResultFilterAttribute
    {
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            var resultFromAction = context.Result as ObjectResult;
            if (resultFromAction?.Value == null || resultFromAction.StatusCode < 200 || resultFromAction.StatusCode >= 300)
            {
                await next();
                return;
            }
            resultFromAction.Value = AutoMapper.Mapper.Map<IEnumerable<ModelCarDto>>(resultFromAction.Value);
            await next();
        }
    }
}
