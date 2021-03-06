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
using Aliyun.Acs.Domain.Transform.V20160511;

namespace Aliyun.Acs.Domain.Model.V20160511
{
    public class QueryContactTemplateRequest : RpcAcsRequest<QueryContactTemplateResponse>
    {
        public QueryContactTemplateRequest()
            : base("Domain", "2016-05-11", "QueryContactTemplate")
        {
        }

		private string _userClientIp;

		private string _lang;

		private string _cCompany;

		private string _eCompany;

		public string UserClientIp
		{
			get
			{
				return _userClientIp;
			}
			set	
			{
				_userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string Lang
		{
			get
			{
				return _lang;
			}
			set	
			{
				_lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string CCompany
		{
			get
			{
				return _cCompany;
			}
			set	
			{
				_cCompany = value;
				DictionaryUtil.Add(QueryParameters, "CCompany", value);
			}
		}

		public string ECompany
		{
			get
			{
				return _eCompany;
			}
			set	
			{
				_eCompany = value;
				DictionaryUtil.Add(QueryParameters, "ECompany", value);
			}
		}

        public override QueryContactTemplateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryContactTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}