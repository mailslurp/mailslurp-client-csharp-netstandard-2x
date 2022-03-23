/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository
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
    ///  Class for testing ValidateEmailAddressListResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ValidateEmailAddressListResultTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ValidateEmailAddressListResult
        //private ValidateEmailAddressListResult instance;

        public ValidateEmailAddressListResultTests()
        {
            // TODO uncomment below to create an instance of ValidateEmailAddressListResult
            //instance = new ValidateEmailAddressListResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ValidateEmailAddressListResult
        /// </summary>
        [Fact]
        public void ValidateEmailAddressListResultInstanceTest()
        {
            // TODO uncomment below to test "IsType" ValidateEmailAddressListResult
            //Assert.IsType<ValidateEmailAddressListResult>(instance);
        }


        /// <summary>
        /// Test the property 'ValidEmailAddresses'
        /// </summary>
        [Fact]
        public void ValidEmailAddressesTest()
        {
            // TODO unit test for the property 'ValidEmailAddresses'
        }
        /// <summary>
        /// Test the property 'InvalidEmailAddresses'
        /// </summary>
        [Fact]
        public void InvalidEmailAddressesTest()
        {
            // TODO unit test for the property 'InvalidEmailAddresses'
        }
        /// <summary>
        /// Test the property 'ResultMapEmailAddressIsValid'
        /// </summary>
        [Fact]
        public void ResultMapEmailAddressIsValidTest()
        {
            // TODO unit test for the property 'ResultMapEmailAddressIsValid'
        }

    }

}