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
    ///  Class for testing PhoneControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PhoneControllerApiTests : IDisposable
    {
        private PhoneControllerApi instance;

        public PhoneControllerApiTests()
        {
            instance = new PhoneControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PhoneControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PhoneControllerApi
            //Assert.IsType<PhoneControllerApi>(instance);
        }

        /// <summary>
        /// Test CreateEmergencyAddress
        /// </summary>
        [Fact]
        public void CreateEmergencyAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateEmergencyAddressOptions createEmergencyAddressOptions = null;
            //var response = instance.CreateEmergencyAddress(createEmergencyAddressOptions);
            //Assert.IsType<EmergencyAddress>(response);
        }

        /// <summary>
        /// Test DeleteEmergencyAddress
        /// </summary>
        [Fact]
        public void DeleteEmergencyAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid addressId = null;
            //var response = instance.DeleteEmergencyAddress(addressId);
            //Assert.IsType<EmptyResponseDto>(response);
        }

        /// <summary>
        /// Test DeletePhoneNumber
        /// </summary>
        [Fact]
        public void DeletePhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //instance.DeletePhoneNumber(phoneNumberId);
        }

        /// <summary>
        /// Test GetEmergencyAddress
        /// </summary>
        [Fact]
        public void GetEmergencyAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid addressId = null;
            //var response = instance.GetEmergencyAddress(addressId);
            //Assert.IsType<EmergencyAddress>(response);
        }

        /// <summary>
        /// Test GetEmergencyAddresses
        /// </summary>
        [Fact]
        public void GetEmergencyAddressesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEmergencyAddresses();
            //Assert.IsType<List<EmergencyAddressDto>>(response);
        }

        /// <summary>
        /// Test GetPhoneNumber
        /// </summary>
        [Fact]
        public void GetPhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //var response = instance.GetPhoneNumber(phoneNumberId);
            //Assert.IsType<PhoneNumberDto>(response);
        }

        /// <summary>
        /// Test GetPhoneNumbers
        /// </summary>
        [Fact]
        public void GetPhoneNumbersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.GetPhoneNumbers(page, size, sort, since, before);
            //Assert.IsType<PagePhoneNumberProjection>(response);
        }

        /// <summary>
        /// Test GetPhonePlans
        /// </summary>
        [Fact]
        public void GetPhonePlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPhonePlans();
            //Assert.IsType<List<PhonePlanDto>>(response);
        }

        /// <summary>
        /// Test TestPhoneNumberSendSms
        /// </summary>
        [Fact]
        public void TestPhoneNumberSendSmsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //TestPhoneNumberOptions testPhoneNumberOptions = null;
            //instance.TestPhoneNumberSendSms(phoneNumberId, testPhoneNumberOptions);
        }
    }
}
