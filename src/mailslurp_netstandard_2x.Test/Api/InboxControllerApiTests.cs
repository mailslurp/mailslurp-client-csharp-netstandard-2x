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
        /// Test CancelScheduledJob
        /// </summary>
        [Fact]
        public void CancelScheduledJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid jobId = null;
            //var response = instance.CancelScheduledJob(jobId);
            //Assert.IsType<ScheduledJobDto>(response);
        }

        /// <summary>
        /// Test CreateInbox
        /// </summary>
        [Fact]
        public void CreateInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string emailAddress = null;
            //List<string> tags = null;
            //string name = null;
            //string description = null;
            //bool? useDomainPool = null;
            //bool? favourite = null;
            //DateTime? expiresAt = null;
            //long? expiresIn = null;
            //bool? allowTeamAccess = null;
            //string inboxType = null;
            //bool? virtualInbox = null;
            //bool? useShortAddress = null;
            //var response = instance.CreateInbox(emailAddress, tags, name, description, useDomainPool, favourite, expiresAt, expiresIn, allowTeamAccess, inboxType, virtualInbox, useShortAddress);
            //Assert.IsType<InboxDto>(response);
        }

        /// <summary>
        /// Test CreateInboxRuleset
        /// </summary>
        [Fact]
        public void CreateInboxRulesetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //CreateInboxRulesetOptions createInboxRulesetOptions = null;
            //var response = instance.CreateInboxRuleset(inboxId, createInboxRulesetOptions);
            //Assert.IsType<InboxRulesetDto>(response);
        }

        /// <summary>
        /// Test CreateInboxWithDefaults
        /// </summary>
        [Fact]
        public void CreateInboxWithDefaultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreateInboxWithDefaults();
            //Assert.IsType<InboxDto>(response);
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
            //Assert.IsType<InboxDto>(response);
        }

        /// <summary>
        /// Test DeleteAllInboxEmails
        /// </summary>
        [Fact]
        public void DeleteAllInboxEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //instance.DeleteAllInboxEmails(inboxId);
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
        /// Test DoesInboxExist
        /// </summary>
        [Fact]
        public void DoesInboxExistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string emailAddress = null;
            //bool? allowCatchAll = null;
            //var response = instance.DoesInboxExist(emailAddress, allowCatchAll);
            //Assert.IsType<InboxExistsDto>(response);
        }

        /// <summary>
        /// Test FlushExpired
        /// </summary>
        [Fact]
        public void FlushExpiredTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? before = null;
            //var response = instance.FlushExpired(before);
            //Assert.IsType<FlushExpiredInboxesResult>(response);
        }

        /// <summary>
        /// Test GetAllInboxes
        /// </summary>
        [Fact]
        public void GetAllInboxesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //bool? favourite = null;
            //string search = null;
            //string tag = null;
            //bool? teamAccess = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //string inboxType = null;
            //Guid? domainId = null;
            //var response = instance.GetAllInboxes(page, size, sort, favourite, search, tag, teamAccess, since, before, inboxType, domainId);
            //Assert.IsType<PageInboxProjection>(response);
        }

        /// <summary>
        /// Test GetAllScheduledJobs
        /// </summary>
        [Fact]
        public void GetAllScheduledJobsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetAllScheduledJobs(page, size, sort, since, before);
            //Assert.IsType<PageScheduledJobs>(response);
        }

        /// <summary>
        /// Test GetDeliveryStatusesByInboxId
        /// </summary>
        [Fact]
        public void GetDeliveryStatusesByInboxIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetDeliveryStatusesByInboxId(inboxId, page, size, sort, since, before);
            //Assert.IsType<PageDeliveryStatus>(response);
        }

        /// <summary>
        /// Test GetEmails
        /// </summary>
        [Fact]
        public void GetEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //int? size = null;
            //int? limit = null;
            //string sort = null;
            //long? retryTimeout = null;
            //long? delayTimeout = null;
            //long? minCount = null;
            //bool? unreadOnly = null;
            //DateTime? before = null;
            //DateTime? since = null;
            //var response = instance.GetEmails(inboxId, size, limit, sort, retryTimeout, delayTimeout, minCount, unreadOnly, before, since);
            //Assert.IsType<List<EmailPreview>>(response);
        }

        /// <summary>
        /// Test GetImapSmtpAccess
        /// </summary>
        [Fact]
        public void GetImapSmtpAccessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? inboxId = null;
            //var response = instance.GetImapSmtpAccess(inboxId);
            //Assert.IsType<ImapSmtpAccessDetails>(response);
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
            //Assert.IsType<InboxDto>(response);
        }

        /// <summary>
        /// Test GetInboxByEmailAddress
        /// </summary>
        [Fact]
        public void GetInboxByEmailAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string emailAddress = null;
            //var response = instance.GetInboxByEmailAddress(emailAddress);
            //Assert.IsType<InboxByEmailAddressResult>(response);
        }

        /// <summary>
        /// Test GetInboxByName
        /// </summary>
        [Fact]
        public void GetInboxByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetInboxByName(name);
            //Assert.IsType<InboxByNameResult>(response);
        }

        /// <summary>
        /// Test GetInboxCount
        /// </summary>
        [Fact]
        public void GetInboxCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetInboxCount();
            //Assert.IsType<CountDto>(response);
        }

        /// <summary>
        /// Test GetInboxEmailCount
        /// </summary>
        [Fact]
        public void GetInboxEmailCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //var response = instance.GetInboxEmailCount(inboxId);
            //Assert.IsType<CountDto>(response);
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
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetInboxEmailsPaginated(inboxId, page, size, sort, since, before);
            //Assert.IsType<PageEmailPreview>(response);
        }

        /// <summary>
        /// Test GetInboxIds
        /// </summary>
        [Fact]
        public void GetInboxIdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetInboxIds();
            //Assert.IsType<InboxIdsResult>(response);
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
            //int? size = null;
            //string sort = null;
            //string searchFilter = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetInboxSentEmails(inboxId, page, size, sort, searchFilter, since, before);
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
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetInboxes(size, sort, since, before);
            //Assert.IsType<List<InboxDto>>(response);
        }

        /// <summary>
        /// Test GetLatestEmailInInbox
        /// </summary>
        [Fact]
        public void GetLatestEmailInInboxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //long timeoutMillis = null;
            //var response = instance.GetLatestEmailInInbox(inboxId, timeoutMillis);
            //Assert.IsType<Email>(response);
        }

        /// <summary>
        /// Test GetOrganizationInboxes
        /// </summary>
        [Fact]
        public void GetOrganizationInboxesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //string searchFilter = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetOrganizationInboxes(page, size, sort, searchFilter, since, before);
            //Assert.IsType<PageOrganizationInboxProjection>(response);
        }

        /// <summary>
        /// Test GetScheduledJob
        /// </summary>
        [Fact]
        public void GetScheduledJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid jobId = null;
            //var response = instance.GetScheduledJob(jobId);
            //Assert.IsType<ScheduledJobDto>(response);
        }

        /// <summary>
        /// Test GetScheduledJobsByInboxId
        /// </summary>
        [Fact]
        public void GetScheduledJobsByInboxIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetScheduledJobsByInboxId(inboxId, page, size, sort, since, before);
            //Assert.IsType<PageScheduledJobs>(response);
        }

        /// <summary>
        /// Test ListInboxRulesets
        /// </summary>
        [Fact]
        public void ListInboxRulesetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //string searchFilter = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.ListInboxRulesets(inboxId, page, size, sort, searchFilter, since, before);
            //Assert.IsType<PageInboxRulesetDto>(response);
        }

        /// <summary>
        /// Test ListInboxTrackingPixels
        /// </summary>
        [Fact]
        public void ListInboxTrackingPixelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //string searchFilter = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.ListInboxTrackingPixels(inboxId, page, size, sort, searchFilter, since, before);
            //Assert.IsType<PageTrackingPixelProjection>(response);
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
        /// Test SendEmailWithQueue
        /// </summary>
        [Fact]
        public void SendEmailWithQueueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //bool validateBeforeEnqueue = null;
            //SendEmailOptions sendEmailOptions = null;
            //instance.SendEmailWithQueue(inboxId, validateBeforeEnqueue, sendEmailOptions);
        }

        /// <summary>
        /// Test SendSmtpEnvelope
        /// </summary>
        [Fact]
        public void SendSmtpEnvelopeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //SendSMTPEnvelopeOptions sendSMTPEnvelopeOptions = null;
            //var response = instance.SendSmtpEnvelope(inboxId, sendSMTPEnvelopeOptions);
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
        /// Test SendWithSchedule
        /// </summary>
        [Fact]
        public void SendWithScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid inboxId = null;
            //SendEmailOptions sendEmailOptions = null;
            //DateTime? sendAtTimestamp = null;
            //long? sendAtNowPlusSeconds = null;
            //bool? validateBeforeEnqueue = null;
            //var response = instance.SendWithSchedule(inboxId, sendEmailOptions, sendAtTimestamp, sendAtNowPlusSeconds, validateBeforeEnqueue);
            //Assert.IsType<ScheduledJobDto>(response);
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
            //Assert.IsType<InboxDto>(response);
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
            //Assert.IsType<InboxDto>(response);
        }
    }
}
