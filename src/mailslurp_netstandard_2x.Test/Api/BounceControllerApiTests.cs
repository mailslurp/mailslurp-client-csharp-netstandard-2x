/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Api;
// uncomment below to import models
//using mailslurp_netstandard_2x.Model;

namespace mailslurp_netstandard_2x.Test.Api
{
    /// <summary>
    ///  Class for testing BounceControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BounceControllerApiTests : IDisposable
    {
        private BounceControllerApi instance;

        public BounceControllerApiTests()
        {
            instance = new BounceControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BounceControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BounceControllerApi
            //Assert.IsType<BounceControllerApi>(instance);
        }

        /// <summary>
        /// Test FilterBouncedRecipient
        /// </summary>
        [Fact]
        public void FilterBouncedRecipientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FilterBouncedRecipientsOptions filterBouncedRecipientsOptions = null;
            //var response = instance.FilterBouncedRecipient(filterBouncedRecipientsOptions);
            //Assert.IsType<FilterBouncedRecipientsResult>(response);
        }

        /// <summary>
        /// Test GetBouncedEmail
        /// </summary>
        [Fact]
        public void GetBouncedEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetBouncedEmail(id);
            //Assert.IsType<BouncedEmailDto>(response);
        }

        /// <summary>
        /// Test GetBouncedEmails
        /// </summary>
        [Fact]
        public void GetBouncedEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetBouncedEmails(page, size, sort, since, before);
            //Assert.IsType<PageBouncedEmail>(response);
        }

        /// <summary>
        /// Test GetBouncedRecipient
        /// </summary>
        [Fact]
        public void GetBouncedRecipientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetBouncedRecipient(id);
            //Assert.IsType<BouncedRecipientDto>(response);
        }

        /// <summary>
        /// Test GetBouncedRecipients
        /// </summary>
        [Fact]
        public void GetBouncedRecipientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetBouncedRecipients(page, size, sort, since, before);
            //Assert.IsType<PageBouncedRecipients>(response);
        }
    }
}
