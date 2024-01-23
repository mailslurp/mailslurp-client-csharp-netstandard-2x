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
    ///  Class for testing RawEmailJson
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RawEmailJsonTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RawEmailJson
        //private RawEmailJson instance;

        public RawEmailJsonTests()
        {
            // TODO uncomment below to create an instance of RawEmailJson
            //instance = new RawEmailJson();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RawEmailJson
        /// </summary>
        [Fact]
        public void RawEmailJsonInstanceTest()
        {
            // TODO uncomment below to test "IsType" RawEmailJson
            //Assert.IsType<RawEmailJson>(instance);
        }


        /// <summary>
        /// Test the property 'Content'
        /// </summary>
        [Fact]
        public void ContentTest()
        {
            // TODO unit test for the property 'Content'
        }

    }

}
