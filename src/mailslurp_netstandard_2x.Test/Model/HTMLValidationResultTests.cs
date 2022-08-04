/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Model;
using mailslurp_netstandard_2x.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace mailslurp_netstandard_2x.Test.Model
{
    /// <summary>
    ///  Class for testing HTMLValidationResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class HTMLValidationResultTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for HTMLValidationResult
        //private HTMLValidationResult instance;

        public HTMLValidationResultTests()
        {
            // TODO uncomment below to create an instance of HTMLValidationResult
            //instance = new HTMLValidationResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HTMLValidationResult
        /// </summary>
        [Fact]
        public void HTMLValidationResultInstanceTest()
        {
            // TODO uncomment below to test "IsType" HTMLValidationResult
            //Assert.IsType<HTMLValidationResult>(instance);
        }


        /// <summary>
        /// Test the property 'IsValid'
        /// </summary>
        [Fact]
        public void IsValidTest()
        {
            // TODO unit test for the property 'IsValid'
        }
        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Fact]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
        }
        /// <summary>
        /// Test the property 'Warnings'
        /// </summary>
        [Fact]
        public void WarningsTest()
        {
            // TODO unit test for the property 'Warnings'
        }

    }

}
