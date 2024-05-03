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
    ///  Class for testing CheckEmailBodyResults
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CheckEmailBodyResultsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CheckEmailBodyResults
        //private CheckEmailBodyResults instance;

        public CheckEmailBodyResultsTests()
        {
            // TODO uncomment below to create an instance of CheckEmailBodyResults
            //instance = new CheckEmailBodyResults();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CheckEmailBodyResults
        /// </summary>
        [Fact]
        public void CheckEmailBodyResultsInstanceTest()
        {
            // TODO uncomment below to test "IsType" CheckEmailBodyResults
            //Assert.IsType<CheckEmailBodyResults>(instance);
        }


        /// <summary>
        /// Test the property 'HasIssues'
        /// </summary>
        [Fact]
        public void HasIssuesTest()
        {
            // TODO unit test for the property 'HasIssues'
        }
        /// <summary>
        /// Test the property 'LinkIssues'
        /// </summary>
        [Fact]
        public void LinkIssuesTest()
        {
            // TODO unit test for the property 'LinkIssues'
        }
        /// <summary>
        /// Test the property 'ImageIssues'
        /// </summary>
        [Fact]
        public void ImageIssuesTest()
        {
            // TODO unit test for the property 'ImageIssues'
        }
        /// <summary>
        /// Test the property 'SpellingIssues'
        /// </summary>
        [Fact]
        public void SpellingIssuesTest()
        {
            // TODO unit test for the property 'SpellingIssues'
        }

    }

}
