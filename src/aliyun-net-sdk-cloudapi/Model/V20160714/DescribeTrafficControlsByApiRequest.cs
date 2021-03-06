/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform.V20160714;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class DescribeTrafficControlsByApiRequest : RpcAcsRequest<DescribeTrafficControlsByApiResponse>
    {
        public DescribeTrafficControlsByApiRequest()
            : base("CloudAPI", "2016-07-14", "DescribeTrafficControlsByApi")
        {
        }

		private string _groupId;

		private string _apiId;

		private string _stageName;

		public string GroupId
		{
			get
			{
				return _groupId;
			}
			set	
			{
				_groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string ApiId
		{
			get
			{
				return _apiId;
			}
			set	
			{
				_apiId = value;
				DictionaryUtil.Add(QueryParameters, "ApiId", value);
			}
		}

		public string StageName
		{
			get
			{
				return _stageName;
			}
			set	
			{
				_stageName = value;
				DictionaryUtil.Add(QueryParameters, "StageName", value);
			}
		}

        public override DescribeTrafficControlsByApiResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeTrafficControlsByApiResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}