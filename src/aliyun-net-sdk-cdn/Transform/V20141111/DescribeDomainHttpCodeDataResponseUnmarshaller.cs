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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainHttpCodeDataResponseUnmarshaller
    {
        public static DescribeDomainHttpCodeDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainHttpCodeDataResponse describeDomainHttpCodeDataResponse = new DescribeDomainHttpCodeDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainHttpCodeData.RequestId"),
                DomainName = context.StringValue("DescribeDomainHttpCodeData.DomainName"),
                DataInterval = context.StringValue("DescribeDomainHttpCodeData.DataInterval"),
                StartTime = context.StringValue("DescribeDomainHttpCodeData.StartTime"),
                EndTime = context.StringValue("DescribeDomainHttpCodeData.EndTime")
            };
            List<DescribeDomainHttpCodeDataResponse.UsageData> httpCodeData = new List<DescribeDomainHttpCodeDataResponse.UsageData>();
			for (int i = 0; i < context.Length("DescribeDomainHttpCodeData.HttpCodeData.Length"); i++) {
                DescribeDomainHttpCodeDataResponse.UsageData usageData = new DescribeDomainHttpCodeDataResponse.UsageData()
                {
                    TimeStamp = context.StringValue($"DescribeDomainHttpCodeData.HttpCodeData[{i}].TimeStamp")
                };
                List<DescribeDomainHttpCodeDataResponse.UsageData.CodeProportionData> value = new List<DescribeDomainHttpCodeDataResponse.UsageData.CodeProportionData>();
				for (int j = 0; j < context.Length($"DescribeDomainHttpCodeData.HttpCodeData[{i}].Value.Length"); j++) {
                    DescribeDomainHttpCodeDataResponse.UsageData.CodeProportionData codeProportionData = new DescribeDomainHttpCodeDataResponse.UsageData.CodeProportionData()
                    {
                        Code = context.StringValue($"DescribeDomainHttpCodeData.HttpCodeData[{i}].Value[{j}].Code"),
                        Proportion = context.StringValue($"DescribeDomainHttpCodeData.HttpCodeData[{i}].Value[{j}].Proportion")
                    };
                    value.Add(codeProportionData);
				}
				usageData.Value = value;

				httpCodeData.Add(usageData);
			}
			describeDomainHttpCodeDataResponse.HttpCodeData = httpCodeData;
        
			return describeDomainHttpCodeDataResponse;
        }
    }
}