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
    ///  Class for testing TrackingControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TrackingControllerApiTests : IDisposable
    {
        private TrackingControllerApi instance;

        public TrackingControllerApiTests()
        {
            instance = new TrackingControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TrackingControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TrackingControllerApi
            //Assert.IsType<TrackingControllerApi>(instance);
        }

        /// <summary>
        /// Test CreateTrackingPixel
        /// </summary>
        [Fact]
        public void CreateTrackingPixelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTrackingPixelOptions createTrackingPixelOptions = null;
            //var response = instance.CreateTrackingPixel(createTrackingPixelOptions);
            //Assert.IsType<TrackingPixelDto>(response);
        }

        /// <summary>
        /// Test GetAllTrackingPixels
        /// </summary>
        [Fact]
        public void GetAllTrackingPixelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //string searchFilter = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetAllTrackingPixels(page, searchFilter, size, sort);
            //Assert.IsType<PageTrackingPixelProjection>(response);
        }

        /// <summary>
        /// Test GetTrackingPixel
        /// </summary>
        [Fact]
        public void GetTrackingPixelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetTrackingPixel(id);
            //Assert.IsType<TrackingPixelDto>(response);
        }
    }
}
