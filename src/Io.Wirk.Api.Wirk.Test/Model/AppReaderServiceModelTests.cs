/* 
 * Wirk
 *
 * <p>API for api.wirk.io</p> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: contact@wirk.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Io.Wirk.Api.Wirk.Api;
using Io.Wirk.Api.Wirk.Model;
using Io.Wirk.Api.Wirk.Client;
using System.Reflection;

namespace Io.Wirk.Api.Wirk.Test
{
    /// <summary>
    ///  Class for testing AppReaderServiceModel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AppReaderServiceModelTests
    {
        private AppReaderServiceModel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AppReaderServiceModel();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AppReaderServiceModel
        /// </summary>
        [Test]
        public void AppReaderServiceModelInstanceTest()
        {
            Assert.IsInstanceOf<AppReaderServiceModel> (instance, "instance is a AppReaderServiceModel");
        }

        /// <summary>
        /// Test the property 'AppName'
        /// </summary>
        [Test]
        public void AppNameTest()
        {
            // TODO: unit test for the property 'AppName'
        }
        /// <summary>
        /// Test the property 'HasInstruction'
        /// </summary>
        [Test]
        public void HasInstructionTest()
        {
            // TODO: unit test for the property 'HasInstruction'
        }
        /// <summary>
        /// Test the property 'HasQuestionOptions'
        /// </summary>
        [Test]
        public void HasQuestionOptionsTest()
        {
            // TODO: unit test for the property 'HasQuestionOptions'
        }
        /// <summary>
        /// Test the property 'IdApp'
        /// </summary>
        [Test]
        public void IdAppTest()
        {
            // TODO: unit test for the property 'IdApp'
        }
        /// <summary>
        /// Test the property 'Qualities'
        /// </summary>
        [Test]
        public void QualitiesTest()
        {
            // TODO: unit test for the property 'Qualities'
        }
        /// <summary>
        /// Test the property 'TitleQuestionOptions'
        /// </summary>
        [Test]
        public void TitleQuestionOptionsTest()
        {
            // TODO: unit test for the property 'TitleQuestionOptions'
        }

    }

}
