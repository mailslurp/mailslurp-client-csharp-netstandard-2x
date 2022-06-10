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
    ///  Class for testing TemplateControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TemplateControllerApiTests : IDisposable
    {
        private TemplateControllerApi instance;

        public TemplateControllerApiTests()
        {
            instance = new TemplateControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TemplateControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TemplateControllerApi
            //Assert.IsType<TemplateControllerApi>(instance);
        }

        /// <summary>
        /// Test CreateTemplate
        /// </summary>
        [Fact]
        public void CreateTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTemplateOptions createTemplateOptions = null;
            //var response = instance.CreateTemplate(createTemplateOptions);
            //Assert.IsType<TemplateDto>(response);
        }

        /// <summary>
        /// Test DeleteTemplate
        /// </summary>
        [Fact]
        public void DeleteTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid templateId = null;
            //instance.DeleteTemplate(templateId);
        }

        /// <summary>
        /// Test GetAllTemplates
        /// </summary>
        [Fact]
        public void GetAllTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetAllTemplates(page, size, sort, since, before);
            //Assert.IsType<PageTemplateProjection>(response);
        }

        /// <summary>
        /// Test GetTemplate
        /// </summary>
        [Fact]
        public void GetTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid templateId = null;
            //var response = instance.GetTemplate(templateId);
            //Assert.IsType<TemplateDto>(response);
        }

        /// <summary>
        /// Test GetTemplates
        /// </summary>
        [Fact]
        public void GetTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTemplates();
            //Assert.IsType<List<TemplateProjection>>(response);
        }

        /// <summary>
        /// Test UpdateTemplate
        /// </summary>
        [Fact]
        public void UpdateTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid templateId = null;
            //CreateTemplateOptions createTemplateOptions = null;
            //var response = instance.UpdateTemplate(templateId, createTemplateOptions);
            //Assert.IsType<TemplateDto>(response);
        }
    }
}
