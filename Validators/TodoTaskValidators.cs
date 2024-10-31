using FluentValidation;
using TaskerAPI.Models.DTOs;

namespace TaskerAPI.Validators
{
    public class CreateTodoTaskValidator : AbstractValidator<CreateTodoTaskDTO>
    {
        public CreateTodoTaskValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(100);

            RuleFor(x => x.DueDate)
                .Must(x => x == null || x > DateTime.UtcNow)
                .WithMessage("Due date must be in the future");
        }
    }

    public class UpdateTodoTaskValidator : AbstractValidator<UpdateTodoTaskDTO>
    {
        public UpdateTodoTaskValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(100);

            RuleFor(x => x.Status)
                .IsInEnum()
                .WithMessage("Invalid status value");

            RuleFor(x => x.DueDate)
                .Must(x => x == null || x > DateTime.UtcNow)
                .WithMessage("Due date must be in the future");
        }
    }
} 