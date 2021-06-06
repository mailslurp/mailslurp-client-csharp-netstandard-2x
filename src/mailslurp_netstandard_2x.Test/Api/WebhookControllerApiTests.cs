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
    ///  Class for testing WebhookControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhookControllerApiTests : IDisposable
    {
        private WebhookControllerApi instance;

        public WebhookControllerApiTests()
        {
            instance = new WebhookControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebhookControllerApi
            //Assert.IsType<WebhookControllerApi>(instance);
        }

        /// <summary>
        /// Test CreateWebhook
        /// </summary>
        [Fact]
        public void CreateWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //CreateWebhookOptions webhookOptions = null;
            //var response = instance.CreateWebhook(inboxId, webhookOptions);
            //Assert.IsType<WebhookDto>(response);
        }

        /// <summary>
        /// Test DeleteWebhook
        /// </summary>
        [Fact]
        public void DeleteWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //Guid webhookId = null;
            //instance.DeleteWebhook(inboxId, webhookId);
        }

        /// <summary>
        /// Test GetAllWebhooks
        /// </summary>
        [Fact]
        public void GetAllWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetAllWebhooks(page, size, sort);
            //Assert.IsType<PageWebhookProjection>(response);
        }

        /// <summary>
        /// Test GetTestWebhookPayload
        /// </summary>
        [Fact]
        public void GetTestWebhookPayloadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //var response = instance.GetTestWebhookPayload(eventName);
            //Assert.IsType<AbstractWebhookPayload>(response);
        }

        /// <summary>
        /// Test GetTestWebhookPayloadNewAttachment
        /// </summary>
        [Fact]
        public void GetTestWebhookPayloadNewAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTestWebhookPayloadNewAttachment();
            //Assert.IsType<WebhookNewAttachmentPayload>(response);
        }

        /// <summary>
        /// Test GetTestWebhookPayloadNewContact
        /// </summary>
        [Fact]
        public void GetTestWebhookPayloadNewContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTestWebhookPayloadNewContact();
            //Assert.IsType<WebhookNewContactPayload>(response);
        }

        /// <summary>
        /// Test GetTestWebhookPayloadNewEmail
        /// </summary>
        [Fact]
        public void GetTestWebhookPayloadNewEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTestWebhookPayloadNewEmail();
            //Assert.IsType<WebhookNewEmailPayload>(response);
        }

        /// <summary>
        /// Test GetWebhook
        /// </summary>
        [Fact]
        public void GetWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid webhookId = null;
            //var response = instance.GetWebhook(webhookId);
            //Assert.IsType<WebhookDto>(response);
        }

        /// <summary>
        /// Test GetWebhooks
        /// </summary>
        [Fact]
        public void GetWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //var response = instance.GetWebhooks(inboxId);
            //Assert.IsType<List<WebhookDto>>(response);
        }

        /// <summary>
        /// Test SendTestData
        /// </summary>
        [Fact]
        public void SendTestDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid webhookId = null;
            //var response = instance.SendTestData(webhookId);
            //Assert.IsType<WebhookTestResult>(response);
        }
    }
}
