using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{

    public class Validator : AbstractValidator<ManagerPanelInformation>
    {
        //public Validator()
        //{
        //    RuleFor(p => p.TC).NotEmpty().WithMessage("TC kısmı boş bırakılmamalıdır.");
        //    RuleFor(t => t.Kurallar).NotEmpty().WithMessage("Kurallar kısmı boş bırakılmamalıdır.");
        //    RuleFor(c => c.TC).Must(Be11Digits).WithMessage("TC kısmı boş bırakılmamalıdır.");
        //}


        //private bool Be11Digits(long arg)
        //{

        //    return Convert.ToBoolean(arg.CompareTo(arg < 9999999999 && arg >= 99999999999));
        //}
    }
}