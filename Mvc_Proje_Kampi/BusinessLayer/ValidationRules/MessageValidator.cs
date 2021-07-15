using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            //Recevier Mail
            RuleFor(x => x.RecevierMail).NotEmpty().WithMessage("Alıcı Maili Boş Olamaz !");
            RuleFor(x => x.RecevierMail).EmailAddress().WithMessage("Alıcı Email adresiniz geçerli formatta değil. Lütfen geçerli formatta giriniz!");
            //Subject
            RuleFor(x => x.subject).NotEmpty().WithMessage("Konu Boş Olamaz !");
            //Content
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("İçerik Boş Olamaz !");
        }
    }
}
