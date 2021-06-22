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
    ///  Class for testing InboxControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InboxControllerApiTests : IDisposable
    {
        private InboxControllerApi instance;

        public InboxControllerApiTests()
        {
            instance = new InboxControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InboxControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InboxControllerApi
            //Assert.IsType<InboxControllerApi>(instance);
        }

        /// <summary>
        /// Test CreateInbox
        /// </summary>
        [Fact]
        public void CreateInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? allowTeamAccess = null;
            //string description = null;
            //string emailAddress = null;
            //DateTime? expiresAt = null;
            //long? expiresIn = null;
            //bool? favourite = null;
            //string inboxType = null;
            //string name = null;
            //List<string> tags = null;
            //bool? useDomainPool = null;
            //var response = instance.CreateInbox(allowTeamAccess, description, emailAddress, expiresAt, expiresIn, favourite, inboxType, name, tags, useDomainPool);
            //Assert.IsType<Inbox>(response);
        }

        /// <summary>
        /// Test CreateInboxWithDefaults
        /// </summary>
        [Fact]
        public void CreateInboxWithDefaultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreateInboxWithDefaults();
            //Assert.IsType<Inbox>(response);
        }

        /// <summary>
        /// Test CreateInboxWithOptions
        /// </summary>
        [Fact]
        public void CreateInboxWithOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateInboxDto createInboxDto = null;
            //var response = instance.CreateInboxWithOptions(createInboxDto);
            //Assert.IsType<Inbox>(response);
        }

        /// <summary>
        /// Test DeleteAllInboxes
        /// </summary>
        [Fact]
        public void DeleteAllInboxesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DeleteAllInboxes();
        }

        /// <summary>
        /// Test DeleteInbox
        /// </summary>
        [Fact]
        public void DeleteInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //instance.DeleteInbox(inboxId);
        }

        /// <summary>
        /// Test GetAllInboxes
        /// </summary>
        [Fact]
        public void GetAllInboxesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? favourite = null;
            //int? page = null;
            //string search = null;
            //int? size = null;
            //string sort = null;
            //string tag = null;
            //bool? teamAccess = null;
            //var response = instance.GetAllInboxes(favourite, page, search, size, sort, tag, teamAccess);
            //Assert.IsType<PageInboxProjection>(response);
        }

        /// <summary>
        /// Test GetEmails
        /// </summary>
        [Fact]
        public void GetEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //int? limit = null;
            //long? minCount = null;
            //long? retryTimeout = null;
            //DateTime? since = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetEmails(inboxId, limit, minCount, retryTimeout, since, size, sort);
            //Assert.IsType<List<EmailPreview>>(response);
        }

        /// <summary>
        /// Test GetInbox
        /// </summary>
        [Fact]
        public void GetInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //var response = instance.GetInbox(inboxId);
            //Assert.IsType<Inbox>(response);
        }

        /// <summary>
        /// Test GetInboxEmailsPaginated
        /// </summary>
        [Fact]
        public void GetInboxEmailsPaginatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetInboxEmailsPaginated(inboxId, page, size, sort);
            //Assert.IsType<PageEmailPreview>(response);
        }

        /// <summary>
        /// Test GetInboxSentEmails
        /// </summary>
        [Fact]
        public void GetInboxSentEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //int? page = null;
            //string searchFilter = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetInboxSentEmails(inboxId, page, searchFilter, size, sort);
            //Assert.IsType<PageSentEmailProjection>(response);
        }

        /// <summary>
        /// Test GetInboxTags
        /// </summary>
        [Fact]
        public void GetInboxTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetInboxTags();
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetInboxes
        /// </summary>
        [Fact]
        public void GetInboxesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? size = null;
            //string sort = null;
            //var response = instance.GetInboxes(size, sort);
            //Assert.IsType<List<Inbox>>(response);
        }

        /// <summary>
        /// Test GetOrganizationInboxes
        /// </summary>
        [Fact]
        public void GetOrganizationInboxesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //string searchFilter = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetOrganizationInboxes(page, searchFilter, size, sort);
            //Assert.IsType<PageOrganizationInboxProjection>(response);
        }

        /// <summary>
        /// Test SendEmail
        /// </summary>
        [Fact]
        public void SendEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //SendEmailOptions sendEmailOptions = null;
            //instance.SendEmail(inboxId, sendEmailOptions);
        }

        /// <summary>
        /// Test SendEmailAndConfirm
        /// </summary>
        [Fact]
        public void SendEmailAndConfirmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //SendEmailOptions sendEmailOptions = null;
            //var response = instance.SendEmailAndConfirm(inboxId, sendEmailOptions);
            //Assert.IsType<SentEmailDto>(response);
        }

        /// <summary>
        /// Test SendTestEmail
        /// </summary>
        [Fact]
        public void SendTestEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //instance.SendTestEmail(inboxId);
        }

        /// <summary>
        /// Test SetInboxFavourited
        /// </summary>
        [Fact]
        public void SetInboxFavouritedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //SetInboxFavouritedOptions setInboxFavouritedOptions = null;
            //var response = instance.SetInboxFavourited(inboxId, setInboxFavouritedOptions);
            //Assert.IsType<Inbox>(response);
        }

        /// <summary>
        /// Test UpdateInbox
        /// </summary>
        [Fact]
        public void UpdateInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //UpdateInboxOptions updateInboxOptions = null;
            //var response = instance.UpdateInbox(inboxId, updateInboxOptions);
            //Assert.IsType<Inbox>(response);
        }
    }
}
