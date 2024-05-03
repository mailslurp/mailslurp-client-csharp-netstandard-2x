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
    ///  Class for testing AliasControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AliasControllerApiTests : IDisposable
    {
        private AliasControllerApi instance;

        public AliasControllerApiTests()
        {
            instance = new AliasControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AliasControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AliasControllerApi
            //Assert.IsType<AliasControllerApi>(instance);
        }

        /// <summary>
        /// Test CreateAlias
        /// </summary>
        [Fact]
        public void CreateAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateAliasOptions createAliasOptions = null;
            //var response = instance.CreateAlias(createAliasOptions);
            //Assert.IsType<AliasDto>(response);
        }

        /// <summary>
        /// Test DeleteAlias
        /// </summary>
        [Fact]
        public void DeleteAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //instance.DeleteAlias(aliasId);
        }

        /// <summary>
        /// Test GetAlias
        /// </summary>
        [Fact]
        public void GetAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //var response = instance.GetAlias(aliasId);
            //Assert.IsType<AliasDto>(response);
        }

        /// <summary>
        /// Test GetAliasEmails
        /// </summary>
        [Fact]
        public void GetAliasEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetAliasEmails(aliasId, page, size, sort, since, before);
            //Assert.IsType<PageEmailProjection>(response);
        }

        /// <summary>
        /// Test GetAliasThreads
        /// </summary>
        [Fact]
        public void GetAliasThreadsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetAliasThreads(aliasId, page, size, sort, since, before);
            //Assert.IsType<PageThreadProjection>(response);
        }

        /// <summary>
        /// Test GetAliases
        /// </summary>
        [Fact]
        public void GetAliasesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetAliases(search, page, size, sort, since, before);
            //Assert.IsType<PageAlias>(response);
        }

        /// <summary>
        /// Test GetThread
        /// </summary>
        [Fact]
        public void GetThreadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid threadId = null;
            //var response = instance.GetThread(threadId);
            //Assert.IsType<ThreadProjection>(response);
        }

        /// <summary>
        /// Test GetThreadsPaginated
        /// </summary>
        [Fact]
        public void GetThreadsPaginatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetThreadsPaginated(page, size, sort, since, before);
            //Assert.IsType<PageThreadProjection>(response);
        }

        /// <summary>
        /// Test ReplyToAliasEmail
        /// </summary>
        [Fact]
        public void ReplyToAliasEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //Guid emailId = null;
            //ReplyToAliasEmailOptions replyToAliasEmailOptions = null;
            //var response = instance.ReplyToAliasEmail(aliasId, emailId, replyToAliasEmailOptions);
            //Assert.IsType<SentEmailDto>(response);
        }

        /// <summary>
        /// Test SendAliasEmail
        /// </summary>
        [Fact]
        public void SendAliasEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //SendEmailOptions sendEmailOptions = null;
            //var response = instance.SendAliasEmail(aliasId, sendEmailOptions);
            //Assert.IsType<SentEmailDto>(response);
        }

        /// <summary>
        /// Test UpdateAlias
        /// </summary>
        [Fact]
        public void UpdateAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //UpdateAliasOptions updateAliasOptions = null;
            //var response = instance.UpdateAlias(aliasId, updateAliasOptions);
            //Assert.IsType<AliasDto>(response);
        }
    }
}
