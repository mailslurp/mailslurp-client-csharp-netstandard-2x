/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
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
    ///  Class for testing ExpiredInboxDto
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ExpiredInboxDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ExpiredInboxDto
        //private ExpiredInboxDto instance;

        public ExpiredInboxDtoTests()
        {
            // TODO uncomment below to create an instance of ExpiredInboxDto
            //instance = new ExpiredInboxDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ExpiredInboxDto
        /// </summary>
        [Fact]
        public void ExpiredInboxDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" ExpiredInboxDto
            //Assert.IsType<ExpiredInboxDto>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'InboxId'
        /// </summary>
        [Fact]
        public void InboxIdTest()
        {
            // TODO unit test for the property 'InboxId'
        }
        /// <summary>
        /// Test the property 'EmailAddress'
        /// </summary>
        [Fact]
        public void EmailAddressTest()
        {
            // TODO unit test for the property 'EmailAddress'
        }

    }

}
