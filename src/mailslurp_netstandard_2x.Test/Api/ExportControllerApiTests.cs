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
    ///  Class for testing ExportControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ExportControllerApiTests : IDisposable
    {
        private ExportControllerApi instance;

        public ExportControllerApiTests()
        {
            instance = new ExportControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ExportControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ExportControllerApi
            //Assert.IsType<ExportControllerApi>(instance);
        }

        /// <summary>
        /// Test ExportEntities
        /// </summary>
        [Fact]
        public void ExportEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKey = null;
            //string exportType = null;
            //string outputFormat = null;
            //DateTime? createdEarliestTime = null;
            //DateTime? createdOldestTime = null;
            //bool? excludePreviouslyExported = null;
            //string filter = null;
            //string listSeparatorToken = null;
            //var response = instance.ExportEntities(apiKey, exportType, outputFormat, createdEarliestTime, createdOldestTime, excludePreviouslyExported, filter, listSeparatorToken);
            //Assert.IsType<byte[]>(response);
        }

        /// <summary>
        /// Test GetExportLink
        /// </summary>
        [Fact]
        public void GetExportLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exportType = null;
            //ExportOptions exportOptions = null;
            //string apiKey = null;
            //var response = instance.GetExportLink(exportType, exportOptions, apiKey);
            //Assert.IsType<ExportLink>(response);
        }
    }
}
