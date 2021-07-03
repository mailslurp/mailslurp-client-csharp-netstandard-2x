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
    ///  Class for testing EmailControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EmailControllerApiTests : IDisposable
    {
        private EmailControllerApi instance;

        public EmailControllerApiTests()
        {
            instance = new EmailControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmailControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EmailControllerApi
            //Assert.IsType<EmailControllerApi>(instance);
        }

        /// <summary>
        /// Test DeleteAllEmails
        /// </summary>
        [Fact]
        public void DeleteAllEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DeleteAllEmails();
        }

        /// <summary>
        /// Test DeleteEmail
        /// </summary>
        [Fact]
        public void DeleteEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //instance.DeleteEmail(emailId);
        }

        /// <summary>
        /// Test DownloadAttachment
        /// </summary>
        [Fact]
        public void DownloadAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentId = null;
            //Guid emailId = null;
            //string apiKey = null;
            //var response = instance.DownloadAttachment(attachmentId, emailId, apiKey);
            //Assert.IsType<byte[]>(response);
        }

        /// <summary>
        /// Test DownloadAttachmentBase64
        /// </summary>
        [Fact]
        public void DownloadAttachmentBase64Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentId = null;
            //Guid emailId = null;
            //var response = instance.DownloadAttachmentBase64(attachmentId, emailId);
            //Assert.IsType<DownloadAttachmentDto>(response);
        }

        /// <summary>
        /// Test DownloadBody
        /// </summary>
        [Fact]
        public void DownloadBodyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //var response = instance.DownloadBody(emailId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test DownloadBodyBytes
        /// </summary>
        [Fact]
        public void DownloadBodyBytesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //var response = instance.DownloadBodyBytes(emailId);
            //Assert.IsType<byte[]>(response);
        }

        /// <summary>
        /// Test ForwardEmail
        /// </summary>
        [Fact]
        public void ForwardEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //ForwardEmailOptions forwardEmailOptions = null;
            //instance.ForwardEmail(emailId, forwardEmailOptions);
        }

        /// <summary>
        /// Test GetAttachmentMetaData
        /// </summary>
        [Fact]
        public void GetAttachmentMetaDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentId = null;
            //Guid emailId = null;
            //var response = instance.GetAttachmentMetaData(attachmentId, emailId);
            //Assert.IsType<AttachmentMetaData>(response);
        }

        /// <summary>
        /// Test GetAttachments1
        /// </summary>
        [Fact]
        public void GetAttachments1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //var response = instance.GetAttachments1(emailId);
            //Assert.IsType<List<AttachmentMetaData>>(response);
        }

        /// <summary>
        /// Test GetEmail
        /// </summary>
        [Fact]
        public void GetEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //bool? decode = null;
            //var response = instance.GetEmail(emailId, decode);
            //Assert.IsType<Email>(response);
        }

        /// <summary>
        /// Test GetEmailContentMatch
        /// </summary>
        [Fact]
        public void GetEmailContentMatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //ContentMatchOptions contentMatchOptions = null;
            //var response = instance.GetEmailContentMatch(emailId, contentMatchOptions);
            //Assert.IsType<EmailContentMatchResult>(response);
        }

        /// <summary>
        /// Test GetEmailHTML
        /// </summary>
        [Fact]
        public void GetEmailHTMLTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //bool? decode = null;
            //var response = instance.GetEmailHTML(emailId, decode);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetEmailHTMLQuery
        /// </summary>
        [Fact]
        public void GetEmailHTMLQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //string htmlSelector = null;
            //var response = instance.GetEmailHTMLQuery(emailId, htmlSelector);
            //Assert.IsType<EmailTextLinesResult>(response);
        }

        /// <summary>
        /// Test GetEmailTextLines
        /// </summary>
        [Fact]
        public void GetEmailTextLinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //bool? decodeHtmlEntities = null;
            //string lineSeparator = null;
            //var response = instance.GetEmailTextLines(emailId, decodeHtmlEntities, lineSeparator);
            //Assert.IsType<EmailTextLinesResult>(response);
        }

        /// <summary>
        /// Test GetEmailsPaginated
        /// </summary>
        [Fact]
        public void GetEmailsPaginatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<Guid> inboxId = null;
            //int? page = null;
            //string searchFilter = null;
            //int? size = null;
            //string sort = null;
            //bool? unreadOnly = null;
            //var response = instance.GetEmailsPaginated(inboxId, page, searchFilter, size, sort, unreadOnly);
            //Assert.IsType<PageEmailProjection>(response);
        }

        /// <summary>
        /// Test GetLatestEmail
        /// </summary>
        [Fact]
        public void GetLatestEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<Guid> inboxIds = null;
            //var response = instance.GetLatestEmail(inboxIds);
            //Assert.IsType<Email>(response);
        }

        /// <summary>
        /// Test GetLatestEmailInInbox
        /// </summary>
        [Fact]
        public void GetLatestEmailInInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? inboxId = null;
            //var response = instance.GetLatestEmailInInbox(inboxId);
            //Assert.IsType<Email>(response);
        }

        /// <summary>
        /// Test GetOrganizationEmailsPaginated
        /// </summary>
        [Fact]
        public void GetOrganizationEmailsPaginatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<Guid> inboxId = null;
            //int? page = null;
            //string searchFilter = null;
            //int? size = null;
            //string sort = null;
            //bool? unreadOnly = null;
            //var response = instance.GetOrganizationEmailsPaginated(inboxId, page, searchFilter, size, sort, unreadOnly);
            //Assert.IsType<PageEmailProjection>(response);
        }

        /// <summary>
        /// Test GetRawEmailContents
        /// </summary>
        [Fact]
        public void GetRawEmailContentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //var response = instance.GetRawEmailContents(emailId);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetRawEmailJson
        /// </summary>
        [Fact]
        public void GetRawEmailJsonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //var response = instance.GetRawEmailJson(emailId);
            //Assert.IsType<RawEmailJson>(response);
        }

        /// <summary>
        /// Test GetUnreadEmailCount
        /// </summary>
        [Fact]
        public void GetUnreadEmailCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUnreadEmailCount();
            //Assert.IsType<UnreadCount>(response);
        }

        /// <summary>
        /// Test ReplyToEmail
        /// </summary>
        [Fact]
        public void ReplyToEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //ReplyToEmailOptions replyToEmailOptions = null;
            //var response = instance.ReplyToEmail(emailId, replyToEmailOptions);
            //Assert.IsType<SentEmailDto>(response);
        }

        /// <summary>
        /// Test SendEmailSourceOptional
        /// </summary>
        [Fact]
        public void SendEmailSourceOptionalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? inboxId = null;
            //bool? useDomainPool = null;
            //SendEmailOptions sendEmailOptions = null;
            //instance.SendEmailSourceOptional(inboxId, useDomainPool, sendEmailOptions);
        }

        /// <summary>
        /// Test ValidateEmail
        /// </summary>
        [Fact]
        public void ValidateEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid emailId = null;
            //var response = instance.ValidateEmail(emailId);
            //Assert.IsType<ValidationDto>(response);
        }
    }
}
