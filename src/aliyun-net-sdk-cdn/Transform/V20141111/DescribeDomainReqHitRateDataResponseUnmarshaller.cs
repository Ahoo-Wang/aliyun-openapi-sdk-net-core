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
    public class DescribeDomainReqHitRateDataResponseUnmarshaller
    {
        public static DescribeDomainReqHitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainReqHitRateDataResponse describeDomainReqHitRateDataResponse = new DescribeDomainReqHitRateDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainReqHitRateData.RequestId"),
                DomainName = context.StringValue("DescribeDomainReqHitRateData.DomainName"),
                DataInterval = context.StringValue("DescribeDomainReqHitRateData.DataInterval"),
                StartTime = context.StringValue("DescribeDomainReqHitRateData.StartTime"),
                EndTime = context.StringValue("DescribeDomainReqHitRateData.EndTime")
            };
            List<DescribeDomainReqHitRateDataResponse.DataModule> reqHitRateInterval = new List<DescribeDomainReqHitRateDataResponse.DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainReqHitRateData.ReqHitRateInterval.Length"); i++) {
                DescribeDomainReqHitRateDataResponse.DataModule dataModule = new DescribeDomainReqHitRateDataResponse.DataModule()
                {
                    TimeStamp = context.StringValue($"DescribeDomainReqHitRateData.ReqHitRateInterval[{i}].TimeStamp"),
                    Value = context.StringValue($"DescribeDomainReqHitRateData.ReqHitRateInterval[{i}].Value")
                };
                reqHitRateInterval.Add(dataModule);
			}
			describeDomainReqHitRateDataResponse.ReqHitRateInterval = reqHitRateInterval;
        
			return describeDomainReqHitRateDataResponse;
        }
    }
}