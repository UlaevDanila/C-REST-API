using FluentValidation;
using JetBrains.Annotations;

namespace OrderProductService.Application.Commands.Categories.CreateCategory;

[UsedImplicitly]
public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator() // TODO правила
    {
        RuleFor(x => x.Name)
            .NotEmpty();
        RuleFor(x => x.Description)
            .NotEmpty();
    }
}