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
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class SetUserBlackListRequest : RpcAcsRequest<SetUserBlackListResponse>
    {
        public SetUserBlackListRequest()
            : base("Cdn", "2014-11-11", "SetUserBlackList")
        {
        }

		private long? _ownerId;

		private string _ownerAccount;

		private string _securityToken;

		private string _configUrl;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return _securityToken;
			}
			set	
			{
				_securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string ConfigUrl
		{
			get
			{
				return _configUrl;
			}
			set	
			{
				_configUrl = value;
				DictionaryUtil.Add(QueryParameters, "ConfigUrl", value);
			}
		}

        public override SetUserBlackListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetUserBlackListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}