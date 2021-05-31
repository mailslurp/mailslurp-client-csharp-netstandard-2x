/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository 
 *
 * The version of the OpenAPI document: 6.5.2
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
    ///  Class for testing SentEmailsControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SentEmailsControllerApiTests : IDisposable
    {
        private SentEmailsControllerApi instance;

        public SentEmailsControllerApiTests()
        {
            instance = new SentEmailsControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SentEmailsControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SentEmailsControllerApi
            //Assert.IsType<SentEmailsControllerApi>(instance);
        }

        /// <summary>
        /// Test GetSentEmail
        /// </summary>
        [Fact]
        public void GetSentEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetSentEmail(id);
            //Assert.IsType<SentEmailDto>(response);
        }

        /// <summary>
        /// Test GetSentEmails
        /// </summary>
        [Fact]
        public void GetSentEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? inboxId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetSentEmails(inboxId, page, size, sort);
            //Assert.IsType<PageSentEmailProjection>(response);
        }

        /// <summary>
        /// Test GetSentOrganizationEmails
        /// </summary>
        [Fact]
        public void GetSentOrganizationEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? inboxId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetSentOrganizationEmails(inboxId, page, size, sort);
            //Assert.IsType<PageSentEmailProjection>(response);
        }
    }
}
