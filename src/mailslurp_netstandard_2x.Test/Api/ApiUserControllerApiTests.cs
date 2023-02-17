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
    ///  Class for testing ApiUserControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ApiUserControllerApiTests : IDisposable
    {
        private ApiUserControllerApi instance;

        public ApiUserControllerApiTests()
        {
            instance = new ApiUserControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApiUserControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ApiUserControllerApi
            //Assert.IsType<ApiUserControllerApi>(instance);
        }

        /// <summary>
        /// Test GetJsonPropertyAsString
        /// </summary>
        [Fact]
        public void GetJsonPropertyAsStringTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string property = null;
            //Object body = null;
            //var response = instance.GetJsonPropertyAsString(property, body);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetUserInfo
        /// </summary>
        [Fact]
        public void GetUserInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserInfo();
            //Assert.IsType<UserInfoDto>(response);
        }
    }
}
