/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Model;
using mailslurp_netstandard_2x.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace mailslurp_netstandard_2x.Test.Model
{
    /// <summary>
    ///  Class for testing LinkIssue
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LinkIssueTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LinkIssue
        //private LinkIssue instance;

        public LinkIssueTests()
        {
            // TODO uncomment below to create an instance of LinkIssue
            //instance = new LinkIssue();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LinkIssue
        /// </summary>
        [Fact]
        public void LinkIssueInstanceTest()
        {
            // TODO uncomment below to test "IsType" LinkIssue
            //Assert.IsType<LinkIssue>(instance);
        }


        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'ResponseStatus'
        /// </summary>
        [Fact]
        public void ResponseStatusTest()
        {
            // TODO unit test for the property 'ResponseStatus'
        }
        /// <summary>
        /// Test the property 'Severity'
        /// </summary>
        [Fact]
        public void SeverityTest()
        {
            // TODO unit test for the property 'Severity'
        }
        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }

    }

}