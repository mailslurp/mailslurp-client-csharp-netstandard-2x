/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
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
    ///  Class for testing UploadAttachmentOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UploadAttachmentOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UploadAttachmentOptions
        //private UploadAttachmentOptions instance;

        public UploadAttachmentOptionsTests()
        {
            // TODO uncomment below to create an instance of UploadAttachmentOptions
            //instance = new UploadAttachmentOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UploadAttachmentOptions
        /// </summary>
        [Fact]
        public void UploadAttachmentOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" UploadAttachmentOptions
            //Assert.IsType<UploadAttachmentOptions>(instance);
        }


        /// <summary>
        /// Test the property 'ContentType'
        /// </summary>
        [Fact]
        public void ContentTypeTest()
        {
            // TODO unit test for the property 'ContentType'
        }
        /// <summary>
        /// Test the property 'Filename'
        /// </summary>
        [Fact]
        public void FilenameTest()
        {
            // TODO unit test for the property 'Filename'
        }
        /// <summary>
        /// Test the property 'Base64Contents'
        /// </summary>
        [Fact]
        public void Base64ContentsTest()
        {
            // TODO unit test for the property 'Base64Contents'
        }

    }

}
