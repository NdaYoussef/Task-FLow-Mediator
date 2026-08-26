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

    #region Methods for NUint 

    //public void SetUp()
    //{
    //    // Initialize any required dependencies or test data here
    //}


    //public void TearDown()
    //{
    //    // Clean up any resources or reset state after each test
    //}

    //public void OneTimeSetUp()
    //{
    //    // Perform any one-time setup before all tests
    //}

    //public void OneTimeTearDown()
    //{
    //    // Perform any one-time cleanup after all tests
    //} 
    #endregion

    public class CreateCommandValidatorTests 
    {
        private readonly Validator _validator;

        //act as SetUp
        public CreateCommandValidatorTests()
        {
            _validator = new Validator();
        }

        public void Dispose()
        {
            // Cleanup
        }


        #region Test Using Fact
        //[Fact]

        //public void Should_Have_Error_When_Title_Is_Empty()
        //{
        //    //arrange
        //    var command = new Command(string.Empty, "Valid Description");

        //    //Act
        //    var result = _validator.TestValidate(command);

        //    //Assert
        //    result.ShouldHaveValidationErrorFor(t => t.title).WithErrorMessage("Title is required");
        //}



        //[Fact]
        //public void Should_Have_Error_When_Description_Is_Empty()
        //{
        //    var command = new Command("title valid", "");

        //    var result = _validator.TestValidate(command);
        //    result.ShouldHaveValidationErrorFor(d => d.description).WithErrorMessage("Description is required.");
        //} 
        #endregion


        [Theory]
        [InlineData("", "Valid Description")]
        [InlineData("Valid Title", "")]
        [InlineData("Valid Title", "Valid Description")]
        public void Should_Not_Have_Error_When_Command_Is_Valid(string Title , string Description)
        {
            var command = new Command(Title, Description);
            var result = _validator.TestValidate(command);
            result.ShouldNotHaveAnyValidationErrors();
        }
    }
}
