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
    ///  Class for testing ExpiredControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ExpiredControllerApiTests : IDisposable
    {
        private ExpiredControllerApi instance;

        public ExpiredControllerApiTests()
        {
            instance = new ExpiredControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ExpiredControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ExpiredControllerApi
            //Assert.IsType<ExpiredControllerApi>(instance);
        }

        /// <summary>
        /// Test GetExpirationDefaults
        /// </summary>
        [Fact]
        public void GetExpirationDefaultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetExpirationDefaults();
            //Assert.IsType<ExpirationDefaults>(response);
        }

        /// <summary>
        /// Test GetExpiredInboxByInboxId
        /// </summary>
        [Fact]
        public void GetExpiredInboxByInboxIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //var response = instance.GetExpiredInboxByInboxId(inboxId);
            //Assert.IsType<ExpiredInboxDto>(response);
        }

        /// <summary>
        /// Test GetExpiredInboxRecord
        /// </summary>
        [Fact]
        public void GetExpiredInboxRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid expiredId = null;
            //var response = instance.GetExpiredInboxRecord(expiredId);
            //Assert.IsType<ExpiredInboxDto>(response);
        }

        /// <summary>
        /// Test GetExpiredInboxes
        /// </summary>
        [Fact]
        public void GetExpiredInboxesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetExpiredInboxes(page, size, sort, since, before);
            //Assert.IsType<PageExpiredInboxRecordProjection>(response);
        }
    }
}
