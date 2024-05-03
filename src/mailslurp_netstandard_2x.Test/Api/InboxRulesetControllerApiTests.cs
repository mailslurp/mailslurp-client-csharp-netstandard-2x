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
    ///  Class for testing InboxRulesetControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InboxRulesetControllerApiTests : IDisposable
    {
        private InboxRulesetControllerApi instance;

        public InboxRulesetControllerApiTests()
        {
            instance = new InboxRulesetControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InboxRulesetControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InboxRulesetControllerApi
            //Assert.IsType<InboxRulesetControllerApi>(instance);
        }

        /// <summary>
        /// Test CreateNewInboxRuleset
        /// </summary>
        [Fact]
        public void CreateNewInboxRulesetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateInboxRulesetOptions createInboxRulesetOptions = null;
            //Guid? inboxId = null;
            //var response = instance.CreateNewInboxRuleset(createInboxRulesetOptions, inboxId);
            //Assert.IsType<InboxRulesetDto>(response);
        }

        /// <summary>
        /// Test DeleteInboxRuleset
        /// </summary>
        [Fact]
        public void DeleteInboxRulesetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.DeleteInboxRuleset(id);
        }

        /// <summary>
        /// Test DeleteInboxRulesets
        /// </summary>
        [Fact]
        public void DeleteInboxRulesetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? inboxId = null;
            //instance.DeleteInboxRulesets(inboxId);
        }

        /// <summary>
        /// Test GetInboxRuleset
        /// </summary>
        [Fact]
        public void GetInboxRulesetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetInboxRuleset(id);
            //Assert.IsType<InboxRulesetDto>(response);
        }

        /// <summary>
        /// Test GetInboxRulesets
        /// </summary>
        [Fact]
        public void GetInboxRulesetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? inboxId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //string searchFilter = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetInboxRulesets(inboxId, page, size, sort, searchFilter, since, before);
            //Assert.IsType<PageInboxRulesetDto>(response);
        }

        /// <summary>
        /// Test TestInboxRuleset
        /// </summary>
        [Fact]
        public void TestInboxRulesetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //InboxRulesetTestOptions inboxRulesetTestOptions = null;
            //var response = instance.TestInboxRuleset(id, inboxRulesetTestOptions);
            //Assert.IsType<InboxRulesetTestResult>(response);
        }

        /// <summary>
        /// Test TestInboxRulesetReceiving
        /// </summary>
        [Fact]
        public void TestInboxRulesetReceivingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TestInboxRulesetReceivingOptions testInboxRulesetReceivingOptions = null;
            //var response = instance.TestInboxRulesetReceiving(testInboxRulesetReceivingOptions);
            //Assert.IsType<TestInboxRulesetReceivingResult>(response);
        }

        /// <summary>
        /// Test TestInboxRulesetSending
        /// </summary>
        [Fact]
        public void TestInboxRulesetSendingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TestInboxRulesetSendingOptions testInboxRulesetSendingOptions = null;
            //var response = instance.TestInboxRulesetSending(testInboxRulesetSendingOptions);
            //Assert.IsType<TestInboxRulesetSendingResult>(response);
        }

        /// <summary>
        /// Test TestInboxRulesetsForInbox
        /// </summary>
        [Fact]
        public void TestInboxRulesetsForInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //InboxRulesetTestOptions inboxRulesetTestOptions = null;
            //var response = instance.TestInboxRulesetsForInbox(inboxId, inboxRulesetTestOptions);
            //Assert.IsType<InboxRulesetTestResult>(response);
        }

        /// <summary>
        /// Test TestNewInboxRuleset
        /// </summary>
        [Fact]
        public void TestNewInboxRulesetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TestNewInboxRulesetOptions testNewInboxRulesetOptions = null;
            //var response = instance.TestNewInboxRuleset(testNewInboxRulesetOptions);
            //Assert.IsType<InboxRulesetTestResult>(response);
        }
    }
}
