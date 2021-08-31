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
    ///  Class for testing DomainControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DomainControllerApiTests : IDisposable
    {
        private DomainControllerApi instance;

        public DomainControllerApiTests()
        {
            instance = new DomainControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DomainControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DomainControllerApi
            //Assert.IsType<DomainControllerApi>(instance);
        }

        /// <summary>
        /// Test AddDomainWildcardCatchAll
        /// </summary>
        [Fact]
        public void AddDomainWildcardCatchAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.AddDomainWildcardCatchAll(id);
            //Assert.IsType<DomainDto>(response);
        }

        /// <summary>
        /// Test CreateDomain
        /// </summary>
        [Fact]
        public void CreateDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateDomainOptions domainOptions = null;
            //var response = instance.CreateDomain(domainOptions);
            //Assert.IsType<DomainDto>(response);
        }

        /// <summary>
        /// Test DeleteDomain
        /// </summary>
        [Fact]
        public void DeleteDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.DeleteDomain(id);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetDomain
        /// </summary>
        [Fact]
        public void GetDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetDomain(id);
            //Assert.IsType<DomainDto>(response);
        }

        /// <summary>
        /// Test GetDomains
        /// </summary>
        [Fact]
        public void GetDomainsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetDomains();
            //Assert.IsType<List<DomainPreview>>(response);
        }

        /// <summary>
        /// Test UpdateDomain
        /// </summary>
        [Fact]
        public void UpdateDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //UpdateDomainOptions updateDomainDto = null;
            //var response = instance.UpdateDomain(id, updateDomainDto);
            //Assert.IsType<DomainDto>(response);
        }
    }
}
