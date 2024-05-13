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
    ///  Class for testing ImapUpdateFlagsOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ImapUpdateFlagsOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ImapUpdateFlagsOptions
        //private ImapUpdateFlagsOptions instance;

        public ImapUpdateFlagsOptionsTests()
        {
            // TODO uncomment below to create an instance of ImapUpdateFlagsOptions
            //instance = new ImapUpdateFlagsOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ImapUpdateFlagsOptions
        /// </summary>
        [Fact]
        public void ImapUpdateFlagsOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" ImapUpdateFlagsOptions
            //Assert.IsType<ImapUpdateFlagsOptions>(instance);
        }


        /// <summary>
        /// Test the property 'Operation'
        /// </summary>
        [Fact]
        public void OperationTest()
        {
            // TODO unit test for the property 'Operation'
        }
        /// <summary>
        /// Test the property 'Flags'
        /// </summary>
        [Fact]
        public void FlagsTest()
        {
            // TODO unit test for the property 'Flags'
        }
        /// <summary>
        /// Test the property 'UidSet'
        /// </summary>
        [Fact]
        public void UidSetTest()
        {
            // TODO unit test for the property 'UidSet'
        }
        /// <summary>
        /// Test the property 'SeqSet'
        /// </summary>
        [Fact]
        public void SeqSetTest()
        {
            // TODO unit test for the property 'SeqSet'
        }

    }

}
