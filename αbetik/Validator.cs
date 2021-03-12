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
        public Validator()
        {
            RuleFor(p => p.TC).NotEmpty().WithMessage("TC kısmı boş bırakılmamalıdır.");
            RuleFor(t => t.Kurallar).NotEmpty().WithMessage("Kurallar kısmı boş bırakılmamalıdır.");
            RuleFor(c => c.TC).InclusiveBetween(9999999999,99999999999).WithMessage("Az veya çok haneli TC girildi.");

            
        }

    }
    
}