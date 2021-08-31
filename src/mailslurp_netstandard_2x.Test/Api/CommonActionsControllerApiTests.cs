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
    ///  Class for testing CommonActionsControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CommonActionsControllerApiTests : IDisposable
    {
        private CommonActionsControllerApi instance;

        public CommonActionsControllerApiTests()
        {
            instance = new CommonActionsControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CommonActionsControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CommonActionsControllerApi
            //Assert.IsType<CommonActionsControllerApi>(instance);
        }

        /// <summary>
        /// Test CreateNewEmailAddress
        /// </summary>
        [Fact]
        public void CreateNewEmailAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? allowTeamAccess = null;
            //DateTime? expiresAt = null;
            //long? expiresIn = null;
            //bool? useDomainPool = null;
            //var response = instance.CreateNewEmailAddress(allowTeamAccess, expiresAt, expiresIn, useDomainPool);
            //Assert.IsType<Inbox>(response);
        }

        /// <summary>
        /// Test CreateNewEmailAddress1
        /// </summary>
        [Fact]
        public void CreateNewEmailAddress1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? allowTeamAccess = null;
            //DateTime? expiresAt = null;
            //long? expiresIn = null;
            //bool? useDomainPool = null;
            //var response = instance.CreateNewEmailAddress1(allowTeamAccess, expiresAt, expiresIn, useDomainPool);
            //Assert.IsType<Inbox>(response);
        }

        /// <summary>
        /// Test EmptyInbox
        /// </summary>
        [Fact]
        public void EmptyInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //instance.EmptyInbox(inboxId);
        }

        /// <summary>
        /// Test SendEmailSimple
        /// </summary>
        [Fact]
        public void SendEmailSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SimpleSendEmailOptions emailOptions = null;
            //instance.SendEmailSimple(emailOptions);
        }
    }
}
