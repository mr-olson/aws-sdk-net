/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Represents the output of a delete repository operation.
    /// </summary>
    public partial class DeleteRepositoryResponse : AmazonWebServiceResponse
    {
        private string _repositoryId;

        /// <summary>
        /// Gets and sets the property RepositoryId. 
        /// <para>
        /// The ID of the repository that was deleted.
        /// </para>
        /// </summary>
        public string RepositoryId
        {
            get { return this._repositoryId; }
            set { this._repositoryId = value; }
        }

        // Check to see if RepositoryId property is set
        internal bool IsSetRepositoryId()
        {
            return this._repositoryId != null;
        }

    }
}