using System.Security.Cryptography.X509Certificates;
using FluentValidation;
using svietnamAPI.Common.Dtos.Catalog;
using svietnamAPI.Common.Dtos.Values.ValidationMessage.Dtos.Catalog;

namespace svietnamAPI.Infras.Validation.Dtos.Catalog
{
    public class CreateCategoryDtoValidator : AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(CreateCategoryDtoValidationMessageConst.NameNotEmpty);
        }
    }
}