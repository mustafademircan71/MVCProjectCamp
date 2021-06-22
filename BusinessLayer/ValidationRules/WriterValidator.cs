using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçilemez");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Lütfen en az 2 Karakter girişi yapınız");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayınız");
        }

    }
}
