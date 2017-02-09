using System;
using System.ComponentModel.DataAnnotations;

namespace Rently.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {

        //custom data annotation for registration when member has to have at least 18 ys of age
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //we cast with a customer object
            var customer = (Customer)validationContext.ObjectInstance;

            //we select te membershipt type
            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            //birtday is compulsory
            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to go on a membership.");
        }
    }
}