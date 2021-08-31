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
    ///  Class for testing WaitForControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WaitForControllerApiTests : IDisposable
    {
        private WaitForControllerApi instance;

        public WaitForControllerApiTests()
        {
            instance = new WaitForControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WaitForControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WaitForControllerApi
            //Assert.IsType<WaitForControllerApi>(instance);
        }

        /// <summary>
        /// Test WaitFor
        /// </summary>
        [Fact]
        public void WaitForTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WaitForConditions waitForConditions = null;
            //var response = instance.WaitFor(waitForConditions);
            //Assert.IsType<List<EmailPreview>>(response);
        }

        /// <summary>
        /// Test WaitForEmailCount
        /// </summary>
        [Fact]
        public void WaitForEmailCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? count = null;
            //long? delay = null;
            //Guid? inboxId = null;
            //DateTime? since = null;
            //string sort = null;
            //long? timeout = null;
            //bool? unreadOnly = null;
            //var response = instance.WaitForEmailCount(count, delay, inboxId, since, sort, timeout, unreadOnly);
            //Assert.IsType<List<EmailPreview>>(response);
        }

        /// <summary>
        /// Test WaitForLatestEmail
        /// </summary>
        [Fact]
        public void WaitForLatestEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? delay = null;
            //Guid? inboxId = null;
            //DateTime? since = null;
            //string sort = null;
            //long? timeout = null;
            //bool? unreadOnly = null;
            //var response = instance.WaitForLatestEmail(delay, inboxId, since, sort, timeout, unreadOnly);
            //Assert.IsType<Email>(response);
        }

        /// <summary>
        /// Test WaitForMatchingEmails
        /// </summary>
        [Fact]
        public void WaitForMatchingEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MatchOptions matchOptions = null;
            //int? count = null;
            //long? delay = null;
            //Guid? inboxId = null;
            //DateTime? since = null;
            //string sort = null;
            //long? timeout = null;
            //bool? unreadOnly = null;
            //var response = instance.WaitForMatchingEmails(matchOptions, count, delay, inboxId, since, sort, timeout, unreadOnly);
            //Assert.IsType<List<EmailPreview>>(response);
        }

        /// <summary>
        /// Test WaitForMatchingFirstEmail
        /// </summary>
        [Fact]
        public void WaitForMatchingFirstEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MatchOptions matchOptions = null;
            //long? delay = null;
            //Guid? inboxId = null;
            //DateTime? since = null;
            //string sort = null;
            //long? timeout = null;
            //bool? unreadOnly = null;
            //var response = instance.WaitForMatchingFirstEmail(matchOptions, delay, inboxId, since, sort, timeout, unreadOnly);
            //Assert.IsType<Email>(response);
        }

        /// <summary>
        /// Test WaitForNthEmail
        /// </summary>
        [Fact]
        public void WaitForNthEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? delay = null;
            //Guid? inboxId = null;
            //int? index = null;
            //DateTime? since = null;
            //string sort = null;
            //long? timeout = null;
            //bool? unreadOnly = null;
            //var response = instance.WaitForNthEmail(delay, inboxId, index, since, sort, timeout, unreadOnly);
            //Assert.IsType<Email>(response);
        }
    }
}
