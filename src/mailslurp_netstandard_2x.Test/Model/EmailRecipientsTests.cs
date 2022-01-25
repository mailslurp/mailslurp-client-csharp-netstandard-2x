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
    ///  Class for testing EmailRecipients
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EmailRecipientsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EmailRecipients
        //private EmailRecipients instance;

        public EmailRecipientsTests()
        {
            // TODO uncomment below to create an instance of EmailRecipients
            //instance = new EmailRecipients();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmailRecipients
        /// </summary>
        [Fact]
        public void EmailRecipientsInstanceTest()
        {
            // TODO uncomment below to test "IsType" EmailRecipients
            //Assert.IsType<EmailRecipients>(instance);
        }


        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            // TODO unit test for the property 'To'
        }
        /// <summary>
        /// Test the property 'Cc'
        /// </summary>
        [Fact]
        public void CcTest()
        {
            // TODO unit test for the property 'Cc'
        }
        /// <summary>
        /// Test the property 'Bcc'
        /// </summary>
        [Fact]
        public void BccTest()
        {
            // TODO unit test for the property 'Bcc'
        }

    }

}
