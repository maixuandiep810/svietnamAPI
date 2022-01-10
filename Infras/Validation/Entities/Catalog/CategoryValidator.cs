// using System.Security.Cryptography.X509Certificates;
// using FluentValidation;
// using svietnamAPI.Common.Dtos.Values.EntityValidationMessage.Catalog;
// using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

// namespace svietnamAPI.Infras.Validation.Entities.Catalog
// {
//     public class CategoryValidator : AbstractValidator<Category>
//     {
//         public CategoryValidator()
//         {
//             RuleFor(x => x.Name).NotEmpty().WithMessage(CategoryValidationMessageConst.NameNotEmpty);
//             RuleFor(x => x.Slug).NotEmpty().WithMessage(CategoryValidationMessageConst.SlugNotEmpty);
//         }
//     }
// }