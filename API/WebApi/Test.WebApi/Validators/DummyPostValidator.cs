using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using Test.Helpers;

namespace MWK.WebApi.Validators
{
    //check for more details https://exceptionnotfound.net/custom-validation-in-asp-net-web-api-with-fluentvalidation/ 
    //also check https://www.exceptionnotfound.net/use-fluentvalidation-for-better-validation-framework-in-mvc/
    public class DummyPostValidator : AbstractValidator<DummyPost>
    {
        public DummyPostValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty().WithMessage("Name Cannot be empty");

            //RuleFor(model => model.cDocID)
            //    .NotEmpty().WithMessage("Order ID is required")
            //    .Length(1, 40).WithMessage("Order ID should be less than 40 characters");

            //RuleFor(model => model.cDocType)
            //    .NotEmpty().WithMessage("Order Type is required")
            //    .Length(1, 10).WithMessage("Order Type should be less than 10 characters");

            //RuleFor(model => model.cPosted)
            //    .Length(1).WithMessage("Posted should be either 'Y/N'");

            //RuleFor(model => model.cStatus)
            //    .Length(1).WithMessage("Status should be either 'N/R/C'");
        }

        private bool BeAValidDate(DateTime date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }

        private bool BeAValidDate(DateTime? date)
        {
            if (date == default(DateTime))
                return false;
            return true;
        }
    }
}