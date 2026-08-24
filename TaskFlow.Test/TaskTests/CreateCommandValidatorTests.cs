using FluentValidation.TestHelper;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static TaskFlow.Application.Features.Tasks.Commands.Create;

namespace TaskFlow.Test.TaskTests
{
    //workflow 
    /*
     * 1- Valid Command 
     * 2- Validation Error Command
     * 3- Database interaction error Command
     * 
     * */
    public class CreateCommandValidatorTests 
    {
        private readonly Validator _validator = new Validator();


        [Fact]
        
        public void Should_Have_Error_When_Title_Is_Empty()
        {
            //arrange
            var command = new Command(string.Empty, "Valid Description");

            //Act
            var result = _validator.TestValidate(command);

            //Assert
            result.ShouldHaveValidationErrorFor(t => t.title).WithErrorMessage("Title is required");
        }


        
        [Fact]
        public void Should_Have_Error_When_Description_Is_Empty()
        {
            var command = new Command("title valid", "");

            var result = _validator.TestValidate(command);
            result.ShouldHaveValidationErrorFor(d => d.description).WithErrorMessage("Description is required.");
        }

        
        [Fact]
        public void Should_Not_Have_Error_When_Command_Is_Valid()
        {
            var command = new Command("Valid Title"," Valid Description");
            var result = _validator.TestValidate(command);
            result.ShouldNotHaveAnyValidationErrors();
        }
    }
}
