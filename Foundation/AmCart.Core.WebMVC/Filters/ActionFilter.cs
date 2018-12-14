using AmCart.Core.ValueObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;

namespace AmCart.Core.WebMVC.Filters
{
    public class ActionFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Guid corelationId = (Guid)context.HttpContext.Items["CorelationId"];


            //post processing logic
            base.OnActionExecuted(context);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Items["CorelationId"] = Guid.NewGuid();
            //pre processing logic
            base.OnActionExecuting(context);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var objectResult = context.Result as ObjectResult;
            var actionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;

            if (objectResult != null
                && objectResult.Value != null
                && typeof(OperationResult<>).Name == actionDescriptor.MethodInfo.ReturnType.Name
                )
            {
                Type operationResultType = typeof(OperationResult<>);
                Type genericType = operationResultType.MakeGenericType(actionDescriptor.MethodInfo.ReturnType.GenericTypeArguments);
                dynamic actionResult = Convert.ChangeType(objectResult.Value, genericType);
                if (!actionResult.IsSuccess)
                {
                    int errorCode = ErrorCodeToHttpCodeMapping(actionResult.MainMessage.Code);
                    objectResult.StatusCode = errorCode;
                }

            }
            base.OnResultExecuting(context);
        }

        private int ErrorCodeToHttpCodeMapping(string errorCode)
        {
            ResourceManager rm = new ResourceManager("Amcart.Core.WebMVC.ErrorResource",
                typeof(AmCart.Core.WebMVC.ErrorResource).GetTypeInfo().Assembly);

            String httpCode = rm.GetString(errorCode);
            return Int32.Parse(httpCode);
        }
    }
}
