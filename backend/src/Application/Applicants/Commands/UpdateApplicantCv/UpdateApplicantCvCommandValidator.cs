using Application.Common.Files;
using Application.Common.Validators;
using FluentValidation;

namespace Application.Applicants.Commands
{
    public class UpdateApplicantCvCommandValidator : AbstractValidator<UpdateApplicantCvCommand>
    {
        public UpdateApplicantCvCommandValidator()
        {
            RuleFor(_ => _.NewCvFileDto)
                .ExtensionMustBeInList(new FileExtension[] { FileExtension.Pdf })
                .When(_ => _.NewCvFileDto != null);
        }
    }
}
