/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository
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
    ///  Class for testing InboxForwarderControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InboxForwarderControllerApiTests : IDisposable
    {
        private InboxForwarderControllerApi instance;

        public InboxForwarderControllerApiTests()
        {
            instance = new InboxForwarderControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InboxForwarderControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InboxForwarderControllerApi
            //Assert.IsType<InboxForwarderControllerApi>(instance);
        }

        /// <summary>
        /// Test CreateNewInboxForwarder
        /// </summary>
        [Fact]
        public void CreateNewInboxForwarderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //CreateInboxForwarderOptions createInboxForwarderOptions = null;
            //var response = instance.CreateNewInboxForwarder(inboxId, createInboxForwarderOptions);
            //Assert.IsType<InboxForwarderDto>(response);
        }

        /// <summary>
        /// Test DeleteInboxForwarder
        /// </summary>
        [Fact]
        public void DeleteInboxForwarderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.DeleteInboxForwarder(id);
        }

        /// <summary>
        /// Test DeleteInboxForwarders
        /// </summary>
        [Fact]
        public void DeleteInboxForwardersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? inboxId = null;
            //instance.DeleteInboxForwarders(inboxId);
        }

        /// <summary>
        /// Test GetInboxForwarder
        /// </summary>
        [Fact]
        public void GetInboxForwarderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetInboxForwarder(id);
            //Assert.IsType<InboxForwarderDto>(response);
        }

        /// <summary>
        /// Test GetInboxForwarders
        /// </summary>
        [Fact]
        public void GetInboxForwardersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? inboxId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //string searchFilter = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetInboxForwarders(inboxId, page, size, sort, searchFilter, since, before);
            //Assert.IsType<PageInboxForwarderDto>(response);
        }

        /// <summary>
        /// Test TestInboxForwarder
        /// </summary>
        [Fact]
        public void TestInboxForwarderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //InboxForwarderTestOptions inboxForwarderTestOptions = null;
            //var response = instance.TestInboxForwarder(id, inboxForwarderTestOptions);
            //Assert.IsType<InboxForwarderTestResult>(response);
        }

        /// <summary>
        /// Test TestInboxForwardersForInbox
        /// </summary>
        [Fact]
        public void TestInboxForwardersForInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //InboxForwarderTestOptions inboxForwarderTestOptions = null;
            //var response = instance.TestInboxForwardersForInbox(inboxId, inboxForwarderTestOptions);
            //Assert.IsType<InboxForwarderTestResult>(response);
        }

        /// <summary>
        /// Test TestNewInboxForwarder
        /// </summary>
        [Fact]
        public void TestNewInboxForwarderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TestNewInboxForwarderOptions testNewInboxForwarderOptions = null;
            //var response = instance.TestNewInboxForwarder(testNewInboxForwarderOptions);
            //Assert.IsType<InboxForwarderTestResult>(response);
        }
    }
}
