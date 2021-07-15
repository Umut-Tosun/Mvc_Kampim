using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator ()
        {
            //userName
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Olamaz .");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı Adı En Az 3 Karakter Olmalıdır.");
            //UserMail
            RuleFor(x=>x.UserMail).NotEmpty().WithMessage("Mail Adresi Boş Olamaz.");
            RuleFor(x => x.UserMail).EmailAddress().WithMessage("Email Adresiniz Geçerli Formatta Değil. Lütfen Geçerli Formatta Giriniz!");
            //Subject
            RuleFor(x=>x.Subject).NotEmpty().WithMessage("Konu Adı Boş Olamaz.");
            RuleFor(x => x.Subject).MaximumLength(30).WithMessage("Konu Adı 20 Karakterden Az Olmalıdır.");
            //Message
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj Boş Olamaz.");
            RuleFor(x => x.Message).MaximumLength(200).WithMessage("Mesaj İçerigi 200 Karakterden Fazla Olamaz.");
           
        }
    }
}
