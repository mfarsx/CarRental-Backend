﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().MinimumLength(2);
            RuleFor(u => u.LastName).MinimumLength(2).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).EmailAddress();


        }
    }
}
