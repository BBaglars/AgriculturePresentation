using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules;

public class TeamValidator : AbstractValidator<Team>
{
    public TeamValidator()
    {
        RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım arkadaşı ismini boş geçemezsiniz");
        RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapınız");
        RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız");
        RuleFor(x => x.Title).NotEmpty().WithMessage("Görev kısmını boş geçemezsiniz");
        RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapınız");
        RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız");
        RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel kısmını boş geçemezsiniz");
    }
}